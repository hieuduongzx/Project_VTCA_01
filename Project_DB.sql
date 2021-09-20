drop database if exists ProjectDB;

create database ProjectDB;

use ProjectDB;

create table Accounts(
	account_id int auto_increment primary key,
    user_name varchar(100) not null,
    user_password varchar(200) not null,
    role int not null default 1
);

/* CREATE & GRANT USER */
create user if not exists 'vtca'@'localhost' identified by 'vtcacademy';
grant all on ProjectDB.* to 'vtca'@'localhost';

-- PF12VTCAcademy
insert into Accounts(user_name, user_password, role) values
	('cashier01', '123456', 1);

select * from Accounts;

select * from Accounts where user_name='cashier01' and user_password='123456';
