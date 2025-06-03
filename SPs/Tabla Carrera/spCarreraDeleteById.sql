CREATE PROCEDURE spCarreraDeleteById
(
@carreraid as INT
)
AS
BEGIN
	DELETE carrera WHERE carreraid = @carreraid
END