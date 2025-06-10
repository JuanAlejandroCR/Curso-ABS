<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMatricula = New System.Windows.Forms.TextBox
        Me.txtId = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.Materia = New System.Windows.Forms.Label
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.dgvMateriasAlumno = New System.Windows.Forms.DataGridView
        Me.cmbMaterias = New System.Windows.Forms.ComboBox
        CType(Me.dgvMateriasAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matricula:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Id:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre:"
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(115, 62)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(100, 20)
        Me.txtMatricula.TabIndex = 3
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(115, 100)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(115, 132)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(193, 20)
        Me.txtNombre.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(337, 55)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Materia
        '
        Me.Materia.AutoSize = True
        Me.Materia.Location = New System.Drawing.Point(39, 202)
        Me.Materia.Name = "Materia"
        Me.Materia.Size = New System.Drawing.Size(45, 13)
        Me.Materia.TabIndex = 8
        Me.Materia.Text = "Materia:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(337, 197)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvMateriasAlumno
        '
        Me.dgvMateriasAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMateriasAlumno.Location = New System.Drawing.Point(42, 260)
        Me.dgvMateriasAlumno.Name = "dgvMateriasAlumno"
        Me.dgvMateriasAlumno.Size = New System.Drawing.Size(500, 150)
        Me.dgvMateriasAlumno.TabIndex = 10
        '
        'cmbMaterias
        '
        Me.cmbMaterias.FormattingEnabled = True
        Me.cmbMaterias.Location = New System.Drawing.Point(115, 197)
        Me.cmbMaterias.Name = "cmbMaterias"
        Me.cmbMaterias.Size = New System.Drawing.Size(121, 21)
        Me.cmbMaterias.TabIndex = 11
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 493)
        Me.Controls.Add(Me.cmbMaterias)
        Me.Controls.Add(Me.dgvMateriasAlumno)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Materia)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.dgvMateriasAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Materia As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dgvMateriasAlumno As System.Windows.Forms.DataGridView
    Friend WithEvents cmbMaterias As System.Windows.Forms.ComboBox
End Class
