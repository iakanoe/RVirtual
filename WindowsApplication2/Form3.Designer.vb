<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblpreg1 = New System.Windows.Forms.Label()
        Me.lblpreg2 = New System.Windows.Forms.Label()
        Me.lblpreg3 = New System.Windows.Forms.Label()
        Me.volver = New System.Windows.Forms.Button()
        Me.modificar = New System.Windows.Forms.Button()
        Me.borrar = New System.Windows.Forms.Button()
        Me.txtpreg1 = New System.Windows.Forms.TextBox()
        Me.txtpreg2 = New System.Windows.Forms.TextBox()
        Me.txtpreg3 = New System.Windows.Forms.TextBox()
        Me.guardar = New System.Windows.Forms.Button()
        Me.selec = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtref = New System.Windows.Forms.TextBox()
        Me.lblref = New System.Windows.Forms.Label()
        Me.a = New System.Windows.Forms.Label()
        Me.diaA = New System.Windows.Forms.ComboBox()
        Me.diaDe = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numMin = New System.Windows.Forms.NumericUpDown()
        Me.numHoras = New System.Windows.Forms.NumericUpDown()
        Me.lblhoras = New System.Windows.Forms.Label()
        Me.lblmin = New System.Windows.Forms.Label()
        Me.lbldiaDe = New System.Windows.Forms.Label()
        Me.lbldiaA = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pregunta 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pregunta 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Pregunta 3"
        '
        'lblpreg1
        '
        Me.lblpreg1.AutoSize = True
        Me.lblpreg1.Location = New System.Drawing.Point(12, 244)
        Me.lblpreg1.Name = "lblpreg1"
        Me.lblpreg1.Size = New System.Drawing.Size(39, 13)
        Me.lblpreg1.TabIndex = 4
        Me.lblpreg1.Text = "Label4"
        '
        'lblpreg2
        '
        Me.lblpreg2.AutoSize = True
        Me.lblpreg2.Location = New System.Drawing.Point(12, 297)
        Me.lblpreg2.Name = "lblpreg2"
        Me.lblpreg2.Size = New System.Drawing.Size(39, 13)
        Me.lblpreg2.TabIndex = 5
        Me.lblpreg2.Text = "Label5"
        '
        'lblpreg3
        '
        Me.lblpreg3.AutoSize = True
        Me.lblpreg3.Location = New System.Drawing.Point(12, 350)
        Me.lblpreg3.Name = "lblpreg3"
        Me.lblpreg3.Size = New System.Drawing.Size(39, 13)
        Me.lblpreg3.TabIndex = 6
        Me.lblpreg3.Text = "Label6"
        '
        'volver
        '
        Me.volver.Location = New System.Drawing.Point(12, 494)
        Me.volver.Name = "volver"
        Me.volver.Size = New System.Drawing.Size(75, 23)
        Me.volver.TabIndex = 7
        Me.volver.Text = "Volver"
        Me.volver.UseVisualStyleBackColor = True
        '
        'modificar
        '
        Me.modificar.Location = New System.Drawing.Point(93, 494)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(75, 23)
        Me.modificar.TabIndex = 8
        Me.modificar.Text = "Modificar"
        Me.modificar.UseVisualStyleBackColor = True
        '
        'borrar
        '
        Me.borrar.Location = New System.Drawing.Point(174, 494)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(75, 23)
        Me.borrar.TabIndex = 9
        Me.borrar.Text = "Borrar"
        Me.borrar.UseVisualStyleBackColor = True
        '
        'txtpreg1
        '
        Me.txtpreg1.Location = New System.Drawing.Point(10, 241)
        Me.txtpreg1.Name = "txtpreg1"
        Me.txtpreg1.Size = New System.Drawing.Size(240, 20)
        Me.txtpreg1.TabIndex = 10
        Me.txtpreg1.Visible = False
        '
        'txtpreg2
        '
        Me.txtpreg2.Location = New System.Drawing.Point(10, 294)
        Me.txtpreg2.Name = "txtpreg2"
        Me.txtpreg2.Size = New System.Drawing.Size(240, 20)
        Me.txtpreg2.TabIndex = 11
        Me.txtpreg2.Visible = False
        '
        'txtpreg3
        '
        Me.txtpreg3.Location = New System.Drawing.Point(10, 347)
        Me.txtpreg3.Name = "txtpreg3"
        Me.txtpreg3.Size = New System.Drawing.Size(240, 20)
        Me.txtpreg3.TabIndex = 12
        Me.txtpreg3.Visible = False
        '
        'guardar
        '
        Me.guardar.Location = New System.Drawing.Point(93, 494)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(75, 23)
        Me.guardar.TabIndex = 13
        Me.guardar.Text = "Guardar"
        Me.guardar.UseVisualStyleBackColor = True
        Me.guardar.Visible = False
        '
        'selec
        '
        Me.selec.Location = New System.Drawing.Point(13, 146)
        Me.selec.Name = "selec"
        Me.selec.Size = New System.Drawing.Size(239, 23)
        Me.selec.TabIndex = 14
        Me.selec.Text = "Seleccionar Archivo..."
        Me.selec.UseVisualStyleBackColor = True
        Me.selec.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtref
        '
        Me.txtref.Location = New System.Drawing.Point(10, 195)
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(240, 20)
        Me.txtref.TabIndex = 17
        Me.txtref.Visible = False
        '
        'lblref
        '
        Me.lblref.AutoSize = True
        Me.lblref.Location = New System.Drawing.Point(12, 198)
        Me.lblref.Name = "lblref"
        Me.lblref.Size = New System.Drawing.Size(39, 13)
        Me.lblref.TabIndex = 16
        Me.lblref.Text = "Label4"
        '
        'a
        '
        Me.a.AutoSize = True
        Me.a.Location = New System.Drawing.Point(9, 172)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(44, 13)
        Me.a.TabIndex = 15
        Me.a.Text = "Nombre"
        '
        'diaA
        '
        Me.diaA.FormattingEnabled = True
        Me.diaA.Items.AddRange(New Object() {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"})
        Me.diaA.Location = New System.Drawing.Point(153, 436)
        Me.diaA.Name = "diaA"
        Me.diaA.Size = New System.Drawing.Size(81, 21)
        Me.diaA.TabIndex = 30
        Me.diaA.Visible = False
        '
        'diaDe
        '
        Me.diaDe.FormattingEnabled = True
        Me.diaDe.Items.AddRange(New Object() {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"})
        Me.diaDe.Location = New System.Drawing.Point(46, 436)
        Me.diaDe.Name = "diaDe"
        Me.diaDe.Size = New System.Drawing.Size(81, 21)
        Me.diaDe.TabIndex = 29
        Me.diaDe.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(133, 442)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "A"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 442)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "De"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 379)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Intervalo de control"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 401)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Horas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(104, 401)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Minutos"
        '
        'numMin
        '
        Me.numMin.Location = New System.Drawing.Point(154, 399)
        Me.numMin.Name = "numMin"
        Me.numMin.Size = New System.Drawing.Size(41, 20)
        Me.numMin.TabIndex = 23
        Me.numMin.Visible = False
        '
        'numHoras
        '
        Me.numHoras.Location = New System.Drawing.Point(57, 399)
        Me.numHoras.Name = "numHoras"
        Me.numHoras.Size = New System.Drawing.Size(41, 20)
        Me.numHoras.TabIndex = 22
        Me.numHoras.Visible = False
        '
        'lblhoras
        '
        Me.lblhoras.AutoSize = True
        Me.lblhoras.Location = New System.Drawing.Point(59, 401)
        Me.lblhoras.Name = "lblhoras"
        Me.lblhoras.Size = New System.Drawing.Size(39, 13)
        Me.lblhoras.TabIndex = 31
        Me.lblhoras.Text = "Label4"
        '
        'lblmin
        '
        Me.lblmin.AutoSize = True
        Me.lblmin.Location = New System.Drawing.Point(154, 401)
        Me.lblmin.Name = "lblmin"
        Me.lblmin.Size = New System.Drawing.Size(39, 13)
        Me.lblmin.TabIndex = 32
        Me.lblmin.Text = "Label4"
        '
        'lbldiaDe
        '
        Me.lbldiaDe.AutoSize = True
        Me.lbldiaDe.Location = New System.Drawing.Point(48, 442)
        Me.lbldiaDe.Name = "lbldiaDe"
        Me.lbldiaDe.Size = New System.Drawing.Size(39, 13)
        Me.lbldiaDe.TabIndex = 33
        Me.lbldiaDe.Text = "Label4"
        '
        'lbldiaA
        '
        Me.lbldiaA.AutoSize = True
        Me.lbldiaA.Location = New System.Drawing.Point(156, 442)
        Me.lbldiaA.Name = "lbldiaA"
        Me.lbldiaA.Size = New System.Drawing.Size(39, 13)
        Me.lbldiaA.TabIndex = 34
        Me.lbldiaA.Text = "Label4"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 521)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbldiaA)
        Me.Controls.Add(Me.lbldiaDe)
        Me.Controls.Add(Me.lblmin)
        Me.Controls.Add(Me.lblhoras)
        Me.Controls.Add(Me.diaA)
        Me.Controls.Add(Me.diaDe)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.numMin)
        Me.Controls.Add(Me.numHoras)
        Me.Controls.Add(Me.txtref)
        Me.Controls.Add(Me.lblref)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.selec)
        Me.Controls.Add(Me.guardar)
        Me.Controls.Add(Me.txtpreg3)
        Me.Controls.Add(Me.txtpreg2)
        Me.Controls.Add(Me.txtpreg1)
        Me.Controls.Add(Me.borrar)
        Me.Controls.Add(Me.modificar)
        Me.Controls.Add(Me.volver)
        Me.Controls.Add(Me.lblpreg3)
        Me.Controls.Add(Me.lblpreg2)
        Me.Controls.Add(Me.lblpreg1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form3"
        Me.ShowIcon = False
        Me.Text = "Detalles"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblpreg1 As Label
    Friend WithEvents lblpreg2 As Label
    Friend WithEvents lblpreg3 As Label
    Friend WithEvents volver As Button
    Friend WithEvents modificar As Button
    Friend WithEvents borrar As Button
    Friend WithEvents txtpreg1 As TextBox
    Friend WithEvents txtpreg2 As TextBox
    Friend WithEvents txtpreg3 As TextBox
    Friend WithEvents guardar As Button
    Friend WithEvents selec As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtref As TextBox
    Friend WithEvents lblref As Label
    Friend WithEvents a As Label
    Friend WithEvents diaA As ComboBox
    Friend WithEvents diaDe As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents numMin As NumericUpDown
    Friend WithEvents numHoras As NumericUpDown
    Friend WithEvents lblhoras As Label
    Friend WithEvents lblmin As Label
    Friend WithEvents lbldiaDe As Label
    Friend WithEvents lbldiaA As Label
End Class
