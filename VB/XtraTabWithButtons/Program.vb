Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraTab.Registrator

Namespace XtraTabWithButtons

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call PaintStyleCollection.DefaultPaintStyles.Add(New SkinViewInfoRegistratorDescendant())
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New Form1())
        End Sub
    End Module
End Namespace
