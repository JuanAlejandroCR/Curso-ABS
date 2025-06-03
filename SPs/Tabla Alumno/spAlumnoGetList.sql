IF OBJECT_ID('spAlumnoGetList', 'P') IS NOT NULL
    DROP PROCEDURE spAlumnoGetList;
GO

CREATE PROCEDURE spAlumnoGetList
AS
BEGIN
    SELECT alumnoid, nombre, matricula, apellidopaterno, apellidomaterno, carreraid FROM alumno
END
