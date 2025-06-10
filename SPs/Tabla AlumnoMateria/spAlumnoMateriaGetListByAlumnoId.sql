IF OBJECT_ID('spAlumnoMateriaGetListByAlumnoId', 'P') IS NOT NULL
    DROP PROCEDURE spAlumnoMateriaGetListByAlumnoId;
GO

CREATE PROCEDURE spAlumnoMateriaGetListByAlumnoId
	@alumnoid INT
AS
BEGIN
    SELECT 
	  am.alumnoid,
	  am.materiaid,
	  m.nombre AS materia	  
	FROM 
	  alumnoMateria am
	JOIN 
	  materia m ON am.materiaid = m.materiaid
	WHERE
		am.alumnoid = @alumnoid
END
