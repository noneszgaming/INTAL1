
insert into users (username) values ('Kiss Miklós')
insert into users (username) values ('Nagy Pintyő')
insert into users (username) values ('Csikra Máté')
insert into users (username) values ('Mikro Ádám')

insert into sprints(description, start_date, end_date, status) values ('Mondd igen', '2024-05-06', '2024-06-07', 0)
insert into sprints(description, start_date, end_date, status) values ('Mondd nem', '2024-07-08', '2024-08-09', 0)
insert into sprints(description, start_date, end_date, status) values ('Mondd mittudomen', '2024-06-06', '2024-06-07', 0)
insert into sprints(description, start_date, end_date, status) values ('Mondd mikor', '2024-06-08', '2024-06-09', 0)

insert into tasks (task_id, sprint_id, description, est_point, status) values ('PP-4', 1, 'Mondd igen', 3.6, 0)
insert into tasks (task_id, sprint_id, description, est_point, status) values ('PP-5', 2, 'Engem nézz', 6.5, 0)
insert into tasks (task_id, sprint_id, description, est_point, status) values ('PP-40', 3, 'Mondd igen', 3.6, 0)
insert into tasks (task_id, sprint_id, description, est_point, status) values ('PP-16', 1, 'Engem nézz', 6.5, 0)

insert into lobbies(user_id) values (1)
insert into lobbies(user_id) values (2)
insert into lobbies(user_id) values (3)
insert into lobbies(user_id) values (1)




