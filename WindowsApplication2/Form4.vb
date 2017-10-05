Imports System.Data.OleDb
Public Class Form4
    Dim adaptador As New OleDbDataAdapter
    Dim consulta As String
    Public db As String
    Dim appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    Dim ds As New DataSet
    Dim passstr As String
    Private Sub enter_Click() Handles enterbtn.Click
        Dim conexion As New OleDbConnection
        conexion.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & db & "")
        Try
            conexion.Open()
            consulta = "SELECT pass FROM login WHERE (user = '" & user.Text & "')"
            ds = New DataSet
            adaptador.SelectCommand = New OleDbCommand(consulta, conexion)
            adaptador.Fill(ds, "login")
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos.", vbExclamation, "Error")
            End
        End Try
        If ds.Tables("login").Rows.Count = 0 Then
            MsgBox("El usuario no existe.", vbExclamation, "Error")
            conexion.Close()
        ElseIf IsDBNull(ds.Tables("login").Rows(0).Item(0)) = True
            MsgBox("El usuario no existe.", vbExclamation, "Error")
            conexion.Close()
        Else
            passstr = ds.Tables("login").Rows(0).Item(0)
            conexion.Close()
            If passstr = pass.Text Then
                Form1.user = user.Text
                Form1.Show()
                Me.Enabled = False
                Me.Close()
            Else
                MsgBox("Contraseña incorrecta.", vbExclamation, "Error")
            End If
        End If
    End Sub
    Public Sub Form4_Load() Handles MyBase.Load
        If IO.File.Exists(appdata & "\rvirtual\db") = True Then
            Dim dir As String = appdata & "\rvirtual\db"
            db = My.Computer.FileSystem.ReadAllText(dir)
            If db = "" Then
                Form5.ShowDialog()
                My.Computer.FileSystem.WriteAllText(dir, db, False)
                db = My.Computer.FileSystem.ReadAllText(dir)
                Form1.db = db
            Else
                Form1.db = db
            End If
        Else
            Form5.ShowDialog()
            My.Computer.FileSystem.WriteAllText(appdata & "\rvirtual\db", db, False)
        End If
    End Sub
    Private Sub AKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles user.KeyPress, pass.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            enter_Click()
        End If
    End Sub
End Class