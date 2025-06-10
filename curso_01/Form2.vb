Imports Escuela.BusinessCore.DomainObjects
Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.Services
Imports Escuela.Contracts.DisplayObjects
Imports System.ComponentModel
Imports Escuela.BusinessCore
Imports Escuela.Contracts.Enums

Public Class Form2

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        llenaGrid()
        llenaCombos()
    End Sub

    Private Sub llenaGrid()
        Dim servicio As IAlumno
        servicio = New AlumnoDomainObject

        Dim lista As BindingList(Of AlumnoDisplayObject) = New BindingList(Of AlumnoDisplayObject)
        lista = servicio.GetList()

        dgvAlumnos.DataSource = lista

    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim servicio As IAlumno
        servicio = New AlumnoDomainObject

        Dim alumno As AlumnoDTO = New AlumnoDTO
        alumno.Nombre = txtNombre.Text
        alumno.Matricula = txtMatricula.Text
        alumno.ApellidoPaterno = txtApellidoPaterno.Text
        alumno.ApellidoMaterno = txtApellidoMaterno.Text
        alumno.CarreraId = cmbCarrera.SelectedValue

        alumno.IsNew = True

        servicio.Save(alumno)

        llenaGrid()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim servicio As IAlumno
        servicio = New AlumnoDomainObject

        servicio.DeleteById(CInt(txtAlumnoId.Text))

        llenaGrid()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        Dim servicio As IAlumno
        servicio = New AlumnoDomainObject

        Dim alumno As AlumnoDTO = New AlumnoDTO
        alumno.AlumnoId = txtAlumnoId.Text
        alumno.Nombre = txtNombre.Text
        alumno.Matricula = txtMatricula.Text
        alumno.ApellidoPaterno = txtApellidoPaterno.Text
        alumno.ApellidoMaterno = txtApellidoMaterno.Text
        alumno.CarreraId = cmbCarrera.SelectedValue

        alumno.IsNew = False

        servicio.Save(alumno)

        llenaGrid()
    End Sub

    Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
        llenaGrid()
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Dim servicio As IAlumno
        servicio = New AlumnoDomainObject

        Dim resultadoDTO As AlumnoDTO = New AlumnoDTO
        resultadoDTO = servicio.GetById(CInt(txtAlumnoId.Text))

        If resultadoDTO.Nombre = "" Then
            MessageBox.Show("El Id no existe en la tabla")
            Return
        End If

        txtNombre.Text = resultadoDTO.Nombre
        txtMatricula.Text = resultadoDTO.Matricula
        txtApellidoPaterno.Text = resultadoDTO.ApellidoPaterno
        txtApellidoMaterno.Text = resultadoDTO.ApellidoMaterno
        cmbCarrera.SelectedValue = resultadoDTO.CarreraId

    End Sub

    Sub llenaCombos()
        Dim servicio As ICarrera
        servicio = New CarreraDomainObject

        Dim lista As BindingList(Of CarreraDisplayObject) = New BindingList(Of CarreraDisplayObject)

        cmbCarrera.DataSource = servicio.GetList()
        cmbCarrera.DisplayMember = CarreraEnum.Nombre.ToString
        cmbCarrera.ValueMember = CarreraEnum.CarreraId.ToString

    End Sub
End Class