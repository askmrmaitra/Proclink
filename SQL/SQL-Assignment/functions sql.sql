-- Question 1:
-- Create a scalar-valued function named fn_GetProductDiscountPrice that accepts a Product ID as input
-- and returns the discounted price after applying a 10% discount.

CREATE FUNCTION dbo.fn_GetProductDiscountPrice
(
    @ProductID INT
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @ListPrice DECIMAL(10,2);
    DECLARE @DiscountedPrice DECIMAL(10,2);

    SELECT
        @ListPrice = list_price
    FROM
        production.products
    WHERE
        product_id = @ProductID;

    SET @DiscountedPrice = @ListPrice * 0.90;

    RETURN @DiscountedPrice;
END;

SELECT dbo.fn_GetProductDiscountPrice(1) AS DiscountedPrice;


-- Question 2:
-- Create an inline table-valued function named fn_GetCustomerOrders that accepts a Customer ID
-- and returns Order ID, Order Date, Order Status, and Store Name.

CREATE FUNCTION dbo.fn_GetCustomerOrders
(
    @CustomerID INT
)
RETURNS TABLE
AS
RETURN
(
    SELECT
        o.order_id,
        o.order_date,
        o.order_status,
        s.store_name
    FROM
        sales.orders o
        INNER JOIN sales.stores s
            ON o.store_id = s.store_id
    WHERE
        o.customer_id = @CustomerID
);

SELECT *
FROM dbo.fn_GetCustomerOrders(5);


-- Question 3:
-- Create a multi-statement table-valued function named fn_GetStoreInventorySummary
-- that accepts a Store ID and returns Product ID, Product Name,
-- Quantity in Stock, and Stock Status.

CREATE FUNCTION dbo.fn_GetStoreInventorySummary
(
    @StoreID INT
)
RETURNS @Inventory TABLE
(
    ProductID INT,
    ProductName VARCHAR(255),
    QuantityInStock INT,
    StockStatus VARCHAR(20)
)
AS
BEGIN

    INSERT INTO @Inventory
    SELECT
        p.product_id,
        p.product_name,
        s.quantity,
        CASE
            WHEN s.quantity = 0 THEN 'Out of Stock'
            WHEN s.quantity BETWEEN 1 AND 10 THEN 'Low Stock'
            ELSE 'In Stock'
        END AS StockStatus
    FROM
        production.stocks s
        INNER JOIN production.products p
            ON s.product_id = p.product_id
    WHERE
        s.store_id = @StoreID;

    RETURN;
END;

SELECT *
FROM dbo.fn_GetStoreInventorySummary(1);