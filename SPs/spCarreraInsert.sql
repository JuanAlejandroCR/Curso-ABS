CREATE PROCEDURE spCarreraInsert

@carreraid as INT,
@nombre as VARCHAR(50),
@siglas as VARCHAR(50)

AS
BEGIN
	INSERT INTO carrera (carreraid, nombre, siglas) VALUES (@carreraid, @nombre, @siglas)
END