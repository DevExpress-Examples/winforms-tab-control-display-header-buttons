<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128618824/12.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4255)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [BaseTabHandlerDescendant.cs](./CS/XtraTabWithButtons/BaseTabHandlerDescendant.cs) (VB: [BaseTabHandlerDescendant.vb](./VB/XtraTabWithButtons/BaseTabHandlerDescendant.vb))
* [Form1.cs](./CS/XtraTabWithButtons/Form1.cs) (VB: [Form1.vb](./VB/XtraTabWithButtons/Form1.vb))
* [SkinTabPainterDescendant.cs](./CS/XtraTabWithButtons/Paint/SkinTabPainterDescendant.cs) (VB: [SkinTabPainterDescendant.vb](./VB/XtraTabWithButtons/Paint/SkinTabPainterDescendant.vb))
* [Program.cs](./CS/XtraTabWithButtons/Program.cs) (VB: [Program.vb](./VB/XtraTabWithButtons/Program.vb))
* [XtraTabPageCollectionDescendant.cs](./CS/XtraTabWithButtons/Tab/Page/XtraTabPageCollectionDescendant.cs) (VB: [XtraTabPageCollectionDescendant.vb](./VB/XtraTabWithButtons/Tab/Page/XtraTabPageCollectionDescendant.vb))
* [XtraTabPageDescendant.cs](./CS/XtraTabWithButtons/Tab/Page/XtraTabPageDescendant.cs) (VB: [XtraTabPageDescendant.vb](./VB/XtraTabWithButtons/Tab/Page/XtraTabPageDescendant.vb))
* [XtraTabControlDescendant.cs](./CS/XtraTabWithButtons/Tab/XtraTabControlDescendant.cs) (VB: [XtraTabControlDescendant.vb](./VB/XtraTabWithButtons/Tab/XtraTabControlDescendant.vb))
* [BaseTabPageViewInfoDescendant.cs](./CS/XtraTabWithButtons/ViewInfo/BaseTabPageViewInfoDescendant.cs) (VB: [BaseTabPageViewInfoDescendant.vb](./VB/XtraTabWithButtons/ViewInfo/BaseTabPageViewInfoDescendant.vb))
* [SkinViewInfoRegistratorDescendant.cs](./CS/XtraTabWithButtons/ViewInfo/Other/SkinViewInfoRegistratorDescendant.cs) (VB: [SkinViewInfoRegistratorDescendant.vb](./VB/XtraTabWithButtons/ViewInfo/Other/SkinViewInfoRegistratorDescendant.vb))
* [SkinTabHeaderViewInfoDescendant.cs](./CS/XtraTabWithButtons/ViewInfo/SkinTabHeaderViewInfoDescendant.cs) (VB: [SkinTabHeaderViewInfoDescendant.vb](./VB/XtraTabWithButtons/ViewInfo/SkinTabHeaderViewInfoDescendant.vb))
* [TabButtonsPanelDescendant.cs](./CS/XtraTabWithButtons/ViewInfo/TabButtonsPanelDescendant.cs) (VB: [TabButtonsPanelDescendant.vb](./VB/XtraTabWithButtons/ViewInfo/TabButtonsPanelDescendant.vb))
<!-- default file list end -->
# How to add custom buttons to tab page headers


<p>This Example shows how to create a custom XtraTabControl  to add custom buttons to tab page headers. You can access these buttons via the <strong>XtraTabPageDescendant.CustomButtons</strong> property. To handle its click, use the <strong>XtraTabPageDescendant.CustomPageButtonClick</strong> event.</p><br />
<p>In this example, you can use RadioButtonControl to change orientation and location of page headers. Also you can click in form buttons to add or delete buttons to tab page headers.</p>

<br/>


