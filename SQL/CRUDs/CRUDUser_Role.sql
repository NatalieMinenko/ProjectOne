CREATE OR REPLACE FUNCTION create_user_role(name VARCHAR)
RETURNS VOID AS $$
BEGIN
    INSERT INTO "UserRoles"("Name")
    VALUES (name);
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION get_user_roles()
RETURNS TABLE(id INT, name VARCHAR) AS $$
BEGIN
    RETURN QUERY
    SELECT "Id", "Name"
    FROM "UserRoles";
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION update_user_role(role_id INT, name VARCHAR)
RETURNS VOID AS $$
BEGIN
    UPDATE "UserRoles"
    SET "Name" = name
    WHERE "Id" = role_id;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION delete_user_role(role_id INT)
RETURNS VOID AS $$
BEGIN
    DELETE FROM "UserRoles"
    WHERE "Id" = role_id;
END;
$$ LANGUAGE plpgsql;