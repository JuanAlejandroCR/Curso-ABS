Namespace DataTransferObjects
    Public Class AlumnoMateriaDTO
        Inherits DataTransferObjectBase

        Private _alumnoid As Integer
        Private _materiaid As Integer        

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

    End Class
End Namespace