IF OBJECT_ID('spAlumnoGetById', 'P') IS NOT NULL
    DROP PROCEDURE spAlumnoGetById;
GO

CREATE PROCEDURE spAlumnoGetById
    @alumnoid INT
AS
BEGIN
    SELECT alumnoid, nombre, matricula, apellidopaterno, apellidomaterno, carreraid FROM alumno WHERE alumnoid = @alumnoid
END
