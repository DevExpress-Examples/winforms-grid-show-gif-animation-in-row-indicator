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

        Public Property IntProperty As Integer

        Public Property StringProperty As String

        Public Property DateProperty As DateTime
    End Class
End Namespace
