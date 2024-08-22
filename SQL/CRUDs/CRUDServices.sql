CREATE OR REPLACE FUNCTION create_service(name Character varying, duration int, is_active BOOLEAN, is_deleted BOOLEAN)
RETURNS VOID AS $$
BEGIN
    INSERT INTO "Services"("Name", "Duration", "IsActive", "IsDeleted")
    VALUES (name, duration, is_active, is_deleted);
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION get_services()
RETURNS TABLE(id int, name Character varying, duration int, is_active BOOLEAN, is_deleted BOOLEAN) AS $$
BEGIN
    RETURN QUERY
    SELECT "Id", "Name", "Duration", "IsActive", "IsDeleted"
    FROM "Services";
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION update_service(service_id INT, name VARCHAR, duration VARCHAR, is_active BOOLEAN, is_deleted BOOLEAN)
RETURNS VOID AS $$
BEGIN
    UPDATE "Services"
    SET "Name" = name, "Duration" = duration, "IsActive" = is_active, "IsDeleted" = is_deleted
    WHERE "Id" = service_id;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION delete_service(serviceId INT)
RETURNS VOID AS $$
BEGIN
    DELETE FROM "Services"
    WHERE "Id" = serviceId;
END;
$$ LANGUAGE plpgsql;
