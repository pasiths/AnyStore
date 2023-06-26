use AnyStore;

drop table tbl_transaction_detail;

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