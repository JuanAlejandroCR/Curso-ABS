Namespace DisplayObjects

    Public Class AlumnoMateriaDisplayObject
        Private _alumnoid As Integer
        Private _materiaid As Integer
        Private _materia As String

        Public Property AlumnoId() As Integer
            Get
                Return _alumnoid
            End Get
            Set(ByVal value As Integer)
                _alumnoid = value
            End Set
        End Property

        Public Property MateriaId() As Integer
            Get
                Return _materiaid
            End Get
            Set(ByVal value As Integer)
                _materiaid = value
            End Set
        End Property

        Public Property Materia() As String
            Get
                Return _materia
            End Get
            Set(ByVal value As String)
                _materia = value
            End Set
        End Property
    End Class

End Namespace