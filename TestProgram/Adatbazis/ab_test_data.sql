
insert into users (username) values ('Kiss Miklós')
insert into users (username) values ('Nagy Pintyő')
insert into users (username) values ('Csikra Máté')
insert into users (username) values ('Mikro Ádám')

insert into sprint(description, start_date, end_date, status) values ('Mondd igen', '2024-05-06', '2024-06-07', 0)
insert into sprint(description, start_date, end_date, status) values ('Mondd nem', '2024-07-08', '2024-08-09', 0)
insert into sprint(description, start_date, end_date, status) values ('Mondd mittudomen', '2024-06-06', '2024-06-07', 0)
insert into sprint(description, start_date, end_date, status) values ('Mondd mikor', '2024-06-08', '2024-06-09', 0)

insert into task (task_id, user_id, sprint_id, description, est_point, status) values ('PP-4', 1, 1, 'Mondd igen', 3.6, 0)
insert into task (task_id, user_id, sprint_id, description, est_point, status) values ('PP-5', 2, 1, 'Engem nézz', 6.5, 0)
insert into task (task_id, user_id, sprint_id, description, est_point, status) values ('PP-40', 1, 2, 'Mondd igen', 3.6, 0)
insert into task (task_id, user_id, sprint_id, description, est_point, status) values ('PP-16', 1, 3, 'Engem nézz', 6.5, 0)

insert into lobby(sprint_id, user_id, start_date) values (2,1,'2024-11-22')
insert into lobby(sprint_id, user_id, start_date) values (3,2,'2024-11-24')
insert into lobby(sprint_id, user_id, start_date) values (1,3,'2024-6-22')
insert into lobby(sprint_id, user_id, start_date) values (1,4,'2024-1-24')


insert into closed_sprint(sprintC_id, description, start_date, end_date, status) values (1, 'Mondd igen', '2024-01-05', '2024-02-07', 1)
insert into closed_sprint(sprintC_id, description, start_date, end_date, status) values (2, 'Mondd nem', '2024-02-08', '2024-03-02', 1)

insert into closed_task (taskC_id, user_id, sprintC_id, description, est_point, status) values ('PP-2', 1, 1, 'aha', 8.1, 1)
insert into closed_task (taskC_id, user_id, sprintC_id, description, est_point, status ) values ('PP-3', 1, 2, 'jaja', 5.9, 1)



