Imports System
Imports DevExpress.XtraTab.ViewInfo
Imports DevExpress.XtraTab
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Utils.Controls

Namespace XtraTabWithButtons

    Public Class BaseTabHandlerDescendant
        Inherits BaseTabHandler

        Public Sub New(ByVal tabControl As IXtraTab)
            MyBase.New(tabControl)
        End Sub

        Protected Overrides Function OnMouseMove(ByVal e As MouseEventArgs) As Boolean
            Dim result As Boolean = MyBase.OnMouseMove(e)
            Dim ee As DXMouseEventArgs = DXMouseEventArgs.GetMouseArgs(e)
            If ViewInfo IsNot Nothing Then
                Dim infodes As BaseTabPageViewInfoDescendant = TryCast(ViewInfo.SelectedTabPageViewInfo, BaseTabPageViewInfoDescendant)
                infodes.PagePanel.ProcessEvent(New ProcessEventEventArgs(EventType.MouseMove, ee))
            End If

            Return result
        End Function

        Protected Overrides Function OnMouseDown(ByVal e As MouseEventArgs) As Boolean
            Dim result As Boolean = MyBase.OnMouseDown(e)
            Dim ee As DXMouseEventArgs = DXMouseEventArgs.GetMouseArgs(e)
            Dim infodes As BaseTabPageViewInfoDescendant = TryCast(ViewInfo.SelectedTabPageViewInfo, BaseTabPageViewInfoDescendant)
            If infodes.PagePanel.Bounds.Contains(e.Location) Then infodes.PagePanel.ProcessEvent(New ProcessEventEventArgs(EventType.MouseDown, ee))
            Return result
        End Function

        Protected Overrides Function OnMouseUp(ByVal e As MouseEventArgs) As Boolean
            Dim result As Boolean = MyBase.OnMouseUp(e)
            Dim ee As DXMouseEventArgs = DXMouseEventArgs.GetMouseArgs(e)
            Dim infodes As BaseTabPageViewInfoDescendant = TryCast(ViewInfo.SelectedTabPageViewInfo, BaseTabPageViewInfoDescendant)
            infodes.PagePanel.ProcessEvent(New ProcessEventEventArgs(EventType.MouseUp, ee))
            Return result
        End Function

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            MyBase.OnMouseLeave(e)
            If ViewInfo IsNot Nothing Then
                Dim infodes As BaseTabPageViewInfoDescendant = TryCast(ViewInfo.SelectedTabPageViewInfo, BaseTabPageViewInfoDescendant)
                infodes.PagePanel.ProcessEvent(New ProcessEventEventArgs(EventType.MouseLeave, EventArgs.Empty))
            End If
        End Sub
    End Class
End Namespace
