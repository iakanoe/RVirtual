<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class users
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblusr = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.volver = New System.Windows.Forms.Button()
        Me.modificar = New System.Windows.Forms.Button()
        Me.borrar = New System.Windows.Forms.Button()
        Me.txtusr = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.guardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'lblusr
        '
        Me.lblusr.AutoSize = True
        Me.lblusr.Location = New System.Drawing.Point(65, 13)
        Me.lblusr.Name = "lblusr"
        Me.lblusr.Size = New System.Drawing.Size(39, 13)
        Me.lblusr.TabIndex = 1
        Me.lblusr.Text = "Label2"
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Location = New System.Drawing.Point(82, 38)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(39, 13)
        Me.lblpass.TabIndex = 3
        Me.lblpass.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña:"
        '
        'volver
        '
        Me.volver.Location = New System.Drawing.Point(12, 68)
        Me.volver.Name = "volver"
        Me.volver.Size = New System.Drawing.Size(75, 23)
        Me.volver.TabIndex = 4
        Me.volver.Text = "Volver"
        Me.volver.UseVisualStyleBackColor = True
        '
        'modificar
        '
        Me.modificar.Location = New System.Drawing.Point(93, 68)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(75, 23)
        Me.modificar.TabIndex = 5
        Me.modificar.Text = "Modificar"
        Me.modificar.UseVisualStyleBackColor = True
        '
        'borrar
        '
        Me.borrar.Location = New System.Drawing.Point(174, 68)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(75, 23)
        Me.borrar.TabIndex = 6
        Me.borrar.Text = "Eliminar"
        Me.borrar.UseVisualStyleBackColor = True
        '
        'txtusr
        '
        Me.txtusr.Location = New System.Drawing.Point(65, 10)
        Me.txtusr.Name = "txtusr"
        Me.txtusr.Size = New System.Drawing.Size(184, 20)
        Me.txtusr.TabIndex = 7
        Me.txtusr.Visible = False
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(82, 35)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(167, 20)
        Me.txtpass.TabIndex = 8
        Me.txtpass.UseSystemPasswordChar = True
        Me.txtpass.Visible = False
        '
        'guardar
        '
        Me.guardar.Location = New System.Drawing.Point(94, 67)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(75, 23)
        Me.guardar.TabIndex = 9
        Me.guardar.Text = "Guardar"
        Me.guardar.UseVisualStyleBackColor = True
        Me.guardar.Visible = False
        '
        'users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 102)
        Me.Controls.Add(Me.guardar)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtusr)
        Me.Controls.Add(Me.borrar)
        Me.Controls.Add(Me.modificar)
        Me.Controls.Add(Me.volver)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblusr)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "users"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Modificar usuario..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblusr As Label
    Friend WithEvents lblpass As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents volver As Button
    Friend WithEvents modificar As Button
    Friend WithEvents borrar As Button
    Friend WithEvents txtusr As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents guardar As Button
End Class
