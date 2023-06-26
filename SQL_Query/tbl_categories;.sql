USE AnyStore;

drop table tbl_categories;

CREATE TABLE tbl_categories(
id int PRIMARY KEY NOT NULL,
title varchar(50) NOT NULL,
description text NOT NULL,
added_date datetime NOT NULL,
added_by int NOT NULL
);