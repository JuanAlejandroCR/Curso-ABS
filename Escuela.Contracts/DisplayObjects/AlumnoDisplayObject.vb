Namespace DisplayObjects

    Public Class AlumnoDisplayObject
        Private _alumnoid As Integer
        Private _nombre As String
        Private _matricula As String
        Private _apellidoPaterno As String
        Private _apellidoMaterno As String
        Private _carreraid As Integer

        Public Property AlumnoId() As Integer
            Get
                Return _alumnoid
            End Get
            Set(ByVal value As Integer)
                _alumnoid = value
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

        Public Property Matricula() As String
            Get
                Return _matricula
            End Get
            Set(ByVal value As String)
                _matricula = value
            End Set
        End Property

        Public Property ApellidoPaterno() As String
            Get
                Return _apellidoPaterno
            End Get
            Set(ByVal value As String)
                _apellidoPaterno = value
            End Set
        End Property

        Public Property ApellidoMaterno() As String
            Get
                Return _apellidoMaterno
            End Get
            Set(ByVal value As String)
                _apellidoMaterno = value
            End Set
        End Property

        Public Property CarreraId() As Integer
            Get
                Return _carreraid
            End Get
            Set(ByVal value As Integer)
                _carreraid = value
            End Set
        End Property

    End Class

End Namespace