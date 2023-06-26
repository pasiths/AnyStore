use AnyStore;

drop table tbl_dea_cust;

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