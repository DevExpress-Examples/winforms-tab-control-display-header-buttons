Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraTab.Buttons
Imports DevExpress.XtraTab.ViewInfo
Imports DevExpress.XtraTab
Imports DevExpress.Utils
Imports System.Drawing

Namespace XtraTabWithButtons
	Public Class TabButtonsPanelDescendant
		Inherits TabButtonsPanel
		Private _PageDescendant As XtraTabPageDescendant

		Public Sub New(ByVal tabViewInfo As BaseTabControlViewInfo, ByVal pagedes As XtraTabPageDescendant)
			MyBase.New(tabViewInfo)
			_PageDescendant = pagedes
		End Sub

		Public ReadOnly Property PageDescendant() As XtraTabPageDescendant
			Get
				Return _PageDescendant
			End Get
		End Property

		Protected Overrides Sub CreateButtonsCore(ByVal buttons As TabButtons, ByVal userButtons As CustomHeaderButtonCollection)
			MyBase.CreateButtonsCore(buttons, PageDescendant.CustomButtons)
		End Sub

		Protected Overrides Sub OnClickButton(ByVal button As TabButtonInfo)
			keepButtons += 1
			Try
				If CanRaiseHeaderButtonClick(button) Then
					PageDescendant.RaiseCustomPageButtonClick(button)
				End If
			Finally
				keepButtons -= 1
			End Try
			If (Not TabViewInfo.IsDisposing) Then
				TabViewInfo.LayoutChanged()
			End If
		End Sub

		Public Function GetToolTip(ByVal point As Point) As ToolTipControlInfo
			Return GetToolTipInfo(point)
		End Function
	End Class
End Namespace
