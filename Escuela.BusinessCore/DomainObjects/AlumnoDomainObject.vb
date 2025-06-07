Imports Escuela.Contracts.Services
Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.DisplayObjects
Imports System.ComponentModel
Imports Escuela.BusinessCore.DataAccesObjects
Imports Escuela.Contracts

Namespace DomainObjects
    Public Class AlumnoDomainObject
        Inherits DomainObjectBase
        Implements IAlumno


        Public Overrides Sub Insert(ByVal dto As Contracts.DataTransferObjectBase)
            Dim dao As AlumnoDAO = New AlumnoDAO

            dao.Insert(dto)
        End Sub

        Public Overrides Sub Update(ByVal dto As Contracts.DataTransferObjectBase)
            Dim dao As AlumnoDAO = New AlumnoDAO

            dao.Update(dto)
        End Sub

        Public Sub DeleteById(ByVal alumnoid As Integer) Implements Contracts.Services.IAlumno.DeleteById
            Dim dao As AlumnoDAO = New AlumnoDAO

            dao.DeleteById(alumnoid)
        End Sub

        Public Function GetById(ByVal alumnoid As Integer) As Contracts.DataTransferObjects.AlumnoDTO Implements Contracts.Services.IAlumno.GetById
            Dim dao As AlumnoDAO = New AlumnoDAO

            Return dao.GetById(alumnoid)
        End Function

        Public Function GetList() As System.ComponentModel.BindingList(Of Contracts.DisplayObjects.AlumnoDisplayObject) Implements Contracts.Services.IAlumno.GetList
            Dim dao As AlumnoDAO = New AlumnoDAO

            Return dao.GetList1()
        End Function

        Public Sub Save(ByVal dto As Contracts.DataTransferObjectBase) Implements Contracts.Services.IAlumno.Save
            DoSave(dto)
        End Sub

    End Class
End Namespace