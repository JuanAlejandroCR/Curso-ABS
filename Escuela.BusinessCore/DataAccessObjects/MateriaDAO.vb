Imports Escuela.Contracts.DataTransferObjects
Imports System.ComponentModel
Imports Escuela.Contracts.DisplayObjects
Imports Escuela.Contracts
Imports Escuela.Contracts.Enums

Namespace DataAccesObjects
    Public Class MateriaDAO
        Inherits DataAccessObjectBase

        Const SP_GETLIST As String = "spMateriaGetList"

        Public Function GetList1() As System.ComponentModel.BindingList(Of Contracts.DisplayObjects.MateriaDisplayObject)

            Dim resultado As DataTable
            resultado = ExecuteResultSet(SP_GETLIST)

            Dim lista As BindingList(Of MateriaDisplayObject) = New BindingList(Of MateriaDisplayObject)

            For Each renglon As DataRow In resultado.Rows
                Dim display As MateriaDisplayObject = New MateriaDisplayObject
                display.MateriaId = CInt(renglon(MateriaEnum.MateriaId.ToString))
                display.Nombre = renglon(MateriaEnum.Nombre.ToString)
                display.Creditos = renglon(MateriaEnum.Creditos.ToString)

                lista.Add(display)
            Next

            Return lista
        End Function
    End Class
End Namespace


