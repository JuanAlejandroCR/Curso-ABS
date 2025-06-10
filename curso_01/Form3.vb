Imports Escuela.BusinessCore.DomainObjects
Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.Services
Imports Escuela.Contracts.DisplayObjects
Imports System.ComponentModel
Imports Escuela.BusinessCore
Imports Escuela.Contracts.Enums

Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenaCombos()        
    End Sub


    Sub llenaCombos()
        Dim servicio As IMateria
        servicio = New MateriaDomainObject

        Dim lista As BindingList(Of MateriaDisplayObject) = New BindingList(Of MateriaDisplayObject)

        cmbMaterias.DataSource = servicio.GetList()
        cmbMaterias.DisplayMember = MateriaEnum.Nombre.ToString
        cmbMaterias.ValueMember = MateriaEnum.MateriaId.ToString

    End Sub

    Sub llenaGrid()
        Dim servicio As IAlumnoMateria
        servicio = New AlumnoMateriaDomainObject

        Dim lista As BindingList(Of AlumnoMateriaDisplayObject) = New BindingList(Of AlumnoMateriaDisplayObject)

        dgvMateriasAlumno.DataSource = servicio.GetList()

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim servicio As IAlumno
        servicio = New AlumnoDomainObject

        Dim resultadoDTO As AlumnoDTO = New AlumnoDTO
        resultadoDTO = servicio.GetByMatricula(txtMatricula.Text)

        txtId.Text = resultadoDTO.AlumnoId
        txtNombre.Text = resultadoDTO.Nombre + " " + resultadoDTO.ApellidoPaterno + " " + resultadoDTO.ApellidoMaterno

        llenaGrid()
    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim servicio As IAlumnoMateria
        servicio = New AlumnoMateriaDomainObject

        Dim alumnoMateria As AlumnoMateriaDTO = New AlumnoMateriaDTO
        alumnoMateria.AlumnoId = txtId.Text
        alumnoMateria.MateriaId = cmbMaterias.SelectedValue

        alumnoMateria.IsNew = True

        servicio.Save(alumnoMateria)

        llenaGrid()
    End Sub


End Class