-- 1. Display the product name and its brand name.
-- 2. Display the product name, category name, and list price.
-- 3. Display the customer's full name and the order date for every order placed.
-- 4. Display the order ID, customer name, and store name for each order.
-- 5. Display the staff name and the store name where the staff member works.
-- 6. Display all customers and their orders, including customers who have not placed any order.
-- 7. Display all products and their stock quantities, including products that do not have stock records.
-- 8. Display all products and the order items in which they appear, including products that were never sold.
-- 9. Display each staff member's name along with the manager's name.
-- 10. Display the order ID, customer name, staff name, and store name for every order.


-- Display the product name and its brand name

SELECT
    p.product_name,
    b.brand_name
FROM production.products p
INNER JOIN production.brands b
    ON p.brand_id = b.brand_id;


-- 2. Display the product name, category name, and list price.

SELECT 
  p.product_name,
  c.category_name,
  p.list_price
FROM 
 production.products p INNER JOIN production.categories c
 ON p.category_id = c.category_id;

 -- 3. Display the customer's full name and the order date for every order placed.
SELECT 
  c.first_name +' '+last_name,
  o.order_date
FROM
  sales.customers c INNER JOIN sales.orders o
  ON c.customer_id =o.customer_id; 

-- 4. Display the order ID, customer name, and store name for each order.

SELECT
    o.order_id,
    c.first_name + ' ' + c.last_name AS customer_name,
    s.store_name
FROM sales.orders o
INNER JOIN sales.customers c
    ON o.customer_id = c.customer_id
INNER JOIN sales.stores s
    ON o.store_id = s.store_id;

-- 5. Display the staff name and the store name where the staff member works.
SELECT 
  stf.first_name+' '+last_name,
  sto.store_name
FROM 
  sales.stores sto INNER JOIN sales.staffs stf
  On sto.store_id = stf.store_id;

-- 6. Display all customers and their orders, including customers who have not placed any order.
SELECT 
  c.first_name+' '+last_name,
  o.order_id,
  o.customer_id,
  o.order_status,
  o.order_date,
  o.required_date,
  o.shipped_date,
  o.store_id,
  o.staff_id
FROM 
 sales.orders o RIGHT JOIN sales.customers c
 ON o.customer_id = c.customer_id;


 -- 7. Display all products and their stock quantities, including products that do not have stock records.
SELECT 
 p.product_id,
 p.product_name,
 p.brand_id,
 p.category_id,
 p.model_year,
 p.list_price,
 s.quantity
FROM 
 production.products p LEFT JOIN production.stocks s
 ON p.product_id = s.product_id;

-- 8. Display all products and the order items in which they appear, including products that were never sold.
SELECT 
 *
FROM 
 production.products p LEFT JOIN sales.order_items s
 ON p.product_id = s.product_id;

-- 9. Display each staff member's name along with the manager's name.

SELECT
    s.first_name + ' ' + s.last_name AS staff_name,
    m.first_name + ' ' + m.last_name AS manager_name
FROM sales.staffs s
LEFT JOIN sales.staffs m
    ON s.manager_id = m.staff_id;


-- 10. Display the order ID, customer name, staff name, and store name for every order.

SELECT
    o.order_id,
    c.first_name + ' ' + c.last_name AS customer_name,
    s.first_name + ' ' + s.last_name AS staff_name,
    st.store_name
FROM sales.orders o
INNER JOIN sales.customers c
    ON o.customer_id = c.customer_id
INNER JOIN sales.staffs s
    ON o.staff_id = s.staff_id
INNER JOIN sales.stores st
    ON o.store_id = st.store_id;




-- Advanced 1. Display the order ID, order date, customer name, product name, and quantity ordered for every order item.
-- Advanced 2. Display the customer name, city, order ID, and the staff member who handled the order.
-- Advanced 3. Display the product name, brand name, category name, and the store name where the product is stocked.
-- Advanced 4. Display the store name, product name, and quantity in stock for all products available in each store.
-- Advanced 5. Display the order ID, customer name, product name, quantity, and list price of every product included in an order.
-- Advanced 6. Display the staff name, manager name, and store name for all staff members.
-- Advanced 7. Display the customer name, order date, store name, and product name for every product purchased by a customer.
-- Advanced 8. Display the brand name, product name, store name, and quantity in stock for every stocked product.
-- Advanced 9. Display the order ID, customer name, staff name, store name, product name, and quantity ordered for every order item.
-- Advanced 10. Display the customer name, product name, brand name, category name, and order date for every product purchased by a customer.

-- Advanced 1. Display the order ID, order date, customer name, product name, and quantity ordered for every order item.

SELECT 
  o.order_id,
  o.order_date,
  c.first_name+' '+last_name,
  p.product_name,
  od.quantity

FROM 
 sales.orders o 
 INNER JOIN sales.customers c ON o.customer_id = c.customer_id
 INNER JOIN sales.order_items od ON o.order_id = od.order_id
 INNER JOIN production.products p ON od.product_id = p.product_id;

-- Advanced 2. Display the customer name, city, order ID, and the staff member who handled the order.

SELECT
    o.order_id,
    c.first_name + ' ' + c.last_name AS customer_name,
    c.city,
    s.first_name + ' ' + s.last_name AS staff_name
FROM
    sales.orders o
    INNER JOIN sales.customers c
        ON o.customer_id = c.customer_id
    INNER JOIN sales.staffs s
        ON o.staff_id = s.staff_id;


-- Advanced 3. Display the product name, brand name, category name, and the store name where the product is stocked.

SELECT
    p.product_name,
    b.brand_name,
    c.category_name,
    s.store_name
FROM
    production.products p
    INNER JOIN production.brands b
        ON p.brand_id = b.brand_id
    INNER JOIN production.categories c
        ON p.category_id = c.category_id
    INNER JOIN production.stocks st
        ON p.product_id = st.product_id
    INNER JOIN sales.stores s
        ON st.store_id = s.store_id;


-- Advanced 4. Display the store name, product name, and quantity in stock for all products available in each store.

SELECT
    s.store_name,
    p.product_name,
    st.quantity
FROM
    production.stocks st
    INNER JOIN sales.stores s
        ON st.store_id = s.store_id
    INNER JOIN production.products p
        ON st.product_id = p.product_id;


-- Advanced 5. Display the order ID, customer name, product name, quantity, and list price of every product included in an order.

SELECT
    o.order_id,
    c.first_name + ' ' + c.last_name AS customer_name,
    p.product_name,
    oi.quantity,
    oi.list_price
FROM
    sales.orders o
    INNER JOIN sales.customers c
        ON o.customer_id = c.customer_id
    INNER JOIN sales.order_items oi
        ON o.order_id = oi.order_id
    INNER JOIN production.products p
        ON oi.product_id = p.product_id;


-- Advanced 6. Display the staff name, manager name, and store name for all staff members.

SELECT
    s.first_name + ' ' + s.last_name AS staff_name,
    m.first_name + ' ' + m.last_name AS manager_name,
    st.store_name
FROM
    sales.staffs s
    LEFT JOIN sales.staffs m
        ON s.manager_id = m.staff_id
    INNER JOIN sales.stores st
        ON s.store_id = st.store_id;


-- Advanced 7. Display the customer name, order date, store name, and product name for every product purchased by a customer.

SELECT
    c.first_name + ' ' + c.last_name AS customer_name,
    o.order_date,
    s.store_name,
    p.product_name
FROM
    sales.orders o
    INNER JOIN sales.customers c
        ON o.customer_id = c.customer_id
    INNER JOIN sales.stores s
        ON o.store_id = s.store_id
    INNER JOIN sales.order_items oi
        ON o.order_id = oi.order_id
    INNER JOIN production.products p
        ON oi.product_id = p.product_id;


-- Advanced 8. Display the brand name, product name, store name, and quantity in stock for every stocked product.

SELECT
    b.brand_name,
    p.product_name,
    s.store_name,
    st.quantity
FROM
    production.stocks st
    INNER JOIN production.products p
        ON st.product_id = p.product_id
    INNER JOIN production.brands b
        ON p.brand_id = b.brand_id
    INNER JOIN sales.stores s
        ON st.store_id = s.store_id;


-- Advanced 9. Display the order ID, customer name, staff name, store name, product name, and quantity ordered for every order item.

SELECT
    o.order_id,
    c.first_name + ' ' + c.last_name AS customer_name,
    s.first_name + ' ' + s.last_name AS staff_name,
    st.store_name,
    p.product_name,
    oi.quantity
FROM
    sales.orders o
    INNER JOIN sales.customers c
        ON o.customer_id = c.customer_id
    INNER JOIN sales.staffs s
        ON o.staff_id = s.staff_id
    INNER JOIN sales.stores st
        ON o.store_id = st.store_id
    INNER JOIN sales.order_items oi
        ON o.order_id = oi.order_id
    INNER JOIN production.products p
        ON oi.product_id = p.product_id;


-- Advanced 10. Display the customer name, product name, brand name, category name, and order date for every product purchased by a customer.

SELECT
    c.first_name + ' ' + c.last_name AS customer_name,
    p.product_name,
    b.brand_name,
    cg.category_name,
    o.order_date
FROM
    sales.orders o
    INNER JOIN sales.customers c
        ON o.customer_id = c.customer_id
    INNER JOIN sales.order_items oi
        ON o.order_id = oi.order_id
    INNER JOIN production.products p
        ON oi.product_id = p.product_id
    INNER JOIN production.brands b
        ON p.brand_id = b.brand_id
    INNER JOIN production.categories cg
        ON p.category_id = cg.category_id;
