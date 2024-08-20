CREATE OR REPLACE FUNCTION create_master_type(name VARCHAR)
RETURNS VOID AS $$
BEGIN
    INSERT INTO "MasterTypes"("Name")
    VALUES (name);
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION get_master_types()
RETURNS TABLE(id INT, name VARCHAR) AS $$
BEGIN
    RETURN QUERY
    SELECT "Id", "Name"
    FROM "MasterTypes";
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION update_master_type(master_type_id INT, name VARCHAR)
RETURNS VOID AS $$
BEGIN
    UPDATE "MasterTypes"
    SET "Name" = name
    WHERE "Id" = master_type_id;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION delete_master_type(master_type_id INT)
RETURNS VOID AS $$
BEGIN
    DELETE FROM "MasterTypes"
    WHERE "Id" = master_type_id;
END;
$$ LANGUAGE plpgsql;