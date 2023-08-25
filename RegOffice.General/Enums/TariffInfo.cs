using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOffice.General.Enums
{
    public enum TariffInfo
    {
        AstralStandardStorage = 1,
        ThreeMonthsAstralStorage = 2,
        SixMonthsAstralStorage = 3,
        NineMonthsAstralStorage = 4,
        Standard1 = 5,
        Standard2 = 6,
        Demo1 = 7,
        Demo2 = 8,
        Custom1 = 9,
        Custom2 = 10,
        Its1 = 11,

        /// <summary>
        /// Информационно-технологическое сопровождение 1С
        /// </summary>
        [EnumGuidAttribute("f9acdaa5-3eb3-4166-b373-3076fbec26b3")]
        Its2 = 12,

        TwelveAndSixMonth1 = 13,
        TwelveAndSixMonth2 = 14,
        SixMonth1 = 15,
        SixMonth2 = 16,
        TechSupport1 = 17,
        TechSupport2 = 18,

        /// <summary>
        /// Промо (1 месяц бесплатно)
        /// </summary>
        Bonus = 19,
        Test = 30,
        AdditionalLicenseForClientsOfAuthorizedAgent = 117,
        [EnumGuidAttribute("09e295e2-2fcc-4cb3-a997-34cd7c07a637")]
        RightDecision = 43,
        [EnumGuidAttribute("e0608b01-2f60-4ed5-bd96-4aec2916fd33")]
        Migration = 201,
        OneSTariffFromOldContract = 50,
        FreeEdo = 535,
        ServicePackageStart = 581,
        GovOrder = 70,
        Commercial = 73,
        B2B = 74,
        Rosreestr = 200,
        Extended = 447,
        Universal = 449,
        [EnumGuidAttribute("78986095-c118-4af0-b5a6-d68e24d01434")]
        BO29092015 = 461,
        Basis = 463,
        [EnumGuidAttribute("a7445085-57f3-4253-9acf-34c802035318")]
        StartEdo = 651,
        [EnumGuidAttribute("522e974d-3251-4469-87fc-7df21aece65d")]
        StartEdoOption = 1108,
        Fabricant = 675,
        Smev = 671,
        CryptoProLicenseInCertificate = 786,
        PaiedForIP = 825,
        [EnumGuidAttribute("e088bf7d-e10e-4e9d-a3a3-91a1e71472f2")]
        DemoGpb = 858,
        BusinessStartCompanyGroup = 873,
        Rosobrnadzor = 884,
        [EnumGuidAttribute("5b8ed73c-b5ae-472e-8a8c-7fa32b57fa75")]
        DemoAstralReportWeb = 999,
        [EnumGuidAttribute("67c5b538-554f-4e81-80b5-8291e80b8d2f")]
        PriorityProcessing = 1018,
        BasisQualifiedCertPhysical = 1029,
        BasisQualifiedCert1C = 1030,
        BasisQualifiedCertAEP = 1042,
        GosZakazKep = 1048,
        BasisAEP = 1053,
        RosobrnadzorWithoutOids = 1058,
        BasisOnlyJuridical = 1062,
        BasisOnlyPhysical = 1063,
        Universal1C = 1035,
        UniversalQualifiedCert = 1050,
        [EnumGuidAttribute("cd0097aa-6835-41e8-b10f-78b741252084")]
        DemoAo5Reporting = 1109,
        [EnumGuidAttribute("c470726f-1f2b-4349-90e5-7a0945012148")]
        OneSEtk = 1394,
        Profi = 1391,
        BasisQualifiedCert1CRS = 1118,
        BasicPromo1500 = 582,
        UniversalUnqualified = 418,
        [EnumGuid("6f3d314f-b7fc-43eb-a0e6-3ce1ee4484fe")]
        Trial = 2500,

        /// <summary>
        /// 1С-Отчетность. Старт ПСБ
        /// </summary>
        [EnumGuid("9dc47f53-3853-491a-8ef0-4543005ddd13")]
        PsbStart = 2226,

        /// <summary>
        /// ПромСвязьБанк.Старт NEW
        /// </summary>
        [EnumGuid("b76ab994-bfc8-45bd-89a2-91d8baa64edf")]
        PsbStartNew = 2480,

        /// <summary>
        /// Информационно-технологическое сопровождение 1С на НТ
        /// </summary>
        [EnumGuid("15925b52-7c1a-4f5c-821d-3c75e7f035aa")]
        ItsNT = 2391,

        /// <summary>
        /// 1С-Отчетность. Старт на НТ
        /// </summary>
        [EnumGuid("60358a83-1a6d-4076-9f01-24f100aeaa93")]
        StartNT = 2392,

        /// <summary>
        /// Верное решение (опция) на НТ
        /// </summary>
        [EnumGuid("33c5a40f-51b4-4969-a0f7-b631136370d4")]
        RightDecisionNT = 2393,

        /// <summary>
        /// 1С-Отчетность. Старт ПСБ на НТ
        /// </summary>
        [EnumGuid("d97bcc46-c0f5-4c3e-91d0-b333bc1b3269")]
        PsbStartNT = 2394,

        /// <summary>
        /// ПромСвязьБанк.Старт NEW на НТ
        /// </summary>
        [EnumGuid("85b554c2-37ff-4381-a0eb-3ceba5229de1")]
        PsbStartNewNT = 2395,

        /// <summary>
        /// Промо Кадровые решения (ФСС и ПФР)
        /// </summary>
        [EnumGuid("5cb77c21-a885-4819-b4fd-43732d71580b")]
        PromoPersonnelSolutions = 2407
    }


    public enum TariffDirection
    {
        None = 0,
        [EnumProtocol(ProtocolInfo.FnsGp3)]
        [EnumProtocol(ProtocolInfo.Gpr469)]
        [EnumProtocol(ProtocolInfo.Prikaz705)]
        [EnumProtocol(ProtocolInfo.Fns534)]
        Fns = 1,
        [EnumProtocol(ProtocolInfo.Pfr190R)]
        Pfr = 2,
        [EnumProtocol(ProtocolInfo.Fss)]
        Fss = 3,
        [EnumProtocol(ProtocolInfo.Fsgs)]
        Fsgs = 4,
        [EnumProtocol(ProtocolInfo.FsRpn)]
        [EnumProtocol(ProtocolInfo.Rpn)]
        Rpn = 5,
        [EnumProtocol(ProtocolInfo.LayoutPfr)]
        Macket = 6,
        [EnumProtocol(ProtocolInfo.RosAlk)]
        RosAlk = 7,
        [EnumProtocol(ProtocolInfo.FnsEdo)]
        Edo = 8
    }


    public static class TariffInfoConverter
    {

        public static Guid GetTariffGuid(this TariffInfo tariffInfo)
        {
            object[] attribs = typeof(TariffInfo).GetField(tariffInfo.ToString()).GetCustomAttributes(typeof(EnumGuidAttribute), false);

            if (attribs != null && attribs.Length > 0)
                return ((EnumGuidAttribute)attribs[attribs.Length - 1]).GuidValue;

            throw new NotImplementedException("Конвертация для данного формата не реализована");
        }
    }


    public enum TariffAttributeInfo
    {
        None = 0,
        AstralReport = 1,
        Protocol = 2,
        [Direction(TariffDirection.Fns)]
        ProtocolFns = 3,
        [Direction(TariffDirection.Pfr)]
        ProtocolPfr = 4,
        [Direction(TariffDirection.Fsgs)]
        ProtocolFsgs = 5,
        [Direction(TariffDirection.Fss)]
        ProtocolFss = 6,
        [Direction(TariffDirection.Rpn)]
        ProtocolRpn = 7,
        QualifiedCertificate = 8,
        [Roaming]
        [Direction(TariffDirection.Fns)]
        RoamingFns = 9,
        [Plugin(PluginInfo.Fss)]
        [DirectionPlugin(TariffDirection.Fss)]
        PluginFss = 10,
        ProtocolAisPfr = 229,
        PluginAisPfr = 230,
        ProlocolEln = 231,
        [Plugin(PluginInfo.SosGpr)]
        [Plugin(PluginInfo.Gpr)]
        [Plugin(PluginInfo.SosGpr3)]
        [DirectionPlugin(TariffDirection.Fns)]
        PluginFns = 11,
        [Plugin(PluginInfo.Egrul)]
        PluginEgrul = 12,
        [Plugin(PluginInfo.Pfr190r)]
        [Plugin(PluginInfo.ArPfr)]
        [Plugin(PluginInfo.Pfr)]
        [DirectionPlugin(TariffDirection.Pfr)]
        PluginPfr = 13,
        [Plugin(PluginInfo.Fsgs)]
        [Plugin(PluginInfo.Fsgs705)]
        [Plugin(PluginInfo.TatarFsgs705)]
        [DirectionPlugin(TariffDirection.Fsgs)]
        PluginStat = 14,
        AstralStorage = 15,
        OneCReport = 16,
        AuthorizedRepresentative1S = 17,
        DigitalSignature1S = 18,
        Efrsfdul = 19,
        EiasFst = 20,
        EtpGpb = 21,
        SolidAsk = 22,
        Aetp = 23,
        B2B = 24,
        ArbitatMember = 25,
        ArbitatOrg = 26,
        Rts = 27,
        MinFinKo = 28,
        Transaction = 29,
        Referi = 32,
        Fts = 33,
        [Direction(TariffDirection.Macket)]
        ProtocolMacket = 34,
        [Plugin(PluginInfo.LayoutPfr)]
        [DirectionPlugin(TariffDirection.Macket)]
        PluginMacket = 35,
        Plugin = 36,
        IntegrityCheck = 37,
        [Direction(TariffDirection.RosAlk)]
        ProtocolAlk = 39,
        [Plugin(PluginInfo.RosAlk)]
        [DirectionPlugin(TariffDirection.RosAlk)]
        PluginAlk = 40,
        [Plugin(PluginInfo.Fsgs)]
        [Plugin(PluginInfo.Fsgs705)]
        [Plugin(PluginInfo.TatarFsgs705)]
        [DirectionPlugin(TariffDirection.Fsgs)]
        PluginFsgs = 41,
        Kpp = 42,
        EdoFormalTransaction = 43,
        EdoInformalTransaction = 44,
        PluginEdo = 45,
        ProtocolEdo = 46,
        Rosreestr = 47,
        CertificateTender = 48,
        [Direction(TariffDirection.Rpn)]
        ProtocolFsRpn = 51,
        CompanyGroup = 55,
        Skrin = 56,
        Smev = 63,
        Counting = 64,
        Bonuses = 65,
        TenderConsulting = 67,
        Fabrikant = 69,
        AstralOfd = 70,
        CertTemplate = 72,
        Gpb = 74,
        CertificatePsb = 138,
        AstralReportWeb = 139,
        CertificateInformationSystem = 156,
        CryptoProLicense = 157,
        UnstructuredName = 162,
        OneTime = 165,
        FnsRegistration = 167,
        PfrRegistration = 168,
        StatRegistration = 169,
        NoAutoSelection = 175,
        AO5Reporting = 177,
        Upgrade = 178,
        IdentificationServices = 179,
        OnlyOncePerAbonent = 180,
        DssUserGroup = 186,
        AstralDssExtension = 235,
        OneSDssExtension = 236,
        NoQualifiedCertificate = 239,
        EndlessTariff = 240,
        ShouldBeReplaced = 241,
        MultiUserMode = 242,
        Doc152 = 245,
        OneS152Doc = 246
    }

    public enum TariffAttributeTypeInfo
    {
        Software = 1,
        Protocol = 2,
        Plugin = 3,
        QualifiedSign = 4
    }

    public enum TariffTypeInfo
    {
        [EnumNameAttribute("Отсутвует")]
        None = 0,
        [EnumNameAttribute("Платная")]
        GeneralLicense = 1,
        [EnumNameAttribute("Расширение")]
        ExtensionLicense = 2,
        [EnumNameAttribute("Сервис")]
        Service = 3,
        [EnumNameAttribute("Платная ГК")]
        CompanyGroup = 6,
        [EnumNameAttribute("Льготная")]
        Its = 7,
        [EnumNameAttribute("Отложенная регистрация ИТС")]
        DelayedRegistration = 8,
        [EnumNameAttribute("Бонусная")]
        Bonus = 9,
        [EnumNameAttribute("Тестовая")]
        Test = 10,
        [EnumNameAttribute("Специальное предложение")]
        Special = 11,
        [EnumNameAttribute("Верное решение")]
        RightSolution = 12,
        [EnumNameAttribute("Обслуживание учетной записи в рамках ранее заключенного договора")]
        TransferAccount = 13,
        [EnumNameAttribute("Лицензия для региона")]
        Regional = 14,
        [EnumNameAttribute("Услуги УЦ")]
        CaService = 15,
        [EnumNameAttribute("Встроенная лицензия")]
        EmbeddedLicense = 16,
        [EnumNameAttribute("Платная ГК ИП")]
        CompanyGroupIndividual = 17,
        [EnumNameAttribute("Кадровые решения")]
        HrSolutions = 18,
        [EnumNameAttribute("Многопользовательский режим")]
        MultiUserMode = 19,
        [EnumNameAttribute("Промо ЕНС")]
        PromoEns = 20
    }

    public static class TariffTypeInfoConverter
    {

        public static string[] GetAllCategoriesNames()
        {
            TariffTypeInfo[] vals = (TariffTypeInfo[])Enum.GetValues(typeof(TariffTypeInfo));
            string[] names = new string[vals.Length];
            for (int i = 0; i < vals.Length; i++)
                names[i] = GetTariffTypeName(vals[i]);
            return names;
        }

        public static string GetTariffTypeName(this TariffTypeInfo tariffTypeInfo)
        {
            object[] attribs = typeof(TariffTypeInfo).GetField(tariffTypeInfo.ToString()).GetCustomAttributes(typeof(EnumNameAttribute), false);

            if (attribs.Length > 0)
                return ((EnumNameAttribute)attribs[attribs.Length - 1]).Description;
            throw new NotImplementedException("Конвертация для данного формата не реализована");
        }
    }

    public enum PriceInfo
    {
        None = 0,
        AstralStorage = 1,
        OneCReport = 2,
        AstralReport = 6,
        Special1S = 7,
        AstralReportArm = 11,
        DigitalSignature1S = 12,
        AstralDigitalSignature = 13,
        AstralTender = 14,
        Edi1S = 25,
        CheckAO = 30,
        CheckAORoaming = 31,
        Npf1S = 86,
        Skrin = 87,
        /// <summary>
        /// тендерный консалтинг
        /// </summary>
        TenderConsulting = 89,
        Skrin1s = 90,
        AstralTender2_0 = 91,
        AstralOfd = 166,
        Gpb = 167,
        DsAstral = 244,
        Ds1C = 245,
        AstralCorporate = 247,
        AstralReport5_0 = 249,
        Ds1CNew = 261,
        DsAstralNew = 265,
        AstralReport5_0Reporting = 288
    }


    public enum TariffGroupInfo
    {
        None = 0,
        OrgIndividual = 1,
        AstralStorage = 2,
        AstralReport = 3,
        OneSReport = 4,
        AstralSignature = 5,
        AstralAuction = 6,
        Edo1C = 7,
        Gpb = 12,
        AstralReportWeb = 14,
        AO5Reporting = 15
    }

    public class ContractTariffInfo
    {
        public TariffAttributeInfo AttributeInfo { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime? InitialDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? WaitingDay { get; set; }
        public int Number { get; set; }
        public decimal? Price { get; set; }

        public ContractTariffInfo()
        {
            Number = 1;
        }

        public bool IsPrimary { get; set; }
    }

    public enum LimitInfo
    {
        None = 0,
        Extension = 1,
        Individual = 2,
        Juridical = 3,
        AuthorizedRepresentativeClient = 4,
        Envd = 5,
        AdditionalAbonent = 6,
        Region = 7,
        Fns = 8,
        Initial = 9,
        MandatoryPayment = 10,
        Physical = 14,
        ForQualified = 21,
        ForNonQualified = 22,
        MaxUses = 25,
        ForCGWithSharedContract = 49,
        FirstProductOnly = 50
    }

    public enum AttributeTypeInfo
    {
        Software = 1,
        Direction = 2,
        Plugin = 3,
        Certificate = 4,
        EnhancedKeyUsages = 5
    }

    public enum CompanyGroupScheme
    {
        /// <summary>
        /// С общим договoром
        /// </summary>
        SharedContract = 1
    }

    public abstract class GroupTariffInfo
    {
        public abstract List<Guid> GetListValue();
    }

    public class ItsGroupTariffInfo : GroupTariffInfo
    {
        private static readonly Lazy<ItsGroupTariffInfo> _instance = new Lazy<ItsGroupTariffInfo>(() => new ItsGroupTariffInfo());

        public static ItsGroupTariffInfo Instance
        {
            get { return _instance.Value; }
        }

        public override List<Guid> GetListValue()
        {
            return new List<Guid>
            {
                TariffInfo.Its2.GetTariffGuid(),
                TariffInfo.PsbStart.GetTariffGuid(),
                TariffInfo.PsbStartNew.GetTariffGuid(),
                TariffInfo.ItsNT.GetTariffGuid(),
                TariffInfo.PsbStartNT.GetTariffGuid(),
                TariffInfo.PsbStartNewNT.GetTariffGuid(),
                TariffInfo.RightDecisionNT.GetTariffGuid(),
                TariffInfo.StartNT.GetTariffGuid()
            };
        }
    }
}
