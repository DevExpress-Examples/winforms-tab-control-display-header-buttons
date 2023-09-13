Imports DevExpress.XtraTab

Namespace XtraTabWithButtons

    Public Class XtraTabPageCollectionDescendant
        Inherits XtraTabPageCollection

        Public Sub New(ByVal tabControl As XtraTabControl)
            MyBase.New(tabControl)
        End Sub

        Protected Overrides Function CreatePage() As XtraTabPage
            Return New XtraTabPageDescendant()
        End Function
    End Class
End Namespace
