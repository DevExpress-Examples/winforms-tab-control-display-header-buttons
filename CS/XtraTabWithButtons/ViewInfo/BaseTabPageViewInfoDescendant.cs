using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTab;

namespace XtraTabWithButtons
{
    public class BaseTabPageViewInfoDescendant : BaseTabPageViewInfo
    {
        private TabButtonsPanelDescendant _PagePanel;
        public BaseTabPageViewInfoDescendant(IXtraTabPage page)
            : base(page)
        {
            _PagePanel = new TabButtonsPanelDescendant(ViewInfo, Page as XtraTabPageDescendant);
        }

        public TabButtonsPanelDescendant PagePanel
        {
            get { return _PagePanel; }
        }
    }
}
