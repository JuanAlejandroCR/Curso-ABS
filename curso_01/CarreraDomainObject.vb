Public Class CarreraDomainObject
    Implements ICarrera

    Public Sub DeleteById(ByVal carreraid As Integer) Implements ICarrera.DeleteById
        Dim db As DB
        db = New DB()
        db.AddParemeter("carreraid", carreraid)
        db.Execute("spCarreraDeleteById")
    End Sub

    Public Sub Insert(ByVal nombre As String, ByVal siglas As String) Implements ICarrera.Insert
        Dim db As DB
        db = New DB()
        db.AddParemeter("nombre", nombre)
        db.AddParemeter("siglas", siglas)
        db.AddOutputParameter("carreraid", 0, 0)
        db.Execute("spCarreraInsert")

        Form1.txtID.Text = db.OutParameter("carreraid")
    End Sub

    Public Sub Update(ByVal carreraid As Integer, ByVal nombre As String, ByVal siglas As String) Implements ICarrera.Update
        Dim db As DB
        db = New DB()
        db.AddParemeter("carreraid", carreraid)
        db.AddParemeter("nombre", nombre)
        db.AddParemeter("siglas", siglas)
        db.Execute("spCarreraUpdate")
    End Sub
End Class
