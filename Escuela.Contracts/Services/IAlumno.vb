Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.DisplayObjects
Imports System.ComponentModel

Namespace Services
    Public Interface IAlumno
        Sub Save(ByVal dto As DataTransferObjectBase)

        Sub DeleteById(ByVal alumnoid As Integer)

        Function GetList() As BindingList(Of AlumnoDisplayObject)

        Function GetById(ByVal alumnoid As Integer) As AlumnoDTO
    End Interface
End Namespace

