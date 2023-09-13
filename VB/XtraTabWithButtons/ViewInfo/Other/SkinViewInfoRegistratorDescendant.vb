Imports DevExpress.XtraTab.Registrator
Imports DevExpress.XtraTab.ViewInfo
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.Drawing

Namespace XtraTabWithButtons

    Public Class SkinViewInfoRegistratorDescendant
        Inherits SkinViewInfoRegistrator

        Public Const MyViewName As String = "MySkin"

        Public Overrides ReadOnly Property ViewName As String
            Get
                Return MyViewName
            End Get
        End Property

        Public Overrides Function CreateHandler(ByVal tabControl As IXtraTab) As BaseTabHandler
            Return New BaseTabHandlerDescendant(tabControl)
        End Function

        Public Overrides Function CreateHeaderViewInfo(ByVal viewInfo As BaseTabControlViewInfo) As BaseTabHeaderViewInfo
            Return New SkinTabHeaderViewInfoDescendant(viewInfo)
        End Function

        Public Overrides Function CreatePainter(ByVal tabControl As IXtraTab) As BaseTabPainter
            Return New SkinTabPainterDescendant(tabControl)
        End Function
    End Class
End Namespace
