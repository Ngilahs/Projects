Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class frmWorkCategory
    'Work_Cate_No, Work_Cate_Name, Rate, Measure, Description
    Dim y As Integer
    Private Sub AddWorkCategory()

        If Len(Trim(txtWcateName.Text)) = 0 Then
            MessageBox.Show("Please enter Work category Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtWcateName.Focus()
            Exit Sub
        End If
        If Len(Trim(txtRate.Text)) = 0 Then
            MessageBox.Show("Please enter Work Rate", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRate.Focus()
            Exit Sub
        End If
        If Len(Trim(txtMeasure.Text)) = 0 Then
            MessageBox.Show("Please enter Work Measure.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMeasure.Focus()
            Exit Sub
        End If
        Try
            sqL = "INSERT INTO workcategory(Work_Cate_Name, Rate, Measure, Description) VALUES (@d2, @d3, @d4, @d5)"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@d2", txtWcateName.Text)
            cmd.Parameters.AddWithValue("@d3", txtRate.Text)
            cmd.Parameters.AddWithValue("@d4", txtMeasure.Text)
            cmd.Parameters.AddWithValue("@d5", txtDescription.Text)
            dr = cmd.ExecuteReader
            MsgBox("Work Category successfully added.", MsgBoxStyle.Information, "Add Work Category")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtWcateName.Text, TimeOfDay, "Added New Work Category")
        clear()
        txtWcateName.Focus()
    End Sub

    Private Sub clear()
        txtworkcategoryNo.Text = ""
        txtWcateName.Text = ""
        txtRate.Text = ""
        txtMeasure.Text = ""
        txtDescription.Text = ""
    End Sub
    Private Sub UpdateWorkCategory()
        Try
            If Len(Trim(txtworkcategoryNo.Text)) = 0 Then
                MessageBox.Show("Please select Work category name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtWcateName.Focus()
                Exit Sub
            End If
            sqL = "UPDATE workcategory SET Work_Cate_Name=@d2, Rate=@d3, Measure=@d4, Description=@d5 WHERE Work_Cate_No = '" & txtworkcategoryNo.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@d2", txtWcateName.Text.ToString)
            cmd.Parameters.AddWithValue("@d3", txtRate.Text.ToString)
            cmd.Parameters.AddWithValue("@d4", txtMeasure.Text.ToString)
            cmd.Parameters.AddWithValue("@d5", txtDescription.Text.ToString)

            If MessageBox.Show("Are you sure want to update the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                dr = cmd.ExecuteReader
                MessageBox.Show("Successfully updated", "Work Category Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        'Update Audit Trail Table
        Audit_Trail(FrmMain.tsslUser.Text, txtWcateName.Text, TimeOfDay, "Updated work category Details")
        clear()
        txtWcateName.Focus()
    End Sub

    Private Sub txtsearchwCatename_TextChanged(sender As Object, e As EventArgs) Handles txtsearchwCatename.TextChanged
        Try
            sqL = "Select Work_Cate_No, Work_Cate_Name, Rate, Measure, Description from workcategory where Work_Cate_Name like '%" & txtsearchwCatename.Text & "%'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            dgwworkcategory.Rows.Clear()
            y = 0
            Do While dr.Read = True
                dgwworkcategory.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4))
                y += 17
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub dgwworkcategory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwworkcategory.CellContentClick
        Dim i As Integer
        i = dgwworkcategory.CurrentRow.Index
        Me.txtworkcategoryNo.Text = dgwworkcategory.Item(0, i).Value
        Me.txtWcateName.Text = dgwworkcategory.Item(1, i).Value
        Me.txtRate.Text = dgwworkcategory.Item(2, i).Value
        Me.txtMeasure.Text = dgwworkcategory.Item(3, i).Value
        Me.txtDescription.Text = dgwworkcategory.Item(4, i).Value
        CreateWorkCategorySave.Enabled = False
    End Sub

    Private Sub CreateDepartmentSave_Click(sender As Object, e As EventArgs) Handles CreateWorkCategorySave.Click
        AddWorkCategory()
        clear()
        dgwworkcategory.Rows.Clear()
    End Sub

    Private Sub updateDepartment_Click(sender As Object, e As EventArgs) Handles updateDepartment.Click
        UpdateWorkCategory()
        dgwworkcategory.Rows.Clear()
        CreateWorkCategorySave.Enabled = True
    End Sub

    Private Sub btnNewItem_Click(sender As Object, e As EventArgs) Handles btnNewItem.Click
        clear()
        dgwworkcategory.Rows.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class