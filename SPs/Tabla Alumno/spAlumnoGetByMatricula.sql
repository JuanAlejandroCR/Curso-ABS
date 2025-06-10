IF OBJECT_ID('spAlumnoGetByMatricula', 'P') IS NOT NULL
    DROP PROCEDURE spAlumnoGetByMatricula;
GO

CREATE PROCEDURE spAlumnoGetByMatricula
    @matricula VARCHAR(10)
AS
BEGIN
    SELECT alumnoid, nombre, matricula, apellidopaterno, apellidomaterno, carreraid FROM alumno WHERE matricula = @matricula
END