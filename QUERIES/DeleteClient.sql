USE [GoodsRental_vsrpp_2]
GO
/****** Object:  StoredProcedure [dbo].[spDeleteClient]    Script Date: 21.09.2017 2:18:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spDeleteClient] 
	-- Add the parameters for the stored procedure here
	@id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM [dbo].[Client] where [client_id] = @id
END
