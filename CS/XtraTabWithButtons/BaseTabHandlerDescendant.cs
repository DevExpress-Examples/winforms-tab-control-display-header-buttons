using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTab;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Controls;

namespace XtraTabWithButtons
{
    public class BaseTabHandlerDescendant : BaseTabHandler
    {
        public BaseTabHandlerDescendant(IXtraTab tabControl)
            : base(tabControl)
        {
            
        }

        protected override bool OnMouseMove(MouseEventArgs e)
        {
            bool result = base.OnMouseMove(e);
            DXMouseEventArgs ee = DXMouseEventArgs.GetMouseArgs(e);
            if (ViewInfo != null)
            {
                BaseTabPageViewInfoDescendant infodes = ViewInfo.SelectedTabPageViewInfo as BaseTabPageViewInfoDescendant;
                infodes.PagePanel.ProcessEvent(new ProcessEventEventArgs(EventType.MouseMove, ee));
            }
            return result;
        }
        protected override bool OnMouseDown(MouseEventArgs e)
        {
            bool result = base.OnMouseDown(e);
            DXMouseEventArgs ee = DXMouseEventArgs.GetMouseArgs(e);
            
            BaseTabPageViewInfoDescendant infodes = ViewInfo.SelectedTabPageViewInfo as BaseTabPageViewInfoDescendant;
            if(infodes.PagePanel.Bounds.Contains(e.Location))
                infodes.PagePanel.ProcessEvent(new ProcessEventEventArgs(EventType.MouseDown, ee));
            return result;
        }

        protected override bool OnMouseUp(MouseEventArgs e)
        {
            bool result = base.OnMouseUp(e);
            DXMouseEventArgs ee = DXMouseEventArgs.GetMouseArgs(e);
            BaseTabPageViewInfoDescendant infodes = ViewInfo.SelectedTabPageViewInfo as BaseTabPageViewInfoDescendant;
            infodes.PagePanel.ProcessEvent(new ProcessEventEventArgs(EventType.MouseUp, ee));
            return result;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (ViewInfo != null)
            {
                BaseTabPageViewInfoDescendant infodes = ViewInfo.SelectedTabPageViewInfo as BaseTabPageViewInfoDescendant;
                infodes.PagePanel.ProcessEvent(new ProcessEventEventArgs(EventType.MouseLeave, EventArgs.Empty));
            }
        }
    }
}
