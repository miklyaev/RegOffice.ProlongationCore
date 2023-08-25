using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOffice.General.Enums
{
    public enum ProtocolInfo
    {
        [EnumNameAttribute("ФНС469")]
        [EnumAliasAttribute("ФНС")]
        Gpr469 = 1,
        [EnumNameAttribute("ПФР")]
        [EnumAliasAttribute("ПФР")]
        Pfr190R = 2,
        [EnumNameAttribute("705 приказ")]
        Prikaz705 = 3,
        [EnumNameAttribute("ФСГС")]
        [EnumAliasAttribute("ФСГС")]
        Fsgs = 4,
        [EnumNameAttribute("ФСС")]
        [EnumAliasAttribute("ФСС")]
        Fss = 5,
        [EnumNameAttribute("ИОН")]
        [EnumAliasAttribute("ИОН")]
        Ion = 6,
        [EnumNameAttribute("ФНС ГП-2")]
        [EnumAliasAttribute("ФНС")]
        Fns534 = 7,
        [EnumNameAttribute("РПН")]
        [EnumAliasAttribute("РПН")]
        Rpn = 8,
        [EnumNameAttribute("ФСРАР")]
        [EnumAliasAttribute("ОИВ")]
        RosAlk = 9,
        [EnumNameAttribute("ФНС ЭДО")]
        [EnumAliasAttribute("ЭДО")]
        FnsEdo = 10,
        [EnumNameAttribute("Сервис")]
        [EnumAliasAttribute("Сервис")]
        Service = 11,
        [EnumNameAttribute("МПФР")]
        [EnumAliasAttribute("ПФР")]
        LayoutPfr = 12,
        [EnumNameAttribute("ФНС")]
        [EnumAliasAttribute("ФНС")]
        FnsGp3 = 13,
        [EnumNameAttribute("НД МАК (РАР)")]
        [EnumAliasAttribute("РАР")]
        NdMakRar = 14,
        [EnumNameAttribute("ФСРПН")]
        [EnumAliasAttribute("РПН")]
        FsRpn = 15,
        [EnumNameAttribute("СКРИН")]
        [EnumAliasAttribute("СКРИН")]
        Skrin = 16,
        [EnumNameAttribute("ФТС")]
        [EnumAliasAttribute("ФТС")]
        Fts = 17,
        [EnumNameAttribute("ОФД")]
        [EnumAliasAttribute("ОФД")]
        Ofd = 18,
        [EnumNameAttribute("ЭЛН")]
        [EnumAliasAttribute("ЭЛН")]
        Eln = 19,
        [EnumNameAttribute("ЭДОК")]
        [EnumAliasAttribute("ЭДОК")]
        PfrEwb = 20,
        [EnumNameAttribute("ЦБ")]
        [EnumAliasAttribute("ЦБ")]
        Cb = 21
    }

    public static class ProtocolInfoConverter
    {
        public static bool IsDefined(this ProtocolInfo value)
        {
            return Enum.IsDefined(value.GetType(), value);
        }

        public static string[] GetAllProtocolNames()
        {
            ProtocolInfo[] vals = (ProtocolInfo[])Enum.GetValues(typeof(ProtocolInfo));
            string[] names = new string[vals.Length];
            for (int i = 0; i < vals.Length; i++)
                names[i] = GetProtocolName(vals[i]);
            return names;
        }

        public static string GetProtocolName(this ProtocolInfo protocolInfo)
        {
            object[] attribs =
                typeof(ProtocolInfo).GetField(protocolInfo.ToString())
                    .GetCustomAttributes(typeof(EnumNameAttribute), false);

            if (attribs != null && attribs.Length > 0)
                return ((EnumNameAttribute)attribs[attribs.Length - 1]).Description;

            throw new NotImplementedException("Конвертация для данного формата не реализована");
        }

        public static string GetProtocolAlias(this ProtocolInfo protocolInfo)
        {
            object[] attribs = typeof(ProtocolInfo).GetField(protocolInfo.ToString()).GetCustomAttributes(typeof(EnumAliasAttribute), false);

            if (attribs != null && attribs.Length > 0)
                return ((EnumAliasAttribute)attribs[attribs.Length - 1]).Description;

            throw new NotImplementedException("Конвертация для данного формата не реализована");
        }
    }

    public abstract class GroupProtocolInfo
    {
        public abstract List<int> GetListValue();
    }

    public class GroupFnsProtocolInfo : GroupProtocolInfo
    {
        private static readonly Lazy<GroupFnsProtocolInfo> _instance = new Lazy<GroupFnsProtocolInfo>(() => new GroupFnsProtocolInfo());

        public static GroupFnsProtocolInfo Instance
        {
            get { return _instance.Value; }
        }

        public override List<int> GetListValue()
        {
            return new List<int>
            {
                (int)ProtocolInfo.Fns534,
                (int)ProtocolInfo.FnsEdo,
                (int)ProtocolInfo.Gpr469,
                (int)ProtocolInfo.FnsGp3
            };
        }
    }

    public class GroupNotFnsProtocolInfo : GroupProtocolInfo
    {
        private static readonly Lazy<GroupNotFnsProtocolInfo> _instance = new Lazy<GroupNotFnsProtocolInfo>(() => new GroupNotFnsProtocolInfo());

        public static GroupNotFnsProtocolInfo Instance
        {
            get { return _instance.Value; }
        }

        public override List<int> GetListValue()
        {
            return Enum.GetValues(typeof(ProtocolInfo)).Cast<int>().Except(
                    GroupFnsProtocolInfo.Instance.GetListValue()).ToList();
        }
    }

    public class GroupSosFnsProtocolInfo : GroupProtocolInfo
    {
        private static readonly Lazy<GroupSosFnsProtocolInfo> _instance = new Lazy<GroupSosFnsProtocolInfo>(() => new GroupSosFnsProtocolInfo());

        public static GroupSosFnsProtocolInfo Instance
        {
            get { return _instance.Value; }
        }

        public override List<int> GetListValue()
        {
            return new List<int>
            {
                (int)ProtocolInfo.Fns534,
                (int)ProtocolInfo.FnsEdo,
                (int)ProtocolInfo.FnsGp3
            };
        }
    }

    public class GroupIrucProtocolInfo : GroupProtocolInfo
    {
        private static readonly Lazy<GroupIrucProtocolInfo> _instance = new Lazy<GroupIrucProtocolInfo>(() => new GroupIrucProtocolInfo());

        public static GroupIrucProtocolInfo Instance
        {
            get { return _instance.Value; }
        }

        public override List<int> GetListValue()
        {
            return new List<int>
            {
                (int)ProtocolInfo.Fns534,
                (int)ProtocolInfo.Gpr469
            };
        }
    }
    public class GroupIrudProtocolInfo : GroupProtocolInfo
    {
        private static readonly Lazy<GroupIrudProtocolInfo> _instance = new Lazy<GroupIrudProtocolInfo>(() => new GroupIrudProtocolInfo());

        public static GroupIrudProtocolInfo Instance
        {
            get { return _instance.Value; }
        }

        public override List<int> GetListValue()
        {
            return new List<int>
            {
                (int)ProtocolInfo.FnsGp3
                //(int)ProtocolInfo.Gpr469
            };
        }
    }

    public class GroupEdiProtocolInfo : GroupProtocolInfo
    {
        private static readonly Lazy<GroupEdiProtocolInfo> _instance = new Lazy<GroupEdiProtocolInfo>(() => new GroupEdiProtocolInfo());

        public static GroupEdiProtocolInfo Instance
        {
            get { return _instance.Value; }
        }

        public override List<int> GetListValue()
        {
            return new List<int>
            {
                (int)ProtocolInfo.FnsEdo
            };
        }
    }

    public class GroupPfrProtocolInfo : GroupProtocolInfo
    {
        private static readonly Lazy<GroupPfrProtocolInfo> _instance = new Lazy<GroupPfrProtocolInfo>(() => new GroupPfrProtocolInfo());

        public static GroupPfrProtocolInfo Instance
        {
            get { return _instance.Value; }
        }

        public override List<int> GetListValue()
        {
            return new List<int>
            {
                (int)ProtocolInfo.Pfr190R,
                (int)ProtocolInfo.LayoutPfr
            };
        }
    }

    public class GroupFsgsProtocolInfo : GroupProtocolInfo
    {
        private static readonly Lazy<GroupFsgsProtocolInfo> _instance = new Lazy<GroupFsgsProtocolInfo>(() => new GroupFsgsProtocolInfo());

        public static GroupFsgsProtocolInfo Instance
        {
            get { return _instance.Value; }
        }

        public override List<int> GetListValue()
        {
            return new List<int>
            {
                (int)ProtocolInfo.Fsgs
            };
        }
    }

    public class GroupAccount1CProtocolInfo : GroupProtocolInfo
    {
        private static readonly Lazy<GroupAccount1CProtocolInfo> _instance = new Lazy<GroupAccount1CProtocolInfo>(() => new GroupAccount1CProtocolInfo());

        public static GroupAccount1CProtocolInfo Instance
        {
            get { return _instance.Value; }
        }

        public override List<int> GetListValue()
        {
            return new List<int>
            {
                (int)ProtocolInfo.Fsgs,
                (int)ProtocolInfo.FnsGp3,
                (int)ProtocolInfo.Pfr190R,
                (int)ProtocolInfo.Fss,
                (int)ProtocolInfo.RosAlk,
                (int)ProtocolInfo.Rpn,
                (int)ProtocolInfo.Fts,
                (int)ProtocolInfo.FsRpn,
            };
        }
    }

    public class GroupActiveProtocolInfo : GroupProtocolInfo
    {
        private static readonly Lazy<GroupActiveProtocolInfo> _instance = new Lazy<GroupActiveProtocolInfo>(() => new GroupActiveProtocolInfo());

        public static GroupActiveProtocolInfo Instance
        {
            get { return _instance.Value; }
        }

        public override List<int> GetListValue()
        {
            return new List<int>
            {
                (int)ProtocolInfo.Pfr190R,
                (int)ProtocolInfo.Fss,
                (int)ProtocolInfo.Fsgs,
                (int)ProtocolInfo.Rpn,
                (int)ProtocolInfo.RosAlk,
                (int)ProtocolInfo.FnsEdo,
                (int)ProtocolInfo.Service,
                (int)ProtocolInfo.LayoutPfr,
                (int)ProtocolInfo.FnsGp3,
                (int)ProtocolInfo.Fts,
                (int)ProtocolInfo.FsRpn,
                (int)ProtocolInfo.Cb,
            };
        }
    }

    public class GroupActiveAstralReportFourProtocolInfo : GroupProtocolInfo
    {
        private static readonly Lazy<GroupActiveAstralReportFourProtocolInfo> _instance =
            new Lazy<GroupActiveAstralReportFourProtocolInfo>(() => new GroupActiveAstralReportFourProtocolInfo());

        public static GroupActiveAstralReportFourProtocolInfo Instance
        {
            get { return _instance.Value; }
        }

        public override List<int> GetListValue()
        {
            return new List<int>
            {
                (int)ProtocolInfo.Pfr190R,
                (int)ProtocolInfo.Fss,
                (int)ProtocolInfo.Fsgs,
                (int)ProtocolInfo.Rpn,
                (int)ProtocolInfo.RosAlk,
                (int)ProtocolInfo.FnsEdo,
                (int)ProtocolInfo.Service,
                (int)ProtocolInfo.LayoutPfr,
                (int)ProtocolInfo.FnsGp3,
                (int)ProtocolInfo.Fts,
                (int)ProtocolInfo.FsRpn,
                (int)ProtocolInfo.Eln,
            };
        }
    }

    public class GroupGprProtocolInfo : GroupProtocolInfo
    {
        private static readonly Lazy<GroupGprProtocolInfo> _instance = new Lazy<GroupGprProtocolInfo>(() => new GroupGprProtocolInfo());

        public static GroupGprProtocolInfo Instance
        {
            get { return _instance.Value; }
        }

        public override List<int> GetListValue()
        {
            return new List<int>
            {
                (int)ProtocolInfo.FnsGp3,
                (int)ProtocolInfo.FnsEdo
            };
        }
    }

    public class GroupOfdProtocolInfo : GroupProtocolInfo
    {
        private static readonly Lazy<GroupOfdProtocolInfo> _instance = new Lazy<GroupOfdProtocolInfo>(() => new GroupOfdProtocolInfo());

        public static GroupProtocolInfo Instance
        {
            get { return _instance.Value; }
        }

        public override List<int> GetListValue()
        {
            return new List<int>
            {
                (int)ProtocolInfo.Ofd
                //(int)ProtocolInfo.Gpr469
            };
        }
    }

    public class GroupRecipientStepProtocolInfo : GroupProtocolInfo
    {
        private static readonly Lazy<GroupRecipientStepProtocolInfo> _instance = new Lazy<GroupRecipientStepProtocolInfo>(() => new GroupRecipientStepProtocolInfo());

        public static GroupProtocolInfo Instance
        {
            get { return _instance.Value; }
        }

        public override List<int> GetListValue()
        {
            return new List<int>
            {
                (int)ProtocolInfo.FnsGp3,
                (int)ProtocolInfo.Ofd,
                (int)ProtocolInfo.Fsgs,
                (int)ProtocolInfo.FnsEdo,
            };
        }
    }


    public class GroupPriorityRecipientStepProtocolInfo : GroupProtocolInfo
    {
        private static readonly Lazy<GroupPriorityRecipientStepProtocolInfo> _instance = new Lazy<GroupPriorityRecipientStepProtocolInfo>(() => new GroupPriorityRecipientStepProtocolInfo());

        public static GroupProtocolInfo Instance
        {
            get { return _instance.Value; }
        }

        public override List<int> GetListValue()
        {
            return new List<int>
            {
                (int)ProtocolInfo.FnsGp3,
                (int)ProtocolInfo.Ofd,
                (int)ProtocolInfo.Fsgs
            };
        }
    }
    public class GroupElnProtocolInfo : GroupProtocolInfo
    {
        private static readonly Lazy<GroupElnProtocolInfo> _instance = new Lazy<GroupElnProtocolInfo>(() => new GroupElnProtocolInfo());

        public static GroupProtocolInfo Instance
        {
            get { return _instance.Value; }
        }

        public override List<int> GetListValue()
        {
            return new List<int>
            {
                (int)ProtocolInfo.Eln
            };
        }
    }

    public class GroupSkrinProtocolInfo : GroupProtocolInfo
    {
        private static readonly Lazy<GroupSkrinProtocolInfo> _instance = new Lazy<GroupSkrinProtocolInfo>(() => new GroupSkrinProtocolInfo());

        public static GroupProtocolInfo Instance
        {
            get { return _instance.Value; }
        }

        public override List<int> GetListValue()
        {
            return new List<int>
            {
                (int)ProtocolInfo.Skrin
            };
        }
    }
    public class GroupAisPfrProtocolInfo : GroupProtocolInfo
    {
        private static readonly Lazy<GroupAisPfrProtocolInfo> _instance = new Lazy<GroupAisPfrProtocolInfo>(() => new GroupAisPfrProtocolInfo());

        public static GroupAisPfrProtocolInfo Instance
        {
            get { return _instance.Value; }
        }

        public override List<int> GetListValue()
        {
            return new List<int>
            {
                (int)ProtocolInfo.PfrEwb,
            };
        }
    }
}
