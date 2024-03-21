<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Log_button = New Button()
        Reg_button = New Button()
        Exit_but = New PictureBox()
        Panel_reg1 = New Panel()
        ShowRegPwd = New CheckBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        reg_pas_conf = New TextBox()
        reg_pas_text = New TextBox()
        final_reg_but = New Button()
        PictureBox7 = New PictureBox()
        reg_usr_text = New TextBox()
        Panel_log1 = New Panel()
        ShowPassword = New CheckBox()
        final_log_but = New Button()
        PictureBox6 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox9 = New PictureBox()
        log_pas_text = New TextBox()
        log_usr_text = New TextBox()
        Minimize_but = New PictureBox()
        Panel_log_but = New Panel()
        Panel_reg_but = New Panel()
        CType(Exit_but, ComponentModel.ISupportInitialize).BeginInit()
        Panel_reg1.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        Panel_log1.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(Minimize_but, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Log_button
        ' 
        Log_button.FlatAppearance.BorderSize = 0
        Log_button.FlatStyle = FlatStyle.Flat
        Log_button.Font = New Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Log_button.ForeColor = Color.FromArgb(CByte(25), CByte(253), CByte(0))
        Log_button.Location = New Point(7, 46)
        Log_button.Margin = New Padding(2)
        Log_button.Name = "Log_button"
        Log_button.Size = New Size(330, 96)
        Log_button.TabIndex = 0
        Log_button.Text = "Login"
        Log_button.UseVisualStyleBackColor = True
        ' 
        ' Reg_button
        ' 
        Reg_button.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        Reg_button.FlatAppearance.BorderSize = 0
        Reg_button.FlatStyle = FlatStyle.Flat
        Reg_button.Font = New Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Reg_button.ForeColor = Color.FromArgb(CByte(25), CByte(253), CByte(0))
        Reg_button.Location = New Point(335, 46)
        Reg_button.Margin = New Padding(2)
        Reg_button.Name = "Reg_button"
        Reg_button.Size = New Size(326, 96)
        Reg_button.TabIndex = 1
        Reg_button.Text = "Register"
        Reg_button.UseVisualStyleBackColor = False
        ' 
        ' Exit_but
        ' 
        Exit_but.ErrorImage = CType(resources.GetObject("Exit_but.ErrorImage"), Image)
        Exit_but.ImageLocation = "../images/exit-24-new.png"
        Exit_but.Location = New Point(645, 10)
        Exit_but.Margin = New Padding(2)
        Exit_but.Name = "Exit_but"
        Exit_but.Size = New Size(19, 19)
        Exit_but.TabIndex = 2
        Exit_but.TabStop = False
        ' 
        ' Panel_reg1
        ' 
        Panel_reg1.Controls.Add(ShowRegPwd)
        Panel_reg1.Controls.Add(Label3)
        Panel_reg1.Controls.Add(Label2)
        Panel_reg1.Controls.Add(Label1)
        Panel_reg1.Controls.Add(reg_pas_conf)
        Panel_reg1.Controls.Add(reg_pas_text)
        Panel_reg1.Controls.Add(final_reg_but)
        Panel_reg1.Controls.Add(PictureBox7)
        Panel_reg1.Controls.Add(reg_usr_text)
        Panel_reg1.Location = New Point(5, 146)
        Panel_reg1.Margin = New Padding(2)
        Panel_reg1.Name = "Panel_reg1"
        Panel_reg1.Size = New Size(653, 439)
        Panel_reg1.TabIndex = 7
        ' 
        ' ShowRegPwd
        ' 
        ShowRegPwd.AutoSize = True
        ShowRegPwd.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        ShowRegPwd.ForeColor = Color.FromArgb(CByte(25), CByte(253), CByte(0))
        ShowRegPwd.Location = New Point(108, 291)
        ShowRegPwd.Name = "ShowRegPwd"
        ShowRegPwd.Size = New Size(157, 28)
        ShowRegPwd.TabIndex = 12
        ShowRegPwd.Text = "Show password"
        ShowRegPwd.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(25), CByte(253), CByte(0))
        Label3.Location = New Point(108, 110)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 24)
        Label3.TabIndex = 11
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(25), CByte(253), CByte(0))
        Label2.Location = New Point(108, 203)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 24)
        Label2.TabIndex = 10
        Label2.Text = "Confirm password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(25), CByte(253), CByte(0))
        Label1.Location = New Point(108, 12)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 24)
        Label1.TabIndex = 9
        Label1.Text = "Username"
        ' 
        ' reg_pas_conf
        ' 
        reg_pas_conf.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        reg_pas_conf.BorderStyle = BorderStyle.None
        reg_pas_conf.Font = New Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        reg_pas_conf.ForeColor = Color.White
        reg_pas_conf.Location = New Point(108, 229)
        reg_pas_conf.Margin = New Padding(2)
        reg_pas_conf.Name = "reg_pas_conf"
        reg_pas_conf.Size = New Size(439, 38)
        reg_pas_conf.TabIndex = 8
        ' 
        ' reg_pas_text
        ' 
        reg_pas_text.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        reg_pas_text.BorderStyle = BorderStyle.None
        reg_pas_text.Font = New Font("Arial", 20F)
        reg_pas_text.ForeColor = Color.White
        reg_pas_text.Location = New Point(108, 136)
        reg_pas_text.Margin = New Padding(2)
        reg_pas_text.Name = "reg_pas_text"
        reg_pas_text.Size = New Size(439, 39)
        reg_pas_text.TabIndex = 7
        ' 
        ' final_reg_but
        ' 
        final_reg_but.BackColor = Color.FromArgb(CByte(25), CByte(253), CByte(0))
        final_reg_but.Cursor = Cursors.Hand
        final_reg_but.FlatAppearance.BorderColor = Color.DimGray
        final_reg_but.FlatAppearance.BorderSize = 0
        final_reg_but.FlatStyle = FlatStyle.Flat
        final_reg_but.Font = New Font("Arial", 18F, FontStyle.Bold)
        final_reg_but.ForeColor = Color.FromArgb(CByte(34), CByte(34), CByte(34))
        final_reg_but.Location = New Point(108, 340)
        final_reg_but.Margin = New Padding(2)
        final_reg_but.Name = "final_reg_but"
        final_reg_but.Size = New Size(438, 65)
        final_reg_but.TabIndex = 6
        final_reg_but.Text = "Register"
        final_reg_but.UseVisualStyleBackColor = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.ErrorImage = CType(resources.GetObject("PictureBox7.ErrorImage"), Image)
        PictureBox7.ImageLocation = "../images/exit1.png"
        PictureBox7.Location = New Point(301, 146)
        PictureBox7.Margin = New Padding(2)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(0, 0)
        PictureBox7.TabIndex = 3
        PictureBox7.TabStop = False
        ' 
        ' reg_usr_text
        ' 
        reg_usr_text.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        reg_usr_text.BorderStyle = BorderStyle.None
        reg_usr_text.Font = New Font("Arial", 20F)
        reg_usr_text.ForeColor = Color.White
        reg_usr_text.Location = New Point(108, 41)
        reg_usr_text.Margin = New Padding(2)
        reg_usr_text.Name = "reg_usr_text"
        reg_usr_text.Size = New Size(439, 39)
        reg_usr_text.TabIndex = 0
        ' 
        ' Panel_log1
        ' 
        Panel_log1.Controls.Add(ShowPassword)
        Panel_log1.Controls.Add(final_log_but)
        Panel_log1.Controls.Add(PictureBox6)
        Panel_log1.Controls.Add(PictureBox8)
        Panel_log1.Controls.Add(PictureBox9)
        Panel_log1.Controls.Add(log_pas_text)
        Panel_log1.Controls.Add(log_usr_text)
        Panel_log1.Location = New Point(7, 144)
        Panel_log1.Margin = New Padding(2)
        Panel_log1.Name = "Panel_log1"
        Panel_log1.Size = New Size(653, 439)
        Panel_log1.TabIndex = 8
        ' 
        ' ShowPassword
        ' 
        ShowPassword.AutoSize = True
        ShowPassword.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        ShowPassword.ForeColor = Color.FromArgb(CByte(25), CByte(253), CByte(0))
        ShowPassword.Location = New Point(249, 244)
        ShowPassword.Name = "ShowPassword"
        ShowPassword.Size = New Size(157, 28)
        ShowPassword.TabIndex = 7
        ShowPassword.Text = "Show password"
        ShowPassword.UseVisualStyleBackColor = True
        ' 
        ' final_log_but
        ' 
        final_log_but.BackColor = Color.FromArgb(CByte(25), CByte(253), CByte(0))
        final_log_but.Cursor = Cursors.Hand
        final_log_but.FlatAppearance.BorderSize = 0
        final_log_but.FlatStyle = FlatStyle.Flat
        final_log_but.Font = New Font("Arial", 18F, FontStyle.Bold)
        final_log_but.ForeColor = Color.FromArgb(CByte(34), CByte(34), CByte(34))
        final_log_but.Location = New Point(110, 307)
        final_log_but.Margin = New Padding(2)
        final_log_but.Name = "final_log_but"
        final_log_but.Size = New Size(438, 65)
        final_log_but.TabIndex = 6
        final_log_but.Text = "Login"
        final_log_but.UseVisualStyleBackColor = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.ErrorImage = CType(resources.GetObject("PictureBox6.ErrorImage"), Image)
        PictureBox6.ImageLocation = "../../images/user-48.png"
        PictureBox6.Location = New Point(110, 86)
        PictureBox6.Margin = New Padding(2)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(48, 48)
        PictureBox6.TabIndex = 5
        PictureBox6.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.ErrorImage = CType(resources.GetObject("PictureBox8.ErrorImage"), Image)
        PictureBox8.ImageLocation = "../../images/lock-48.png"
        PictureBox8.Location = New Point(110, 162)
        PictureBox8.Margin = New Padding(2)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(48, 48)
        PictureBox8.TabIndex = 4
        PictureBox8.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.ErrorImage = CType(resources.GetObject("PictureBox9.ErrorImage"), Image)
        PictureBox9.ImageLocation = "../images/exit1.png"
        PictureBox9.Location = New Point(305, 186)
        PictureBox9.Margin = New Padding(2)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(0, 0)
        PictureBox9.TabIndex = 3
        PictureBox9.TabStop = False
        ' 
        ' log_pas_text
        ' 
        log_pas_text.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        log_pas_text.BorderStyle = BorderStyle.None
        log_pas_text.Font = New Font("Segoe UI", 20F)
        log_pas_text.ForeColor = Color.White
        log_pas_text.Location = New Point(185, 165)
        log_pas_text.Margin = New Padding(2)
        log_pas_text.Name = "log_pas_text"
        log_pas_text.Size = New Size(363, 45)
        log_pas_text.TabIndex = 1
        ' 
        ' log_usr_text
        ' 
        log_usr_text.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        log_usr_text.BorderStyle = BorderStyle.None
        log_usr_text.Font = New Font("Segoe UI", 20F)
        log_usr_text.ForeColor = Color.White
        log_usr_text.Location = New Point(185, 86)
        log_usr_text.Margin = New Padding(2)
        log_usr_text.Name = "log_usr_text"
        log_usr_text.Size = New Size(363, 45)
        log_usr_text.TabIndex = 0
        ' 
        ' Minimize_but
        ' 
        Minimize_but.ErrorImage = CType(resources.GetObject("Minimize_but.ErrorImage"), Image)
        Minimize_but.ImageLocation = "../../images/almost.png"
        Minimize_but.InitialImage = CType(resources.GetObject("Minimize_but.InitialImage"), Image)
        Minimize_but.Location = New Point(614, 10)
        Minimize_but.Margin = New Padding(2)
        Minimize_but.Name = "Minimize_but"
        Minimize_but.Size = New Size(19, 19)
        Minimize_but.TabIndex = 4
        Minimize_but.TabStop = False
        ' 
        ' Panel_log_but
        ' 
        Panel_log_but.BackColor = Color.FromArgb(CByte(25), CByte(253), CByte(0))
        Panel_log_but.Location = New Point(10, 44)
        Panel_log_but.Name = "Panel_log_but"
        Panel_log_but.Size = New Size(327, 4)
        Panel_log_but.TabIndex = 13
        ' 
        ' Panel_reg_but
        ' 
        Panel_reg_but.Location = New Point(335, 44)
        Panel_reg_but.Name = "Panel_reg_but"
        Panel_reg_but.Size = New Size(325, 4)
        Panel_reg_but.TabIndex = 14
        ' 
        ' Form
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(34), CByte(34))
        ClientSize = New Size(674, 594)
        Controls.Add(Panel_reg1)
        Controls.Add(Panel_log1)
        Controls.Add(Panel_reg_but)
        Controls.Add(Panel_log_but)
        Controls.Add(Minimize_but)
        Controls.Add(Exit_but)
        Controls.Add(Reg_button)
        Controls.Add(Log_button)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(Exit_but, ComponentModel.ISupportInitialize).EndInit()
        Panel_reg1.ResumeLayout(False)
        Panel_reg1.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        Panel_log1.ResumeLayout(False)
        Panel_log1.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(Minimize_but, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Log_button As Button
    Friend WithEvents Reg_button As Button
    Friend WithEvents Exit_but As PictureBox
    Friend WithEvents Panel_reg1 As Panel
    Friend WithEvents reg_pas_conf As TextBox
    Friend WithEvents reg_pas_text As TextBox
    Friend WithEvents final_reg_but As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents reg_usr_text As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Minimize_but As PictureBox
    Friend WithEvents Panel_log_but As Panel
    Friend WithEvents Panel_reg_but As Panel
    Friend WithEvents Panel_log1 As Panel
    Friend WithEvents final_log_but As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents log_pas_text As TextBox
    Friend WithEvents log_usr_text As TextBox
    Friend WithEvents ShowPassword As CheckBox
    Friend WithEvents ShowRegPwd As CheckBox

End Class
