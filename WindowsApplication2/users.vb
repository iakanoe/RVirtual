Imports System.Data.OleDb
Public Class users
    Dim consulta As String
    Dim conexion As New OleDbConnection
    Dim appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    Public user As String
    Dim ds As New DataSet
    Dim adap As New OleDbDataAdapter
    Private Sub users_Load() Handles MyBase.Load
        txtusr.Visible = False
        txtpass.Visible = False
        lblpass.Visible = True
        lblusr.Visible = True
        modificar.Visible = True
        guardar.Visible = False
        conexion.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Form1.db)
        Try
            conexion.Open()
            consulta = "SELECT * FROM login WHERE (user = '" & user & "')"
            adap.SelectCommand = New OleDbCommand(consulta, conexion)
            adap.Fill(ds, "login")
            lblusr.Text = ds.Tables("login").Rows(0).Item(0).ToString
            lblpass.Text = ds.Tables("login").Rows(0).Item(1).ToString
            conexion.Close()
        Catch ex As Exception
            MsgBox("No se pudo obtener datos de la DB.", vbExclamation, "Error")
        End Try
    End Sub
    Private Sub volver_Click(sender As Object, e As EventArgs) Handles volver.Click
        Me.Close()
        config.Show()
        config.config_Load()
    End Sub
    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        txtpass.Visible = True
        txtusr.Visible = True
        lblusr.Visible = False
        lblpass.Visible = False
        txtpass.Text = lblpass.Text
        txtusr.Text = lblusr.Text
        modificar.Visible = False
        guardar.Visible = True
    End Sub
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        Try
            consulta = "UPDATE login SET user = '" & txtusr.Text & "', pass = '" & txtpass.Text & "' WHERE (user = '" & user & "')"
            Dim cmd As New OleDbCommand(consulta, conexion)
            conexion.Open()
            cmd.ExecuteNonQuery()
            conexion.Close()
            users_Load()
        Catch ex As Exception
            MsgBox("No se pudo actualizar la base de datos.", vbExclamation, "Error")
        End Try
    End Sub
    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        Dim respuesta As Byte
        respuesta = MsgBox("¿Está seguro de que desea eliminar este registro?", vbYesNo, "Eliminar")
        If respuesta = vbYes Then
            consulta = "DELETE FROM login WHERE (user = '" & user & "')"
            Dim comando As New OleDbCommand(consulta, conexion)
            comando.ExecuteNonQuery()
            MsgBox("Registro eliminado", vbInformation, "Eliminado")
            config.Focus()
            config.config_Load()
            Me.Close()
        End If
    End Sub
End Class