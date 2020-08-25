-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
-- =============================================
-- Author:		권희경
-- Create date: 2020-06-26
-- Description:	구직글 조회수 증가 프로시저
-- =============================================
--CREATE PROCEDURE RecruitCountPlus
--	@w_num int
--AS
--BEGIN
	
--	update RECRUIT set COUNT = COUNT+1 where W_NUM = @w_num;
--END
--GO

--create procedure RESUME

--	@re_num int,
--	@id nvarchar(4000),
--	@name nvarchar(100),
--	@addr nvarchar(100),
--	@email nvarchar(100),
--	@phone nvarchar(50),
--	@re_subject nvarchar(50),
--	@license nvarchar(50),
--	@exp nvarchar(50),
--	@content nvarchar(100),
--	@location nvarchar(50)
--as
--begin
--	select null;
--end
--go

select * from INFORMATION_SCHEMA.ROUTINES
--저장된 모든 프로시저 조회
drop procedure sp_renamediagram;

USE [TodayWork]
GO

create procedure [dbo].[A_LIST]

	@w_num int,
	@a_id nvarchar(50),
	@a_name nvarchar(50),
	@a_phone nvarchar(50),
	@a_addr nvarchar(50),
	@a_com_name nvarchar(50),
	@a_com_field nvarchar(50),
	@a_com_pay nvarchar(50),
	@a_com_place nvarchar(50)

as
begin
	select
	null
end
go