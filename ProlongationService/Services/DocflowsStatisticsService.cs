using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProlongationService.Services
{
    public interface IDocflowsStatisticsService
    {
        public List<DocflowsStatisticsData> GetDocflowsStatistics(Dictionary<Guid, int> guids, DateTime beginDate, DateTime endDate);
    }
    public class DocflowsStatisticsService : IDocflowsStatisticsService
    {
        private readonly IConfiguration _configuration;
        public DocflowsStatisticsService(IConfiguration config)
        {
            _configuration = config;
        }
        public List<DocflowsStatisticsData> GetDocflowsStatistics(Dictionary<Guid, int> guids, DateTime beginDate, DateTime endDate)
        {
            const int OFD_PRODUCT_TYPE = 20;

            if (guids == null)
                throw new ArgumentNullException("guids");

            if (!guids.Any()) return new List<DocflowsStatisticsData>();

            var ofdKkts = guids.Where(x => x.Value == OFD_PRODUCT_TYPE).Select(x => x.Key).ToArray();
            var otherGuids = guids.Where(x => x.Value != OFD_PRODUCT_TYPE).Select(x => x.Key).ToArray();

            var basicStatisticTask = Task<List<BasicStatisticsData>>.Factory.StartNew(() => GetBasicStatistics(otherGuids, beginDate, endDate));

            Task<List<TransactionStatesSummary>>[] taskArray =
            {
                                                                   Task<List<TransactionStatesSummary>>.Factory.StartNew(() => GetPfrStatistics(otherGuids, beginDate, endDate)),
                                                                   Task<List<TransactionStatesSummary>>.Factory.StartNew(() => GetOfdStatistics(ofdKkts))
            };

            var basicStatistics = basicStatisticTask.Result;
            var pfrStatistics = taskArray[0].Result;
            var ofdStatistics = taskArray[1].Result;

            var result = new List<DocflowsStatisticsData>();

            foreach (var guid in otherGuids)
            {
                var basicStatistic = basicStatistics.SingleOrDefault(f => f.Guid == guid);
                var pfr = pfrStatistics.SingleOrDefault(f => f.guid == guid);

                var statistics = new DocflowsStatisticsData() { Guid = guid };

                if (basicStatistic == null)
                    statistics.Fns = 0;
                else
                    statistics.Fns = basicStatistic.Fns;

                if (pfr == null)
                    statistics.Pfr = 0;
                else
                    statistics.Pfr = pfr.Uncomplited + pfr.Positive + pfr.Negative + pfr.Error;

                result.Add(statistics);
            }

            //предполагается, что если гуид вернулся, то последняя дата отправки отчёта об открытии смены была более 3 дней назад
            result.AddRange(ofdStatistics.Select(ofdKkt => new DocflowsStatisticsData
            {
                Guid = ofdKkt.guid,
                HasOfdCashReport = true
            }));

            return result;
        }

        private List<BasicStatisticsData> GetBasicStatistics(Guid[] guids, DateTime beginDate, DateTime endDate)
        {
            try
            {
                if (guids == null)
                    throw new ArgumentNullException("guids");

                if (!guids.Any()) return new List<BasicStatisticsData>();

                var postData = JsonConvert.SerializeObject(new PostData()
                {
                    BeginDate = beginDate.ToString("yyyy-MM-dd"),
                    EndDate = endDate.ToString("yyyy-MM-dd"),
                    Guids = guids
                });


                var request = (HttpWebRequest)WebRequest.Create("http://statistic.astral.ru/api/v1/basic_stat");
                request.KeepAlive = false;
                request.ConnectionGroupName = Guid.NewGuid().ToString();
                request.ContentType = "text/json; charset=utf-8";
                request.Method = "POST";
                request.ServicePoint.Expect100Continue = false;
                request.Timeout = Convert.ToInt32(_configuration["DocflowsStatisticsTimeout"]);

                using (var writer = new StreamWriter(request.GetRequestStream()))
                {
                    writer.Write(postData);
                    writer.Flush();
                    writer.Close();

                    using (var responce = (HttpWebResponse)request.GetResponse())
                    {
                        using (var reader = new StreamReader(responce.GetResponseStream()))
                        {
                            var result = reader.ReadToEnd();
                            reader.Close();

                            if (string.IsNullOrWhiteSpace(result))
                                throw new Exception("Запрос статистики вернул пустой ответ.");

                            return JsonConvert.DeserializeObject<BasicStatisticsData[]>(result).ToList();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка получения статистики по состояниям транзакций по УП.", ex);
            }
        }

        private List<TransactionStatesSummary> GetPfrStatistics(Guid[] guids, DateTime beginDate, DateTime endDate)
        {
            try
            {
                if (guids == null)
                    throw new ArgumentNullException("guids");

                if (!guids.Any()) return new List<TransactionStatesSummary>();

                var postData = JsonConvert.SerializeObject(new
                {
                    beginDate = beginDate.ToString("yyyy-MM-dd"),
                    endDate = endDate.ToString("yyyy-MM-dd"),
                    guids
                });


                var request = (HttpWebRequest)WebRequest.Create("http://82.138.1.118:8880/monitoring?act=ao_count");
                request.KeepAlive = false;
                request.ConnectionGroupName = Guid.NewGuid().ToString();
                request.ContentType = "text/json; charset=utf-8";
                request.Method = "POST";
                request.ServicePoint.Expect100Continue = false;
                request.Timeout = Convert.ToInt32(_configuration["DocflowsStatisticsTimeout"]);

                using (var writer = new StreamWriter(request.GetRequestStream()))
                {
                    writer.Write(postData);
                    writer.Flush();
                    writer.Close();

                    using (var responce = (HttpWebResponse)request.GetResponse())
                    {
                        using (var reader = new StreamReader(responce.GetResponseStream()))
                        {
                            var result = reader.ReadToEnd();
                            reader.Close();

                            if (string.IsNullOrWhiteSpace(result))
                                throw new Exception("Запрос статистики вернул пустой ответ.");

                            result = result.Trim(new[] { '(', ')' });

                            return JsonConvert.DeserializeObject<TransactionStatesSummary[]>(result).ToList();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка получения статистики по состояниям транзакций ПФР.", ex);
            }
        }

        private List<TransactionStatesSummary> GetOfdStatistics(Guid[] guids)
        {
            try
            {
                if (guids == null)
                    throw new ArgumentNullException("guids");

                if (!guids.Any()) return new List<TransactionStatesSummary>();

                var postData = JsonConvert.SerializeObject(guids);


                var request = (HttpWebRequest)WebRequest.Create("https://ofd.astralnalog.ru/api/v4.1/statistic.shiftsStartTimeByWrGuids");
                request.KeepAlive = false;
                request.ConnectionGroupName = Guid.NewGuid().ToString();
                request.ContentType = "text/json; charset=utf-8";
                request.Method = "POST";
                request.ServicePoint.Expect100Continue = false;
                request.Timeout = Convert.ToInt32(_configuration["DocflowsStatisticsTimeout"]);

                using (var writer = new StreamWriter(request.GetRequestStream()))
                {
                    writer.Write(postData);
                    writer.Flush();
                    writer.Close();

                    using (var responce = (HttpWebResponse)request.GetResponse())
                    {
                        using (var reader = new StreamReader(responce.GetResponseStream()))
                        {
                            var result = reader.ReadToEnd();
                            reader.Close();

                            if (string.IsNullOrWhiteSpace(result))
                                throw new Exception("Запрос статистики вернул пустой ответ.");

                            result = result.Trim(new[] { '(', ')' });

                            dynamic obj = JsonConvert.DeserializeObject(result);
                            string resultField = obj.result.ToString();

                            return resultField.Contains("description") ? new List<TransactionStatesSummary>()
                                : JsonConvert.DeserializeObject<TransactionStatesSummary[]>(resultField).ToList();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка получения статистики ОФД.", ex);
            }
        }
    }


    public class DocflowsStatisticsData
    {
        //guid
        public Guid Guid { get; set; }
        //ФНС
        public int Fns { get; set; }
        //ПФР
        public int Pfr { get; set; }
        //ОФД
        public bool HasOfdCashReport { get; set; }
    }

    class BasicStatisticsData
    {
        public Guid Guid { get; set; }
        public int Fns { get; set; }
        public int RosStat { get; set; }
        public int Fss { get; set; }
        public int Pfr { get; set; }
    }

    class TransactionStatesSummary
    {
        public Guid guid { get; set; }
        public int Uncomplited { get; set; }
        public int Positive { get; set; }
        public int Negative { get; set; }
        public int Error { get; set; }
    }

    class PostData
    {
        [JsonProperty("begindate")]
        public string BeginDate { get; set; }
        [JsonProperty("enddate")]
        public string EndDate { get; set; }
        [JsonProperty("guids")]
        public Guid[] Guids { get; set; }
    }
}
