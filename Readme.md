<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128628082/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3156)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - Display a GIF animation in the row indicator

This example shows how to handle the [CustomDrawRowIndicator](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.CustomDrawRowIndicator) event to display a GIF animation in the [row indicator](https://docs.devexpress.com/WindowsForms/554/controls-and-libraries/data-grid/visual-elements/grid-view-elements/row-indicator-panel?p=netframework) of the focused row.

```csharp
private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e) {
  GridView view = (GridView)sender;
  if ( e.RowHandle != view.FocusedRowHandle || !view.IsDataRow(e.RowHandle) || imgToDraw == null )
    return;
  e.Info.ImageIndex = -1;
  Point imgLocation = new Point();
  imgLocation.Y = e.Bounds.Y + e.Bounds.Size.Height / 2 - imgToDraw.Size.Height / 2;
  imgLocation.X = e.Bounds.X + e.Bounds.Size.Width / 2 - imgToDraw.Size.Width / 2;
  e.Painter.DrawObject(e.Info);
  e.Cache.DrawImage(imgToDraw, imgLocation);			
  e.Handled = true;
}
```

We created a helper class (`AnimatedGifImageHelper`) to obtain animation frames and draw them as static images (the `Image` class). The Timer's `Interval` property specifies the animation speed (the longer the interval, the slower the animation).

```csharp
private void timer1_Tick(object sender, EventArgs e) {
  imgToDraw = gifHelper.GetNextFrame();
  // Redraws the row indicator cell that corresponds to the focused row.
  gridView1.InvalidateRowIndicator(gridView1.FocusedRowHandle);
}
```

## Files to Review

* [AnimatedGifImageHelper.cs](./CS/DataGridWinApp1/AnimatedGifImageHelper.cs) (VB: [AnimatedGifImageHelper.vb](./VB/DataGridWinApp1/AnimatedGifImageHelper.vb))
* [DataClass.cs](./CS/DataGridWinApp1/DataClass.cs) (VB: [DataClass.vb](./VB/DataGridWinApp1/DataClass.vb))
* [Form1.cs](./CS/DataGridWinApp1/Form1.cs) (VB: [Form1.vb](./VB/DataGridWinApp1/Form1.vb))
* [Program.cs](./CS/DataGridWinApp1/Program.cs) (VB: [Program.vb](./VB/DataGridWinApp1/Program.vb))


## Documentation

* [Custom Painting Basics](https://docs.devexpress.com/WindowsForms/762/controls-and-libraries/data-grid/appearance-and-conditional-formatting/custom-painting/custom-painting-basics)
* [Manually Invalidating Controls](https://docs.devexpress.com/WindowsForms/765/controls-and-libraries/data-grid/appearance-and-conditional-formatting/custom-painting/manually-invalidating-controls)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-show-gif-animation-in-row-indicator&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-show-gif-animation-in-row-indicator&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
