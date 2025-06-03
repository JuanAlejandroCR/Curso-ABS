IF OBJECT_ID('spAlumnoUpdate', 'P') IS NOT NULL
    DROP PROCEDURE spAlumnoUpdate;
GO

CREATE PROCEDURE spAlumnoUpdate
    @alumnoid INT OUTPUT,
    @nombre VARCHAR(100),
    @matricula VARCHAR(10),
    @apellidopaterno VARCHAR(100),
    @apellidomaterno VARCHAR(100),
    @carreraid INT
AS
BEGIN
    UPDATE alumno SET nombre = @nombre, matricula = @matricula, apellidopaterno = @apellidopaterno, apellidomaterno = @apellidomaterno, carreraid = @carreraid  
	WHERE alumnoid = @alumnoid
END