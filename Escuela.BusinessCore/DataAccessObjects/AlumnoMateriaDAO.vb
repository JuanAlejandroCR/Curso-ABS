Imports Escuela.Contracts.DataTransferObjects
Imports System.ComponentModel
Imports Escuela.Contracts.DisplayObjects
Imports Escuela.Contracts
Imports Escuela.Contracts.Enums

Namespace DataAccesObjects

    Public Class AlumnoMateriaDAO
        Inherits DataAccessObjectBase

        Const SP_INSERT As String = "spAlumnoMateriaInsert"
        Const SP_GETLISTBYALUMNOID As String = "spAlumnoMateriaGetListByAlumnoId"

        Public Sub Insert(ByVal dto As DataTransferObjectBase)

            Dim dtoAlumnoCarrera As AlumnoMateriaDTO
            dtoAlumnoCarrera = CType(dto, AlumnoMateriaDTO)

            AddParemeter(AlumnoMateriaEnum.AlumnoId.ToString, dtoAlumnoCarrera.AlumnoId)
            AddParemeter(AlumnoMateriaEnum.MateriaId.ToString, dtoAlumnoCarrera.MateriaId)            
            Execute(SP_INSERT)

        End Sub

        Public Function GetList1ByAlumnoId(ByVal ByAlumnoId) As System.ComponentModel.BindingList(Of Contracts.DisplayObjects.AlumnoMateriaDisplayObject)
            AddParemeter(AlumnoMateriaEnum.AlumnoId.ToString, ByAlumnoId)

            Dim resultado As DataTable
            resultado = ExecuteResultSet(SP_GETLISTBYALUMNOID)

            Dim lista As BindingList(Of AlumnoMateriaDisplayObject) = New BindingList(Of AlumnoMateriaDisplayObject)

            For Each renglon As DataRow In resultado.Rows
                Dim display As AlumnoMateriaDisplayObject = New AlumnoMateriaDisplayObject
                display.AlumnoId = CInt(renglon(AlumnoMateriaEnum.AlumnoId.ToString))
                display.MateriaId = renglon(AlumnoMateriaEnum.MateriaId.ToString)
                display.Materia = renglon(AlumnoMateriaEnum.Materia.ToString)

                lista.Add(display)
            Next

            Return lista
        End Function
    End Class


End Namespace