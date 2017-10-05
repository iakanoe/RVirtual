<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pregunta1 = New System.Windows.Forms.Label()
        Me.respuesta1 = New System.Windows.Forms.TextBox()
        Me.pregunta2 = New System.Windows.Forms.Label()
        Me.respuesta2 = New System.Windows.Forms.TextBox()
        Me.respuesta3 = New System.Windows.Forms.TextBox()
        Me.pregunta3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiguienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.siguiente = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dbstate = New System.Windows.Forms.Label()
        Me.ubicacion = New System.Windows.Forms.LinkLabel()
        Me.ref = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(278, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(407, 212)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'pregunta1
        '
        Me.pregunta1.AutoSize = True
        Me.pregunta1.Location = New System.Drawing.Point(9, 66)
        Me.pregunta1.Name = "pregunta1"
        Me.pregunta1.Size = New System.Drawing.Size(39, 13)
        Me.pregunta1.TabIndex = 2
        Me.pregunta1.Text = "Label2"
        '
        'respuesta1
        '
        Me.respuesta1.Location = New System.Drawing.Point(12, 82)
        Me.respuesta1.Multiline = True
        Me.respuesta1.Name = "respuesta1"
        Me.respuesta1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.respuesta1.Size = New System.Drawing.Size(260, 42)
        Me.respuesta1.TabIndex = 3
        '
        'pregunta2
        '
        Me.pregunta2.AutoSize = True
        Me.pregunta2.Location = New System.Drawing.Point(9, 128)
        Me.pregunta2.Name = "pregunta2"
        Me.pregunta2.Size = New System.Drawing.Size(39, 13)
        Me.pregunta2.TabIndex = 4
        Me.pregunta2.Text = "Label2"
        '
        'respuesta2
        '
        Me.respuesta2.Location = New System.Drawing.Point(12, 144)
        Me.respuesta2.Multiline = True
        Me.respuesta2.Name = "respuesta2"
        Me.respuesta2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.respuesta2.Size = New System.Drawing.Size(260, 42)
        Me.respuesta2.TabIndex = 5
        '
        'respuesta3
        '
        Me.respuesta3.Location = New System.Drawing.Point(12, 206)
        Me.respuesta3.Multiline = True
        Me.respuesta3.Name = "respuesta3"
        Me.respuesta3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.respuesta3.Size = New System.Drawing.Size(260, 42)
        Me.respuesta3.TabIndex = 7
        '
        'pregunta3
        '
        Me.pregunta3.AutoSize = True
        Me.pregunta3.Location = New System.Drawing.Point(9, 189)
        Me.pregunta3.Name = "pregunta3"
        Me.pregunta3.Size = New System.Drawing.Size(39, 13)
        Me.pregunta3.TabIndex = 6
        Me.pregunta3.Text = "Label2"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HerramientasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(697, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraciónToolStripMenuItem, Me.SiguienteToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'SiguienteToolStripMenuItem
        '
        Me.SiguienteToolStripMenuItem.Name = "SiguienteToolStripMenuItem"
        Me.SiguienteToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.SiguienteToolStripMenuItem.Text = "Siguiente"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'siguiente
        '
        Me.siguiente.Location = New System.Drawing.Point(12, 255)
        Me.siguiente.Name = "siguiente"
        Me.siguiente.Size = New System.Drawing.Size(260, 23)
        Me.siguiente.TabIndex = 9
        Me.siguiente.Text = "Siguiente"
        Me.siguiente.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Estado de Base de Datos:"
        '
        'dbstate
        '
        Me.dbstate.AutoSize = True
        Me.dbstate.ForeColor = System.Drawing.Color.Red
        Me.dbstate.Location = New System.Drawing.Point(137, 283)
        Me.dbstate.Name = "dbstate"
        Me.dbstate.Size = New System.Drawing.Size(39, 13)
        Me.dbstate.TabIndex = 11
        Me.dbstate.Text = "Label3"
        '
        'ubicacion
        '
        Me.ubicacion.AutoSize = True
        Me.ubicacion.Location = New System.Drawing.Point(275, 283)
        Me.ubicacion.Name = "ubicacion"
        Me.ubicacion.Size = New System.Drawing.Size(129, 13)
        Me.ubicacion.TabIndex = 12
        Me.ubicacion.TabStop = True
        Me.ubicacion.Text = "Abrir ubicación de imagen"
        '
        'ref
        '
        Me.ref.AutoSize = True
        Me.ref.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ref.Location = New System.Drawing.Point(8, 33)
        Me.ref.Name = "ref"
        Me.ref.Size = New System.Drawing.Size(66, 24)
        Me.ref.TabIndex = 13
        Me.ref.Text = "Label3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 308)
        Me.Controls.Add(Me.ref)
        Me.Controls.Add(Me.ubicacion)
        Me.Controls.Add(Me.dbstate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.siguiente)
        Me.Controls.Add(Me.respuesta3)
        Me.Controls.Add(Me.pregunta3)
        Me.Controls.Add(Me.respuesta2)
        Me.Controls.Add(Me.pregunta2)
        Me.Controls.Add(Me.respuesta1)
        Me.Controls.Add(Me.pregunta1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Ronda Virtual"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pregunta1 As Label
    Friend WithEvents respuesta1 As TextBox
    Friend WithEvents pregunta2 As Label
    Friend WithEvents respuesta2 As TextBox
    Friend WithEvents respuesta3 As TextBox
    Friend WithEvents pregunta3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiguienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents siguiente As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dbstate As Label
    Friend WithEvents ubicacion As LinkLabel
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ref As Label
End Class
