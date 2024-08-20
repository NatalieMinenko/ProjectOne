CREATE FUNCTION create_reservation(start_date_time TIMESTAMP, sum_amount INT, client_id INT, status_id INT, is_action BOOLEAN)
RETURNS VOID AS $$
BEGIN
    INSERT INTO "Reservations"("StartDateTime", "Sum", "ClientId", "StatusId", "IsAction")
    VALUES (start_date_time, sum_amount, client_id, status_id, is_action);
END;
$$ LANGUAGE plpgsql;

CREATE FUNCTION get_reservations()
RETURNS TABLE(id INT, start_date_time TIMESTAMP, sum_amount INT, client_id INT, status_id INT, is_action BOOLEAN) AS $$
BEGIN
    RETURN QUERY
    SELECT "Id", "StartDateTime", "Sum", "ClientId", "StatusId", "IsAction"
    FROM "Reservations";
END;
$$ LANGUAGE plpgsql;

CREATE FUNCTION update_reservation(reservation_id INT, start_date_time TIMESTAMP, sum_amount INT, client_id INT, status_id INT, is_action BOOLEAN)
RETURNS VOID AS $$
BEGIN
    UPDATE "Reservations"
    SET "StartDateTime" = start_date_time, "Sum" = sum_amount, "ClientId" = client_id, "StatusId" = status_id, "IsAction" = is_action
    WHERE "Id" = reservation_id;
END;
$$ LANGUAGE plpgsql;

CREATE  FUNCTION delete_reservation(reservation_id INT)
RETURNS VOID AS $$
BEGIN
    DELETE FROM "Reservations"
    WHERE "Id" = reservation_id;
END;
$$ LANGUAGE plpgsql;