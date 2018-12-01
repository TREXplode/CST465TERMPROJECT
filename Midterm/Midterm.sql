GO
CREATE TABLE Questions
(
	ID int primary key identity(1, 1),
	Qusetion varchar(200),
	Answer varchar(250),
	QType varchar(15)
)
GO
CREATE PROCEDURE ID_Get
(
	@ID int = NULL
)
AS
BEGIN
	SELECT *
	FROM Questions
	WHERE ID = @ID;
END
GO
CREATE PROCEDURE QuestGet
(
	@ID int = NULL
)
AS
BEGIN
	SELECT *
	FROM Questions
	WHERE ID = @ID;
END
GO
CREATE PROCEDURE QuestList_Get
AS
BEGIN
	SELECT *
	FROM Questions
	ORDER BY ID;
END
GO
CREATE PROCEDURE Store_Answers
(
	@ID int = NULL,
	@Answer varchar(250)
)
AS
BEGIN
IF @ID IS NOT NULL
	BEGIN
	UPDATE Question SET Answer=@Answer
	WHERE ID=@ID;
	END
END