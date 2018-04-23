Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraTab.ViewInfo
Imports DevExpress.XtraTab.Buttons
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraTab
Imports DevExpress.Utils

Namespace XtraTabWithButtons
	Public Class SkinTabHeaderViewInfoDescendant
		Inherits SkinTabHeaderViewInfo
		Public Sub New(ByVal viewInfo As BaseTabControlViewInfo)
			MyBase.New(viewInfo)
		End Sub

		Protected Overrides Function CreatePage(ByVal page As IXtraTabPage) As BaseTabPageViewInfo
			Return New BaseTabPageViewInfoDescendant(page)
		End Function

		Protected Overrides Sub CalcHPageViewInfo(ByVal info As BaseTabPageViewInfo)
			MyBase.CalcHPageViewInfo(info)
			Dim infodes As BaseTabPageViewInfoDescendant = TryCast(info, BaseTabPageViewInfoDescendant)
			Dim TextRect As Rectangle = infodes.Text
			TextRect.Width -= infodes.PagePanel.Bounds.Width
			infodes.Text = TextRect
		End Sub

		Protected Overrides Sub CalcVPageViewInfo(ByVal info As BaseTabPageViewInfo)
			MyBase.CalcVPageViewInfo(info)
			Dim infodes As BaseTabPageViewInfoDescendant = TryCast(info, BaseTabPageViewInfoDescendant)
			Dim TextRect As Rectangle = infodes.Text
			If (HeaderLocation = TabHeaderLocation.Top AndAlso RealPageOrientation = TabOrientation.Vertical) OrElse (HeaderLocation = TabHeaderLocation.Left AndAlso (RealPageOrientation = TabOrientation.Default OrElse RealPageOrientation = TabOrientation.Vertical)) Then
					TextRect.Height -= infodes.PagePanel.Bounds.Height
					TextRect.Y += infodes.PagePanel.Bounds.Height
			End If
			If (HeaderLocation = TabHeaderLocation.Bottom AndAlso RealPageOrientation = TabOrientation.Vertical) OrElse (HeaderLocation = TabHeaderLocation.Right AndAlso (RealPageOrientation = TabOrientation.Default OrElse RealPageOrientation = TabOrientation.Vertical)) Then
					TextRect.Height -= infodes.PagePanel.Bounds.Height
			End If
			infodes.Text = TextRect
		End Sub

		Private Function CalcSize(ByVal info As BaseTabPageViewInfo, ByVal PageSize As Size) As Size
			Dim infodes As BaseTabPageViewInfoDescendant = TryCast(info, BaseTabPageViewInfoDescendant)
			Dim ButtonsPanel As TabButtonsPanelDescendant = infodes.PagePanel
			Dim g As Graphics = GraphicsInfo.Graphics
			ButtonsPanel.CreateButtons(TabButtons.None)
			Dim ButtonsSize As Size = ButtonsPanel.CalcSize(g)
			Dim pageBounds As Rectangle = infodes.Bounds
			Dim rect As Rectangle = Rectangle.Empty
			If (Not ButtonsSize.IsEmpty) Then
				rect = New Rectangle(pageBounds.X + pageBounds.Width - ButtonsSize.Width, pageBounds.Y + pageBounds.Height - ButtonsSize.Height, ButtonsSize.Width, ButtonsSize.Height)
			End If
			If (HeaderLocation = TabHeaderLocation.Top OrElse HeaderLocation = TabHeaderLocation.Bottom) AndAlso (RealPageOrientation = TabOrientation.Horizontal OrElse RealPageOrientation = TabOrientation.Default) Then
				PageSize.Width += ButtonsSize.Width
			End If
			If (HeaderLocation = TabHeaderLocation.Top OrElse HeaderLocation = TabHeaderLocation.Bottom) AndAlso RealPageOrientation = TabOrientation.Vertical Then
				PageSize.Width = Math.Max(ButtonsSize.Width, PageSize.Width)
				PageSize.Height += ButtonsSize.Height
			End If
			If (HeaderLocation = TabHeaderLocation.Right OrElse HeaderLocation = TabHeaderLocation.Left) AndAlso RealPageOrientation = TabOrientation.Horizontal Then
				PageSize.Width += ButtonsSize.Width
				PageSize.Height = Math.Max(ButtonsSize.Height, PageSize.Height)
			End If
			If (HeaderLocation = TabHeaderLocation.Right OrElse HeaderLocation = TabHeaderLocation.Left) AndAlso (RealPageOrientation = TabOrientation.Default OrElse RealPageOrientation = TabOrientation.Vertical) Then
				PageSize.Height += ButtonsSize.Height
				PageSize.Width = Math.Max(ButtonsSize.Width, PageSize.Width)
			End If
			ButtonsPanel.Bounds = rect
			Return PageSize
		End Function

		Protected Overrides Function CalcHPageSize(ByVal info As BaseTabPageViewInfo) As Size
			Dim hPageSize As Size = MyBase.CalcHPageSize(info)
			hPageSize = CalcSize(info, hPageSize)
			Return hPageSize
		End Function

		Protected Overrides Function CalcVPageSize(ByVal info As BaseTabPageViewInfo) As Size
			Dim vPageSize As Size = MyBase.CalcVPageSize(info)
			vPageSize = CalcSize(info, vPageSize)
			Return vPageSize
		End Function

		Protected Overrides Function CalcPageFocusBounds(ByVal info As BaseTabPageViewInfo, ByVal contentBounds As Rectangle) As Rectangle
			Dim FocusRect As Rectangle = MyBase.CalcPageFocusBounds(info, contentBounds)
			Dim infodes As BaseTabPageViewInfoDescendant = TryCast(info, BaseTabPageViewInfoDescendant)
			Dim ButtonsPanel As TabButtonsPanelDescendant = infodes.PagePanel
			Dim PanelBounds As Rectangle = ButtonsPanel.Bounds
			Dim X As Integer = 0, Y As Integer = 0
			If (HeaderLocation = TabHeaderLocation.Top OrElse HeaderLocation = TabHeaderLocation.Bottom) AndAlso (RealPageOrientation = TabOrientation.Horizontal OrElse RealPageOrientation = TabOrientation.Default) Then
				FocusRect.Width += CalcPageIndent(info, IndentType.Top)
				FocusRect.Width -= PanelBounds.Width
				X = FocusRect.Right
				Y = (infodes.Bounds.Height - PanelBounds.Height) / 2 + infodes.Bounds.Y
			End If
			If HeaderLocation = TabHeaderLocation.Top AndAlso RealPageOrientation = TabOrientation.Vertical Then
				FocusRect.Height += CalcPageIndent(info, IndentType.Top)
				FocusRect.Height -= ButtonsPanel.Bounds.Height
				FocusRect.Y += ButtonsPanel.Bounds.Height - CalcPageIndent(info, IndentType.Top)
				X = (infodes.Bounds.Width - PanelBounds.Width) / 2 + infodes.Bounds.X
				Y = FocusRect.Top - PanelBounds.Height
			End If
			If HeaderLocation = TabHeaderLocation.Bottom AndAlso RealPageOrientation = TabOrientation.Vertical Then
				FocusRect.Height += CalcPageIndent(info, IndentType.Top)
				FocusRect.Y -= ButtonsPanel.Bounds.Height
				X = (infodes.Bounds.Width - PanelBounds.Width) / 2 + infodes.Bounds.X
				Y = FocusRect.Bottom
			End If
			If HeaderLocation = TabHeaderLocation.Right AndAlso RealPageOrientation = TabOrientation.Horizontal Then
				FocusRect.Width += CalcPageIndent(info, IndentType.Top)
				FocusRect.Width -= ButtonsPanel.Bounds.Width
				X = FocusRect.Right
				Y = (infodes.Bounds.Height - PanelBounds.Height) / 2 + infodes.Bounds.Y
			End If
			If HeaderLocation = TabHeaderLocation.Left AndAlso RealPageOrientation = TabOrientation.Horizontal Then
				FocusRect.Width -= CalcPageIndent(info, IndentType.Top)
				FocusRect.Width -= ButtonsPanel.Bounds.Width
				X = FocusRect.Right
				Y = (infodes.Bounds.Height - PanelBounds.Height) / 2 + infodes.Bounds.Y
			End If
			If HeaderLocation = TabHeaderLocation.Right AndAlso (RealPageOrientation = TabOrientation.Default OrElse RealPageOrientation = TabOrientation.Vertical) Then
				FocusRect.Height += CalcPageIndent(info, IndentType.Right)
				FocusRect.Height -= ButtonsPanel.Bounds.Height
				X = (infodes.Bounds.Width - PanelBounds.Width) / 2 + infodes.Bounds.X
				Y = FocusRect.Bottom
			End If
			If HeaderLocation = TabHeaderLocation.Left AndAlso (RealPageOrientation = TabOrientation.Default OrElse RealPageOrientation = TabOrientation.Vertical) Then
				FocusRect.Height += CalcPageIndent(info, IndentType.Right)
				FocusRect.Height -= ButtonsPanel.Bounds.Height
				FocusRect.Y += ButtonsPanel.Bounds.Height
				X = (infodes.Bounds.Width - PanelBounds.Width) / 2 + infodes.Bounds.X
				Y = FocusRect.Top - ButtonsPanel.Bounds.Height
			End If
			PanelBounds = New Rectangle(X, Y, PanelBounds.Width, PanelBounds.Height)
			ButtonsPanel.Bounds = PanelBounds
			Return FocusRect
		End Function

		Protected Overrides Sub UpdatePageBounds(ByVal info As BaseTabPageViewInfo)
			MyBase.UpdatePageBounds(info)
			Dim infodes As BaseTabPageViewInfoDescendant = TryCast(info, BaseTabPageViewInfoDescendant)
			Dim hIndent As Integer = 0
			Dim Page As XtraTabPage = TryCast(info.Page, XtraTabPage)
			If Page.TabControl.SelectedTabPage Is Page Then
				hIndent += 1
			Else
				hIndent = 0
			End If
			If HeaderLocation = TabHeaderLocation.Top AndAlso (RealPageOrientation = TabOrientation.Horizontal OrElse RealPageOrientation = TabOrientation.Default) Then
				infodes.PagePanel.Bounds = New Rectangle(New Point(infodes.PagePanel.Bounds.X, infodes.PagePanel.Bounds.Y - hIndent + 1), infodes.PagePanel.Bounds.Size)
			End If
			If HeaderLocation = TabHeaderLocation.Bottom AndAlso (RealPageOrientation = TabOrientation.Horizontal OrElse RealPageOrientation = TabOrientation.Default) Then
				infodes.PagePanel.Bounds = New Rectangle(New Point(infodes.PagePanel.Bounds.X, infodes.PagePanel.Bounds.Y + hIndent - 2), infodes.PagePanel.Bounds.Size)
			End If
			If HeaderLocation = TabHeaderLocation.Right AndAlso RealPageOrientation = TabOrientation.Horizontal Then
				infodes.PagePanel.Bounds = New Rectangle(New Point(infodes.PagePanel.Bounds.X + hIndent, infodes.PagePanel.Bounds.Y), infodes.PagePanel.Bounds.Size)
			End If
			If HeaderLocation = TabHeaderLocation.Left AndAlso RealPageOrientation = TabOrientation.Horizontal Then
				infodes.PagePanel.Bounds = New Rectangle(New Point(infodes.PagePanel.Bounds.X - hIndent, infodes.PagePanel.Bounds.Y), infodes.PagePanel.Bounds.Size)
			End If
			If HeaderLocation = TabHeaderLocation.Right AndAlso (RealPageOrientation = TabOrientation.Default OrElse RealPageOrientation = TabOrientation.Vertical) Then
				infodes.PagePanel.Bounds = New Rectangle(New Point(infodes.PagePanel.Bounds.X + hIndent, infodes.PagePanel.Bounds.Y), infodes.PagePanel.Bounds.Size)
			End If
			If HeaderLocation = TabHeaderLocation.Left AndAlso (RealPageOrientation = TabOrientation.Default OrElse RealPageOrientation = TabOrientation.Vertical) Then
				infodes.PagePanel.Bounds = New Rectangle(New Point(infodes.PagePanel.Bounds.X - hIndent, infodes.PagePanel.Bounds.Y), infodes.PagePanel.Bounds.Size)
			End If
			If HeaderLocation = TabHeaderLocation.Top AndAlso RealPageOrientation = TabOrientation.Vertical Then
				infodes.PagePanel.Bounds = New Rectangle(New Point(infodes.PagePanel.Bounds.X, infodes.PagePanel.Bounds.Y - hIndent), infodes.PagePanel.Bounds.Size)
			End If
			If HeaderLocation = TabHeaderLocation.Bottom AndAlso RealPageOrientation = TabOrientation.Vertical Then
				infodes.PagePanel.Bounds = New Rectangle(New Point(infodes.PagePanel.Bounds.X, infodes.PagePanel.Bounds.Y + hIndent), infodes.PagePanel.Bounds.Size)
			End If
			Dim g As Graphics = GraphicsInfo.Graphics
			infodes.PagePanel.CalcViewInfo(g)
		End Sub

		Protected Overrides Function GetToolTipInfo(ByVal point As Point) As ToolTipControlInfo
			Dim hit As BaseTabHitInfo = ViewInfo.CalcHitInfo(point)
			If hit.Page IsNot Nothing AndAlso (Not hit.InPageCloseButton) Then
				For Each item As BaseTabPageViewInfoDescendant In AllPages
					If item.Page Is hit.Page Then
						Dim PageDes As BaseTabPageViewInfoDescendant = TryCast(item, BaseTabPageViewInfoDescendant)
						Return PageDes.PagePanel.GetToolTip(point)
					End If
				Next item
			End If
			Return MyBase.GetToolTipInfo(point)
		End Function
	End Class
End Namespace