Imports System.IO
Imports System.Data.SqlClient

Imports Escuela.BusinessCore.DomainObjects
Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.Services


Public Class Form1



    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        llenaGrid()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim servicio As ICarrera
        servicio = New CarreraDomainObject

        Dim carrera As CarreraDTO = New CarreraDTO
        carrera.Nombre = txtNombre.Text
        carrera.Siglas = txtSiglas.Text

        servicio.Insert(carrera)

        llenaGrid()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim servicio As ICarrera
        servicio = New CarreraDomainObject

        servicio.DeleteById(CInt(txtID.Text))

        llenaGrid()
    End Sub


    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        Dim servicio As ICarrera
        servicio = New CarreraDomainObject

        Dim carrera As CarreraDTO = New CarreraDTO
        carrera.CarreraId = txtID.Text
        carrera.Nombre = txtNombre.Text
        carrera.Siglas = txtSiglas.Text

        servicio.Update(carrera)

        llenaGrid()
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click

        Dim servicio As ICarrera
        servicio = New CarreraDomainObject

        Dim resultadoDTO As CarreraDTO = New CarreraDTO
        resultadoDTO = servicio.GetById(CInt(txtID.Text))

        If resultadoDTO.Nombre = "" Then
            MessageBox.Show("El Id no existe en la tabla")
            Return
        End If

        txtNombre.Text = resultadoDTO.Nombre
        txtSiglas.Text = resultadoDTO.Siglas

    End Sub

    Private Sub llenaGrid()

        Dim servicio As ICarrera
        servicio = New CarreraDomainObject

        dgvCarreras.DataSource = servicio.GetList()
        dgvCarreras.Columns("nombre").Width = 250
    End Sub



    ' Ejemplo para el tema de SP con parámetros de salida
    Private Sub btnArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArea.Click        

        Dim conexion As SqlConnection
        ' Lee el string de conexion a la DB en el archivo curso_01\config\conexion.txt
        Dim rutaBase As String = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\..\"))
        Dim rutaConexion As String = Path.Combine(rutaBase, "config\conexion.txt")

        Dim cadenaConexion As String = File.ReadAllText(rutaConexion)

        conexion = New SqlConnection()
        conexion.ConnectionString = cadenaConexion
        conexion.Open()

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
