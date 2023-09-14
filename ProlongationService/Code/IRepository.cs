using ProlongationService.Containers;
using RegOffice.DataModel.Model;
using RegOffice.DataModel.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ProductProlongationData = RegOffice.DataModel.Model.ProductProlongationData;

namespace ProlongationService.Code
{
    public interface IRepository
    {
        PostgreeSqlContext GetContext();
        List<ProlongationShortDatum> ProlongationDataLinq(int agentId, int[] products);     
        ProlongationShortDatum AddProlongationShortDatum(ProlongationShortDatum productProlongationData);
        ProlongationShortDatum UpdateProlongationShortDatum(ProlongationShortDatum prolongationShortDatum, ProlongationShortDatum productProlongationData);
        void RemoveProlongationShortDatum(ProlongationShortDatum prolongationShortDatum);
        ProlongationShortDatum GetProlongationShortDatum(int productId, int contractId);
        List<ProlongationShortDatum> GetProlongationShortData(Guid productGuid);     
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
