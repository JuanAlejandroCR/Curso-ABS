Imports Escuela.Contracts.DataTransferObjects
Imports System.ComponentModel
Imports Escuela.Contracts.DisplayObjects
Imports Escuela.Contracts
Imports Escuela.Contracts.Enums

Namespace DataAccesObjects

    Public Class CarreraDAO
        Inherits DataAccessObjectBase

        Const SP_INSERT As String = "spCarreraInsert"
        Const SP_DELETEBYID As String = "spCarreraDeleteById"
        Const SP_UPDATE As String = "spCarreraUpdate"
        Const SP_GETBYID As String = "spCarreraGetById"
        Const SP_GETLIST As String = "spCarreraGetList"

        Public Sub Insert(ByVal dto As DataTransferObjectBase)

            Dim dtoCarrera As CarreraDTO
            dtoCarrera = CType(dto, CarreraDTO)

            AddParemeter(CarreraEnum.Nombre.ToString, dtoCarrera.Nombre)
            AddParemeter(CarreraEnum.Siglas.ToString, dtoCarrera.Siglas)
            AddOutputParameter(CarreraEnum.CarreraId.ToString, 0, 0)
            Execute(SP_INSERT)

        End Sub

        Public Sub DeleteById(ByVal carreraid As Integer)
            AddParemeter(CarreraEnum.CarreraId.ToString, carreraid)
            Execute(SP_DELETEBYID)
        End Sub

        Public Sub Update(ByVal dto As DataTransferObjectBase)

            Dim dtoCarrera As CarreraDTO
            dtoCarrera = CType(dto, CarreraDTO)

            AddParemeter(CarreraEnum.CarreraId.ToString, dtoCarrera.CarreraId)
            AddParemeter(CarreraEnum.Nombre.ToString, dtoCarrera.Nombre)
            AddParemeter(CarreraEnum.Siglas.ToString, dtoCarrera.Siglas)
            Execute(SP_UPDATE)
        End Sub

        Public Function GetById(ByVal carreraid As Integer) As CarreraDTO
            AddParemeter(CarreraEnum.CarreraId.ToString, carreraid)

            Dim resultado As DataTable
            resultado = ExecuteResultSet(SP_GETBYID)

            If resultado.Rows.Count = 0 Then
                Return New CarreraDTO()
            End If

            Dim carreraDTO As CarreraDTO = New CarreraDTO
            carreraDTO.Nombre = resultado.Rows(0)(CarreraEnum.Nombre.ToString)
            carreraDTO.Siglas = resultado.Rows(0)(CarreraEnum.Siglas.ToString)

            Return carreraDTO
        End Function

        Public Function GetList1() As System.ComponentModel.BindingList(Of Contracts.DisplayObjects.CarreraDisplayObject)

            Dim resultado As DataTable
            resultado = ExecuteResultSet(SP_GETLIST)

            Dim lista As BindingList(Of CarreraDisplayObject) = New BindingList(Of CarreraDisplayObject)

            For Each renglon As DataRow In resultado.Rows
                Dim display As CarreraDisplayObject = New CarreraDisplayObject
                display.CarreraId = CInt(renglon(CarreraEnum.CarreraId.ToString))
                display.Nombre = renglon(CarreraEnum.Nombre.ToString)
                display.Siglas = renglon(CarreraEnum.Siglas.ToString)

                lista.Add(display)
            Next

            Return lista
        End Function
    End Class


End Namespace