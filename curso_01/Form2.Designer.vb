<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnListar = New System.Windows.Forms.Button
        Me.btnActualizar = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.txtMatricula = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAlumnoId = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dgvAlumnos = New System.Windows.Forms.DataGridView
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.cmbCarrera = New System.Windows.Forms.ComboBox
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(377, 303)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(75, 23)
        Me.btnListar.TabIndex = 21
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(259, 303)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 20
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(146, 303)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 19
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(42, 303)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 18
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(153, 128)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(107, 20)
        Me.txtMatricula.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Matricula"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(153, 81)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(319, 20)
        Me.txtNombre.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre"
        '
        'txtAlumnoId
        '
        Me.txtAlumnoId.Location = New System.Drawing.Point(153, 42)
        Me.txtAlumnoId.Name = "txtAlumnoId"
        Me.txtAlumnoId.Size = New System.Drawing.Size(100, 20)
        Me.txtAlumnoId.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Id Alumno:"
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(153, 176)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(319, 20)
        Me.txtApellidoPaterno.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Apellido Paterno"
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(153, 223)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(319, 20)
        Me.txtApellidoMaterno.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Apellido Materno"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Id Carrera:"
        '
        'dgvAlumnos
        '
        Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlumnos.Location = New System.Drawing.Point(42, 352)
        Me.dgvAlumnos.Name = "dgvAlumnos"
        Me.dgvAlumnos.Size = New System.Drawing.Size(665, 257)
        Me.dgvAlumnos.TabIndex = 29
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(522, 42)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 30
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'cmbCarrera
        '
        Me.cmbCarrera.FormattingEnabled = True
        Me.cmbCarrera.Location = New System.Drawing.Point(153, 266)
        Me.cmbCarrera.Name = "cmbCarrera"
        Me.cmbCarrera.Size = New System.Drawing.Size(319, 21)
        Me.cmbCarrera.TabIndex = 31
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 679)
        Me.Controls.Add(Me.cmbCarrera)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.dgvAlumnos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtApellidoMaterno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtApellidoPaterno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAlumnoId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAlumnoId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoPaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoMaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents cmbCarrera As System.Windows.Forms.ComboBox
End Class
