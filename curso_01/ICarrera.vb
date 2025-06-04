Public Interface ICarrera

    Sub Insert(ByVal nombre As String, ByVal siglas As String)

    Sub DeleteById(ByVal carreraid As Integer)

    Sub Update(ByVal carreraid As Integer, ByVal nombre As String, ByVal siglas As String)

End Interface
