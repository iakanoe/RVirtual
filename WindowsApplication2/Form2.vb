Imports System.Data.OleDb
Public Class config
    Dim consulta As String
    Dim conexion As New OleDbConnection
    Dim appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    Public num As Integer
    Private Sub selectbtn_Click(sender As Object, e As EventArgs) Handles selectbtn.Click
        OpenFileDialog1.ShowDialog()
        PictureBox1.ImageLocation = OpenFileDialog1.FileName
    End Sub
    Public Sub config_Load() Handles MyBase.Load
        Dim dataset As New DataSet
        Dim adaptador As New OleDbDataAdapter
        Try
            conexion.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Form1.db)
            conexion.Open()
            consulta = "Select * FROM preguntas"
            adaptador.SelectCommand = New OleDbCommand(consulta, conexion)
            adaptador.Fill(dataset, "preguntas")
            DataGridView1.DataSource = dataset
            DataGridView1.DataMember = "preguntas"
            dataset = New DataSet
            consulta = "Select * FROM login"
            adaptador.SelectCommand = New OleDbCommand(consulta, conexion)
            adaptador.Fill(dataset, "login")
            usersgrid.DataSource = dataset
            usersgrid.DataMember = "login"
            conexion.Close()
        Catch ex As Exception
            MsgBox("No se ha podido conectar con la base de datos.", vbExclamation, "Error")
        End Try
    End Sub
    Private Sub volverbtn_Click(sender As Object, e As EventArgs) Handles volverbtn.Click
        Form1.Activate()
        Me.Close()
    End Sub
    Private Sub guardarbtn_Click() Handles guardarbtn.Click
        Dim comando As New OleDbCommand
        conexion.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Form1.db)
        conexion.Open()
        Dim intervalo As Integer
        intervalo = (numHoras.Value * 60) + numMin.Value
        Dim numi As Integer = chequearnumero()
        consulta = "INSERT INTO preguntas (imagen, pregunta1, pregunta2, pregunta3, direccion, ref, intervalo, de, a) VALUES (" & numi & ", '" & preg1.Text & "', '" & preg2.Text & "', '" & preg3.Text & "', '" & PictureBox1.ImageLocation & "', '" & ref.Text & "', " & intervalo.ToString & ", '" & diaDe.SelectedItem & "', '" & diaA.SelectedItem & "')"
        comando.CommandText = consulta.ToString
        comando.Connection = conexion
        Try
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No se pudo guardar el registro en la base de datos.", vbExclamation, "Error")
        End Try
        Dim consulta2 As String = "INSERT INTO horas (imagen, hora) VALUES (" & numi & ", '')"
        comando = New OleDbCommand
        comando.Connection = conexion
        comando.CommandText = consulta2
        Try
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No se pudo guardar el registro en la base de datos.", vbExclamation, "Error")
        End Try
        conexion.Close()
        config_Load()
        ref.Text = ""
        preg1.Text = ""
        preg2.Text = ""
        preg3.Text = ""
        diaA.SelectedItem = Nothing
        diaDe.SelectedItem = Nothing
        numHoras.Value = 0
        numMin.Value = 0
        PictureBox1.Image = Nothing
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        num = DataGridView1.Rows(DataGridView1.CurrentCellAddress.Y).Cells.Item(0).Value.GetHashCode
        Form3.ShowDialog()
    End Sub
    Public Function chequearnumero() As Integer
        consulta = "SELECT * FROM preguntas"
        Dim dataset As New DataSet
        Dim adaptador As New OleDbDataAdapter
        Dim conteo As Integer
        adaptador = New OleDbDataAdapter(consulta, conexion)
        adaptador.Fill(dataset, "preguntas")
        conteo = dataset.Tables("preguntas").Rows.Count
        chequearnumero = conteo + 1
    End Function
    Private Sub usersgrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles usersgrid.CellDoubleClick
        users.user = usersgrid.Rows(usersgrid.CurrentCellAddress.Y).Cells.Item(0).Value.ToString
        users.ShowDialog()
    End Sub
    Private Sub agregar_Click(sender As Object, e As EventArgs) Handles agregar.Click
        Dim comando As New OleDbCommand
        conexion.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Form1.db)
        conexion.Open()
        consulta = "INSERT INTO login (user, pass) VALUES ('" & txtuser.Text & "', '" & txtpass.Text & "')"
        comando.CommandText = consulta
        comando.Connection = conexion
        Try
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No se pudo guardar el registro en la base de datos.", vbExclamation, "Error")
        End Try
        conexion.Close()
        config_Load()
        txtuser.Text = ""
        txtpass.Text = ""
    End Sub
End Class