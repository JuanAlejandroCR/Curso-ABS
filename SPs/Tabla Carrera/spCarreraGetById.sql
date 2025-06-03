CREATE PROCEDURE spCarreraGetById
(
@carreraid as INT
)
AS
BEGIN
	SELECT nombre, siglas FROM carrera WHERE carreraid = @carreraid
END