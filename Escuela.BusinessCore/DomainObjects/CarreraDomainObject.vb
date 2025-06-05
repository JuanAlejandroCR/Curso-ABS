Imports Escuela.Contracts.Services
Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.DisplayObjects
Imports System.ComponentModel

Namespace DomainObjects
    Public Class CarreraDomainObject
        Implements ICarrera

        Public Sub DeleteById(ByVal carreraid As Integer) Implements ICarrera.DeleteById
            Dim db As DB
            db = New DB()
            db.AddParemeter("carreraid", carreraid)
            db.Execute("spCarreraDeleteById")
        End Sub

        Public Sub Insert(ByVal dto As CarreraDTO) Implements ICarrera.Insert
            Dim db As DB
            db = New DB()
            db.AddParemeter("nombre", dto.Nombre)
            db.AddParemeter("siglas", dto.Siglas)
            db.AddOutputParameter("carreraid", 0, 0)
            db.Execute("spCarreraInsert")

        End Sub

        Public Sub Update(ByVal dto As CarreraDTO) Implements ICarrera.Update
            Dim db As DB
            db = New DB()
            db.AddParemeter("carreraid", dto.CarreraId)
            db.AddParemeter("nombre", dto.Nombre)
            db.AddParemeter("siglas", dto.Siglas)
            db.Execute("spCarreraUpdate")
        End Sub


        Public Function GetById(ByVal carreraid As Integer) As CarreraDTO Implements ICarrera.GetById
            Dim db As DB = New DB()
            db.AddParemeter("carreraid", carreraid)

            Dim resultado As DataTable
            resultado = db.ExecuteResultSet("spCarreraGetById")

            If resultado.Rows.Count = 0 Then
                Return New CarreraDTO()
            End If

            Dim carreraDTO As CarreraDTO = New CarreraDTO
            carreraDTO.Nombre = resultado.Rows(0)("nombre")
            carreraDTO.Siglas = resultado.Rows(0)("siglas")

            Return carreraDTO
        End Function

        Public Function GetList1() As System.ComponentModel.BindingList(Of Contracts.DisplayObjects.CarreraDisplayObject) Implements Contracts.Services.ICarrera.GetList
            Dim db As DB
            db = New DB()

            Dim resultado As DataTable
            resultado = db.ExecuteResultSet("spCarreraGetList")

            Dim lista As BindingList(Of CarreraDisplayObject) = New BindingList(Of CarreraDisplayObject)

            For Each renglon As DataRow In resultado.Rows
                Dim display As CarreraDisplayObject = New CarreraDisplayObject
                display.CarreraId = CInt(renglon("carreraid"))
                display.Nombre = renglon("nombre")
                display.Siglas = renglon("siglas")

                lista.Add(display)
            Next

            Return lista
        End Function
    End Class
End Namespace