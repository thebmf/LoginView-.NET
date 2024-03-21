' Import necessary namespaces for event logging and MySQL database interaction
Imports System.Diagnostics.Eventing.Reader
Imports MySql.Data.MySqlClient

' Define the main form of application
Public Class Form
    ' Declare variables for MySQL connection and command
    Private MysqlConn As MySqlConnection
    Private COMMAND As MySqlCommand

    ' Initialize the form and its components
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Focus on the login password textbox and hide passwords in all password fields
        log_pas_text.Focus()
        log_pas_text.UseSystemPasswordChar = True
        reg_pas_text.UseSystemPasswordChar = True
        reg_pas_conf.UseSystemPasswordChar = True

        ' Show the login panel and hide the registration panel by default
        Panel_log1.Visible = True
        Panel_reg1.Visible = False

    End Sub


    ' Event handler for the Login button click
    Private Sub Log_button_Click(sender As Object, e As EventArgs) Handles Log_button.Click
        ' Bring the login panel to the front and adjust visibility
        Panel_log1.BringToFront()
        Panel_log1.BringToFront()
        Panel_log1.Visible = True
        Panel_reg1.Visible = False

        ' Styling for the active and inactive buttons and panels
        Log_button.BackColor = Color.FromArgb(34, 34, 34)
        Reg_button.BackColor = Color.FromArgb(51, 51, 51)
        Reg_button.ForeColor = Color.FromArgb(25, 253, 0)
        Panel_log_but.BackColor = Color.FromArgb(25, 253, 0)
        Panel_reg_but.BackColor = Color.FromArgb(51, 51, 51)
        log_usr_text.Focus()


    End Sub

    ' Event handler for the Register button click
    Private Sub Reg_button_Click(sender As Object, e As EventArgs) Handles Reg_button.Click
        ' Bring the registration panel to the front and adjust visibility
        Panel_reg1.BringToFront()
        Panel_reg1.Visible = True
        Panel_log1.Visible = False

        ' Styling for the active and inactive buttons and panels
        Reg_button.BackColor = Color.FromArgb(34, 34, 34)
        Log_button.BackColor = Color.FromArgb(51, 51, 51)
        Log_button.ForeColor = Color.FromArgb(25, 253, 0)
        Panel_reg_but.BackColor = Color.FromArgb(25, 253, 0)
        Panel_log_but.BackColor = Color.FromArgb(51, 51, 51)
        reg_usr_text.Focus()
    End Sub

    ' Event handler for the main login button
    Private Sub Final_log_but_Click(sender As Object, e As EventArgs) Handles final_log_but.Click
        ' Initialize and configure the MySQL connection
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; port=3307;uid=root; password='';database=authentication"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            ' Prepare the SQL query for user authentication
            Dim Query As String = "select * from authentication.users where UserName=@username and Password=@password"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            COMMAND.Parameters.AddWithValue("@username", log_usr_text.Text)
            COMMAND.Parameters.AddWithValue("@password", log_pas_text.Text)
            READER = COMMAND.ExecuteReader
            Dim count As Integer = 0

            ' Count matching records
            While READER.Read
                count += 1
            End While

            ' Check login status based on the count of matching records
            If count = 1 Then
                MessageBox.Show("Congratulations! You logged in.")
            ElseIf count > 1 Then
                MessageBox.Show("Duplicate users found.")
            Else
                MessageBox.Show("Username or password incorrect.")
            End If
        Catch ex As Exception
            ' Handle potential errors gracefully
            MessageBox.Show(ex.Message)
        Finally
            ' Ensure the connection is closed and resources are released
            MysqlConn.Close()
            MysqlConn.Dispose()
        End Try
    End Sub

    ' Event handler for the main registration button
    Private Sub final_reg_but_Click(sender As Object, e As EventArgs) Handles final_reg_but.Click
        ' Check if the passwords entered match
        If reg_pas_text.Text <> reg_pas_conf.Text Then
            MessageBox.Show("Passwords do not match.")
            Return
        End If

        ' Initialize and configure the MySQL connection for registration
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; port=3307;uid=root; password='';database=authentication"

        Try
            MysqlConn.Open()
            ' Prepare the SQL query for inserting the new user
            Dim Query As String = "INSERT INTO authentication.users (UserName, Password) VALUES (@username, @password)"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            COMMAND.Parameters.AddWithValue("@username", reg_usr_text.Text)
            COMMAND.Parameters.AddWithValue("@password", reg_pas_text.Text)

            ' Execute the insertion and get the result
            Dim result As Integer = COMMAND.ExecuteNonQuery()

            ' Notify the user based on the outcome of the registration attempt
            If result > 0 Then
                MessageBox.Show("User registered successfully.")
            Else
                MessageBox.Show("Registration failed.")
            End If
        Catch ex As MySqlException When ex.Number = 1062
            ' Handle the specific case of a duplicate username
            MessageBox.Show("Username already exists.")
        Catch ex As Exception
            ' Handle other potential errors gracefully
            MessageBox.Show(ex.Message)
        Finally
            ' Ensure the connection is closed and resources are released
            MysqlConn.Close()
            MysqlConn.Dispose()
        End Try
    End Sub

    ' Event handler for toggling the visibility of the login password
    Private Sub ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        ' Toggle the UseSystemPasswordChar property based on the checkbox state
        If (ShowPassword.Checked) Then
            log_pas_text.UseSystemPasswordChar = False

        Else
            log_pas_text.UseSystemPasswordChar = True
        End If
    End Sub

    ' Event handler for toggling the visibility of the registration passwords
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ShowRegPwd.CheckedChanged
        ' Toggle the UseSystemPasswordChar property for both registration password fields based on the checkbox state
        If (ShowRegPwd.Checked) Then
            reg_pas_text.UseSystemPasswordChar = False
            reg_pas_conf.UseSystemPasswordChar = False

        Else
            reg_pas_text.UseSystemPasswordChar = True
            reg_pas_conf.UseSystemPasswordChar = True
        End If
    End Sub

    ' Event handler for exiting the application
    Private Sub Exit_but_Click(sender As Object, e As EventArgs) Handles Exit_but.Click
        ' Close the application
        Application.Exit()
    End Sub

    ' Event handler for minimizing the application window
    Private Sub Minimize_but_Click(sender As Object, e As EventArgs) Handles Minimize_but.Click
        ' Minimize the form
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class

