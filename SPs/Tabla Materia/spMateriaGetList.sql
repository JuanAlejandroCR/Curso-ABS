IF OBJECT_ID('spMateriaGetList', 'P') IS NOT NULL
    DROP PROCEDURE spMateriaGetList;
GO

CREATE PROCEDURE spMateriaGetList
AS
BEGIN
    SELECT 
		materiaid, 
		nombre, 
		creditos 
	FROM materia 
END
