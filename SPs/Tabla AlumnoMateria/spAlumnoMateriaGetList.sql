IF OBJECT_ID('spAlumnoMateriaGetList', 'P') IS NOT NULL
    DROP PROCEDURE spAlumnoMateriaGetList;
GO

CREATE PROCEDURE spAlumnoMateriaGetList
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
END
