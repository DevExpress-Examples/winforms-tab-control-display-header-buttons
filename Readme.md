<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128618824/12.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4255)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Tab Control - Display custom buttons in tab headers

This example creates a custom tab control that can display buttons in tab headers.

![WinForms Tab Control - Display custom buttons in tab headers](https://raw.githubusercontent.com/DevExpress-Examples/how-to-add-custom-buttons-to-tab-page-headers-e4255/12.2.4%2B/media/winforms-custom-tab-control.png)

Use the `XtraTabPageDescendant.CustomButtons` property to access tab header buttons:

```csharp
xtraTabPageDescendant1.CustomButtons.Add(new CustomHeaderButton() { Kind = ButtonPredefines.Plus });
```

The `XtraTabPageDescendant.CustomPageButtonClick` event allows you to handle button clicks:

```csharp
private void xtraTabControlDescendant1_CustomHeaderButtonClick(object sender, CustomHeaderButtonEventArgs e) {
    XtraTabControlDescendant xtraTab = sender as XtraTabControlDescendant;
    MessageBox.Show(string.Format("TabName {0}, click on button {1} kind {2}", xtraTab.Name, e.Button.Index, e.Button.Kind));
}
```


## Files to Review

* [BaseTabHandlerDescendant.cs](./CS/XtraTabWithButtons/BaseTabHandlerDescendant.cs) (VB: [BaseTabHandlerDescendant.vb](./VB/XtraTabWithButtons/BaseTabHandlerDescendant.vb))
* [Form1.cs](./CS/XtraTabWithButtons/Form1.cs) (VB: [Form1.vb](./VB/XtraTabWithButtons/Form1.vb))
* [SkinTabPainterDescendant.cs](./CS/XtraTabWithButtons/Paint/SkinTabPainterDescendant.cs) (VB: [SkinTabPainterDescendant.vb](./VB/XtraTabWithButtons/Paint/SkinTabPainterDescendant.vb))
* [XtraTabPageCollectionDescendant.cs](./CS/XtraTabWithButtons/Tab/Page/XtraTabPageCollectionDescendant.cs) (VB: [XtraTabPageCollectionDescendant.vb](./VB/XtraTabWithButtons/Tab/Page/XtraTabPageCollectionDescendant.vb))
* [XtraTabPageDescendant.cs](./CS/XtraTabWithButtons/Tab/Page/XtraTabPageDescendant.cs) (VB: [XtraTabPageDescendant.vb](./VB/XtraTabWithButtons/Tab/Page/XtraTabPageDescendant.vb))
* [XtraTabControlDescendant.cs](./CS/XtraTabWithButtons/Tab/XtraTabControlDescendant.cs) (VB: [XtraTabControlDescendant.vb](./VB/XtraTabWithButtons/Tab/XtraTabControlDescendant.vb))
* [BaseTabPageViewInfoDescendant.cs](./CS/XtraTabWithButtons/ViewInfo/BaseTabPageViewInfoDescendant.cs) (VB: [BaseTabPageViewInfoDescendant.vb](./VB/XtraTabWithButtons/ViewInfo/BaseTabPageViewInfoDescendant.vb))
* [SkinViewInfoRegistratorDescendant.cs](./CS/XtraTabWithButtons/ViewInfo/Other/SkinViewInfoRegistratorDescendant.cs) (VB: [SkinViewInfoRegistratorDescendant.vb](./VB/XtraTabWithButtons/ViewInfo/Other/SkinViewInfoRegistratorDescendant.vb))
* [SkinTabHeaderViewInfoDescendant.cs](./CS/XtraTabWithButtons/ViewInfo/SkinTabHeaderViewInfoDescendant.cs) (VB: [SkinTabHeaderViewInfoDescendant.vb](./VB/XtraTabWithButtons/ViewInfo/SkinTabHeaderViewInfoDescendant.vb))
* [TabButtonsPanelDescendant.cs](./CS/XtraTabWithButtons/ViewInfo/TabButtonsPanelDescendant.cs) (VB: [TabButtonsPanelDescendant.vb](./VB/XtraTabWithButtons/ViewInfo/TabButtonsPanelDescendant.vb))
