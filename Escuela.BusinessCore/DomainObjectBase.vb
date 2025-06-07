Imports Escuela.Contracts

Public MustInherit Class DomainObjectBase

    Public MustOverride Sub Insert(ByVal dto As DataTransferObjectBase)
    Public MustOverride Sub Update(ByVal dto As DataTransferObjectBase)
    Public Sub DoSave(ByVal dto As DataTransferObjectBase)
        If dto.IsNew Then
            Insert(dto)
        Else
            Update(dto)
        End If
    End Sub

End Class
