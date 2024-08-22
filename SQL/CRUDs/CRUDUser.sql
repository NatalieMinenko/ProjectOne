CREATE OR REPLACE FUNCTION create_user(name VARCHAR, phone VARCHAR, mail VARCHAR, role_id INT, master_type_id INT DEFAULT NULL)
RETURNS VOID AS $$
BEGIN
    INSERT INTO "Users"("Name", "Phone", "Mail", "RoleId", "MasterTypeId")
    VALUES (name, phone, mail, role_id, master_type_id);
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION get_users()
RETURNS TABLE(id INT, name VARCHAR, phone VARCHAR, mail VARCHAR, role_id INT, master_type_id INT) AS $$
BEGIN
    RETURN QUERY
    SELECT "Id", "Name", "Phone", "Mail", "RoleId", "MasterTypeId"
    FROM "Users";
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION update_user(user_id INT, name VARCHAR, phone VARCHAR, mail VARCHAR, role_id INT, master_type_id INT)
RETURNS VOID AS $$
BEGIN
    UPDATE "Users"
    SET "Name" = name, "Phone" = phone, "Mail" = mail, "RoleId" = role_id, "MasterTypeId" = master_type_id
    WHERE "Id" = user_id;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION delete_user(user_id INT)
RETURNS VOID AS $$
BEGIN
    DELETE FROM "Users"
    WHERE "Id" = user_id;
END;
$$ LANGUAGE plpgsql;