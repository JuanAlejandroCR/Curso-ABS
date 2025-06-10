Imports Escuela.Contracts.Services
Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.DisplayObjects
Imports System.ComponentModel
Imports Escuela.BusinessCore.DataAccesObjects
Imports Escuela.Contracts

Namespace DomainObjects
    Public Class MateriaDomainObject
        Inherits DomainObjectBase
        Implements IMateria

        Public Function GetList() As System.ComponentModel.BindingList(Of Contracts.DisplayObjects.MateriaDisplayObject) Implements Contracts.Services.IMateria.GetList
            Dim dao As MateriaDAO = New MateriaDAO()

            Return dao.GetList1()
        End Function

        Public Overrides Sub Insert(ByVal dto As Contracts.DataTransferObjectBase)

        End Sub

        Public Overrides Sub Update(ByVal dto As Contracts.DataTransferObjectBase)

        End Sub
    End Class
End Namespace