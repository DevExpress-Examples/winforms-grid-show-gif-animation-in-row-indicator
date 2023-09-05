<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128628082/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3156)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Data Grid - Display a GIF animation in the row indicator

This example shows how to handle the [CustomDrawRowIndicator](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.CustomDrawRowIndicator) event to display a GIF animation in the [row indicator](https://docs.devexpress.com/WindowsForms/554/controls-and-libraries/data-grid/visual-elements/grid-view-elements/row-indicator-panel?p=netframework) of the focused row.

We created a helper class to obtain animation frames and draw them as static images (the `Image` class). The Timer's `Interval` property specifies the animation speed (the longer the interval, the slower the animation).


## Files to Review

* [AnimatedGifImageHelper.cs](./CS/DataGridWinApp1/AnimatedGifImageHelper.cs) (VB: [AnimatedGifImageHelper.vb](./VB/DataGridWinApp1/AnimatedGifImageHelper.vb))
* [DataClass.cs](./CS/DataGridWinApp1/DataClass.cs) (VB: [DataClass.vb](./VB/DataGridWinApp1/DataClass.vb))
* [Form1.cs](./CS/DataGridWinApp1/Form1.cs) (VB: [Form1.vb](./VB/DataGridWinApp1/Form1.vb))
* [Program.cs](./CS/DataGridWinApp1/Program.cs) (VB: [Program.vb](./VB/DataGridWinApp1/Program.vb))
