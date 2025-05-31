CREATE PROCEDURE spCarreraGetList
AS
BEGIN
	SELECT carreraid, nombre, siglas FROM carrera
END