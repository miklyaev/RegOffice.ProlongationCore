using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOffice.General.Enums
{
    public class CommonPluginInfo
    {
        public Guid PluginGuid { get; set; }
        public int? TariffCode { get; set; }
    }

    public enum PluginTariffInfo
    {
        Main = 1,
        EsfAll = 2,
        EsfProduct = 3,
        EsfPartner = 4,
        EsfSos = 5
    }

    public enum PluginInfo
    {
        [EnumGuidAttribute("68560c2f-f3c7-42e8-8e33-74fc4c6d253d")]
        Gpr = 1,
        [EnumGuidAttribute("3e8a6a23-d325-4c74-9bb5-e83c0bd4de4e")]
        Pfr = 2,
        [EnumGuidAttribute("4eafa422-bb5e-4e7c-ae58-fa843f2e0c34")]
        Fns = 3,
        [EnumGuidAttribute("08341d87-c89a-41b6-b200-cceff57c7482")]
        Calendar = 4,
        [EnumGuidAttribute("8c3722a0-b843-4b80-a728-acb0d5c98ca6")]
        ArFns = 5,
        [EnumGuidAttribute("99c17741-bc10-4db1-b3f0-8c6f6070aa73")]
        Fsgs705 = 6,
        [EnumGuidAttribute("07b8b036-c3ac-4444-b2ec-5f58ac274729")]
        TatarFsgs705 = 7,
        [EnumGuidAttribute("3e39e43f-b7a0-41e0-a31f-ca35c90cbed8")]
        TestFss = 8,
        [EnumGuidAttribute("1408cc36-c3ac-4444-b2ec-5458ac274729")]
        Fsgs = 9,
        [EnumGuidAttribute("d72094c1-e679-493c-98bb-690a8ab422d2")]
        Fss = 10,
        [EnumGuidAttribute("2a9a5c7c-fef2-4b0f-a834-9a6ec2cbc800")]
        Ion = 11,
        [EnumGuidAttribute("0276b456-7d40-4b66-a098-9584ca3991c0")]
        Egrul = 12,
        [EnumGuidAttribute("71efdd62-16ac-73aa-5bdd-65ae4d8905e1")]
        ArPfr = 13,
        [EnumGuidAttribute("dd41f56f-3d5e-48c1-80eb-253b68623f76")]
        SosGpr = 14,
        [EnumGuidAttribute("442c8b03-09b3-4ea2-81ab-557a16845a8a")]
        TaxPlayer = 15,
        [EnumGuidAttribute("14ac603c-983d-44f2-9d1f-46fd98426691")]
        Rpn = 16,
        [EnumGuidAttribute("610f56f5-0fdc-478b-acb6-bda33d759257")]
        Pfr190r = 17,
        [EnumGuidAttribute("46472fba-069f-4d41-9e49-736df914ccd1")]
        Workflow = 18,
        [EnumGuidAttribute("00c5a7c5-f050-46c7-a018-88b3f6949ae3")]
        FnsExtract = 19,
        [EnumGuidAttribute("0ce5ddcc-2a93-4133-8d32-873c0ae5b706")]
        PfrExtract = 20,
        [EnumGuidAttribute("a969ffe4-5491-4db4-ab2e-a62b8f75f273")]
        RosAlk = 21,
        [EnumGuidAttribute("fbabc67f-5d64-4905-b6dc-a0c2a3d6e3ee")]
        LayoutPfr = 22,
        [EnumGuidAttribute("485600c9-5398-455d-9d73-b646bacc5ba7")]
        SosGpr3 = 23,
        [EnumGuidAttribute("4c86392b-7d26-4543-be05-ece754112074")]
        Skrin = 26,
    }

    public static class PluginInfoConverter
    {
        public static Guid[] GetAllPluginInfoGuids()
        {
            PluginInfo[] vals = (PluginInfo[])Enum.GetValues(typeof(PluginInfo));
            Guid[] guids = new Guid[vals.Length];
            for (int i = 0; i < vals.Length; i++)
                guids[i] = GetPluginGuid(vals[i]);
            return guids;
        }

        public static Guid GetPluginGuid(this PluginInfo pluginInfo)
        {
            object[] attribs = typeof(PluginInfo).GetField(pluginInfo.ToString()).GetCustomAttributes(typeof(EnumGuidAttribute), false);

            if (attribs != null && attribs.Length > 0)
                return ((EnumGuidAttribute)attribs[attribs.Length - 1]).GuidValue;

            throw new NotImplementedException("Конвертация для данного формата не реализована");
        }
    }
}
