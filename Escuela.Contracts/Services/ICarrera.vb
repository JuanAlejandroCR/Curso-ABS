Imports Escuela.Contracts.DataTransferObjects

Namespace Services
    Public Interface ICarrera

        Sub Insert(ByVal dto As CarreraDTO)

        Sub DeleteById(ByVal carreraid As Integer)

        Sub Update(ByVal dto As CarreraDTO)

        Function GetList() As DataTable

        Function GetById(ByVal carreraid As Integer) As CarreraDTO

    End Interface
End Namespace
