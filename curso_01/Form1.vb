Imports Escuela.BusinessCore.DomainObjects
Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.Services
Imports Escuela.Contracts.DisplayObjects
Imports System.ComponentModel
Imports Escuela.BusinessCore

Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        llenaGrid()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim servicio As ICarrera
        servicio = New CarreraDomainObject

        Dim carrera As CarreraDTO = New CarreraDTO
        carrera.Nombre = txtNombre.Text
        carrera.Siglas = txtSiglas.Text

        carrera.IsNew = True

        servicio.Save(carrera)

        llenaGrid()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim servicio As ICarrera
        servicio = New CarreraDomainObject

        servicio.DeleteById(CInt(txtID.Text))

        llenaGrid()
    End Sub


    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        Dim servicio As ICarrera
        servicio = New CarreraDomainObject

        Dim carrera As CarreraDTO = New CarreraDTO
        carrera.CarreraId = txtID.Text
        carrera.Nombre = txtNombre.Text
        carrera.Siglas = txtSiglas.Text

        carrera.IsNew = False

        servicio.Save(carrera)

        llenaGrid()
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click

        Dim servicio As ICarrera
        servicio = New CarreraDomainObject

        Dim resultadoDTO As CarreraDTO = New CarreraDTO
        resultadoDTO = servicio.GetById(CInt(txtID.Text))

        If resultadoDTO.Nombre = "" Then
            MessageBox.Show("El Id no existe en la tabla")
            Return
        End If

        txtNombre.Text = resultadoDTO.Nombre
        txtSiglas.Text = resultadoDTO.Siglas

    End Sub

    Private Sub llenaGrid()

        Dim servicio As ICarrera
        servicio = New CarreraDomainObject

        Dim lista As BindingList(Of CarreraDisplayObject) = New BindingList(Of CarreraDisplayObject)

        lista = servicio.GetList()

        dgvCarreras.DataSource = lista
        dgvCarreras.Columns("nombre").Width = 250
    End Sub


    ' Ejemplo para el tema de SP con parámetros de salida
    Private Sub btnArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArea.Click        
        Dim db As DataAccessObjectBase
        db = New DataAccessObjectBase()

        db.AddParemeter("largo", CInt(txtLargo.Text))
        db.AddParemeter("ancho", CInt(txtAncho.Text))
        db.AddOutputParameter("area", 0, 0)
        db.Execute("spAreaDeRectangulo")

        txtResultado.Text = db.OutParameter("area")
    End Sub
End Class
