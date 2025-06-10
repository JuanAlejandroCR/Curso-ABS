Imports Escuela.Contracts.Services
Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.DisplayObjects
Imports System.ComponentModel
Imports Escuela.BusinessCore.DataAccesObjects
Imports Escuela.Contracts

Namespace DomainObjects
    Public Class CarreraDomainObject
        Inherits DomainObjectBase
        Implements ICarrera

        Public Sub DeleteById(ByVal carreraid As Integer) Implements ICarrera.DeleteById
            Dim dao As CarreraDAO = New CarreraDAO

            dao.DeleteById(carreraid)
        End Sub

        Public Function GetById(ByVal carreraid As Integer) As CarreraDTO Implements ICarrera.GetById
            Dim dao As CarreraDAO = New CarreraDAO

            Return dao.GetById(carreraid)
        End Function

        Public Function GetList1() As System.ComponentModel.BindingList(Of Contracts.DisplayObjects.CarreraDisplayObject) Implements Contracts.Services.ICarrera.GetList
            Dim dao As CarreraDAO = New CarreraDAO

            Return dao.GetList1()
        End Function

        Public Sub Save(ByVal dto As Contracts.DataTransferObjectBase) Implements Contracts.Services.ICarrera.Save
            DoSave(dto)
        End Sub

        Public Overrides Sub Insert(ByVal dto As Contracts.DataTransferObjectBase)

            Dim dtoCarrera As CarreraDTO = New CarreraDTO()
            dtoCarrera = CType(dto, CarreraDTO)

            If ExisteSigla(dtoCarrera.Siglas) Then
                Throw New SiglaDuplicadaException
            End If


            Dim dao As CarreraDAO = New CarreraDAO

            dao.Insert(dto)
        End Sub

        Public Overrides Sub Update(ByVal dto As Contracts.DataTransferObjectBase)
            Dim dao As CarreraDAO = New CarreraDAO

            dao.Update(dto)
        End Sub

        Public Function ExisteSigla(ByVal sigla As String) As Boolean Implements Contracts.Services.ICarrera.ExisteSigla
            If sigla = "ISC" Then
                Return True
            Else
                Return False
            End If
        End Function
    End Class
End Namespace