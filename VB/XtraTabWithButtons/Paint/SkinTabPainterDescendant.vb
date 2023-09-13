Imports DevExpress.XtraTab.Drawing
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo
Imports System.Drawing

Namespace XtraTabWithButtons

    Public Class SkinTabPainterDescendant
        Inherits SkinTabPainter

        Public Sub New(ByVal tabControl As IXtraTab)
            MyBase.New(tabControl)
        End Sub

        Protected Overrides Sub DrawHeaderPage(ByVal e As TabDrawArgs, ByVal row As BaseTabRowViewInfo, ByVal pInfo As BaseTabPageViewInfo)
            MyBase.DrawHeaderPage(e, row, pInfo)
            Dim pInfodes As BaseTabPageViewInfoDescendant = TryCast(pInfo, BaseTabPageViewInfoDescendant)
            DrawHeaderPageButtons(e, pInfodes)
        End Sub

        Protected Overridable Sub DrawHeaderPageButtons(ByVal e As TabDrawArgs, ByVal pInfo As BaseTabPageViewInfoDescendant)
            pInfo.PagePanel.Draw(e.Cache)
        End Sub
    End Class
End Namespace
