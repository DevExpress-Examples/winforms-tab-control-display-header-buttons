Imports Microsoft.VisualBasic
Imports System
Namespace XtraTabWithButtons
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.xtraTabControlDescendant1 = New XtraTabWithButtons.XtraTabControlDescendant()
			Me.xtraTabPageDescendant1 = New XtraTabWithButtons.XtraTabPageDescendant()
			Me.xtraTabPageDescendant2 = New XtraTabWithButtons.XtraTabPageDescendant()
			Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
			Me.radioGroup2 = New DevExpress.XtraEditors.RadioGroup()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton4 = New DevExpress.XtraEditors.SimpleButton()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.simpleButton5 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton6 = New DevExpress.XtraEditors.SimpleButton()
			Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.xtraTabControlDescendant1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControlDescendant1.SuspendLayout()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioGroup2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControlDescendant1
			' 
			Me.xtraTabControlDescendant1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
			Me.xtraTabControlDescendant1.CustomHeaderButtons.AddRange(New DevExpress.XtraTab.Buttons.CustomHeaderButton() { New DevExpress.XtraTab.Buttons.CustomHeaderButton(), New DevExpress.XtraTab.Buttons.CustomHeaderButton(), New DevExpress.XtraTab.Buttons.CustomHeaderButton()})
			Me.xtraTabControlDescendant1.Location = New System.Drawing.Point(12, 12)
			Me.xtraTabControlDescendant1.Name = "xtraTabControlDescendant1"
			Me.xtraTabControlDescendant1.SelectedTabPage = Me.xtraTabPageDescendant1
			Me.xtraTabControlDescendant1.Size = New System.Drawing.Size(815, 593)
			Me.xtraTabControlDescendant1.TabIndex = 0
			Me.xtraTabControlDescendant1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPageDescendant1, Me.xtraTabPageDescendant2})
'			Me.xtraTabControlDescendant1.CustomHeaderButtonClick += New DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventHandler(Me.xtraTabControlDescendant1_CustomHeaderButtonClick);
			' 
			' xtraTabPageDescendant1
			' 
			Me.xtraTabPageDescendant1.CustomButtons.AddRange(New DevExpress.XtraTab.Buttons.CustomHeaderButton() { New DevExpress.XtraTab.Buttons.CustomHeaderButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "11", -1, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, serializableAppearanceObject1, "", Nothing, Nothing, True), New DevExpress.XtraTab.Buttons.CustomHeaderButton(), New DevExpress.XtraTab.Buttons.CustomHeaderButton(), New DevExpress.XtraTab.Buttons.CustomHeaderButton(), New DevExpress.XtraTab.Buttons.CustomHeaderButton()})
			Me.xtraTabPageDescendant1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xtraTabPageDescendant1.Name = "xtraTabPageDescendant1"
			Me.xtraTabPageDescendant1.Size = New System.Drawing.Size(809, 565)
			Me.xtraTabPageDescendant1.Text = "xtraTabPageDescendant1"
'			Me.xtraTabPageDescendant1.CustomPageButtonClick += New DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventHandler(Me.xtraTabPageDescendant1_CustomPageButtonClick);
			' 
			' xtraTabPageDescendant2
			' 
			Me.xtraTabPageDescendant2.CustomButtons.AddRange(New DevExpress.XtraTab.Buttons.CustomHeaderButton() { New DevExpress.XtraTab.Buttons.CustomHeaderButton(), New DevExpress.XtraTab.Buttons.CustomHeaderButton()})
			Me.xtraTabPageDescendant2.Name = "xtraTabPageDescendant2"
			Me.xtraTabPageDescendant2.Size = New System.Drawing.Size(809, 565)
			Me.xtraTabPageDescendant2.Text = "xtraTabPageDescendant2"
'			Me.xtraTabPageDescendant2.CustomPageButtonClick += New DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventHandler(Me.xtraTabPageDescendant2_CustomPageButtonClick);
			' 
			' radioGroup1
			' 
			Me.radioGroup1.Location = New System.Drawing.Point(850, 35)
			Me.radioGroup1.Name = "radioGroup1"
			Me.radioGroup1.Size = New System.Drawing.Size(83, 113)
			Me.radioGroup1.TabIndex = 1
'			Me.radioGroup1.SelectedIndexChanged += New System.EventHandler(Me.radioGroup1_SelectedIndexChanged);
			' 
			' radioGroup2
			' 
			Me.radioGroup2.Location = New System.Drawing.Point(850, 181)
			Me.radioGroup2.Name = "radioGroup2"
			Me.radioGroup2.Size = New System.Drawing.Size(83, 80)
			Me.radioGroup2.TabIndex = 2
'			Me.radioGroup2.SelectedIndexChanged += New System.EventHandler(Me.radioGroup2_SelectedIndexChanged);
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(850, 322)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 3
			Me.simpleButton1.Text = "Add Button"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(850, 352)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton2.TabIndex = 4
			Me.simpleButton2.Text = "Delete Button"
'			Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click);
			' 
			' simpleButton3
			' 
			Me.simpleButton3.Location = New System.Drawing.Point(850, 411)
			Me.simpleButton3.Name = "simpleButton3"
			Me.simpleButton3.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton3.TabIndex = 5
			Me.simpleButton3.Text = "Add Button"
'			Me.simpleButton3.Click += New System.EventHandler(Me.simpleButton3_Click);
			' 
			' simpleButton4
			' 
			Me.simpleButton4.Location = New System.Drawing.Point(850, 441)
			Me.simpleButton4.Name = "simpleButton4"
			Me.simpleButton4.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton4.TabIndex = 6
			Me.simpleButton4.Text = "Delete Button"
'			Me.simpleButton4.Click += New System.EventHandler(Me.simpleButton4_Click);
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(850, 16)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(75, 13)
			Me.labelControl1.TabIndex = 7
			Me.labelControl1.Text = "HeaderLocation"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(850, 162)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(89, 13)
			Me.labelControl2.TabIndex = 8
			Me.labelControl2.Text = "HeaderOrientation"
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(850, 303)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(30, 13)
			Me.labelControl3.TabIndex = 9
			Me.labelControl3.Text = "Page1"
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(850, 392)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(30, 13)
			Me.labelControl4.TabIndex = 10
			Me.labelControl4.Text = "Page2"
			' 
			' simpleButton5
			' 
			Me.simpleButton5.Location = New System.Drawing.Point(850, 497)
			Me.simpleButton5.Name = "simpleButton5"
			Me.simpleButton5.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton5.TabIndex = 11
			Me.simpleButton5.Text = "Add Button"
'			Me.simpleButton5.Click += New System.EventHandler(Me.simpleButton5_Click);
			' 
			' simpleButton6
			' 
			Me.simpleButton6.Location = New System.Drawing.Point(850, 526)
			Me.simpleButton6.Name = "simpleButton6"
			Me.simpleButton6.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton6.TabIndex = 12
			Me.simpleButton6.Text = "Delete Button"
'			Me.simpleButton6.Click += New System.EventHandler(Me.simpleButton6_Click);
			' 
			' labelControl5
			' 
			Me.labelControl5.Location = New System.Drawing.Point(850, 478)
			Me.labelControl5.Name = "labelControl5"
			Me.labelControl5.Size = New System.Drawing.Size(53, 13)
			Me.labelControl5.TabIndex = 13
			Me.labelControl5.Text = "TabControl"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1080, 617)
			Me.Controls.Add(Me.labelControl5)
			Me.Controls.Add(Me.simpleButton6)
			Me.Controls.Add(Me.simpleButton5)
			Me.Controls.Add(Me.labelControl4)
			Me.Controls.Add(Me.labelControl3)
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.simpleButton4)
			Me.Controls.Add(Me.simpleButton3)
			Me.Controls.Add(Me.simpleButton2)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.radioGroup2)
			Me.Controls.Add(Me.radioGroup1)
			Me.Controls.Add(Me.xtraTabControlDescendant1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.xtraTabControlDescendant1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControlDescendant1.ResumeLayout(False)
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioGroup2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents xtraTabControlDescendant1 As XtraTabControlDescendant
		Private WithEvents xtraTabPageDescendant1 As XtraTabPageDescendant
		Private WithEvents xtraTabPageDescendant2 As XtraTabPageDescendant
		Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup
		Private WithEvents radioGroup2 As DevExpress.XtraEditors.RadioGroup
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton3 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton4 As DevExpress.XtraEditors.SimpleButton
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private WithEvents simpleButton5 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton6 As DevExpress.XtraEditors.SimpleButton
		Private labelControl5 As DevExpress.XtraEditors.LabelControl







	End Class
End Namespace

