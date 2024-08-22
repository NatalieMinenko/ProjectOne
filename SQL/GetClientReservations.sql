CREATE OR REPLACE FUNCTION get_client_reservations(client_id INT)
RETURNS TABLE(reservation_id INT, start_date_time TIMESTAMP, sum_amount INT, status character varying, is_action BOOLEAN) AS $$
BEGIN
    RETURN QUERY
    SELECT r."Id", r."StartDateTime", r."Sum", sr."Name", r."IsAction"
    FROM "Reservations" r
    JOIN "StatusReservations" sr ON r."StatusId" = sr."Id"
    WHERE r."ClientId" = client_id;
END;
$$ LANGUAGE plpgsql;

select get_client_reservations(5);
-- Возвращает список всех бронирований конкретного клиента 