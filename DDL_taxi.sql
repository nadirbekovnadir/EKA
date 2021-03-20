USE taxi;
CREATE TABLE drivers (
	id int IDENTITY(1,1) primary key,
	name varchar(100) not null,
);

CREATE TABLE cars (
	id int IDENTITY(1,1) primary key,
	number varchar(100) not null UNIQUE,
);

CREATE TABLE cars_to_drivers (
	id int IDENTITY(1,1) primary key,
	driver_id int REFERENCES drivers (id),
	cars_id int REFERENCES cars (id),
	using_time datetime DEFAULT GETDATE()
);