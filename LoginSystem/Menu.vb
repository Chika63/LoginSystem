Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Text
Imports Google.Protobuf.Reflection.FieldDescriptorProto.Types
Imports MySql.Data.MySqlClient

Public Class Menu

    Public Sub Menu_Load() Handles MyBase.Load

    End Sub

    Private Sub Engbtn_Click(sender As Object, e As EventArgs) Handles Engbtn.Click
        Dim engapl As New EngApl
        engapl.show()
    End Sub
End Class
