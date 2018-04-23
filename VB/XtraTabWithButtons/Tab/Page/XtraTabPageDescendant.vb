Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.Buttons
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTab.ViewInfo
Imports DevExpress.Utils.Design

Namespace XtraTabWithButtons
	Public Class XtraTabPageDescendant
		Inherits XtraTabPage
		Private customHeaderButtonsCore As CustomHeaderButtonCollection

		Public Event CustomPageButtonClick As CustomHeaderButtonEventHandler

		Public Sub New()
			customHeaderButtonsCore = New CustomHeaderButtonCollection()
			AddHandler CustomButtons.CollectionChanged, AddressOf CustomButtons_CollectionChanged
		End Sub

		Private Sub CustomButtons_CollectionChanged(ByVal sender As Object, ByVal e As CollectionChangeEventArgs)
			If (Not DesignMode) OrElse Site Is Nothing Then
				Return
			End If
			EditorContextHelper.FireChanged(Site, Me)
		End Sub

		<Localizable(True), Category(CategoryName.Behavior), RefreshProperties(RefreshProperties.All), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Overridable ReadOnly Property CustomButtons() As CustomHeaderButtonCollection
			Get
				Return customHeaderButtonsCore
			End Get
		End Property

		Public Sub RaiseCustomPageButtonClick(ByVal button As TabButtonInfo)
			If CustomPageButtonClickEvent IsNot Nothing Then
				Dim args As New CustomHeaderButtonEventArgs(TryCast(button.Button, CustomHeaderButton), Me)
				RaiseEvent CustomPageButtonClick(Me, args)
			End If
		End Sub
	End Class
End Namespace
