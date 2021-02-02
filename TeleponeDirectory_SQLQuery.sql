create database TeleponeDirectory
use TeleponeDirectory
create table Directory
(
DirectoryId int identity(1,1) primary key,
Firstname nvarchar(max),
LastName nvarchar(max),
EmailAddress nvarchar(max),
Telepone1 nvarchar(max),
Telepone2 nvarchar(max),
Telepone3 nvarchar(max),
FacebookURI nvarchar(max),
TwiterURI nvarchar(max),
YoutubeURI nvarchar(max),
Explanation nvarchar(max)
)

create table UserLogin
(
Id int identity(1,1) primary key,
UserName nvarchar(max),
UserPassword nvarchar(max)
)

insert into UserLogin values ('deneme','1')