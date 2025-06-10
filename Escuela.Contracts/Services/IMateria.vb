Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.DisplayObjects
Imports System.ComponentModel

Namespace Services
    Public Interface IMateria

        Function GetList() As BindingList(Of MateriaDisplayObject)

    End Interface
End Namespace

