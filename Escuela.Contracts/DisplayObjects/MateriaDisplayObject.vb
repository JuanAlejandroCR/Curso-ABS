Namespace DisplayObjects

    Public Class MateriaDisplayObject
        Private _materiaid As Integer
        Private _nombre As String
        Private _creditos As Integer

        Public Property MateriaId() As Integer
            Get
                Return _materiaid
            End Get
            Set(ByVal value As Integer)
                _materiaid = value
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

        Public Property Creditos() As String
            Get
                Return _creditos
            End Get
            Set(ByVal value As String)
                _creditos = value
            End Set
        End Property
    End Class

End Namespace