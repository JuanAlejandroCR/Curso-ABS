Imports System.IO
Imports System.Data.SqlClient

Public Class DataAccessObjectBase
    Private conexion As SqlConnection
    Private comando As SqlCommand

    Sub New()
        ' Se realiza la conexión a la DB en este sub (constructor), leyendo el archivo curso_01\config\conexion.txt
        Dim rutaBase As String = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\..\..\"))
        Dim rutaConexion As String = Path.Combine(rutaBase, "config\conexion.txt")
        Dim cadenaConexion As String = File.ReadAllText(rutaConexion)

        conexion = New SqlConnection()
        conexion.ConnectionString = cadenaConexion
        conexion.Open()

        comando = New SqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.Connection = conexion
    End Sub

    Public Sub AddParemeter(ByVal name As String, ByVal value As Object)
        Dim parametro As SqlParameter
        parametro = New SqlParameter
        parametro.ParameterName = name
        parametro.Value = value
        comando.Parameters.Add(parametro)
    End Sub

    Public Sub AddOutputParameter(ByVal name As String, ByVal value As Object, ByVal size As Integer)
        Dim parametro As SqlParameter
        parametro = New SqlParameter
        parametro.ParameterName = name
        parametro.Value = value
        parametro.Direction = ParameterDirection.Output

        ' El parametro size, cuando el output es de tipo int el valor será 0
        parametro.Size = size
        comando.Parameters.Add(parametro)
    End Sub

    Public Function OutParameter(ByVal name As String) As Object
        Return comando.Parameters(name).Value
    End Function

    Public Function ExecuteResultSet(ByVal sp As String) As DataTable
        comando.CommandText = sp
        Dim resultados As DataSet
        resultados = New DataSet()

        Dim adaptador As SqlDataAdapter
        adaptador = New SqlDataAdapter()
        adaptador.SelectCommand = comando
        adaptador.Fill(resultados, "tabla")

        Return resultados.Tables("tabla")
    End Function

    Public Sub Execute(ByVal sp As String)
        comando.CommandText = sp
        comando.ExecuteNonQuery()
    End Sub

End Class
