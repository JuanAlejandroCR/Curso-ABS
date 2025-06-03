IF OBJECT_ID('spAlumnoDeleteById', 'P') IS NOT NULL
    DROP PROCEDURE spAlumnoDeleteById;
GO

CREATE PROCEDURE spAlumnoDeleteById
    @alumnoid INT
AS
BEGIN
    DELETE alumno WHERE alumnoid = @alumnoid
END
