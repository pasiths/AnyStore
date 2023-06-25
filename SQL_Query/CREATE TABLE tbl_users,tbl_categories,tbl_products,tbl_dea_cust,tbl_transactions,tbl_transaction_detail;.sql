USE AnyStore;

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

CREATE TABLE tbl_categories(
id int PRIMARY KEY NOT NULL,
title varchar(50) NOT NULL,
despription text NOT NULL,
added_date datetime NOT NULL,
addded_by int NOT NULL
);

CREATE TABLE tbl_products(
id int primary key not null,
name varchar(50) not null,
category int not null,
description text not null,
rate decimal(18,2) not null,
qty decimal(18,2) not null,
added_date datetime not null,
added_by int not null
);

create table tbl_dea_cust(
id int primary key not null,
type varchar(50) not null,
name varchar(150) not null,
email varchar(150) not null,
contact varchar(15) not null,
address text not null,
added_date datetime not null,
added_by int not null
);

create table tbl_transactions(
id int primary key not null,
dea_cust_id int not null,
grandTotal decimal(18,2) not null,
transaction_date datetime not null,
tax decimal(18,2) not null,
discount decimal(18,2) not null,
added_by int not null
);

create table tbl_transaction_detail(
id int primary key not null,
product_id int not null,
rate decimal(18,2) not null,
qty decimal(18,2) not null,
total decimal(18,2) not null,
dea_cust_id int not null,
added_date datetime not null,
added_by int not null
);