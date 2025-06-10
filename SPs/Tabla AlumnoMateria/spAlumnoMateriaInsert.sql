IF OBJECT_ID('spAlumnoMateriaInsert', 'P') IS NOT NULL
    DROP PROCEDURE spAlumnoMateriaInsert;
GO

CREATE PROCEDURE spAlumnoMateriaInsert
    @alumnoid INT,
    @materiaid INT
AS
BEGIN
    INSERT INTO alumnoMateria (alumnoid, materiaid)
    VALUES (@alumnoid, @materiaid)
    
END
