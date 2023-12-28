create table users(
userID int primary key identity,
username varchar(50) not null,
upassword varchar(100) not null,
uconfirmpassword varchar(100) not null,
)