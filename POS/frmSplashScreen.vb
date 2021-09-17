Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmSplashScreen
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqll As String
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If txtActivationID.Text = TextBox1.Text Then
                ProgressBar1.Visible = True
                ProgressBar1.Value = ProgressBar1.Value + 2
                If (ProgressBar1.Value = 10) Then
                    Label3.Text = "Reading modules.."
                ElseIf (ProgressBar1.Value = 20) Then
                    Label3.Text = "Turning on modules."
                ElseIf (ProgressBar1.Value = 40) Then
                    Label3.Text = "Starting modules.."
                ElseIf (ProgressBar1.Value = 60) Then
                    Label3.Text = "Loading modules.."
                ElseIf (ProgressBar1.Value = 80) Then
                    Label3.Text = "Done Loading modules.."
                ElseIf (ProgressBar1.Value = 100) Then
                    frmLogin.Show()
                    Timer1.Enabled = False
                    Me.Hide()
                End If
            End If
            If txtActivationID.Text <> TextBox1.Text Then
                ProgressBar1.Visible = True
                ProgressBar1.Value = ProgressBar1.Value + 2
                If (ProgressBar1.Value = 10) Then
                    Label3.Text = "Reading modules.."
                ElseIf (ProgressBar1.Value = 20) Then
                    Label3.Text = "Turning on modules."
                ElseIf (ProgressBar1.Value = 40) Then
                    Label3.Text = "Starting modules.."
                ElseIf (ProgressBar1.Value = 60) Then
                    Label3.Text = "Loading modules.."
                ElseIf (ProgressBar1.Value = 80) Then
                    Label3.Text = "Done Loading modules.."
                ElseIf (ProgressBar1.Value = 100) Then
                    frmActivation.Show()
                    Timer1.Enabled = False
                    Me.Hide()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
            End
        End Try
    End Sub
    Private Sub frmSplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim i As System.Management.ManagementObject
            Dim searchInfo_Processor As New System.Management.ManagementObjectSearcher("Select * from Win32_Processor")
            For Each i In searchInfo_Processor.Get()
                txtHardwareID.Text = i("ProcessorID").ToString
            Next
            'Dim searchInfo_Board As New System.Management.ManagementObjectSearcher("Select * from Win32_BaseBoard")
            'For Each i In searchInfo_Board.Get()
            '    txtSerialNo.Text = i("SerialNumber").ToString
            'Next + (txtSerialNo.Text)
            Dim st As String = (txtHardwareID.Text)
            TextBox1.Text = Encryption.MakePassword(st, 659)
            Dim con As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=posisdb;User ID=root;Password=admin@2018dec;")
            con.Open()
            sqll = "select RTRIM(ActivationID) from activation where HardwareID=@d1"
            cmd = New MySqlCommand(sqll, con)
            cmd.Parameters.AddWithValue("@d1", txtHardwareID.Text)
            'cmd.Parameters.AddWithValue("@d2", txtSerialNo.Text)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                txtActivationID.Text = Decrypt(dr.GetValue(0))
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
            End
        End Try
    End Sub

    
End Class

