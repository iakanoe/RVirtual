Imports System.Data.OleDb
Imports Microsoft.VisualBasic.DateAndTime
Public Class Form1
    Dim isadmin As Boolean
    Dim numimag As Integer
    Dim conexion As New OleDbConnection
    Dim adaptador As New OleDbDataAdapter
    Dim consulta As String
    Dim respuesta As New DataSet
    Public db As String
    Public user As String
    Dim intervalo As Integer
    Dim cant As Integer = 0
    Dim dicho As Boolean
    Private Sub Form1_Load() Handles MyBase.Load, MyBase.Shown
        conectar()
        If conectar() = True Then
            dbstate.Text = "Conectado"
            dbstate.ForeColor = Color.Lime
            If user = "admin" Then
                isadmin = True
            Else
                isadmin = False
            End If
            conteo()
            If conteo() = 0 And isadmin = True Then
                Dim response As MsgBoxResult = MsgBox("La base de datos está vacía. ¿Ir a configuración?", vbOKCancel, "Configuracion")
                If response = vbOK Then
                    ConfiguraciónToolStripMenuItem_Click()
                Else
                    End
                End If
            ElseIf conteo() = 0 And isadmin = False Then
                MsgBox("La base de datos está vacía. Contactar al administrador para solucionar el problema.", vbExclamation, "Error")
            Else
                numimag = 1
                    reimagequest()
                End If
            Else
                dbstate.Text = "No conectado"
            dbstate.ForeColor = Color.Red
            MsgBox("No se ha podido conectar a la base de datos.", vbExclamation, "Error")
        End If
    End Sub
    Private Function conteo() As Integer
        consulta = "Select * FROM preguntas"
        Dim dataset As New DataSet
        adaptador.SelectCommand = New OleDbCommand(consulta, conexion)
        adaptador.Fill(dataset, "preguntas")
        conteo = dataset.Tables("preguntas").Rows.Count
        Exit Function
    End Function
    Public Sub reimagequest()
        Dim intervalo As Integer = Buscar("intervalo", numimag)
        Dim hora1 As Date, hora2 As Date
        If Buscar("hora", numimag, "horas") = "" Then
            image()
        Else
            hora1 = Buscar("hora", numimag, "horas")
            hora1 = hora1.AddMinutes(intervalo)
            hora2 = Format((TimeValue(Now)), "hh:mm")
            If hora2 >= hora1 Then
                image()
                If cant >= conteo() And dicho = True Then
                    MsgBox("Se ha encontrado una imagen para revisar.", vbExclamation)
                End If
                dicho = False
                cant = 1
            Else
                If cant < conteo() Then
                    cant = cant + 1
                Else
                    If dicho = False Then
                        MsgBox("No hay ninguna imagen para revisar ahora.")
                        lblclear()
                        dicho = True
                    End If
                End If
                numimag = numimag + 1
                If numimag > conteo() Then
                    numimag = 1
                End If
                reimagequest()
            End If
        End If
    End Sub
    Public Function Buscar(what As String, num As Integer, Optional where As String = Nothing) As String
        Dim responder As String
        If where = Nothing Then
            where = "preguntas"
            consulta = "Select " & what & " FROM preguntas WHERE (imagen = " & num & ")"
        Else
            consulta = "Select " & what & " FROM " & where & " WHERE (imagen = " & num & ")"
        End If
        respuesta = New DataSet
        respuesta = consultar(consulta, where)
        If respuesta.Tables(where).Rows.Count = 0 Then
            responder = ""
        ElseIf IsDBNull(respuesta.Tables(where).Rows(0).Item(0)) = True And respuesta.Tables(where).Rows.Count <> 0 Then
            responder = ""
        Else
            responder = respuesta.Tables(where).Rows(0).Item(0)
        End If
        Buscar = responder
        Exit Function
    End Function
    Public Function conectar() As Boolean
        Try
            conexion.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + db)
            conexion.Open()
            Return conectar = True
        Catch ex As Exception
            Return conectar = False
        End Try
        Exit Function
    End Function
    Public Function consultar(consult As String, what As String) As DataSet
        Dim dataset As New DataSet
        adaptador.SelectCommand = New OleDbCommand(consult, conexion)
        adaptador.Fill(dataset, what)
        consultar = dataset
        Exit Function
    End Function
    Private Sub ubicacion_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ubicacion.LinkClicked
        Process.Start("explorer.exe", Strings.Left(Buscar("direccion", numimag), Strings.InStrRev(Buscar("direccion", numimag), "\")))
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        Form4.Close()
    End Sub
    Private Sub ConfiguraciónToolStripMenuItem_Click() Handles ConfiguraciónToolStripMenuItem.Click
        If isadmin = True Then
            config.ShowDialog()
            Form1_Load()
        Else
            MsgBox("Solo los administradores pueden acceder a la configuración. Contacte al administrador del sistema para configurar.", vbExclamation, "Acceso denegado")
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start(PictureBox1.ImageLocation)
    End Sub
    Private Sub siguiente_Click(sender As Object, e As EventArgs) Handles siguiente.Click, SiguienteToolStripMenuItem.Click
        If chequear = True Then
            conectar()
            consulta = "INSERT INTO respuestas VALUES ('" & ref.Text & "', '" & respuesta1.Text & "', '" & respuesta2.Text & "', '" & respuesta3.Text & "', #" & DateTime.Now.ToShortDateString & "#, #" & TimeOfDay.ToLongTimeString & "#, '" & user & "')"
            Dim comando As New OleDbCommand(consulta, conexion)
            Dim hora As String = TimeOfDay.ToLongTimeString
            Dim stringssa As String = "UPDATE horas SET hora='" & hora & "' WHERE imagen = " & numimag & ""
            Dim comando2 As New OleDbCommand(stringssa, conexion)
            Try
                comando.ExecuteNonQuery()
                comando2.ExecuteNonQuery()
                numimag = numimag + 1
                If numimag > conteo() Then
                    numimag = 1
                End If
                reimagequest()
            Catch ex As Exception
                MsgBox("Hubo un error al intentar registrar las respuestas en la base de datos.", vbExclamation, "Error")
            End Try
        Else
            MsgBox("Falta completar campos.", vbExclamation, "Error")
        End If
    End Sub
    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Form4.user.Text = ""
        Form4.pass.Text = ""
        Form4.Enabled = True
        Form4.Show()
        Me.Close()
    End Sub
    Private Sub image()
        cant = 0
        respuesta1.Text = ""
        respuesta2.Text = ""
        respuesta3.Text = ""
        PictureBox1.ImageLocation = Buscar("direccion", numimag)
        pregunta1.Text = Buscar("pregunta1", numimag)
        If Buscar("pregunta2", numimag) IsNot "" Then
            pregunta2.Visible = True
            pregunta2.Text = Buscar("pregunta2", numimag)
            respuesta2.Visible = True
            If Buscar("pregunta3", numimag) IsNot "" Then
                pregunta3.Visible = True
                pregunta3.Text = Buscar("pregunta3", numimag)
                respuesta3.Visible = True
            Else
                pregunta3.Visible = False
                respuesta3.Visible = False
                respuesta3.Text = "a"
            End If
        Else
            pregunta2.Visible = False
            respuesta2.Visible = False
            respuesta2.Text = "a"
            pregunta3.Visible = False
            respuesta3.Visible = False
            respuesta3.Text = "a"
        End If
        ref.Text = Buscar("ref", numimag)
    End Sub
    Private Function chequear() As Boolean
        If respuesta1.Text = "" Or respuesta2.Text = "" Or respuesta3.Text = "" Then
            chequear = False
        Else
            chequear = True
        End If
    End Function
    Public Sub lblclear()
        ref.Text = Nothing
        pregunta1.Text = Nothing
        pregunta2.Text = Nothing
        pregunta3.Text = Nothing
        respuesta1.Text = Nothing
        respuesta2.Text = Nothing
        respuesta3.Text = Nothing
        PictureBox1.Image = Nothing
        pregunta2.Visible = True
        pregunta3.Visible = True
        respuesta2.Visible = True
        respuesta3.Visible = True
    End Sub
    'falta dias
End Class