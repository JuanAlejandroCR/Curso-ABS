Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.DisplayObjects
Imports System.ComponentModel

Namespace Services
    Public Interface IAlumnoMateria

        Sub Save(ByVal dto As DataTransferObjectBase)

        Function GetListByAlumnoId(ByVal alumnoid As Integer) As BindingList(Of AlumnoMateriaDisplayObject)

    End Interface
End Namespace

