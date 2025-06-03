Imports System.IO
Imports System.Data.SqlClient


Public Class Form1

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

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim comando As SqlCommand
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "spCarreraInsert"
        comando.CommandType = CommandType.StoredProcedure

        Dim parCarrearaId As SqlParameter
        parCarrearaId = New SqlParameter
        parCarrearaId.ParameterName = "carreraid"
        parCarrearaId.Value = 0
        parCarrearaId.Direction = ParameterDirection.Output

        comando.Parameters.Add(parCarrearaId)

        Dim parNombre As SqlParameter
        parNombre = New SqlParameter
        parNombre.ParameterName = "nombre"
        parNombre.Value = txtNombre.Text

        comando.Parameters.Add(parNombre)

        Dim parSiglas As SqlParameter
        parSiglas = New SqlParameter
        parSiglas.ParameterName = "siglas"
        parSiglas.Value = txtSiglas.Text

        comando.Parameters.Add(parSiglas)


        comando.ExecuteNonQuery()

        txtID.Text = comando.Parameters("carreraid").Value

        llenaGrid()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim comando As SqlCommand
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "spCarreraDeleteById"
        comando.CommandType = CommandType.StoredProcedure

        Dim parCarrearaId As SqlParameter
        parCarrearaId = New SqlParameter
        parCarrearaId.ParameterName = "carreraid"
        parCarrearaId.Value = CInt(txtID.Text)

        comando.Parameters.Add(parCarrearaId)

        comando.ExecuteNonQuery()
        llenaGrid()
    End Sub


    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        Dim comando As SqlCommand
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "spCarreraUpdate"
        comando.CommandType = CommandType.StoredProcedure

        Dim parNombre As SqlParameter
        parNombre = New SqlParameter
        parNombre.ParameterName = "nombre"
        parNombre.Value = txtNombre.Text

        comando.Parameters.Add(parNombre)

        Dim parSiglas As SqlParameter
        parSiglas = New SqlParameter
        parSiglas.ParameterName = "siglas"
        parSiglas.Value = txtSiglas.Text

        comando.Parameters.Add(parSiglas)

        Dim parCarrearaId As SqlParameter
        parCarrearaId = New SqlParameter
        parCarrearaId.ParameterName = "carreraid"
        parCarrearaId.Value = CInt(txtID.Text)

        comando.Parameters.Add(parCarrearaId)


        comando.ExecuteNonQuery()
        llenaGrid()
    End Sub

    Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click

        Dim comando As SqlCommand
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "spCarreraGetList"
        comando.CommandType = CommandType.StoredProcedure        

        Dim resultados As DataSet
        resultados = New DataSet()

        Dim adaptador As SqlDataAdapter
        adaptador = New SqlDataAdapter()

        adaptador.SelectCommand = comando
        adaptador.Fill(resultados, "carreras")

        dgvCarreras.DataSource = resultados.Tables("carreras")
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click

        Dim comando As SqlCommand
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "spCarreraGetById"
        comando.CommandType = CommandType.StoredProcedure

        Dim parCarrearaId As SqlParameter
        parCarrearaId = New SqlParameter
        parCarrearaId.ParameterName = "carreraid"
        parCarrearaId.Value = CInt(txtID.Text)

        comando.Parameters.Add(parCarrearaId)

        Dim resultados As DataSet
        resultados = New DataSet()

        Dim adaptador As SqlDataAdapter
        adaptador = New SqlDataAdapter()

        adaptador.SelectCommand = comando
        adaptador.Fill(resultados, "carreras")

        If resultados.Tables("carreras").Rows.Count = 0 Then
            MessageBox.Show("El Id no existe en la tabla")
            Return
        End If


        txtNombre.Text = resultados.Tables("carreras").Rows(0)("nombre")
        txtSiglas.Text = resultados.Tables("carreras").Rows(0)("siglas")

    End Sub

    Private Sub llenaGrid()
        Dim comando As SqlCommand
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "spCarreraGetList"
        comando.CommandType = CommandType.StoredProcedure

        Dim resultados As DataSet
        resultados = New DataSet()

        Dim adaptador As SqlDataAdapter
        adaptador = New SqlDataAdapter()
        adaptador.SelectCommand = comando
        adaptador.Fill(resultados, "carreras")

        dgvCarreras.DataSource = resultados.Tables("carreras")
        dgvCarreras.Columns("nombre").Width = 250
    End Sub


    Private Sub btnArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArea.Click
        ' Ejemplo para el tema de SP con parámetros de salida
        Dim comando As SqlCommand
        comando = New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "spAreaDeRectangulo"
        comando.CommandType = CommandType.StoredProcedure

        Dim parLargo As SqlParameter
        parLargo = New SqlParameter
        parLargo.ParameterName = "largo"
        parLargo.Value = CInt(txtLargo.Text)

        comando.Parameters.Add(parLargo)

        Dim parAncho As SqlParameter
        parAncho = New SqlParameter
        parAncho.ParameterName = "ancho"
        parAncho.Value = txtAncho.Text

        comando.Parameters.Add(parAncho)

        Dim parArea As SqlParameter
        parArea = New SqlParameter
        parArea.ParameterName = "area"
        parArea.Value = 0
        parArea.Direction = ParameterDirection.Output

        comando.Parameters.Add(parArea)

        comando.ExecuteNonQuery()

        txtResultado.Text = comando.Parameters("area").Value

    End Sub
End Class
