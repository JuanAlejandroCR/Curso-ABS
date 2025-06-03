CREATE PROCEDURE spAreaRectangulo
(
@largo as INT,
@ancho as INT,
@area as INT OUTPUT
)
AS
BEGIN
	SET @area = @largo * @ancho
END