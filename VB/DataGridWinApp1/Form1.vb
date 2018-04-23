Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid

Namespace DataGridWinApp1
	Partial Public Class Form1
		Inherits Form
		Private data As New BindingList(Of DataClass)()
		Private gifHelper As New AnimatedGifImageHelper("..\..\star_icons04.gif")
		Private imgToDraw As Image = Nothing

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			For i As Integer = 0 To 19
				data.Add(New DataClass(i))
			Next i

			dataClassBindingSource.DataSource = data
		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			imgToDraw = gifHelper.GetNextFrame()
			gridView1.InvalidateRowIndicator(gridView1.FocusedRowHandle)
		End Sub

		Private Sub gridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As RowIndicatorCustomDrawEventArgs) Handles gridView1.CustomDrawRowIndicator
			Dim view As GridView = CType(sender, GridView)
			If e.RowHandle <> view.FocusedRowHandle OrElse (Not view.IsDataRow(e.RowHandle)) OrElse imgToDraw Is Nothing Then
				Return
			End If

			e.Info.ImageIndex = -1
			Dim imgLocation As New Point()
			imgLocation.Y = e.Bounds.Y + e.Bounds.Size.Height \ 2 - imgToDraw.Size.Height \ 2
			imgLocation.X = e.Bounds.X + e.Bounds.Size.Width \ 2 - imgToDraw.Size.Width \ 2

			e.Painter.DrawObject(e.Info)
			e.Graphics.DrawImage(imgToDraw, imgLocation)
			e.Handled = True
		End Sub
	End Class
End Namespace