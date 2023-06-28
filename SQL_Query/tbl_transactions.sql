USE AnyStore;

drop table tbl_transactions;

create table tbl_transactions(
id int primary key not null,
type varchar(10) not null,
dea_cust_id int not null,
grandTotal decimal(18,2) not null,
transaction_date datetime not null,
tax decimal(18,2) not null,
discount decimal(18,2) not null,
added_by int not null
);

