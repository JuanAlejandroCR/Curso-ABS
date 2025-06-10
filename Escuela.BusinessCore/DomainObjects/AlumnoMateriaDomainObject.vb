Imports Escuela.Contracts.Services
Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.DisplayObjects
Imports System.ComponentModel
Imports Escuela.BusinessCore.DataAccesObjects
Imports Escuela.Contracts

Namespace DomainObjects
    Public Class AlumnoMateriaDomainObject
        Inherits DomainObjectBase
        Implements IAlumnoMateria

        Public Overrides Sub Insert(ByVal dto As Contracts.DataTransferObjectBase)
            Dim dao As AlumnoMateriaDAO = New AlumnoMateriaDAO()

            dao.Insert(dto)
        End Sub

        Public Overrides Sub Update(ByVal dto As Contracts.DataTransferObjectBase)

        End Sub


        Public Sub Save(ByVal dto As Contracts.DataTransferObjectBase) Implements Contracts.Services.IAlumnoMateria.Save
            DoSave(dto)
        End Sub

        Public Function GetListByAlumnoId(ByVal alumnoid As Integer) As System.ComponentModel.BindingList(Of Contracts.DisplayObjects.AlumnoMateriaDisplayObject) Implements Contracts.Services.IAlumnoMateria.GetListByAlumnoId
            Dim dao As AlumnoMateriaDAO = New AlumnoMateriaDAO()

            Return dao.GetList1ByAlumnoId(alumnoid)
        End Function
    End Class
End Namespace