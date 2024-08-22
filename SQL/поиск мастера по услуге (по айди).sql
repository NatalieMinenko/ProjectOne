Поиск мастера по айди услуги

select S."Id", S."Name", S."Duration", MTS."Cost", MT."Id", MT."Name", U."Id", U."Name"
from "Services" as S
join "MasterType_Services" as MTS on MTS."ServiceId"= S."Id"
join "MasterTypes" as MT on MT."Id" = MTS."MasterTypeId"
join "Users" as U on U."MasterTypeId" = MT."Id"
where S."Id" = 1

вывести услуги

select "Name" from "Services";


вывести активные услуги:

select "Name" from "Services"
where "IsActive"=true