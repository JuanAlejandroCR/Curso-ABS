CREATE PROCEDURE spCarreraUpdate
(
@carreraid as INT,
@nombre as VARCHAR(50),
@siglas as VARCHAR(50)
)
AS
BEGIN
	UPDATE carrera SET nombre = @nombre, siglas = @siglas  WHERE carreraid = @carreraid
END