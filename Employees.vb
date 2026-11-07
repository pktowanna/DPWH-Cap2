Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class Employees

    Private Sub Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayEmployees()
    End Sub
    Public Sub DisplayEmployees()
        Dim connString As String = GlobalConnectionString

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Dim query As String = "SELECT employeeid, employeename, employeedesignation FROM employee"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        employeesdgv.Rows.Clear()
                        While reader.Read()
                            employeesdgv.Rows.Add(
                            reader("employeeid").ToString(),
                            reader("employeename").ToString(),
                            reader("employeedesignation").ToString()
                        )
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading employee: " & ex.Message)
        End Try
    End Sub




    Public Sub AddNewEmployee()
        If String.IsNullOrWhiteSpace(employeefirstnametxt.Text) OrElse
       String.IsNullOrWhiteSpace(employeemiddleinitialtxt.Text) OrElse
       String.IsNullOrWhiteSpace(employeelastnametxt.Text) OrElse
       String.IsNullOrWhiteSpace(employeedesignationtxt.Text) Then
            MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim fullName As String = employeefirstnametxt.Text.Trim() & " " &
                             employeemiddleinitialtxt.Text.Trim().ToUpper() & ". " &
                             employeelastnametxt.Text.Trim()

        Dim connString As String = GlobalConnectionString

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Dim checkQuery As String = "SELECT COUNT(*) FROM employee WHERE employeename = @name"
                Using checkCmd As New MySqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@name", fullName)
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("This employee already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                Dim insertQuery As String = "INSERT INTO employee (employeename, employeedesignation) VALUES (@name, @designation)"
                Using cmd As New MySqlCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@name", fullName)
                    cmd.Parameters.AddWithValue("@designation", employeedesignationtxt.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            employeefirstnametxt.Clear()
            employeemiddleinitialtxt.Clear()
            employeelastnametxt.Clear()
            employeedesignationtxt.Clear()
            DisplayEmployees()
            MessageBox.Show("Employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error adding employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub UpdateEmployee()
        If String.IsNullOrWhiteSpace(employeeidlbl.Text) OrElse
       String.IsNullOrWhiteSpace(employeefirstnametxt.Text) OrElse
       String.IsNullOrWhiteSpace(employeemiddleinitialtxt.Text) OrElse
       String.IsNullOrWhiteSpace(employeelastnametxt.Text) OrElse
       String.IsNullOrWhiteSpace(employeedesignationtxt.Text) Then
            MessageBox.Show("Please select an employee and fill all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim employeeId As Integer
        If Not Integer.TryParse(employeeidlbl.Text, employeeId) Then
            MessageBox.Show("Invalid Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim fullName As String = employeefirstnametxt.Text.Trim() & " " &
                             employeemiddleinitialtxt.Text.Trim().ToUpper() & ". " &
                             employeelastnametxt.Text.Trim()

        Dim connString As String = GlobalConnectionString

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim updateQuery As String = "UPDATE employee SET employeename = @name, employeedesignation = @designation WHERE employeeid = @id"
                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@name", fullName)
                    cmd.Parameters.AddWithValue("@designation", employeedesignationtxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@id", employeeId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            employeeidlbl.Text = ""
            employeefirstnametxt.Clear()
            employeemiddleinitialtxt.Clear()
            employeelastnametxt.Clear()
            employeedesignationtxt.Clear()
            updateemployeebtn.Visible = False
            DisplayEmployees()

            MessageBox.Show("Employee updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error updating employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub addnewemployeebtn_Click(sender As Object, e As EventArgs) Handles addnewemployeebtn.Click
        AddNewEmployee()
        Dashboard.InitializeEmployeeSuggestions()
    End Sub

    Private Sub employeesdgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles employeesdgv.CellClick
        If e.RowIndex < 0 OrElse e.RowIndex >= employeesdgv.Rows.Count Then
            updateemployeebtn.Visible = False
            Return
        End If

        Dim selectedRow As DataGridViewRow = employeesdgv.Rows(e.RowIndex)
        If selectedRow.Cells("employeeid").Value Is Nothing Then
            updateemployeebtn.Visible = False
            Return
        End If

        Dim selectedId As Integer
        If Not Integer.TryParse(selectedRow.Cells("employeeid").Value.ToString(), selectedId) Then
            updateemployeebtn.Visible = False
            Return
        End If

        Dim connString As String = GlobalConnectionString

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT * FROM employee WHERE employeeid = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", selectedId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            employeeidlbl.Text = reader("employeeid").ToString()
                            Dim fullName As String = reader("employeename").ToString().Trim()
                            Dim designation As String = reader("employeedesignation").ToString().Trim()

                            Dim nameParts() As String = fullName.Split(" "c)
                            If nameParts.Length >= 3 Then
                                Dim middleInitialWithDot As String = nameParts(nameParts.Length - 2)
                                Dim middleInitial As String = middleInitialWithDot.Replace(".", "")
                                employeemiddleinitialtxt.Text = middleInitial
                                employeelastnametxt.Text = nameParts(nameParts.Length - 1)
                                employeefirstnametxt.Text = String.Join(" ", nameParts, 0, nameParts.Length - 2)
                            Else
                                employeefirstnametxt.Text = fullName
                                employeemiddleinitialtxt.Clear()
                                employeelastnametxt.Clear()
                            End If

                            employeedesignationtxt.Text = designation

                            If Not String.IsNullOrWhiteSpace(employeefirstnametxt.Text) AndAlso
                               Not String.IsNullOrWhiteSpace(employeemiddleinitialtxt.Text) AndAlso
                               Not String.IsNullOrWhiteSpace(employeelastnametxt.Text) AndAlso
                               Not String.IsNullOrWhiteSpace(employeedesignationtxt.Text) Then
                                updateemployeebtn.Visible = True
                            Else
                                updateemployeebtn.Visible = False
                            End If
                        Else
                            updateemployeebtn.Visible = False
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving employee details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            updateemployeebtn.Visible = False
        End Try
    End Sub

    Private Sub updateemployeebtn_Click(sender As Object, e As EventArgs) Handles updateemployeebtn.Click
        UpdateEmployee()
        Dashboard.InitializeEmployeeSuggestions()
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Close()
    End Sub

    Private Sub employeesearchtxt_TextChanged(sender As Object, e As EventArgs) Handles employeesearchtxt.TextChanged
        Dim filter As String = employeesearchtxt.Text.Trim().ToLower()

        For Each row As DataGridViewRow In employeesdgv.Rows
            If row.IsNewRow Then Continue For

            Dim id As String = row.Cells("employeeid").Value.ToString().ToLower()
            Dim name As String = row.Cells("employeename").Value.ToString().ToLower()
            Dim desig As String = row.Cells("employeedesignation").Value.ToString().ToLower()

            row.Visible = (id.Contains(filter) OrElse name.Contains(filter) OrElse desig.Contains(filter))
        Next
    End Sub



End Class