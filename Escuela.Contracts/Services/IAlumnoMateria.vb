Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.DisplayObjects
Imports System.ComponentModel

Namespace Services
    Public Interface IAlumnoMateria

        Sub Save(ByVal dto As DataTransferObjectBase)

        Function GetList() As BindingList(Of AlumnoMateriaDisplayObject)

    End Interface
End Namespace

