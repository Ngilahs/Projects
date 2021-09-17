Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop.Excel
Imports System.IO
Public Class Helpers
    'Public Sub openConnection(MysqlConn)
    '    If String.IsNullOrWhiteSpace(My.Settings.srv) Or String.IsNullOrWhiteSpace(My.Settings.usr) Or
    '        String.IsNullOrWhiteSpace(My.Settings.usr) Or String.IsNullOrWhiteSpace(My.Settings.pwd) Then
    '        MsgBox("No settings configured for connection", MsgBoxStyle.Exclamation, "Error")
    '        If Settings.ShowDialog = DialogResult.OK Then
    '            MysqlConn.ConnectionString = "Server=" & My.Settings.srv & ";Database=" &
    '                My.Settings.usr & ";User=" & My.Settings.usr & ";Pwd=" & My.Settings.pwd
    '            MysqlConn.Open()
    '        Else
    '            End
    '        End If
    '    Else
    '        MysqlConn.ConnectionString = "Server=" & My.Settings.srv & ";Database=" &
    '                My.Settings.db & ";User=" & My.Settings.usr & ";Pwd=" & My.Settings.pwd
    '        MysqlConn.Open()
    '    End If
    'End Sub
    'Public Sub checkSettings(caller)
    '    If My.Settings.srv = "" Or My.Settings.db = "" Or My.Settings.usr = "" Or My.Settings.pwd = "" Or My.Settings.loc_rpts = "" Or My.Settings.loc_cdo = "" Or My.Settings.loc_jobcard = "" Then
    '        Dim alert As New AlertDialog("No settings configured, set one now", "No settings", "warning")
    '        If alert.ShowDialog() = DialogResult.Cancel Then
    '            caller.Close()
    '        Else
    '            LaunchDialogs.SettingsDialog()
    '        End If
    '    End If
    'End Sub
End Class
