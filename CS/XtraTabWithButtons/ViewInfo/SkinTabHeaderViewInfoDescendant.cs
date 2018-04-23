using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTab.Buttons;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTab;
using DevExpress.Utils;

namespace XtraTabWithButtons {
    public class SkinTabHeaderViewInfoDescendant : SkinTabHeaderViewInfo {
        public SkinTabHeaderViewInfoDescendant(BaseTabControlViewInfo viewInfo)
            : base(viewInfo) { }

        protected override BaseTabPageViewInfo CreatePage(IXtraTabPage page) {
            return new BaseTabPageViewInfoDescendant(page);
        }

        protected override void CalcHPageViewInfo(BaseTabPageViewInfo info) {
            base.CalcHPageViewInfo(info);
            BaseTabPageViewInfoDescendant infodes = info as BaseTabPageViewInfoDescendant;
            Rectangle TextRect = infodes.Text;
            TextRect.Width -= infodes.PagePanel.Bounds.Width;
            infodes.Text = TextRect;
        }

        protected override void CalcVPageViewInfo(BaseTabPageViewInfo info) {
            base.CalcVPageViewInfo(info);
            BaseTabPageViewInfoDescendant infodes = info as BaseTabPageViewInfoDescendant;
            Rectangle TextRect = infodes.Text;
            if ((HeaderLocation == TabHeaderLocation.Top &&
                                RealPageOrientation == TabOrientation.Vertical) || (HeaderLocation == TabHeaderLocation.Left &&
                (RealPageOrientation == TabOrientation.Default || RealPageOrientation == TabOrientation.Vertical))) {
                    TextRect.Height -= infodes.PagePanel.Bounds.Height;
                    TextRect.Y += infodes.PagePanel.Bounds.Height;
            }
            if ((HeaderLocation == TabHeaderLocation.Bottom &&
                               RealPageOrientation == TabOrientation.Vertical) || (HeaderLocation == TabHeaderLocation.Right &&
                (RealPageOrientation == TabOrientation.Default || RealPageOrientation == TabOrientation.Vertical))) {
                    TextRect.Height -= infodes.PagePanel.Bounds.Height;
            }
            infodes.Text = TextRect;
        }

        private Size CalcSize(BaseTabPageViewInfo info, Size PageSize) {
            BaseTabPageViewInfoDescendant infodes = info as BaseTabPageViewInfoDescendant;
            TabButtonsPanelDescendant ButtonsPanel = infodes.PagePanel;
            Graphics g = GraphicsInfo.Graphics;
            ButtonsPanel.CreateButtons(TabButtons.None);
            Size ButtonsSize = ButtonsPanel.CalcSize(g);
            Rectangle pageBounds = infodes.Bounds;
            Rectangle rect = Rectangle.Empty;
            if (!ButtonsSize.IsEmpty)
                rect = new Rectangle(pageBounds.X + pageBounds.Width - ButtonsSize.Width, pageBounds.Y + pageBounds.Height - ButtonsSize.Height,
                    ButtonsSize.Width, ButtonsSize.Height);
            if ((HeaderLocation == TabHeaderLocation.Top || HeaderLocation == TabHeaderLocation.Bottom) &&
                (RealPageOrientation == TabOrientation.Horizontal || RealPageOrientation == TabOrientation.Default)) {
                PageSize.Width += ButtonsSize.Width;
            }
            if ((HeaderLocation == TabHeaderLocation.Top || HeaderLocation == TabHeaderLocation.Bottom) &&
                RealPageOrientation == TabOrientation.Vertical) {
                PageSize.Width = Math.Max(ButtonsSize.Width, PageSize.Width);
                PageSize.Height += ButtonsSize.Height;
            }
            if ((HeaderLocation == TabHeaderLocation.Right || HeaderLocation == TabHeaderLocation.Left) &&
                RealPageOrientation == TabOrientation.Horizontal) {
                PageSize.Width += ButtonsSize.Width;
                PageSize.Height = Math.Max(ButtonsSize.Height, PageSize.Height);
            }
            if ((HeaderLocation == TabHeaderLocation.Right || HeaderLocation == TabHeaderLocation.Left) &&
               (RealPageOrientation == TabOrientation.Default || RealPageOrientation == TabOrientation.Vertical)) {
                PageSize.Height += ButtonsSize.Height;
                PageSize.Width = Math.Max(ButtonsSize.Width, PageSize.Width);
            }
            ButtonsPanel.Bounds = rect;
            return PageSize;
        }

        protected override Size CalcHPageSize(BaseTabPageViewInfo info) {
            Size hPageSize = base.CalcHPageSize(info);
            hPageSize = CalcSize(info, hPageSize);
            return hPageSize;
        }

        protected override Size CalcVPageSize(BaseTabPageViewInfo info) {
            Size vPageSize = base.CalcVPageSize(info);
            vPageSize = CalcSize(info, vPageSize);
            return vPageSize;
        }

        protected override Rectangle CalcPageFocusBounds(BaseTabPageViewInfo info, Rectangle contentBounds) {
            Rectangle FocusRect = base.CalcPageFocusBounds(info, contentBounds);
            BaseTabPageViewInfoDescendant infodes = info as BaseTabPageViewInfoDescendant;
            TabButtonsPanelDescendant ButtonsPanel = infodes.PagePanel;
            Rectangle PanelBounds = ButtonsPanel.Bounds;
            int X = 0, Y = 0;
            if ((HeaderLocation == TabHeaderLocation.Top || HeaderLocation == TabHeaderLocation.Bottom) &&
                (RealPageOrientation == TabOrientation.Horizontal || RealPageOrientation == TabOrientation.Default)) {
                FocusRect.Width += CalcPageIndent(info, IndentType.Top);
                FocusRect.Width -= PanelBounds.Width;
                X = FocusRect.Right;
                Y = (infodes.Bounds.Height - PanelBounds.Height) / 2 + infodes.Bounds.Y;
            }
            if (HeaderLocation == TabHeaderLocation.Top &&
                RealPageOrientation == TabOrientation.Vertical) {
                FocusRect.Height += CalcPageIndent(info, IndentType.Top);
                FocusRect.Height -= ButtonsPanel.Bounds.Height;
                FocusRect.Y += ButtonsPanel.Bounds.Height - CalcPageIndent(info, IndentType.Top);
                X = (infodes.Bounds.Width - PanelBounds.Width) / 2 + infodes.Bounds.X;
                Y = FocusRect.Top - PanelBounds.Height;
            }
            if (HeaderLocation == TabHeaderLocation.Bottom &&
                RealPageOrientation == TabOrientation.Vertical) {
                FocusRect.Height += CalcPageIndent(info, IndentType.Top);
                FocusRect.Y -= ButtonsPanel.Bounds.Height;
                X = (infodes.Bounds.Width - PanelBounds.Width) / 2 + infodes.Bounds.X;
                Y = FocusRect.Bottom;
            }
            if (HeaderLocation == TabHeaderLocation.Right &&
                RealPageOrientation == TabOrientation.Horizontal) {
                FocusRect.Width += CalcPageIndent(info, IndentType.Top);
                FocusRect.Width -= ButtonsPanel.Bounds.Width;
                X = FocusRect.Right;
                Y = (infodes.Bounds.Height - PanelBounds.Height) / 2 + infodes.Bounds.Y;
            }
            if (HeaderLocation == TabHeaderLocation.Left &&
                RealPageOrientation == TabOrientation.Horizontal) {
                FocusRect.Width -= CalcPageIndent(info, IndentType.Top);
                FocusRect.Width -= ButtonsPanel.Bounds.Width;
                X = FocusRect.Right;
                Y = (infodes.Bounds.Height - PanelBounds.Height) / 2 + infodes.Bounds.Y;
            }
            if (HeaderLocation == TabHeaderLocation.Right &&
                (RealPageOrientation == TabOrientation.Default || RealPageOrientation == TabOrientation.Vertical)) {
                FocusRect.Height += CalcPageIndent(info, IndentType.Right);
                FocusRect.Height -= ButtonsPanel.Bounds.Height;
                X = (infodes.Bounds.Width - PanelBounds.Width) / 2 + infodes.Bounds.X;
                Y = FocusRect.Bottom;
            }
            if (HeaderLocation == TabHeaderLocation.Left &&
                (RealPageOrientation == TabOrientation.Default || RealPageOrientation == TabOrientation.Vertical)) {
                FocusRect.Height += CalcPageIndent(info, IndentType.Right);
                FocusRect.Height -= ButtonsPanel.Bounds.Height;
                FocusRect.Y += ButtonsPanel.Bounds.Height;
                X = (infodes.Bounds.Width - PanelBounds.Width) / 2 + infodes.Bounds.X;
                Y = FocusRect.Top - ButtonsPanel.Bounds.Height;
            }
            PanelBounds = new Rectangle(X, Y, PanelBounds.Width, PanelBounds.Height);
            ButtonsPanel.Bounds = PanelBounds;
            return FocusRect;
        }

        protected override void UpdatePageBounds(BaseTabPageViewInfo info) {
            base.UpdatePageBounds(info);
            BaseTabPageViewInfoDescendant infodes = info as BaseTabPageViewInfoDescendant;
            int hIndent = 0;
            XtraTabPage Page = info.Page as XtraTabPage;
            if (Page.TabControl.SelectedTabPage == Page)
                hIndent++;
            else
                hIndent = 0;
            if (HeaderLocation == TabHeaderLocation.Top &&
                (RealPageOrientation == TabOrientation.Horizontal || RealPageOrientation == TabOrientation.Default)) {
                infodes.PagePanel.Bounds = new Rectangle(new Point(infodes.PagePanel.Bounds.X, infodes.PagePanel.Bounds.Y - hIndent + 1),
                infodes.PagePanel.Bounds.Size);
            }
            if (HeaderLocation == TabHeaderLocation.Bottom &&
                (RealPageOrientation == TabOrientation.Horizontal || RealPageOrientation == TabOrientation.Default)) {
                infodes.PagePanel.Bounds = new Rectangle(new Point(infodes.PagePanel.Bounds.X, infodes.PagePanel.Bounds.Y + hIndent - 2),
                infodes.PagePanel.Bounds.Size);
            }
            if (HeaderLocation == TabHeaderLocation.Right &&
                RealPageOrientation == TabOrientation.Horizontal)
                infodes.PagePanel.Bounds = new Rectangle(new Point(infodes.PagePanel.Bounds.X + hIndent, infodes.PagePanel.Bounds.Y),
                infodes.PagePanel.Bounds.Size);
            if (HeaderLocation == TabHeaderLocation.Left &&
                RealPageOrientation == TabOrientation.Horizontal)
                infodes.PagePanel.Bounds = new Rectangle(new Point(infodes.PagePanel.Bounds.X - hIndent, infodes.PagePanel.Bounds.Y),
                infodes.PagePanel.Bounds.Size);
            if (HeaderLocation == TabHeaderLocation.Right &&
                (RealPageOrientation == TabOrientation.Default || RealPageOrientation == TabOrientation.Vertical))
                infodes.PagePanel.Bounds = new Rectangle(new Point(infodes.PagePanel.Bounds.X + hIndent, infodes.PagePanel.Bounds.Y),
                    infodes.PagePanel.Bounds.Size);
            if (HeaderLocation == TabHeaderLocation.Left &&
                (RealPageOrientation == TabOrientation.Default || RealPageOrientation == TabOrientation.Vertical))
                infodes.PagePanel.Bounds = new Rectangle(new Point(infodes.PagePanel.Bounds.X - hIndent, infodes.PagePanel.Bounds.Y),
                    infodes.PagePanel.Bounds.Size);
            if (HeaderLocation == TabHeaderLocation.Top &&
                RealPageOrientation == TabOrientation.Vertical)
                infodes.PagePanel.Bounds = new Rectangle(new Point(infodes.PagePanel.Bounds.X, infodes.PagePanel.Bounds.Y - hIndent),
                infodes.PagePanel.Bounds.Size);
            if (HeaderLocation == TabHeaderLocation.Bottom &&
                RealPageOrientation == TabOrientation.Vertical)
                infodes.PagePanel.Bounds = new Rectangle(new Point(infodes.PagePanel.Bounds.X, infodes.PagePanel.Bounds.Y + hIndent),
                infodes.PagePanel.Bounds.Size);
            Graphics g = GraphicsInfo.Graphics;
            infodes.PagePanel.CalcViewInfo(g);
        }

        protected override ToolTipControlInfo GetToolTipInfo(Point point) {
            BaseTabHitInfo hit = ViewInfo.CalcHitInfo(point);
            if (hit.Page != null && !hit.InPageControlBox)
                foreach (BaseTabPageViewInfoDescendant item in AllPages)
                    if (item.Page == hit.Page) {
                        BaseTabPageViewInfoDescendant PageDes = item as BaseTabPageViewInfoDescendant;
                        return PageDes.PagePanel.GetToolTip(point);
                    }
            return base.GetToolTipInfo(point);
        }
    }
}