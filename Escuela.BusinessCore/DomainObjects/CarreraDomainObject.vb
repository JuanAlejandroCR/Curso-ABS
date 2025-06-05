Imports Escuela.Contracts.Services
Imports Escuela.Contracts.DataTransferObjects

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

        Public Function GetList() As DataTable Implements ICarrera.GetList
            Dim db As DB
            db = New DB()

            Return db.ExecuteResultSet("spCarreraGetList")
        End Function

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

    End Class
End Namespace