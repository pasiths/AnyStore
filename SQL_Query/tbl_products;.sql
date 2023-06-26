use AnyStore;

drop table tbl_products;

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