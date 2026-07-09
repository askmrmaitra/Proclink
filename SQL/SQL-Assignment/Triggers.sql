-- Create a log table and triggers to store INSERT and DELETE operations on products.

CREATE TABLE production.product_logs
(
    log_id INT IDENTITY(1,1) PRIMARY KEY,
    product_id INT NOT NULL,
    product_name VARCHAR(255) NOT NULL,
    list_price DECIMAL(10,2) NOT NULL,
    action_date DATETIME DEFAULT GETDATE(),
    operation VARCHAR(20) NOT NULL,
    CHECK(operation ='INS' or operation='DEL')
);


CREATE TRIGGER trg_product_logs
ON production.products
AFTER INSERT
AS
BEGIN
    INSERT INTO production.product_logs
    (
        product_id,
        product_name,
        list_price,
        operation
    )
    SELECT
        product_id,
        product_name,
        list_price,
        'INS'
    FROM inserted;
END;



INSERT INTO production.products
(
    product_name,
    brand_id,
    category_id,
    model_year,
    list_price
)
VALUES
(
    'Test Bike',
    1,
    1,
    2025,
    50000
);


SELECT *
FROM production.product_logs;


CREATE TRIGGER trg_product_delete
ON production.products
AFTER DELETE
AS
BEGIN
    INSERT INTO production.product_logs
    (
        product_id,
        product_name,
        list_price,
        operation
    )
    SELECT
        product_id,
        product_name,
        list_price,
        'DEL'
    FROM deleted;
END;


SELECT TOP 1 *
FROM production.products;


DELETE FROM production.products
WHERE product_id = 321;


SELECT *
FROM production.product_logs
ORDER BY log_id DESC;