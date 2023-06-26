USE AnyStore;

DROP TABLE tbl_users;

CREATE TABLE tbl_users(
id int PRIMARY KEY NOT NULL,
first_name varchar(50) NOT NULL,
last_name varchar(50) NOT NULL,
email varchar(50) NOT NULL,
username varchar(50) NOT NULL,
password text NOT NULL,
address text NOT NULL,
gender varchar(10) NOT NULL,
user_type varchar(15) NOT NULL,
added_date datetime NOT NULL,
added_by int NOT NULL
);