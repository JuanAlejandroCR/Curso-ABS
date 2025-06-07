Imports Escuela.Contracts.DataTransferObjects
Imports System.ComponentModel
Imports Escuela.Contracts.DisplayObjects
Imports Escuela.Contracts
Imports Escuela.Contracts.Enums

Namespace DataAccesObjects

    Public Class AlumnoDAO
        Inherits DataAccessObjectBase

        Const SP_INSERT As String = "spAlumnoInsert"
        Const SP_DELETEBYID As String = "spAlumnoDeleteById"
        Const SP_UPDATE As String = "spAlumnoUpdate"
        Const SP_GETBYID As String = "spAlumnoGetById"
        Const SP_GETLIST As String = "spAlumnoGetList"

        Public Sub Insert(ByVal dto As DataTransferObjectBase)

            Dim dtoAlumno As AlumnoDTO
            dtoAlumno = CType(dto, AlumnoDTO)

            AddParemeter(AlumnoEnum.Nombre.ToString, dtoAlumno.Nombre)
            AddParemeter(AlumnoEnum.Matricula.ToString, dtoAlumno.Matricula)
            AddParemeter(AlumnoEnum.ApellidoPaterno.ToString, dtoAlumno.ApellidoPaterno)
            AddParemeter(AlumnoEnum.ApellidoMaterno.ToString, dtoAlumno.ApellidoMaterno)
            AddParemeter(AlumnoEnum.CarreraId.ToString, dtoAlumno.CarreraId)

            AddOutputParameter(AlumnoEnum.AlumnoId.ToString, 0, 0)
            Execute(SP_INSERT)

        End Sub

        Public Sub DeleteById(ByVal alumnoid As Integer)
            AddParemeter(AlumnoEnum.AlumnoId.ToString, alumnoid)
            Execute(SP_DELETEBYID)
        End Sub

        Public Sub Update(ByVal dto As DataTransferObjectBase)

            Dim dtoAlumno As AlumnoDTO
            dtoAlumno = CType(dto, AlumnoDTO)

            AddParemeter(AlumnoEnum.AlumnoId.ToString, dtoAlumno.AlumnoId)
            AddParemeter(AlumnoEnum.Nombre.ToString, dtoAlumno.Nombre)
            AddParemeter(AlumnoEnum.Matricula.ToString, dtoAlumno.Matricula)
            AddParemeter(AlumnoEnum.ApellidoPaterno.ToString, dtoAlumno.ApellidoPaterno)
            AddParemeter(AlumnoEnum.ApellidoMaterno.ToString, dtoAlumno.ApellidoMaterno)
            AddParemeter(AlumnoEnum.CarreraId.ToString, dtoAlumno.CarreraId)
            Execute(SP_UPDATE)
        End Sub

        Public Function GetById(ByVal alumnoid As Integer) As AlumnoDTO
            AddParemeter(AlumnoEnum.AlumnoId.ToString, alumnoid)

            Dim resultado As DataTable
            resultado = ExecuteResultSet(SP_GETBYID)

            If resultado.Rows.Count = 0 Then
                Return New AlumnoDTO()
            End If

            Dim alumnoDTO As AlumnoDTO = New AlumnoDTO
            alumnoDTO.Nombre = resultado.Rows(0)(AlumnoEnum.Nombre.ToString)
            alumnoDTO.Matricula = resultado.Rows(0)(AlumnoEnum.Matricula.ToString)
            alumnoDTO.ApellidoPaterno = resultado.Rows(0)(AlumnoEnum.ApellidoPaterno.ToString)
            alumnoDTO.ApellidoMaterno = resultado.Rows(0)(AlumnoEnum.ApellidoMaterno.ToString)
            alumnoDTO.CarreraId = resultado.Rows(0)(AlumnoEnum.CarreraId.ToString)

            Return alumnoDTO
        End Function

        Public Function GetList1() As System.ComponentModel.BindingList(Of Contracts.DisplayObjects.AlumnoDisplayObject)

            Dim resultado As DataTable
            resultado = ExecuteResultSet(SP_GETLIST)

            Dim lista As BindingList(Of AlumnoDisplayObject) = New BindingList(Of AlumnoDisplayObject)

            For Each renglon As DataRow In resultado.Rows
                Dim display As AlumnoDisplayObject = New AlumnoDisplayObject
                display.AlumnoId = CInt(renglon(AlumnoEnum.AlumnoId.ToString))
                display.Nombre = renglon(AlumnoEnum.Nombre.ToString)
                display.Matricula = renglon(AlumnoEnum.Matricula.ToString)
                display.ApellidoPaterno = renglon(AlumnoEnum.ApellidoPaterno.ToString)
                display.ApellidoMaterno = renglon(AlumnoEnum.ApellidoMaterno.ToString)
                display.CarreraId = renglon(AlumnoEnum.CarreraId.ToString)

                lista.Add(display)
            Next

            Return lista
        End Function
    End Class


End Namespace