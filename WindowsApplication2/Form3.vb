Public Class Form3
    Dim conexion As New OleDb.OleDbConnection
    Dim adaptador As New OleDb.OleDbDataAdapter
    Dim consulta As String
    Dim respuesta As New DataSet
    Dim appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    Private Function buscarporimagen(que As String, num As Integer) As String
        conexion.Close()
        conexion.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Form1.db)
        Try
            conexion.Open()
            adaptador = New OleDb.OleDbDataAdapter
            Dim ds As New DataSet
            consulta = "SELECT " & que.ToString & " FROM preguntas WHERE (imagen = " & num.ToString & ") "
            Dim cmd As New OleDb.OleDbCommand(consulta, conexion)
            adaptador.SelectCommand = cmd
            Try
                adaptador.Fill(ds, "preguntas")
                If IsDBNull(ds.Tables("preguntas").Rows(0).Item(0).ToString()) = True Then
                    MsgBox("Ocurrió un error.", vbExclamation, "Error")
                    buscarporimagen = ""
                    Me.Close()
                ElseIf ds.Tables("preguntas").Rows.Count = 0 Then
                    MsgBox("Ocurrió un error.", vbExclamation, "Error")
                    buscarporimagen = ""
                    Me.Close()
                Else
                    buscarporimagen = ds.Tables("preguntas").Rows(0).Item(0).ToString()
                End If
            Catch ex As Exception
                MsgBox("No se ha podido consultar a la DB.", vbExclamation, "Error")
                buscarporimagen = ""
                Me.Close()
            End Try
        Catch ex As Exception
            MsgBox("No se ha podido conectar a la DB.", vbExclamation, "Error")
            buscarporimagen = ""
            Me.Close()
        End Try
    End Function
    Private Sub formload(sender As Object, e As EventArgs) Handles MyBase.Load
        lblclear()
        lblref.Text = buscarporimagen("ref", config.num)
        lblref.Visible = True
        txtref.Visible = False
        PictureBox1.ImageLocation = buscarporimagen("direccion", config.num)
        Label1.Visible = True
        lblpreg1.Visible = True
        lblpreg1.Text = buscarporimagen("pregunta1", config.num)
        lblpreg2.Text = buscarporimagen("pregunta2", config.num)
        lblpreg3.Text = buscarporimagen("pregunta3", config.num)
        lbldiaA.Text = buscarporimagen("a", config.num)
        lbldiaDe.Text = buscarporimagen("de", config.num)
        lblhoras.Text = checktime("hs")
        lblmin.Text = checktime("min")
        If buscarporimagen("pregunta2", config.num) = "" Then
            Label2.Visible = False
            Label3.Visible = False
            lblpreg2.Visible = False
            lblpreg3.Visible = False
        ElseIf buscarporimagen("pregunta3", config.num) = "" And buscarporimagen("pregunta2", config.num) IsNot "" Then
            Label3.Visible = False
            lblpreg3.Visible = False
            lblpreg2.Visible = True
            Label2.Visible = True
        Else
            Label3.Visible = True
            lblpreg3.Visible = True
            lblpreg2.Visible = True
            Label2.Visible = True
        End If
    End Sub
    Public Sub lblclear()
        lblpreg1.Visible = True
        lblpreg2.Visible = True
        lblpreg3.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        lblpreg1.Text = ""
        lblpreg2.Text = ""
        lblpreg3.Text = ""
        txtpreg1.Visible = False
        txtpreg2.Visible = False
        txtpreg3.Visible = False
        txtpreg1.Text = ""
        txtpreg2.Text = ""
        txtpreg3.Text = ""
        guardar.Visible = False
        modificar.Visible = True
        selec.Visible = False
        lbldiaA.Visible = True
        lbldiaDe.Visible = True
        lblhoras.Visible = True
        lblmin.Visible = True
        diaA.Visible = False
        diaDe.Visible = False
        numMin.Visible = False
        numHoras.Visible = False
    End Sub
    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        txtpreg1.Visible = True
        txtpreg2.Visible = True
        txtpreg3.Visible = True
        lblpreg1.Visible = False
        lblpreg2.Visible = False
        lblpreg3.Visible = False
        lblref.Visible = False
        txtref.Visible = True
        txtref.Text = lblref.Text
        txtpreg1.Text = lblpreg1.Text
        txtpreg2.Text = lblpreg2.Text
        txtpreg3.Text = lblpreg3.Text
        numHoras.Value = lblhoras.Text
        numMin.Value = lblmin.Text
        diaA.SelectedItem = lbldiaA.Text
        diaDe.SelectedItem = lbldiaDe.Text
        modificar.Visible = False
        guardar.Visible = True
        selec.Visible = True
        lbldiaA.Visible = False
        lbldiaDe.Visible = False
        lblhoras.Visible = False
        lblmin.Visible = False
        diaA.Visible = True
        diaDe.Visible = True
        numMin.Visible = True
        numHoras.Visible = True
    End Sub
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        Try
            consulta = "UPDATE preguntas SET pregunta1 = '" & txtpreg1.Text & "', pregunta2 = '" & txtpreg2.Text & "', pregunta3 = '" & txtpreg3.Text & "', direccion = '" & PictureBox1.ImageLocation & "', ref = '" & txtref.Text & "', intervalo = " & (numHoras.Value * 60) + numMin.Value & ", de = '" & diaDe.SelectedItem & "', a = '" & diaA.SelectedItem & "' WHERE (imagen = " & config.num & ")"
            Dim comando As New OleDb.OleDbCommand(consulta, conexion)
            comando.ExecuteNonQuery()
            lblpreg1.Text = Buscarporimagen("pregunta1", config.num)
            If Buscarporimagen("pregunta2", config.num) = "" Then
                lblpreg2.Visible = False
                Label2.Visible = False
                Label3.Visible = False
                lblpreg3.Visible = False
            ElseIf Buscarporimagen("pregunta3", config.num) = "" And Buscarporimagen("pregunta2", config.num) IsNot "" Then
                Label3.Visible = False
                lblpreg3.Visible = False
                lblpreg2.Text = Buscarporimagen("pregunta2", config.num)
            Else
                lblpreg2.Text = Buscarporimagen("pregunta2", config.num)
                lblpreg3.Text = Buscarporimagen("pregunta3", config.num)
            End If
            PictureBox1.ImageLocation = Buscarporimagen("direccion", config.num)
            lblpreg1.Visible = True
            lblpreg2.Visible = True
            lblpreg3.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            txtpreg1.Visible = False
            txtpreg2.Visible = False
            txtpreg3.Visible = False
            guardar.Visible = False
            modificar.Visible = True
        Catch ex As Exception
            MsgBox("No se pudo actualizar la base de datos.", vbExclamation, "Error")
        End Try
    End Sub
    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        Dim respuesta As Byte
        respuesta = MsgBox("¿Está seguro de que desea eliminar este registro?", vbYesNo, "Eliminar")
        If respuesta = vbYes Then
            consulta = "DELETE FROM preguntas WHERE (imagen = " & config.num & ")"
            Dim comando As New OleDb.OleDbCommand(consulta, conexion)
            comando.ExecuteNonQuery()
            consulta = "DELETE FROM horas WHERE (imagen = " & config.num & ")"
            comando = New OleDb.OleDbCommand(consulta, conexion)
            comando.ExecuteNonQuery()
            MsgBox("Registro eliminado", vbInformation, "Eliminado")
            lblclear()
            config.Focus()
            config.config_Load()
            Me.Close()
        End If
    End Sub
    Private Sub selec_Click(sender As Object, e As EventArgs) Handles selec.Click
        OpenFileDialog1.ShowDialog()
        PictureBox1.ImageLocation = OpenFileDialog1.FileName
    End Sub
    Private Sub volver_Click(sender As Object, e As EventArgs) Handles volver.Click
        Me.Close()
        config.Show()
        config.config_Load()
    End Sub
    Private Sub desconectar()
        conexion.Close()
    End Sub
    Private Function checktime(que As String) As Integer
        Dim int As Integer = buscarporimagen("intervalo", config.num)
        Dim horas As Integer = 0
        While int >= 60
            horas = horas + 1
            int = int - 60
        End While
        If que = "hs" Then
            checktime = horas
        ElseIf que = "min" Then
            checktime = int
        Else
            checktime = Nothing
        End If
    End Function
End Class