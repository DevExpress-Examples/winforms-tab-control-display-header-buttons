using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTab;

namespace XtraTabWithButtons
{
    public class XtraTabControlDescendant : XtraTabControl
    {
        protected override XtraTabPageCollection CreateTabCollection()
        {
            return new XtraTabPageCollectionDescendant(this);
        }
    }
}
