CREATE TABLE [dbo].[MovieStudio]
(
	[MovieId] INT NOT NULL , 
    [StudioId] INT NOT NULL, 
    CONSTRAINT [FK_MovieStudio_Movies] FOREIGN KEY ([MovieId]) REFERENCES Movies(Id), 
    CONSTRAINT [FK_MovieStudio_Studios] FOREIGN KEY ([StudioId]) REFERENCES Studios(Id)
)
