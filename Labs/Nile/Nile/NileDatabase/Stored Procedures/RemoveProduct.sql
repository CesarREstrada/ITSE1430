 -- Cesar Estrada
 -- ITSE 1430
 -- November 26, 2018
 -- RemoveProducts.sql

CREATE PROCEDURE [dbo].[RemoveProduct]
    @id INT
AS BEGIN
    SET NOCOUNT ON;

    DELETE FROM Products
    WHERE Id = @id
END
