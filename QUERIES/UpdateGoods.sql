USE [GoodsRental_vsrpp_2]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateGoods]    Script Date: 21.09.2017 2:59:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[spUpdateGoods]
	-- Add the parameters for the stored procedure here
	@id INT,
	@name nvarchar(30),
	@type_id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[Goods]
		SET [type_id] = @type_id, 
			[goods_name] = @name 
		WHERE [goods_id] = @id;
END
