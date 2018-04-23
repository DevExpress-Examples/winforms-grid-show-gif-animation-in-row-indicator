Imports Microsoft.VisualBasic
Imports System
Namespace DataGridWinApp1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.dataClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colIntProperty = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colStringProperty = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDateProperty = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.dataClassBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(433, 314)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' dataClassBindingSource
			' 
			Me.dataClassBindingSource.DataSource = GetType(DataGridWinApp1.DataClass)
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colIntProperty, Me.colStringProperty, Me.colDateProperty})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
'			Me.gridView1.CustomDrawRowIndicator += New DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(Me.gridView1_CustomDrawRowIndicator);
			' 
			' colIntProperty
			' 
			Me.colIntProperty.FieldName = "IntProperty"
			Me.colIntProperty.Name = "colIntProperty"
			Me.colIntProperty.Visible = True
			Me.colIntProperty.VisibleIndex = 0
			' 
			' colStringProperty
			' 
			Me.colStringProperty.FieldName = "StringProperty"
			Me.colStringProperty.Name = "colStringProperty"
			Me.colStringProperty.Visible = True
			Me.colStringProperty.VisibleIndex = 1
			' 
			' colDateProperty
			' 
			Me.colDateProperty.FieldName = "DateProperty"
			Me.colDateProperty.Name = "colDateProperty"
			Me.colDateProperty.Visible = True
			Me.colDateProperty.VisibleIndex = 2
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
			Me.timer1.Interval = 200
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(433, 314)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private dataClassBindingSource As System.Windows.Forms.BindingSource
		Private colIntProperty As DevExpress.XtraGrid.Columns.GridColumn
		Private colStringProperty As DevExpress.XtraGrid.Columns.GridColumn
		Private colDateProperty As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents timer1 As System.Windows.Forms.Timer
	End Class
End Namespace

