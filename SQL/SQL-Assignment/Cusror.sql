-- Display order details using a cursor.

DECLARE
    @order_id INT,
    @order_status INT;

DECLARE orders_cursor CURSOR
FOR
SELECT
    order_id,
    order_status
FROM sales.orders;

OPEN orders_cursor;

FETCH NEXT FROM orders_cursor
INTO @order_id, @order_status;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'Order ID: ' + CAST(@order_id AS VARCHAR) +
          ' Status: ' + CAST(@order_status AS VARCHAR);

    FETCH NEXT FROM orders_cursor
    INTO @order_id, @order_status;
END;

CLOSE orders_cursor;

DEALLOCATE orders_cursor;



-- Display stock details using a cursor.

DECLARE
    @store_id INT,
    @product_id INT,
    @qty INT;

DECLARE stocks_cursor CURSOR
FOR
SELECT
    store_id,
    product_id,
    quantity
FROM production.stocks;

OPEN stocks_cursor;

FETCH NEXT FROM stocks_cursor
INTO @store_id, @product_id, @qty;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'Store: ' + CAST(@store_id AS VARCHAR) +
          ' Product: ' + CAST(@product_id AS VARCHAR) +
          ' Qty: ' + CAST(@qty AS VARCHAR);

    FETCH NEXT FROM stocks_cursor
    INTO @store_id, @product_id, @qty;
END;

CLOSE stocks_cursor;

DEALLOCATE stocks_cursor;