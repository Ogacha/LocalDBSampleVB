Imports System.Data.SqlClient
Public Class Form1

    Private table As DataTable = New DataTable()

    Private Sub cmdExecButton_Click(sender As Object, e As EventArgs) Handles cmdExecButton.Click
        Try
            ' 通常の ADO.NET と変わりません。トランザクション、ストアドプロシージャー、
            ' ストアド関数など、ほぼフル機能が使えます。
            ' DataSource に指定するのは、(LocalDB)\インスタンスです。
            ' 2016 から規定のインスタンス名は、MSSQLLocalDB です。
            ' AttachDbFileName= で接続する .mdf ファイルを指定できます。
            ' ファイル指定を省略した場合は、既定のファイルにつなぎにいきます。
            ' C:\Users\ユーザー\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\ 配下
            ' システム データベースの照合順序は変更できず、SQL_Latin1_General_CP1_CI_AS です。
            Using con As SqlConnection = New SqlConnection(tbConnectionString.Text)
                con.Open()
                Dim tran As SqlTransaction = con.BeginTransaction()
                Dim cmd = New SqlCommand(tbCommand.Text, con, tran)
                Dim adp = New SqlDataAdapter(cmd)
                adp.Fill(table)
                tran.Commit()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        dgvResultTable.DataSource = table
    End Sub

    ' .mdf ファイルを作成するときは、CREATE DATABASE を ON (NAME=, FILENAME=) を指定して
    ' 作成します。この場合の接続は、既定の接続でよいでしょう。
    Private Sub cmdCreateMdf_Click(sender As Object, e As EventArgs) Handles cmdCreateMdf.Click
        Try
            Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;")
                con.Open()
                Dim cmd = New SqlCommand("CREATE DATABASE LocalDBSample ON (NAME='LocalDBSample', FILENAME='C:\TEMP\LocalDBSample.mdf')", con)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class
