-- Cesar Estrada
-- ITSE 1430
-- November 26, 2018
-- GetProduct.sql

CREATE PROCEDURE [dbo].[GetProduct]
    @id INT
AS BEGIN
    SET NOCOUNT ON;

    SELECT Id, Name, Price, Description, IsDiscontinued
    FROM Products
    WHERE Id = @id
END
