using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTab.Drawing;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using System.Drawing;

namespace XtraTabWithButtons
{
    public class SkinTabPainterDescendant : SkinTabPainter
    {
        public SkinTabPainterDescendant(IXtraTab tabControl)
            : base(tabControl) { }

        protected override void DrawHeaderPage(TabDrawArgs e, BaseTabRowViewInfo row, BaseTabPageViewInfo pInfo)
        {
            base.DrawHeaderPage(e, row, pInfo);
            BaseTabPageViewInfoDescendant pInfodes = pInfo as BaseTabPageViewInfoDescendant;
            DrawHeaderPageButtons(e, pInfodes);
        }

        protected virtual void DrawHeaderPageButtons(TabDrawArgs e, BaseTabPageViewInfoDescendant pInfo)
        {
            pInfo.PagePanel.Draw(e.Cache);
        }
    }
}