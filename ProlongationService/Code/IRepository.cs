using ProlongationService.Containers;
using RegOffice.DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlongationService.Code
{
    public interface IRepository
    {
        PostgreeSqlContext GetContext();
        List<ProductProlongationData> ProlongationDataLinq(int agentId, int[] products);
        List<ProductProlongationData> GetProductsProlongationData();
        List<ProductProlongationData> GetProductsEpProlongationData();
        ProlongationShortDatum AddProlongationShortDatum(ProductProlongationData productProlongationData);
        ProlongationShortDatum UpdateProlongationShortDatum(ProlongationShortDatum prolongationShortDatum, ProductProlongationData productProlongationData);
        void RemoveProlongationShortDatum(ProlongationShortDatum prolongationShortDatum);
        ProlongationShortDatum GetProlongationShortDatum(int productId, int contractId);
        List<ProlongationShortDatum> GetProlongationShortData(Guid productGuid);
        List<ShortDataSummary> GetProlongationShortDataSummaryDifference();
        List<ShortDataSummary> GetProlongationShortDataSummaryToRemove();
        List<ProlongationShortDatum> GetOutdatedProlongationData();
        List<ProlongationShortDatum> GetUnactiveProlongationData();
        List<ProlongationShortDatum> GetTransferredProlongationData();
        List<int> GetAbonentsIds();
        List<int> GetNoDispatchAbonentsIds();
        Dictionary<Guid, int> GetAbonentsGuids(List<int> ids);
        List<ProlongationShortDatum> GetAbonentProlongationShortData(int id);

        void UpdateShortDataSummary(int agentId);
        IEnumerable<int> GetProductAgents(int[] productTypeIds);
    }
}
