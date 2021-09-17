Imports MySql.Data.MySqlClient
Imports System.Configuration
Module SQLConn
    Public ServerMySQL As String
    Public PortMySQL As String
    Public UserNameMySQL As String
    Public PwdMySQL As String
    Public DBNameMySQL As String
    Public sqL As String
    Public ds As New DataSet()
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As New MySqlDataAdapter
    Public conn As New MySqlConnection
    Public xUser_ID As Integer
    Public xUser_Access As String
    Public LOGID As Integer
    Public LOGIDDD As Double
    Public sPCName As String       'Name of the PC that is being used
    Public sPCUser As String       'Name of the User on the Networked PC
    Public sDBUser As String       'Name of the Database User
    Public sDateTime As String     'Date and Time of the change
    Public sTable As String        'Table where the record is being edited
    Public CTL As Control          'The control in the form being edited
    Public sFrom As String         'Original Data in the control
    Public sTo As String           'What the original data was changed to
    Public frm As Form
    Sub getData()
        Dim AppName As String = Application.ProductName

        Try
            DBNameMySQL = GetSetting(AppName, "DBSection", "DB_Name", "temp")
            ServerMySQL = GetSetting(AppName, "DBSection", "DB_IP", "temp")
            PortMySQL = GetSetting(AppName, "DBSection", "DB_Port", "temp")
            UserNameMySQL = GetSetting(AppName, "DBSection", "DB_User", "temp")
            PwdMySQL = GetSetting(AppName, "DBSection", "DB_Password", "temp")

        Catch ex As Exception
            MsgBox("System registry was not established, you can set/save " &
            "these settings by pressing F1", MsgBoxStyle.Information)
        End Try

    End Sub

    Public Sub ConnDB()
        Try
            conn.ConnectionString = "Server = '" & ServerMySQL & "';  " _
                                         & "Port = '" & PortMySQL & "'; " _
                                         & "Database = '" & DBNameMySQL & "'; " _
                                         & "user id = '" & UserNameMySQL & "'; " _
                                         & "password = '" & PwdMySQL & "'"

            conn.Open()

            'DBNameMySQL = "posisdb"
            'ServerMySQL = "WIN-G03TE1M7SO4"
            'UserNameMySQL = "wandii"
            'PortMySQL = "3306"
            'PwdMySQL = "jona"
            DBNameMySQL = "posisdb"
            ServerMySQL = "192.168.0.207"
            UserNameMySQL = "joshua"
            PortMySQL = "3306"
            PwdMySQL = "admin"
        Catch ex As Exception
            'MsgBox("The system failed to establish a connection", MsgBoxStyle.Information, "Database Settings")
        End Try

    End Sub

    Public Sub DisconnMy()

        conn.Close()
        conn.Dispose()

    End Sub

    Sub SaveData()
        Dim AppName As String = Application.ProductName

        SaveSetting(AppName, "DBSection", "DB_Name", DBNameMySQL)
        SaveSetting(AppName, "DBSection", "DB_IP", ServerMySQL)
        SaveSetting(AppName, "DBSection", "DB_Port", PortMySQL)
        SaveSetting(AppName, "DBSection", "DB_User", UserNameMySQL)
        SaveSetting(AppName, "DBSection", "DB_Password", PwdMySQL)

        'MsgBox("Database connection settings are saved.", MsgBoxStyle.Information)
    End Sub

End Module


