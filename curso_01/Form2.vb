Imports System.IO
Imports System.Data.SqlClient


Public Class Form2

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        llenaGrid()
    End Sub

    Private Sub llenaGrid()
        Dim db As DB
        db = New DB()

        dgvAlumnos.DataSource = db.ExecuteResultSet("spAlumnoGetList")
    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim db As DB
        db = New DB()
        db.AddParemeter("nombre", txtNombre.Text)
        db.AddParemeter("matricula", txtMatricula.Text)
        db.AddParemeter("apellidopaterno", txtApellidoPaterno.Text)
        db.AddParemeter("apellidomaterno", txtApellidoMaterno.Text)
        db.AddParemeter("carreraid", txtCarreraId.Text)

        db.AddOutputParameter("alumnoid", 0, 0)
        db.Execute("spAlumnoInsert")

        txtAlumnoId.Text = db.OutParameter("alumnoid")

        llenaGrid()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim db As DB
        db = New DB()
        db.AddParemeter("alumnoid", CInt(txtAlumnoId.Text))
        db.Execute("spAlumnoDeleteById")

        llenaGrid()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        Dim db As DB
        db = New DB()
        db.AddParemeter("alumnoid", CInt(txtAlumnoId.Text))
        db.AddParemeter("nombre", txtNombre.Text)
        db.AddParemeter("matricula", txtMatricula.Text)
        db.AddParemeter("apellidopaterno", txtApellidoPaterno.Text)
        db.AddParemeter("apellidomaterno", txtApellidoMaterno.Text)
        db.AddParemeter("carreraid", txtCarreraId.Text)

        db.Execute("spAlumnoUpdate")

        llenaGrid()
    End Sub

    Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
        llenaGrid()
    End Sub

End Class