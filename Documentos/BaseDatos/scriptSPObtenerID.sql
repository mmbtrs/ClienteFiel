USE [CLIENTE_FIEL]
GO

/****** Object:  StoredProcedure [dbo].[spObtenerID]    Script Date: 28/09/2017 12:13:48 a.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spObtenerID] 
	-- Add the parameters for the stored procedure here
	@tabla nvarchar(50) = NULL,
	@valor int OUTPUT
AS
BEGIN
	BEGIN TRANSACTION
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	--DECLARE @valor int;
    -- Insert statements for procedure here
	SELECT @valor=valor 
	FROM SECUENCIAS
	WHERE tabla = @tabla;
	UPDATE SECUENCIAS 
	SET valor = @valor+1
	WHERE tabla = @tabla;
	COMMIT;
END




GO

