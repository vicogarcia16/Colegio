<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Panel1 = New Panel()
        Button1 = New Button()
        Label1 = New Label()
        Panel3 = New Panel()
        MenuStrip2 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        txtBusca = New TextBox()
        dataListado = New DataGridView()
        Panel4 = New Panel()
        Panel5 = New Panel()
        CheckBox9 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label5 = New Label()
        TextBox2 = New TextBox()
        Label4 = New Label()
        MenuStrip1 = New MenuStrip()
        GuardarToolStripMenuItem = New ToolStripMenuItem()
        GuardarCambiosToolStripMenuItem = New ToolStripMenuItem()
        TextBox1 = New TextBox()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        MenuStrip2.SuspendLayout()
        CType(dataListado, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(977, 57)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.Location = New Point(930, 10)
        Button1.Name = "Button1"
        Button1.Size = New Size(38, 36)
        Button1.TabIndex = 1
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(9, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 28)
        Label1.TabIndex = 0
        Label1.Text = "Usuarios"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(MenuStrip2)
        Panel3.Controls.Add(txtBusca)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 57)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(977, 59)
        Panel3.TabIndex = 1
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.BackColor = Color.Transparent
        MenuStrip2.Dock = DockStyle.None
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1})
        MenuStrip2.Location = New Point(9, 17)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(42, 28)
        MenuStrip2.TabIndex = 3
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.BackColor = Color.Transparent
        ToolStripMenuItem1.Font = New Font("Segoe UI", 12F)
        ToolStripMenuItem1.ForeColor = Color.White
        ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), Image)
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(34, 24)
        ' 
        ' txtBusca
        ' 
        txtBusca.Font = New Font("Segoe UI", 10F)
        txtBusca.Location = New Point(54, 15)
        txtBusca.Name = "txtBusca"
        txtBusca.Size = New Size(390, 30)
        txtBusca.TabIndex = 0
        ' 
        ' dataListado
        ' 
        dataListado.AllowUserToAddRows = False
        dataListado.AllowUserToDeleteRows = False
        dataListado.AllowUserToResizeRows = False
        dataListado.BackgroundColor = Color.White
        dataListado.BorderStyle = BorderStyle.None
        dataListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataListado.Dock = DockStyle.Fill
        dataListado.Location = New Point(0, 0)
        dataListado.Name = "dataListado"
        dataListado.RowHeadersWidth = 51
        dataListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dataListado.Size = New Size(977, 537)
        dataListado.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Panel5)
        Panel4.Controls.Add(TextBox3)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(TextBox2)
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(MenuStrip1)
        Panel4.Controls.Add(TextBox1)
        Panel4.Controls.Add(Label2)
        Panel4.Location = New Point(125, 137)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(700, 353)
        Panel4.TabIndex = 3
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(CheckBox9)
        Panel5.Controls.Add(CheckBox8)
        Panel5.Controls.Add(CheckBox7)
        Panel5.Controls.Add(CheckBox6)
        Panel5.Controls.Add(CheckBox5)
        Panel5.Controls.Add(CheckBox4)
        Panel5.Controls.Add(CheckBox3)
        Panel5.Controls.Add(CheckBox2)
        Panel5.Controls.Add(CheckBox1)
        Panel5.Controls.Add(Label3)
        Panel5.Location = New Point(452, 3)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(245, 347)
        Panel5.TabIndex = 7
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.BackColor = Color.Transparent
        CheckBox9.Font = New Font("Segoe UI", 10F)
        CheckBox9.ForeColor = Color.Brown
        CheckBox9.Location = New Point(14, 313)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(99, 27)
        CheckBox9.TabIndex = 12
        CheckBox9.Text = "Reportes"
        CheckBox9.UseVisualStyleBackColor = False
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.BackColor = Color.Transparent
        CheckBox8.Font = New Font("Segoe UI", 10F)
        CheckBox8.ForeColor = Color.Brown
        CheckBox8.Location = New Point(14, 280)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(84, 27)
        CheckBox8.TabIndex = 11
        CheckBox8.Text = "Kardex"
        CheckBox8.UseVisualStyleBackColor = False
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.BackColor = Color.Transparent
        CheckBox7.Font = New Font("Segoe UI", 10F)
        CheckBox7.ForeColor = Color.Brown
        CheckBox7.Location = New Point(14, 247)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(114, 27)
        CheckBox7.TabIndex = 10
        CheckBox7.Text = "Asistencias"
        CheckBox7.UseVisualStyleBackColor = False
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.BackColor = Color.Transparent
        CheckBox6.Font = New Font("Segoe UI", 10F)
        CheckBox6.ForeColor = Color.Brown
        CheckBox6.Location = New Point(14, 214)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(132, 27)
        CheckBox6.TabIndex = 9
        CheckBox6.Text = "Gastos varios"
        CheckBox6.UseVisualStyleBackColor = False
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.BackColor = Color.Transparent
        CheckBox5.Font = New Font("Segoe UI", 10F)
        CheckBox5.ForeColor = Color.Brown
        CheckBox5.Location = New Point(14, 181)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(145, 27)
        CheckBox5.TabIndex = 8
        CheckBox5.Text = "Ingresos varios"
        CheckBox5.UseVisualStyleBackColor = False
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.BackColor = Color.Transparent
        CheckBox4.Font = New Font("Segoe UI", 10F)
        CheckBox4.ForeColor = Color.Brown
        CheckBox4.Location = New Point(14, 148)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(77, 27)
        CheckBox4.TabIndex = 7
        CheckBox4.Text = "Pagos"
        CheckBox4.UseVisualStyleBackColor = False
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.BackColor = Color.Transparent
        CheckBox3.Font = New Font("Segoe UI", 10F)
        CheckBox3.ForeColor = Color.Brown
        CheckBox3.Location = New Point(14, 115)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(86, 27)
        CheckBox3.TabIndex = 6
        CheckBox3.Text = "Cobros"
        CheckBox3.UseVisualStyleBackColor = False
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.BackColor = Color.Transparent
        CheckBox2.Font = New Font("Segoe UI", 10F)
        CheckBox2.ForeColor = Color.Brown
        CheckBox2.Location = New Point(14, 82)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(139, 27)
        CheckBox2.TabIndex = 5
        CheckBox2.Text = "Configuración"
        CheckBox2.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Segoe UI", 10F)
        CheckBox1.ForeColor = Color.Brown
        CheckBox1.Location = New Point(14, 49)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(110, 27)
        CheckBox1.TabIndex = 4
        CheckBox1.Text = "Matriculas"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.ForeColor = Color.DodgerBlue
        Label3.Location = New Point(14, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(212, 25)
        Label3.TabIndex = 3
        Label3.Text = "Asignación de permisos"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 11F)
        TextBox3.Location = New Point(181, 105)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(202, 32)
        TextBox3.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F)
        Label5.Location = New Point(63, 107)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 25)
        Label5.TabIndex = 5
        Label5.Text = "Contraseña:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 11F)
        TextBox2.Location = New Point(181, 65)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(202, 32)
        TextBox2.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F)
        Label4.Location = New Point(87, 65)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 25)
        Label4.TabIndex = 3
        Label4.Text = "Usuario:"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Transparent
        MenuStrip1.Dock = DockStyle.Bottom
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {GuardarToolStripMenuItem, GuardarCambiosToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 322)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(700, 31)
        MenuStrip1.TabIndex = 8
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' GuardarToolStripMenuItem
        ' 
        GuardarToolStripMenuItem.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        GuardarToolStripMenuItem.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        GuardarToolStripMenuItem.Size = New Size(89, 27)
        GuardarToolStripMenuItem.Text = "Guardar"
        ' 
        ' GuardarCambiosToolStripMenuItem
        ' 
        GuardarCambiosToolStripMenuItem.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        GuardarCambiosToolStripMenuItem.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        GuardarCambiosToolStripMenuItem.Name = "GuardarCambiosToolStripMenuItem"
        GuardarCambiosToolStripMenuItem.Size = New Size(160, 27)
        GuardarCambiosToolStripMenuItem.Text = "Guardar cambios"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 11F)
        TextBox1.Location = New Point(181, 26)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(244, 32)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(14, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 25)
        Label2.TabIndex = 0
        Label2.Text = "Nombre completo:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(849, 354)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 136)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Usuarios
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(977, 537)
        Controls.Add(PictureBox1)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(dataListado)
        FormBorderStyle = FormBorderStyle.None
        MainMenuStrip = MenuStrip1
        Name = "Usuarios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Usuarios"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        CType(dataListado, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents txtBusca As TextBox
    Friend WithEvents dataListado As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel4.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel4.Visible = True
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub

    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarCambiosToolStripMenuItem As ToolStripMenuItem
End Class
