<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Form))
        Me.TitleLogin_Panel = New System.Windows.Forms.Panel()
        Me.Logo_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Login_Panel = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Exit_Botton = New System.Windows.Forms.Button()
        Me.Enter_Button = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Experimental_Button = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Password_PictureBox = New System.Windows.Forms.PictureBox()
        Me.User_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Login_ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Login_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TitleLogin_Panel.SuspendLayout()
        CType(Me.Logo_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Password_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLogin_Panel
        '
        Me.TitleLogin_Panel.BackColor = System.Drawing.SystemColors.Desktop
        Me.TitleLogin_Panel.Controls.Add(Me.Logo_PictureBox)
        Me.TitleLogin_Panel.Controls.Add(Me.Label3)
        Me.TitleLogin_Panel.Location = New System.Drawing.Point(0, 72)
        Me.TitleLogin_Panel.Name = "TitleLogin_Panel"
        Me.TitleLogin_Panel.Size = New System.Drawing.Size(421, 46)
        Me.TitleLogin_Panel.TabIndex = 19
        '
        'Logo_PictureBox
        '
        Me.Logo_PictureBox.ErrorImage = Nothing
        Me.Logo_PictureBox.Image = CType(resources.GetObject("Logo_PictureBox.Image"), System.Drawing.Image)
        Me.Logo_PictureBox.Location = New System.Drawing.Point(366, -1)
        Me.Logo_PictureBox.Name = "Logo_PictureBox"
        Me.Logo_PictureBox.Size = New System.Drawing.Size(63, 55)
        Me.Logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo_PictureBox.TabIndex = 12
        Me.Logo_PictureBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(10, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "LOGIN"
        '
        'Login_Panel
        '
        Me.Login_Panel.BackColor = System.Drawing.Color.DarkCyan
        Me.Login_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Login_Panel.Name = "Login_Panel"
        Me.Login_Panel.Size = New System.Drawing.Size(484, 46)
        Me.Login_Panel.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Exit_Botton)
        Me.GroupBox1.Controls.Add(Me.Enter_Button)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Experimental_Button)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Controls.Add(Me.Password_PictureBox)
        Me.GroupBox1.Controls.Add(Me.User_PictureBox)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 153)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'Exit_Botton
        '
        Me.Exit_Botton.BackColor = System.Drawing.Color.PowderBlue
        Me.Exit_Botton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Botton.Location = New System.Drawing.Point(199, 112)
        Me.Exit_Botton.Name = "Exit_Botton"
        Me.Exit_Botton.Size = New System.Drawing.Size(70, 33)
        Me.Exit_Botton.TabIndex = 16
        Me.Exit_Botton.Text = "Salir"
        Me.Exit_Botton.UseVisualStyleBackColor = False
        '
        'Enter_Button
        '
        Me.Enter_Button.BackColor = System.Drawing.Color.PowderBlue
        Me.Enter_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enter_Button.Location = New System.Drawing.Point(109, 112)
        Me.Enter_Button.Name = "Enter_Button"
        Me.Enter_Button.Size = New System.Drawing.Size(70, 33)
        Me.Enter_Button.TabIndex = 15
        Me.Enter_Button.Text = "Entrar"
        Me.Enter_Button.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(109, 69)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(161, 26)
        Me.txtPassword.TabIndex = 3
        '
        'Experimental_Button
        '
        Me.Experimental_Button.BackColor = System.Drawing.Color.PowderBlue
        Me.Experimental_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Experimental_Button.Location = New System.Drawing.Point(6, 110)
        Me.Experimental_Button.Name = "Experimental_Button"
        Me.Experimental_Button.Size = New System.Drawing.Size(85, 36)
        Me.Experimental_Button.TabIndex = 13
        Me.Experimental_Button.Text = "Ingresar"
        Me.Experimental_Button.UseVisualStyleBackColor = False
        Me.Experimental_Button.Visible = False
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(109, 28)
        Me.txtUser.Multiline = True
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(161, 26)
        Me.txtUser.TabIndex = 2
        '
        'Password_PictureBox
        '
        Me.Password_PictureBox.Image = CType(resources.GetObject("Password_PictureBox.Image"), System.Drawing.Image)
        Me.Password_PictureBox.Location = New System.Drawing.Point(64, 63)
        Me.Password_PictureBox.Name = "Password_PictureBox"
        Me.Password_PictureBox.Size = New System.Drawing.Size(48, 41)
        Me.Password_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Password_PictureBox.TabIndex = 11
        Me.Password_PictureBox.TabStop = False
        '
        'User_PictureBox
        '
        Me.User_PictureBox.Image = CType(resources.GetObject("User_PictureBox.Image"), System.Drawing.Image)
        Me.User_PictureBox.Location = New System.Drawing.Point(64, 19)
        Me.User_PictureBox.Name = "User_PictureBox"
        Me.User_PictureBox.Size = New System.Drawing.Size(49, 46)
        Me.User_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.User_PictureBox.TabIndex = 10
        Me.User_PictureBox.TabStop = False
        '
        'Login_ProgressBar
        '
        Me.Login_ProgressBar.Location = New System.Drawing.Point(88, 282)
        Me.Login_ProgressBar.Name = "Login_ProgressBar"
        Me.Login_ProgressBar.Size = New System.Drawing.Size(222, 10)
        Me.Login_ProgressBar.TabIndex = 16
        Me.Login_ProgressBar.Visible = False
        '
        'Login_Timer
        '
        '
        'Login_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(434, 336)
        Me.Controls.Add(Me.TitleLogin_Panel)
        Me.Controls.Add(Me.Login_Panel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Login_ProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "Login_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TitleLogin_Panel.ResumeLayout(False)
        Me.TitleLogin_Panel.PerformLayout()
        CType(Me.Logo_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Password_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleLogin_Panel As Panel
    Friend WithEvents Logo_PictureBox As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Login_Panel As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Enter_Button As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Experimental_Button As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Password_PictureBox As PictureBox
    Friend WithEvents User_PictureBox As PictureBox
    Friend WithEvents Login_ProgressBar As ProgressBar
    Friend WithEvents Login_Timer As Timer
    Friend WithEvents Exit_Botton As Button
End Class
