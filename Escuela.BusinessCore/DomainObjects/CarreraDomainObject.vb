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

        'Public Sub Insert(ByVal dto As CarreraDTO) Implements ICarrera.Insert
        '    Dim dao As CarreraDAO = New CarreraDAO

        '    dao.Insert(dto)

        'End Sub

        'Public Sub Update(ByVal dto As CarreraDTO) Implements ICarrera.Update
        '    Dim dao As CarreraDAO = New CarreraDAO

        '    dao.Update(dto)
        'End Sub


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
            Dim dao As CarreraDAO = New CarreraDAO

            dao.Insert(dto)
        End Sub

        Public Overrides Sub Update(ByVal dto As Contracts.DataTransferObjectBase)
            Dim dao As CarreraDAO = New CarreraDAO

            dao.Update(dto)
        End Sub
    End Class
End Namespace