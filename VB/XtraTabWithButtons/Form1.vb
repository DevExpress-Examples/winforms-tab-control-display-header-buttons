Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo
Imports DevExpress.XtraTab.Registrator
Imports DevExpress.XtraTab.Buttons
Imports DevExpress.XtraTab.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace XtraTabWithButtons
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			xtraTabControlDescendant1.PaintStyleName = SkinViewInfoRegistratorDescendant.MyViewName
			xtraTabControlDescendant1.TabPages(0).Image = SystemIcons.Error.ToBitmap()
			CalcRadioGroup(GetType(TabHeaderLocation), radioGroup1)
			CalcRadioGroup(GetType(TabOrientation), radioGroup2)
		End Sub

		Private Sub CalcRadioGroup(ByVal EnumType As Type, ByVal radioGroup As RadioGroup)
			For Each item As Object In System.Enum.GetValues(EnumType)
				Dim radioItem As New RadioGroupItem(item, item.ToString())
				radioGroup.Properties.Items.Add(radioItem)
			Next item
		End Sub

		Private Sub xtraTabPageDescendant1_CustomPageButtonClick(ByVal sender As Object, ByVal e As CustomHeaderButtonEventArgs) Handles xtraTabPageDescendant1.CustomPageButtonClick
			Dim xtraPage As XtraTabPageDescendant = TryCast(sender, XtraTabPageDescendant)
			MessageBox.Show(String.Format("PageName {0}, click on button {1} kind {2}", xtraPage.Name, e.Button.Index, e.Button.Kind))
		End Sub

		Private Sub xtraTabControlDescendant1_CustomHeaderButtonClick(ByVal sender As Object, ByVal e As CustomHeaderButtonEventArgs) Handles xtraTabControlDescendant1.CustomHeaderButtonClick
			Dim xtraTab As XtraTabControlDescendant = TryCast(sender, XtraTabControlDescendant)
			MessageBox.Show(String.Format("TabName {0}, click on button {1} kind {2}", xtraTab.Name, e.Button.Index, e.Button.Kind))
		End Sub

		Private Sub xtraTabPageDescendant2_CustomPageButtonClick(ByVal sender As Object, ByVal e As CustomHeaderButtonEventArgs) Handles xtraTabPageDescendant2.CustomPageButtonClick
			Dim xtraPage As XtraTabPageDescendant = TryCast(sender, XtraTabPageDescendant)
			MessageBox.Show(String.Format("PageName {0}, click on button {1} kind {2}", xtraPage.Name, e.Button.Index, e.Button.Kind))
		End Sub

		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroup1.SelectedIndexChanged
			xtraTabControlDescendant1.HeaderLocation = CType(radioGroup1.EditValue, TabHeaderLocation)
		End Sub

		Private Sub radioGroup2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroup2.SelectedIndexChanged
			xtraTabControlDescendant1.HeaderOrientation = CType(radioGroup2.EditValue, TabOrientation)
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			xtraTabPageDescendant1.CustomButtons.Add(New CustomHeaderButton())
			xtraTabControlDescendant1.SelectedTabPage = xtraTabPageDescendant2
			xtraTabControlDescendant1.SelectedTabPage = xtraTabPageDescendant1
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			If xtraTabPageDescendant1.CustomButtons.Count > 0 Then
				xtraTabPageDescendant1.CustomButtons.RemoveAt(xtraTabPageDescendant1.CustomButtons.Count - 1)
			End If
			xtraTabControlDescendant1.SelectedTabPage = xtraTabPageDescendant2
			xtraTabControlDescendant1.SelectedTabPage = xtraTabPageDescendant1
		End Sub

		Private Sub simpleButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton3.Click
			xtraTabPageDescendant2.CustomButtons.Add(New CustomHeaderButton())
			xtraTabControlDescendant1.SelectedTabPage = xtraTabPageDescendant1
			xtraTabControlDescendant1.SelectedTabPage = xtraTabPageDescendant2
		End Sub

		Private Sub simpleButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton4.Click
			If xtraTabPageDescendant2.CustomButtons.Count > 0 Then
				xtraTabPageDescendant2.CustomButtons.RemoveAt(xtraTabPageDescendant2.CustomButtons.Count - 1)
			End If
			xtraTabControlDescendant1.SelectedTabPage = xtraTabPageDescendant1
			xtraTabControlDescendant1.SelectedTabPage = xtraTabPageDescendant2
		End Sub

		Private Sub simpleButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton5.Click
			xtraTabControlDescendant1.CustomHeaderButtons.Add(New CustomHeaderButton())
		End Sub

		Private Sub simpleButton6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton6.Click
			If xtraTabControlDescendant1.CustomHeaderButtons.Count > 0 Then
				xtraTabControlDescendant1.CustomHeaderButtons.RemoveAt(xtraTabControlDescendant1.CustomHeaderButtons.Count - 1)
			End If
		End Sub
	End Class
End Namespace