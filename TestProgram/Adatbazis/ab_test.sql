create database planningpoker
go

use planningpoker

create table tasks
(
task_id varchar(6) not null,
user_id int not null,
sprint_id int not null,
description char(255),
est_point float,
status bit not null default 0,
primary key (task_id)
)


create table users
(
user_id int not null identity (1,1),
username varchar(30),
primary key (user_id)
)


create table lobbies
(
lobby_id int not null identity (1,1),
sprint_id int,
user_id int,
start_date date,
primary key (lobby_id)
)


create table sprints
(
sprint_id int not null identity (1,1), 
description char(255), 
start_date date, 
end_date date,
status bit not null DEFAULT 0
primary key (sprint_id)
)



create table closed_sprints (
sprintC_id int not null,
description varchar(255),
start_date date,
end_date date,
status bit,
primary key (sprintC_id)
)


create table closed_tasks
(
taskC_id varchar(6) not null,
user_id int,
sprintC_id int,
description varchar(255),
est_point float,
status bit,
primary key (taskC_id)
)


alter table closed_tasks
add foreign key (sprintC_id) references closed_sprints (sprintC_id)
alter table closed_tasks
add foreign key (user_id) references users (user_id)


alter table tasks
add foreign key (sprint_id) references sprints (sprint_id)
alter table tasks
add foreign key (user_id) references users (user_id)



alter table lobbies
add foreign key (sprint_id) references sprints (sprint_id)
alter table lobbies
add foreign key (user_id) references users (user_id)



