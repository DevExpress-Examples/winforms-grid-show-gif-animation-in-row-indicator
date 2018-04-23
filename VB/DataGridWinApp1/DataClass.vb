Imports Microsoft.VisualBasic
Imports System

Namespace DataGridWinApp1
	Public Class DataClass
		Public Sub New(ByVal seed As Integer)
			IntProperty = seed
			StringProperty = "Text " & seed
			DateProperty = DateTime.Now.AddDays(-seed)
		End Sub

		Public Sub New()
		End Sub

		Private privateIntProperty As Integer
		Public Property IntProperty() As Integer
			Get
				Return privateIntProperty
			End Get
			Set(ByVal value As Integer)
				privateIntProperty = value
			End Set
		End Property

		Private privateStringProperty As String
		Public Property StringProperty() As String
			Get
				Return privateStringProperty
			End Get
			Set(ByVal value As String)
				privateStringProperty = value
			End Set
		End Property

		Private privateDateProperty As DateTime
		Public Property DateProperty() As DateTime
			Get
				Return privateDateProperty
			End Get
			Set(ByVal value As DateTime)
				privateDateProperty = value
			End Set
		End Property
	End Class
End Namespace
