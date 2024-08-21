--список всех клиентов
select U."Id", U."Name", UR."Name" from "Users" as U
join "UserRoles" as UR
on U."RoleId" = UR."Id"
where UR."Id" = 1

--список админов
select U."Id", U."Name", UR."Name" from "Users" as U
join "UserRoles" as UR
on U."RoleId" = UR."Id"
where UR."Id" = 2

--список мастеров
select U."Id", U."Name", UR."Name" from "Users" as U
join "UserRoles" as UR
on U."RoleId" = UR."Id"
where UR."Id" = 3

--список всех мастеров с категорией, услугой и стоимостью
select U."Id", U."Name", U."MasterTypeId", UR."Name", MT."Name", S."Name", MTS."Cost"
from "Users" as U
join "UserRoles" as UR 
on U."RoleId" = UR."Id"
join "MasterTypes" as MT
on U."MasterTypeId"=MT."Id"
join "MasterType_Services" as MTS
on MT."Id"=MTS."MasterTypeId"
join "Services" as S
on MTS."ServiceId"=S."Id"
where UR."Id" = 3

