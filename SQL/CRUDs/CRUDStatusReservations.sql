CREATE OR REPLACE FUNCTION create_status_reservation(name VARCHAR)
RETURNS VOID AS $$
BEGIN
    INSERT INTO "StatusReservations"("Name")
    VALUES (name);
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION get_status_reservations()
RETURNS TABLE(id INT, name VARCHAR) AS $$
BEGIN
    RETURN QUERY
    SELECT "Id", "Name"
    FROM "StatusReservations";
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION update_status_reservation(status_id INT, name VARCHAR)
RETURNS VOID AS $$
BEGIN
    UPDATE "StatusReservations"
    SET "Name" = name
    WHERE "Id" = status_id;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION delete_status_reservation(status_id INT)
RETURNS VOID AS $$
BEGIN
    DELETE FROM "StatusReservations"
    WHERE "Id" = status_id;
END;
$$ LANGUAGE plpgsql;

