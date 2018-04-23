using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTab.Buttons;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTab;
using DevExpress.Utils;
using System.Drawing;

namespace XtraTabWithButtons
{
    public class TabButtonsPanelDescendant : TabButtonsPanel
    {
        private XtraTabPageDescendant _PageDescendant;

        public TabButtonsPanelDescendant(BaseTabControlViewInfo tabViewInfo, XtraTabPageDescendant pagedes)
            : base(tabViewInfo)
        {
            _PageDescendant = pagedes;
        }

        public XtraTabPageDescendant PageDescendant
        {
            get { return _PageDescendant; }
        }

        protected override void CreateButtonsCore(TabButtons buttons, CustomHeaderButtonCollection userButtons)
        {
            base.CreateButtonsCore(buttons, PageDescendant.CustomButtons);
        }

        protected override void OnClickButton(TabButtonInfo button)
        {
            keepButtons++;
            try
            {
                if (CanRaiseHeaderButtonClick(button))
                    PageDescendant.RaiseCustomPageButtonClick(button);
            }
            finally
            {
                keepButtons--;
            }
            if (!TabViewInfo.IsDisposing)
                TabViewInfo.LayoutChanged();
        }

        public ToolTipControlInfo GetToolTip(Point point)
        {
            return GetToolTipInfo(point);
        }
    }
}
