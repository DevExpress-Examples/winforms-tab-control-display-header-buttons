using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTab.Registrator;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTab;
using DevExpress.XtraTab.Drawing;

namespace XtraTabWithButtons
{
    public class SkinViewInfoRegistratorDescendant : SkinViewInfoRegistrator
    {
        public const string MyViewName = "MySkin";
        public override string ViewName
        {
            get
            {
                return MyViewName;
            }
        }

        public override BaseTabHandler CreateHandler(IXtraTab tabControl)
        {
            return new BaseTabHandlerDescendant(tabControl);
        }

        public override BaseTabHeaderViewInfo CreateHeaderViewInfo(BaseTabControlViewInfo viewInfo)
        {
            return new SkinTabHeaderViewInfoDescendant(viewInfo);
        }

        public override BaseTabPainter CreatePainter(IXtraTab tabControl)
        {
            return new SkinTabPainterDescendant(tabControl);
        }
    }
}
