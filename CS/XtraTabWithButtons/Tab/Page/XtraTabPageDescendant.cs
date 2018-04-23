using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTab;
using DevExpress.XtraTab.Buttons;
using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.Utils.Design;

namespace XtraTabWithButtons
{
    public class XtraTabPageDescendant : XtraTabPage
    {
        CustomHeaderButtonCollection customHeaderButtonsCore;

        public event CustomHeaderButtonEventHandler CustomPageButtonClick;

        public XtraTabPageDescendant()
        {
            customHeaderButtonsCore = new CustomHeaderButtonCollection();
            CustomButtons.CollectionChanged += CustomButtons_CollectionChanged;
        }

        void CustomButtons_CollectionChanged(object sender, CollectionChangeEventArgs e)
        {
            if (!DesignMode || Site == null) return;
            EditorContextHelper.FireChanged(Site, this);
        }

        [Localizable(true), Category(CategoryName.Behavior), RefreshProperties(RefreshProperties.All)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public virtual CustomHeaderButtonCollection CustomButtons
        {
            get { return customHeaderButtonsCore; }
        }

        public void RaiseCustomPageButtonClick(TabButtonInfo button)
        {
            if (CustomPageButtonClick != null)
            {
                CustomHeaderButtonEventArgs args = new CustomHeaderButtonEventArgs(button.Button as CustomHeaderButton, this);
                CustomPageButtonClick(this, args);
            }
        }
    }
}
