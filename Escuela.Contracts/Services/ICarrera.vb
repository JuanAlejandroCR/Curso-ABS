Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.DisplayObjects
Imports System.ComponentModel

Namespace Services
    Public Interface ICarrera

        Sub Save(ByVal dto As DataTransferObjectBase)

        Sub DeleteById(ByVal carreraid As Integer)

        Function GetList() As BindingList(Of CarreraDisplayObject)

        Function GetById(ByVal carreraid As Integer) As CarreraDTO

        Function ExisteSigla(ByVal sigla As String) As Boolean

    End Interface
End Namespace
