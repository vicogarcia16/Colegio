<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        txtLogin = New TextBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        txtPassword = New TextBox()
        Label2 = New Label()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.Location = New Point(504, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(38, 36)
        Button1.TabIndex = 0
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(137, 70)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(279, 231)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 20F)
        Label1.Location = New Point(211, 304)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 41)
        Label1.TabIndex = 2
        Label1.Text = "Acceder"
        ' 
        ' txtLogin
        ' 
        txtLogin.BorderStyle = BorderStyle.None
        txtLogin.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        txtLogin.Location = New Point(137, 364)
        txtLogin.Name = "txtLogin"
        txtLogin.Size = New Size(279, 25)
        txtLogin.TabIndex = 3
        txtLogin.Text = "usuario"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DimGray
        Panel1.Location = New Point(136, 393)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(280, 1)
        Panel1.TabIndex = 5
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DimGray
        Panel2.Location = New Point(136, 438)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(280, 1)
        Panel2.TabIndex = 7
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 11F)
        txtPassword.Location = New Point(137, 409)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(279, 25)
        txtPassword.TabIndex = 6
        txtPassword.Text = "Contraseña"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(136, 442)
        Label2.Name = "Label2"
        Label2.Size = New Size(172, 25)
        Label2.TabIndex = 8
        Label2.Text = "Ingrese contraseña"
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.HotTrack
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(137, 499)
        Button2.Name = "Button2"
        Button2.Size = New Size(279, 63)
        Button2.TabIndex = 9
        Button2.Text = "Iniciar Sesión"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(548, 626)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(txtPassword)
        Controls.Add(Panel1)
        Controls.Add(txtLogin)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button

End Class
