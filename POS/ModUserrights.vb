'' AppPermissionsModule.vb
''
'' Subject: 
''
'' Description: This module contains the code that limits which 
'' menus are shown in the menu strip. It uses a database to store 
'' user info as well as permissions which are used to control 
'' which menus the user will be shown.
''
'' Notes: 
'' It only contains code for SQLExpress and mySQL.
''
'' For SQLExpress, download and install SQLExpress.
'' Below is a link for SQLExpress 2008 with SP1:
'' http://www.microsoft.com/en-us/download/details.aspx?id=25052
''
'' Add the following Imports statement:
'' Imports System.Data.SqlClient
''
'' For mySQL, download and install Connector/Net 
'' http://dev.mysql.com/downloads/connector/net/
''
'' Add Reference:
'' Project => Add Reference => .NET => MySQL.Data
''
'' Then add the following Imports statement:
'' Imports MySql.Data
''
'' Usage:
''
'' Place the following code in the form's "Load" event, or
'' in a button event:
''     doTasks("user5", ToolStripStatusLabel1, StatusStrip1, MenuStrip1, "SQLExpress")
''                         or
''     doTasks("user5", ToolStripStatusLabel1, StatusStrip1, MenuStrip1, "mySQL")
''
'' You can also get a list of users by placing the following code 
'' in the form's "Load" event:
''
''     Dim userList As List(Of String) = Nothing
''     userList = getUsersSQLExpress(ToolStripStatusLabel1, StatusStrip1)
''
''

'' Written by:  cgeier 05/27/2014


'Imports MySql.Data.MySqlClient
'Imports MySql.Data
'Module ModUserrights
'    '--------------------------------------------
'    ' ToDo:
'    ' Change dbName to the name of your database
'    '--------------------------------------------
'    'database name
'    Private dbName As String = "posisdb"

'    '--------------------------------------------
'    ' ToDo:
'    ' Change dbUsername to your database username
'    ' Change dbPassword to your database password
'    '--------------------------------------------
'    Private dbUsername As String = "root"
'    Private dbPassword As String = "admin"

'    'connection string for mySQL
'    Public _connectStrMySQL = "Database=posisdb;Data Source=localhost;User Id=" & dbUsername & ";Password=" & dbPassword

'    'dictionary of permissions within the program
'    'adds permissions for all ancestors
'    Private _menuPermissionsDict As New Dictionary(Of String, Boolean)

'    'dictionary of all menus and sub-menus that exist on form
'    Private _menuDict As New Dictionary(Of String, MenuInfo)

'    'this is our local copy of the ToolStripStatusLabel from the form
'    Private _ToolStripStatusLabel1 As ToolStripStatusLabel = Nothing

'    'this is our local copy of the StatusStrip from the form
'    Private _StatusStrip1 As StatusStrip = Nothing

'    ''' <summary>
'    ''' This is the main Sub. This is what does all the work.
'    ''' </summary>
'    ''' <param name="username">(String) id that exists in table AppUser (column name = 'id')</param>
'    ''' <param name="ToolStripStatusLabel1">(ToolStripStatusLabel) Name of StatusLabel in StatusStrip on form.</param>
'    ''' <param name="StatusStrip1">(StatusStrip) Name of StatusStrip on form.</param>
'    ''' <param name="MenuStrip1">(MenuStrip) Name of MenuStrip on form.</param>
'    ''' <param name="databaseProduct">(String) Valid values are: "SQLExpress" or "mySQL"</param>
'    ''' <remarks></remarks>
'    Public Sub doTasks(ByVal username As String, _
'                        ByVal ToolStripStatusLabel1 As ToolStripStatusLabel, _
'                        ByVal StatusStrip1 As StatusStrip, _
'                        ByVal MenuStrip1 As MenuStrip, _
'                        ByVal databaseProduct As String)

'        Dim errMessage As String = String.Empty
'        Dim permissionsDt As DataTable = Nothing

'        'set private variable values
'        'used by other methods
'        _ToolStripStatusLabel1 = ToolStripStatusLabel1
'        _StatusStrip1 = StatusStrip1
'        Try
'                If databaseProduct = "mySQL" Then
'                    'get user permissions from db
'                    permissionsDt = getPermissionsMySQL(username)
'                Else
'                    errMessage = "Error: (doTasks): " & " Database product not supported. "
'                errMessage += "Must be'mySQL'."
'                    MessageBox.Show(errMessage)
'                    ToolStripStatusLabel1.Text = errMessage
'                    _StatusStrip1.Refresh()
'                End If
'                If permissionsDt IsNot Nothing Then
'                    setPermissions(permissionsDt, MenuStrip1)
'                End If
'        Catch ex As Exception
'            errMessage = "Error: (doTasks): " & ex.Message
'            MessageBox.Show(errMessage)
'            ToolStripStatusLabel1.Text = errMessage
'            _StatusStrip1.Refresh()
'        End Try
'    End Sub

'    Private Function getPermissionsMySQL(ByVal username As String) As DataTable
'        'uses _ToolStripStatusLabel1 and _StatusStrip1 values set in
'        'doTasks and/or getUsersSQLExpress

'        Dim retDataTable As New DataTable
'        Dim errMessage As String = String.Empty

'        Try
'            'update status
'            _ToolStripStatusLabel1.Text = "Status: Getting User Permissions..."

'            'refresh the StatusStrip
'            'to ensure the ToolStripStatusLabel
'            'text is updated
'            _StatusStrip1.Refresh()

'            'Create SQL Connection and get permissions
'            Using cn As New MySqlClient.MySqlConnection(_connectStrMySQL)

'                Dim sqlText As String = String.Empty
'                sqlText = "Select grouppermission.groupname, grouppermission.permissionname "
'                sqlText += "FROM grouppermission "
'                sqlText += "INNER JOIN usergroup "
'                sqlText += "ON grouppermission.groupName = usergroup.groupname "
'                sqlText += "WHERE usergroup.Userid = '" & username & "'"
'                Try
'                    ' Open Connection
'                    cn.Open()
'                    Using cmd As New MySqlClient.MySqlCommand(sqlText, cn)
'                        Dim dA As New MySqlClient.MySqlDataAdapter(sqlText, cn)
'                        Try
'                            dA.Fill(retDataTable)
'                        Catch ex As Exception
'                            errMessage = "getPermissionsMySQL (MySqlDataAdapter): " & ex.Message
'                            MessageBox.Show(errMessage)
'                            _ToolStripStatusLabel1.Text = errMessage
'                            _StatusStrip1.Refresh()
'                        End Try
'                    End Using

'                Catch ex As MySqlClient.MySqlException
'                    errMessage = "getPermissionsMySQL (error in connection - MySqlException): " & ex.Message
'                    MessageBox.Show(errMessage)
'                    _ToolStripStatusLabel1.Text = errMessage
'                    _StatusStrip1.Refresh()
'                Catch ex As Exception
'                    errMessage = "getPermissionsMySQL (error in connection): " & ex.Message
'                    MessageBox.Show(errMessage)
'                    _ToolStripStatusLabel1.Text = errMessage
'                    _StatusStrip1.Refresh()
'                End Try
'            End Using

'        Catch ex As MySqlClient.MySqlException
'            errMessage = "getPermissionsMySQL (MySqlException): " & ex.Message
'            MessageBox.Show(errMessage)
'            _ToolStripStatusLabel1.Text = errMessage
'            _StatusStrip1.Refresh()
'        Catch ex As Exception
'            errMessage = "getPermissionsMySQL: " & ex.Message
'            MessageBox.Show(errMessage)
'            _ToolStripStatusLabel1.Text = errMessage
'            _StatusStrip1.Refresh()
'        End Try

'        Return retDataTable
'    End Function
'    Public Function getUsersMySQL(ByVal ToolStripStatusLabel1 As ToolStripStatusLabel, _
'                    ByVal StatusStrip1 As StatusStrip) As List(Of String)
'        'requires Imports MySql.Data

'        'list to return
'        Dim retList As New List(Of String)

'        Dim dt As New DataTable
'        Dim errMessage As String = String.Empty

'        'set private variable values
'        'used by other methods
'        _ToolStripStatusLabel1 = ToolStripStatusLabel1
'        _StatusStrip1 = StatusStrip1

'        Try
'            'update status
'            _ToolStripStatusLabel1.Text = "Status: Getting Users..."

'            'refresh the StatusStrip
'            'to ensure the ToolStripStatusLabel
'            'text is updated
'            _StatusStrip1.Refresh()

'            'Create SQL Connection and get permissions
'            Using cn As New MySqlClient.MySqlConnection(_connectStrMySQL)

'                Dim sqlText As String = String.Empty
'                sqlText = "Select staff.StaffID "
'                sqlText += "FROM staff "

'                Try
'                    ' Open Connection
'                    cn.Open()

'                    Using cmd As New MySqlClient.MySqlCommand(sqlText, cn)
'                        Dim dA As New MySqlClient.MySqlDataAdapter(sqlText, cn)

'                        Try
'                            dA.Fill(dt)

'                            If dt IsNot Nothing Then
'                                For Each row As DataRow In dt.Rows

'                                    'add id to list
'                                    retList.Add(row("StaffID").ToString())
'                                Next
'                            End If
'                        Catch ex As Exception
'                            errMessage = "getUsersMySQL (MySqlDataAdapter): " & ex.Message
'                            MessageBox.Show(errMessage)
'                            _ToolStripStatusLabel1.Text = errMessage
'                            _StatusStrip1.Refresh()
'                        End Try
'                    End Using

'                Catch ex As MySqlClient.MySqlException
'                    errMessage = "getUsersMySQL (error in connection - MySqlException): " & ex.Message
'                    MessageBox.Show(errMessage)
'                    _ToolStripStatusLabel1.Text = errMessage
'                    _StatusStrip1.Refresh()
'                Catch ex As Exception
'                    errMessage = "getUsersMySQL (error in connection): " & ex.Message
'                    MessageBox.Show(errMessage)
'                    _ToolStripStatusLabel1.Text = errMessage
'                    _StatusStrip1.Refresh()
'                End Try
'            End Using

'        Catch ex As MySqlClient.MySqlException
'            errMessage = "getUsersMySQL (MySqlException): " & ex.Message
'            MessageBox.Show(errMessage)
'            _ToolStripStatusLabel1.Text = errMessage
'            _StatusStrip1.Refresh()
'        Catch ex As Exception
'            errMessage = "getUsersMySQL: " & ex.Message
'            MessageBox.Show(errMessage)
'            _ToolStripStatusLabel1.Text = errMessage
'            _StatusStrip1.Refresh()
'        End Try

'        Return retList
'    End Function
'    Private Sub setPermissions(ByVal dt As DataTable, _
'                               ByVal MenuStrip1 As MenuStrip)

'        'uses _ToolStripStatusLabel1 and _StatusStrip1 values set in
'        'doTasks and/or getUsersSQLExpress

'        Dim errMessage As String = String.Empty
'        Dim dbPermissionsDict As New Dictionary(Of String, Boolean)

'        Try

'            'reset _menuPermissionsDict
'            _menuPermissionsDict.Clear()

'            'clear dictionary of menu info
'            _menuDict.Clear()


'            'retrieve menu info from form
'            getToolStripMenuNames(MenuStrip1)

'            For Each row As DataRow In dt.Rows
'                Dim menuPermission As String = Nothing
'                menuPermission = row("permissionname").ToString()
'                'Console.WriteLine("dbMenuPermission: " & menuPermission)

'                If menuPermission IsNot Nothing Then

'                    'add permission to dbPermissionDict
'                    dbPermissionsDict.Add(menuPermission, True)
'                End If
'            Next


'            '--------------------------------------------
'            'ToDo:
'            '
'            'Add any menus names you want all users
'            'to have access to here.
'            '
'            'We add permissions to "dbPermissionDict"
'            'so we can get all of the menu's ancestors
'            '(parent) menus at the same time.
'            '
'            'It is only necessary to add the 
'            'youngest child menu. All of it's ancestors
'            'will be granted permission automatically.
'            '
'            'ex:
'            'File menu has name "FileToolStripMenuItem1"
'            'File => Edit menu has name "EditToolStripMenu1"
'            '
'            'You only need to add "EditToolStripMenu1".
'            'Permissions for "FileToolStripMenuItem1"
'            'will be added automatically.
'            '-----------------------------------------------


'            'grants all users access to File => Exit menu
'            If Not dbPermissionsDict.ContainsKey("ExitToolStripMenuItem") Then
'                dbPermissionsDict.Add("ExitToolStripMenuItem", True)
'            End If

'            If Not dbPermissionsDict.ContainsKey("ChangePasswordToolStripMenuItem") Then
'                dbPermissionsDict.Add("ChangePasswordToolStripMenuItem", True)
'            End If

'            'grants all users access to Tools => Refresh
'            'RefreshToolStripMenuItem is the name for the 
'            '"Refresh" menu (under Tools)
'            If Not dbPermissionsDict.ContainsKey("TransactionToolStripMenuItem") Then
'                dbPermissionsDict.Add("TransactionToolStripMenuItem", True)
'            End If

'            If Not dbPermissionsDict.ContainsKey("RecordToolStripMenuItem") Then
'                dbPermissionsDict.Add("RecordToolStripMenuItem", True)
'            End If

'            '------------------------------------
'            'Add any menus you want all users to
'            'have access to here
'            '-------------------------------------

'            For Each kvp1 As KeyValuePair(Of String, Boolean) In dbPermissionsDict
'                'get permission name
'                Dim permission As String = kvp1.Key

'                'grants permissions for all ancestor (parent) menus
'                'permissions are updated in menuPermissionDict
'                getAncestors(permission, _menuDict, _menuPermissionsDict)
'            Next

'            For Each kvp As KeyValuePair(Of String, MenuInfo) In _menuDict

'                If (_menuPermissionsDict.ContainsKey(kvp.Key)) Then

'                    'if user has permissions, make menu / drop-down menu visible
'                    _menuDict(kvp.Key).menu.Visible = True

'                    Console.WriteLine("permission: " & kvp.Key)
'                Else
'                    'if user doesn't have permissions for menu,
'                    'hide the menu
'                    _menuDict(kvp.Key).menu.Visible = False
'                End If

'            Next

'            Console.WriteLine()

'            _ToolStripStatusLabel1.Text = "Status: Complete."
'            _StatusStrip1.Refresh()


'        Catch ex As Exception
'            errMessage = "setPermissions: " & ex.Message
'            MessageBox.Show(errMessage)
'            _ToolStripStatusLabel1.Text = errMessage
'            _StatusStrip1.Refresh()
'        End Try
'    End Sub

'    Private Sub getAncestors(ByVal menuName As String, ByVal _menuDict As Dictionary(Of String, MenuInfo), ByRef _menuPermissionsDict As Dictionary(Of String, Boolean))
'        'uses _ToolStripStatusLabel1 and _StatusStrip1 values set in
'        'doTasks and/or getUsersSQLExpress

'        Dim parentMenuName As String = String.Empty
'        Dim errMessage As String = String.Empty

'        Try
'            'check if menu name exists in form
'            'if so, get it's parent
'            If _menuDict.ContainsKey(menuName) Then

'                'add menu name to dictionary, if it doesn't already exist
'                If Not _menuPermissionsDict.ContainsKey(menuName) Then
'                    _menuPermissionsDict.Add(menuName, True)
'                End If

'                'get parent menu name
'                parentMenuName = _menuDict(menuName).parent

'                'if parentMenuName exists, call getAncestors again
'                If parentMenuName <> "" Then

'                    'add parent menu to menuPermissionDict, if it doesn't exist
'                    If Not _menuPermissionsDict.ContainsKey(parentMenuName) Then

'                        'add to dictionary
'                        _menuPermissionsDict.Add(parentMenuName, True)
'                    End If

'                    'get the parent menu's ancestor (parent)
'                    'by recursively calling "getAncestors"
'                    'we will get all parent menus until we
'                    'reach the top level menu
'                    getAncestors(parentMenuName, _menuDict, _menuPermissionsDict)
'                End If

'            End If
'        Catch ex As Exception
'            errMessage = "getAncestors: " & ex.Message
'            MessageBox.Show(errMessage)
'            _ToolStripStatusLabel1.Text = errMessage
'            _StatusStrip1.Refresh()
'        End Try

'    End Sub

'    Private Sub getToolStripMenuNames(ByVal myMenuStrip As MenuStrip)
'        'uses _ToolStripStatusLabel1 and _StatusStrip1 values set in
'        'doTasks and/or getUsersSQLExpress

'        'holds data for display
'        Dim output As String = String.Empty
'        Dim errMessage As String = String.Empty

'        Try
'            'hold menu info
'            Dim menuList As New List(Of MenuInfo)

'            'keeps track of depth
'            Dim depth As Integer = 0

'            'get top level menus - File, Tools, etc...
'            For Each tsItem As ToolStripMenuItem In myMenuStrip.Items


'                'add menu to list
'                'ToolStripMenuItem, menu name, depth, parent name
'                menuList.Add(New MenuInfo(tsItem, tsItem.Name, depth, ""))

'                'add menu to list
'                'ToolStripMenuItem, depth, parent name
'                'menuList.Add(New MenuInfo(tsItem, depth, ""))

'                'get all child menu items - DropDownMenus
'                getToolStripChildMenuNames(tsItem, menuList, depth)
'            Next

'            output = "List of Menus:" + System.Environment.NewLine + System.Environment.NewLine

'            For Each item As MenuInfo In menuList
'                output += "Name: " & item.name & " Depth: " & item.depth & System.Environment.NewLine
'                output += "      Parent: " + item.parent + System.Environment.NewLine + System.Environment.NewLine

'                'add info to _menuDict
'                '_menuDict.Add(item.name, item)
'                _menuDict.Add(item.menu.Name, item)
'            Next

'            MessageBox.Show(output)
'            Console.WriteLine(output)

'        Catch ex As Exception
'            errMessage = "getToolStripMenuNames: " & ex.Message
'            MessageBox.Show(errMessage)
'            _ToolStripStatusLabel1.Text = errMessage
'            _StatusStrip1.Refresh()
'        End Try


'    End Sub

'    'recursive function to get drop down menus
'    Private Sub getToolStripChildMenuNames(ByVal myToolStripMenuItem As ToolStripMenuItem, ByRef menuList As List(Of MenuInfo), ByRef depth As Integer)
'        'uses _ToolStripStatusLabel1 and _StatusStrip1 values set in
'        'doTasks and/or getUsersSQLExpress

'        Dim errMessage As String = String.Empty

'        Try
'            'increment depth
'            depth += 1

'            'get DropDown menus
'            For Each child As ToolStripMenuItem In myToolStripMenuItem.DropDownItems

'                'add menu name to list
'                'ToolStripMenuItem, menu name, depth, parent name
'                menuList.Add(New MenuInfo(child, child.Name, depth, myToolStripMenuItem.Name))

'                'add menu name to list
'                'ToolStripMenuItem, depth, parent name
'                'menuList.Add(New MenuInfo(child, depth, myToolStripMenuItem.Name))

'                'recursivesly call function to get all children
'                getToolStripChildMenuNames(child, menuList, depth)
'            Next

'            'decrement depth
'            depth -= 1
'        Catch ex As Exception
'            errMessage = "getToolStripChildMenuNames: " & ex.Message
'            MessageBox.Show(errMessage)
'            _ToolStripStatusLabel1.Text = errMessage
'            _StatusStrip1.Refresh()
'        End Try

'    End Sub

'End Module
