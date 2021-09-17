Imports System.ComponentModel
Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Diagnostics
Imports System.Configuration
Public Class frmbackuprestoredb
    Dim OutputStream As System.IO.StreamWriter
    Sub OnDataReceived1(ByVal Sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs)
        If e.Data IsNot Nothing Then
            Dim text As String = e.Data
            Dim bytes As Byte() = Encoding.Default.GetBytes(text)
            text = Encoding.UTF8.GetString(bytes)
            OutputStream.WriteLine(text)
        End If
    End Sub
    Sub CreateBackup()
        Process.Start("[192.168.0.5]", "-u [lmcp] -p [admin] [besdb] -r ""[C:\Users\Admin\Documents\dumps]""")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbackup.Click
        Try
            Dim file As String
            sfd.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
            sfd.FileName = "Database Backup " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"
            If sfd.ShowDialog = DialogResult.OK Then
                file = sfd.FileName
                Dim myProcess As New Process()
                myProcess.StartInfo.FileName = "cmd.exe"
                myProcess.StartInfo.UseShellExecute = False
                myProcess.StartInfo.WorkingDirectory = "\\192.168.0.5\C:\Program Files\MySQL\MySQL Server 8.0\bin\mysqldump.exe"
                myProcess.StartInfo.RedirectStandardInput = True
                myProcess.StartInfo.RedirectStandardOutput = True
                myProcess.Start()
                Dim myStreamWriter As StreamWriter = myProcess.StandardInput
                Dim mystreamreader As StreamReader = myProcess.StandardOutput
                myStreamWriter.WriteLine("mysqldump -u lmcp --Password=admin -h 192.168.0.5 ""besdb"" > """ + file + """ ")
                myStreamWriter.Close()
                myProcess.WaitForExit()
                myProcess.Close()
                MsgBox("Backup Created Successfully!", MsgBoxStyle.Information, "Backup")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally

        End Try
    End Sub

    Private Sub Backupdatabase()
        Dim MysqlConn As MySqlConnection
        Dim cmd As MySqlCommand
        Dim mb As MySqlBackup
        Dim file As String
        file = "C:\\backup.sql"
        MysqlConn = New MySqlConnection
        MysqlConn = New MySqlConnection(ConfigurationManager.ConnectionStrings("POS").ConnectionString)
        mb = New MySqlBackup(cmd)
        cmd.Connection = MysqlConn
        MysqlConn.Open()
        mb.ExportToFile(file)
        MysqlConn.Close()
    End Sub

    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
        Dim file As String
        opd.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
        If opd.ShowDialog = DialogResult.OK Then
            file = opd.FileName
            Dim myProcess As New Process()
            myProcess.StartInfo.FileName = "cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.WorkingDirectory = "C:\Program Files\MySQL\MySQL Server 8.0\bin"
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.Start()
            Dim myStreamWriter As StreamWriter = myProcess.StandardInput
            Dim mystreamreader As StreamReader = myProcess.StandardOutput
            myStreamWriter.WriteLine("mysql -u root --Password=admin -h localhost ""besdb"" < """ + file + """ ")
            myStreamWriter.Close()
            myProcess.WaitForExit()
            myProcess.Close()
            MsgBox("Database Restoration Successfully!", MsgBoxStyle.Information, "Restore")
        End If

    End Sub
    Private Sub frmbackuprestoredb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
End Class