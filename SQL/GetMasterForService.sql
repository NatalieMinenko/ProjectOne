CREATE OR REPLACE FUNCTION get_masters_for_service(service_id INT)
RETURNS TABLE(master_id INT, master_name TEXT) AS $$
BEGIN
    RETURN QUERY
    SELECT u."Id", u."Name"
    FROM "Users" u
    JOIN "MasterType_Services" mts ON u."MasterTypeId" = mts."MasterTypeId"
    WHERE mts."ServiceId" = service_id AND u."RoleId" = 3; -- RoleId = 3 предполагает, что это мастер
END;
$$ LANGUAGE plpgsql;

--  Функция для получения списка мастеров которые могут оказывать услугу 