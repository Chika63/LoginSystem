Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Google.Protobuf.Reflection.FieldDescriptorProto.Types
Imports MySql.Data.MySqlClient

Public Class LoginFm

    Private Sub Okbtn_Click(sender As Object, e As EventArgs) Handles Okbtn.Click


        Dim con As MySqlConnection
        Dim comm As New SqlCommand

        '接続文字列
        Dim connectionString As String = "server=localhost;database=sysdb;user id=root;password=root"

        'コネクション生成
        con = New MySqlConnection(connectionString)

        con.Open()

        Try
            Dim stbSQL As StringBuilder = New StringBuilder()

            stbSQL.AppendLine("select ")
            stbSQL.AppendLine("pt.Id ")
            stbSQL.AppendLine(", pt.PassWord ")
            stbSQL.AppendLine("from ")
            stbSQL.AppendLine("pwd_t pt ")

            Dim command As New MySqlCommand(stbSQL.ToString, con)
            Dim adapter As New MySqlDataAdapter(command)
            Dim dt As New DataTable
            adapter.Fill(dt)

            '確認
            DataGridView1.DataSource = dt
            Dim LoginText As String = LoginTb.Text

            If dt Is Nothing Then
                Return
            ElseIf dt.Rows(0).Item("Id").ToString = LoginText Then

                Dim menu As New Menu
                menu.Show()


            End If

        Catch ex As Exception
            Throw
        Finally
            con.Close()
        End Try






    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
