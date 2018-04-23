using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraTab;

namespace XtraTabWithButtons
{
    public class XtraTabPageCollectionDescendant : XtraTabPageCollection
    {
        public XtraTabPageCollectionDescendant(XtraTabControl tabControl)
            : base(tabControl) { }

        protected override XtraTabPage CreatePage()
        {
            return new XtraTabPageDescendant();
        }
    }
}
