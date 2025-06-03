Imports System.IO
Imports System.Data.SqlClient


Public Class Form2

    Dim conexion As SqlConnection

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        ' Lee el string de conexion a la DB en el archivo config\conexion.txt
        Dim rutaBase As String = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\"))
        Dim rutaConexion As String = Path.Combine(rutaBase, "config\conexion.txt")

        Dim cadenaConexion As String = File.ReadAllText(rutaConexion)

        conexion = New SqlConnection()
        conexion.ConnectionString = cadenaConexion
        conexion.Open()

        llenaGrid()
    End Sub

    Private Sub llenaGrid()
        Dim comando As SqlCommand
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "spAlumnoGetList"
        comando.CommandType = CommandType.StoredProcedure

        Dim resultados As DataSet
        resultados = New DataSet()

        Dim adaptador As SqlDataAdapter
        adaptador = New SqlDataAdapter()
        adaptador.SelectCommand = comando
        adaptador.Fill(resultados, "alumnos")

        dgvAlumnos.DataSource = resultados.Tables("alumnos")        
    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim comando As SqlCommand
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "spAlumnoInsert"
        comando.CommandType = CommandType.StoredProcedure

        Dim parNombre As SqlParameter
        parNombre = New SqlParameter
        parNombre.ParameterName = "nombre"
        parNombre.Value = txtNombre.Text

        comando.Parameters.Add(parNombre)

        Dim parMatricula As SqlParameter
        parMatricula = New SqlParameter
        parMatricula.ParameterName = "matricula"
        parMatricula.Value = txtMatricula.Text

        comando.Parameters.Add(parMatricula)

        Dim parApellidoPaterno As SqlParameter
        parApellidoPaterno = New SqlParameter
        parApellidoPaterno.ParameterName = "apellidopaterno"
        parApellidoPaterno.Value = txtApellidoPaterno.Text

        comando.Parameters.Add(parApellidoPaterno)

        Dim parApellidoMaterno As SqlParameter
        parApellidoMaterno = New SqlParameter
        parApellidoMaterno.ParameterName = "apellidomaterno"
        parApellidoMaterno.Value = txtApellidoMaterno.Text

        comando.Parameters.Add(parApellidoMaterno)

        Dim parCarreraId As SqlParameter
        parCarreraId = New SqlParameter
        parCarreraId.ParameterName = "carreraid"
        parCarreraId.Value = txtCarreraId.Text

        comando.Parameters.Add(parCarreraId)

        Dim parAlumnoId As SqlParameter
        parAlumnoId = New SqlParameter
        parAlumnoId.ParameterName = "alumnoid"
        parAlumnoId.Value = 0
        parAlumnoId.Direction = ParameterDirection.Output

        comando.Parameters.Add(parAlumnoId)


        comando.ExecuteNonQuery()

        txtAlumnoId.Text = comando.Parameters("alumnoid").Value

        llenaGrid()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim comando As SqlCommand
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "spAlumnoDeleteById"
        comando.CommandType = CommandType.StoredProcedure

        Dim parAlumnoId As SqlParameter
        parAlumnoId = New SqlParameter
        parAlumnoId.ParameterName = "alumnoid"
        parAlumnoId.Value = CInt(txtAlumnoId.Text)

        comando.Parameters.Add(parAlumnoId)

        comando.ExecuteNonQuery()
        llenaGrid()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim comando As SqlCommand
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "spAlumnoUpdate"
        comando.CommandType = CommandType.StoredProcedure


        Dim parAlumnoId As SqlParameter
        parAlumnoId = New SqlParameter
        parAlumnoId.ParameterName = "alumnoid"
        parAlumnoId.Value = CInt(txtAlumnoId.Text)

        comando.Parameters.Add(parAlumnoId)

        Dim parNombre As SqlParameter
        parNombre = New SqlParameter
        parNombre.ParameterName = "nombre"
        parNombre.Value = txtNombre.Text

        comando.Parameters.Add(parNombre)

        Dim parMatricula As SqlParameter
        parMatricula = New SqlParameter
        parMatricula.ParameterName = "matricula"
        parMatricula.Value = txtMatricula.Text

        comando.Parameters.Add(parMatricula)

        Dim parApellidoPaterno As SqlParameter
        parApellidoPaterno = New SqlParameter
        parApellidoPaterno.ParameterName = "apellidopaterno"
        parApellidoPaterno.Value = txtApellidoPaterno.Text

        comando.Parameters.Add(parApellidoPaterno)

        Dim parApellidoMaterno As SqlParameter
        parApellidoMaterno = New SqlParameter
        parApellidoMaterno.ParameterName = "apellidomaterno"
        parApellidoMaterno.Value = txtApellidoMaterno.Text

        comando.Parameters.Add(parApellidoMaterno)

        Dim parCarreraId As SqlParameter
        parCarreraId = New SqlParameter
        parCarreraId.ParameterName = "carreraid"
        parCarreraId.Value = txtCarreraId.Text

        comando.Parameters.Add(parCarreraId)

        comando.ExecuteNonQuery()

        llenaGrid()
    End Sub

    Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
        llenaGrid()
    End Sub

End Class