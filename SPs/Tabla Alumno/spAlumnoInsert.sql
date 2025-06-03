IF OBJECT_ID('spAlumnoInsert', 'P') IS NOT NULL
    DROP PROCEDURE spAlumnoInsert;
GO

CREATE PROCEDURE spAlumnoInsert
    @alumnoid INT OUTPUT,
    @nombre VARCHAR(100),
    @matricula VARCHAR(10),
    @apellidopaterno VARCHAR(100),
    @apellidomaterno VARCHAR(100),
    @carreraid INT
AS
BEGIN
    INSERT INTO alumno (nombre, matricula, apellidopaterno, apellidomaterno, carreraid)
    VALUES (@nombre, @matricula, @apellidopaterno, @apellidomaterno, @carreraid)

    SET @alumnoid = SCOPE_IDENTITY()
END
