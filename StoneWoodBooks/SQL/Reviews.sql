﻿USE [C:\USERS\DEVIN\SOURCE\REPOS\STONEWOODBOOKS\STONEWOODBOOKS\APP_DATA\STONEWOODDATA.MDF]

CREATE TABLE [dbo].[BookReviews](
[ISBN] INT FOREIGN KEY REFERENCES Books(ISBN),
[Username] VARCHAR(12) FOREIGN KEY REFERENCES Customer(Username),
[Description] VARCHAR(140),
[NumStars] int NOT NULL,
CONSTRAINT Pk_BookReviews PRIMARY KEY CLUSTERED (ISBN, Username));