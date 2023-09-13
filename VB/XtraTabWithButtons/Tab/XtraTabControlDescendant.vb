Imports DevExpress.XtraTab

Namespace XtraTabWithButtons

    Public Class XtraTabControlDescendant
        Inherits XtraTabControl

        Protected Overrides Function CreateTabCollection() As XtraTabPageCollection
            Return New XtraTabPageCollectionDescendant(Me)
        End Function
    End Class
End Namespace
