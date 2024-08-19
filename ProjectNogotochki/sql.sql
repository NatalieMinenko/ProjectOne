CREATE TABLE IF NOT EXISTS "Services" (
	"Id" Serial PRIMARY KEY,
	"Name" CHARACTER VARYING(255) NOT NULL,
	"Duration" CHARACTER VARYING(80) NOT NULL,
	"IsActive" Boolean Default true,
	"IsDeleted" Boolean Default false
);

CREATE TABLE IF NOT EXISTS "MasterType_Services" (
	"MasterTypeId" Serial NOT NULL,
	"ServiceId" Serial NOT NULL,
	"Cost" Integer NOT NULL
);

CREATE TABLE IF NOT EXISTS "Reservations" (
	"Id" Serial PRIMARY KEY,
	"StartDateTime" Timestamp NOT NULL,
	"Sum" Integer NOT NULL,
	"ClientId" Serial NOT NULL,
	"StatusId" Serial NOT NULL,
	"IsAction" Boolean NOT NULL
);

CREATE TABLE IF NOT EXISTS "Users" (
	"Id" Serial PRIMARY KEY,
	"Name" CHARACTER VARYING(30) NOT NULL,
	"Phone" CHARACTER VARYING(30) NOT NULL,
	"Mail" CHARACTER VARYING(30) NOT NULL,
	"RoleId" Serial NOT NULL,
	"MasterTypeId" Serial
);

CREATE TABLE IF NOT EXISTS "UserRoles" (
	"Id" Serial PRIMARY KEY,
	"Name" CHARACTER VARYING(30) NOT NULL
);

CREATE TABLE IF NOT EXISTS "Reservations_Services" (
	"ServicesId" Serial NOT NULL,
	"ReservationsId" Serial NOT NULL
);

CREATE TABLE IF NOT EXISTS "StatusReservations" (
	"Id" Serial PRIMARY KEY,
	"Name" CHARACTER VARYING(30) NOT NULL
);

CREATE TABLE IF NOT EXISTS "MasterTypes" (
	"Id" Serial PRIMARY KEY,
	"Name" CHARACTER VARYING(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS "Reservations_Masters" (
	"ReservationsId" Serial NOT NULL,
	"UsersId" Serial NOT NULL
);


ALTER TABLE "MasterType_Services" ADD CONSTRAINT "MasterType_Services_fk0" FOREIGN KEY ("MasterTypeId") REFERENCES "MasterTypes"("Id");

ALTER TABLE "MasterType_Services" ADD CONSTRAINT "MasterType_Services_fk1" FOREIGN KEY ("ServiceId") REFERENCES "Services"("Id");
ALTER TABLE "Reservations" ADD CONSTRAINT "Reservations_fk3" FOREIGN KEY ("ClientId") REFERENCES "Users"("Id");

ALTER TABLE "Reservations" ADD CONSTRAINT "Reservations_fk4" FOREIGN KEY ("StatusId") REFERENCES "StatusReservations"("Id");
ALTER TABLE "Users" ADD CONSTRAINT "Users_fk4" FOREIGN KEY ("RoleId") REFERENCES "UserRoles"("Id");

ALTER TABLE "Users" ADD CONSTRAINT "Users_fk5" FOREIGN KEY ("MasterTypeId") REFERENCES "MasterTypes"("Id");

ALTER TABLE "Reservations_Services" ADD CONSTRAINT "Reservations_Services_fk0" FOREIGN KEY ("ServicesId") REFERENCES "Services"("Id");

ALTER TABLE "Reservations_Services" ADD CONSTRAINT "Reservations_Services_fk1" FOREIGN KEY ("ReservationsId") REFERENCES "Reservations"("Id");


ALTER TABLE "Reservations_Masters" ADD CONSTRAINT "Reservations_Masters_fk0" FOREIGN KEY ("ReservationsId") REFERENCES "Reservations"("Id");

ALTER TABLE "Reservations_Masters" ADD CONSTRAINT "Reservations_Masters_fk1" FOREIGN KEY ("UsersId") REFERENCES "Users"("Id");

insert into "UserRoles" ("Name")
values ('Client');

insert into "UserRoles" ("Name")
values ('Admin');

insert into "UserRoles" ("Name")
values ('Master');

select * from "UserRoles"

insert into "MasterTypes" ("Name")
values ('Top master/Manicure');

insert into "MasterTypes" ("Name")
values ('Master/Manicure');

insert into "MasterTypes" ("Name")
values ('Junior master/Manicure');

insert into "MasterTypes" ("Name")
values ('Top master/Pedicure');

insert into "MasterTypes" ("Name")
values ('Master/Pedicure');

insert into "MasterTypes" ("Name")
values ('Junior master/Pedicure');

select * from "MasterTypes"

insert into "Users" ("Name", "Phone", "Mail", "RoleId", "MasterTypeId")
values('Karina', 'phone06', 'mail06', 1, 1);

insert into "Users" ("Name", "Phone", "Mail", "RoleId")
values('Natalia', 'phone01', 'mail01', 2);

insert into "Users" ("Name", "Phone", "Mail", "RoleId")
values('UraganKatrin', 'phone01', 'mail01', 2);

insert into "Users" ("Name", "Phone", "Mail", "RoleId", "MasterTypeId")
values('Anasteisha', 'phone02', 'mail02', 1, 2);

insert into "Users" ("Name", "Phone", "Mail", "RoleId", "MasterTypeId")
values('Svetik', 'phone03', 'mail03', 1, 2);

insert into "Users" ("Name", "Phone", "Mail", "RoleId", "MasterTypeId")
values('Karina', 'phone04', 'mail04', 3, 3);

insert into "Users" ("Name", "Phone", "Mail", "RoleId", "MasterTypeId")
values('Angelina', 'phone05', 'mail05', 3, 6);

select * from "Users";

insert into "Services" ("Name", "Duration", "IsActive", "IsDeleted")
values ('Снятие + маникюр(лак/гель)', 120, true, false);

insert into "Services" ("Name", "Duration", "IsActive", "IsDeleted")
values('Маникюр с покрытием (лак)', 120, true, false);

insert into "Services" ("Name", "Duration", "IsActive", "IsDeleted")
values('Маникюр с покрытием (гель)', 120, true, false);

insert into "Services" ("Name", "Duration", "IsActive", "IsDeleted")
values('Снятие+педикюр(лак/гель)', 120, true, false);

insert into "Services" ("Name", "Duration", "IsActive", "IsDeleted")
values('Педикюр с покрытием(лак)', 120, true, false);

insert into "Services" ("Name", "Duration", "IsActive", "IsDeleted")
values('Педикюр с покрытием(гель)', 120, true, false);

insert into "MasterType_Services" ("MasterTypeId", "ServiceId", "Cost")
values (1, 1, 2500), (2, 1, 2300), (3, 1, 2000), (1, 2, 2300), 
(2, 2, 2100), (3, 2, 1900), (1, 3, 2400), (2, 3, 2200), (3, 3, 2000), 
(4, 4, 3500), (5, 4, 3300), (6, 4, 3100), (4, 5, 3300), (5, 5, 3100), 
(6, 5, 2900), (4, 6, 3400), (5, 6, 3200), (6, 6, 3000);

select * from "Services";
select * from "MasterTypes";









