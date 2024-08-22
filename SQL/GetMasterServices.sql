CREATE OR REPLACE FUNCTION get_master_services(master_id INT)
RETURNS TABLE(service_id INT, service_name character varying, cost INT) AS $$
BEGIN
    RETURN QUERY
    SELECT s."Id", s."Name", mts."Cost"
    FROM "MasterType_Services" mts
    JOIN "Services" s ON mts."ServiceId" = s."Id"
    JOIN "Users" u ON u."MasterTypeId" = mts."MasterTypeId"
    WHERE u."Id" = master_id AND s."IsActive" = TRUE AND s."IsDeleted" = FALSE;
END;
$$ LANGUAGE plpgsql;

select get_master_services(3);
-- Функция для получения доступных услуг мастера по ид 