Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraTab.ViewInfo
Imports DevExpress.XtraTab

Namespace XtraTabWithButtons
	Public Class BaseTabPageViewInfoDescendant
		Inherits BaseTabPageViewInfo
		Private _PagePanel As TabButtonsPanelDescendant
		Public Sub New(ByVal page As IXtraTabPage)
			MyBase.New(page)
			_PagePanel = New TabButtonsPanelDescendant(ViewInfo, TryCast(Me.Page, XtraTabPageDescendant))
		End Sub

		Public ReadOnly Property PagePanel() As TabButtonsPanelDescendant
			Get
				Return _PagePanel
			End Get
		End Property
	End Class
End Namespace
