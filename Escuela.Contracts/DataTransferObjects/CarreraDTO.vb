Namespace DataTransferObjects
    Public Class CarreraDTO

        Private _carreraid As Integer
        Private _nombre As String
        Private _siglas As String

        Public Property CarreraId() As Integer
            Get
                Return _carreraid
            End Get
            Set(ByVal value As Integer)
                _carreraid = value
            End Set
        End Property

        Public Property Nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
            End Set
        End Property

        Public Property Siglas() As String
            Get
                Return _siglas
            End Get
            Set(ByVal value As String)
                _siglas = value
            End Set
        End Property

    End Class
End Namespace