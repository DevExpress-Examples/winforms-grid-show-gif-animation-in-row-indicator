using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace DataGridWinApp1
{
	public partial class Form1 : Form
	{
		private BindingList<DataClass> data = new BindingList<DataClass>();
		private AnimatedGifImageHelper gifHelper = new AnimatedGifImageHelper("..\\..\\star_icons04.gif");
		private Image imgToDraw = null;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			for ( int i = 0; i < 20; i++ )
				data.Add(new DataClass(i));

			dataClassBindingSource.DataSource = data;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			imgToDraw = gifHelper.GetNextFrame();
			gridView1.InvalidateRowIndicator(gridView1.FocusedRowHandle);
		}

		private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
		{
			GridView view = (GridView)sender;
			if ( e.RowHandle != view.FocusedRowHandle || !view.IsDataRow(e.RowHandle) || imgToDraw == null )
				return;

			e.Info.ImageIndex = -1;
			Point imgLocation = new Point();
			imgLocation.Y = e.Bounds.Y + e.Bounds.Size.Height / 2 - imgToDraw.Size.Height / 2;
			imgLocation.X = e.Bounds.X + e.Bounds.Size.Width / 2 - imgToDraw.Size.Width / 2;

			e.Painter.DrawObject(e.Info);
			e.Graphics.DrawImage(imgToDraw, imgLocation);
			e.Handled = true;
		}
	}
}