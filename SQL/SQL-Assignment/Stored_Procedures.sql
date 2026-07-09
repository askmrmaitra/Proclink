-- Create a stored procedure to display Product Name and List Price.

CREATE PROCEDURE uspProductList
AS
BEGIN
    SELECT
        product_name,
        list_price
    FROM
        production.products
    ORDER BY
        product_name;
END;

-- Execute the stored procedure.

EXEC uspProductList;


-- Create a stored procedure to display products whose List Price is greater than or equal to the given value.

CREATE PROCEDURE uspFindProducts
(
    @min_list_price DECIMAL
)
AS
BEGIN
    SELECT
        product_name,
        list_price
    FROM
        production.products
    WHERE
        list_price >= @min_list_price
    ORDER BY
        list_price;
END;

-- Execute the stored procedure.

EXEC uspFindProducts 100;


-- Modify the stored procedure to display products between the minimum and maximum List Price.

ALTER PROCEDURE uspFindProducts
(
    @min_list_price DECIMAL,
    @max_list_price DECIMAL
)
AS
BEGIN
    SELECT
        product_name,
        list_price
    FROM
        production.products
    WHERE
        list_price >= @min_list_price
        AND list_price <= @max_list_price
    ORDER BY
        list_price;
END;

-- Execute the modified stored procedure.

EXEC uspFindProducts 900, 1000;


-- Drop the stored procedure.

DROP PROCEDURE uspFindProducts;