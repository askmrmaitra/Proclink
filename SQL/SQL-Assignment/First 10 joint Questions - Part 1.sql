-- 1. Display all candidates along with matching employees based on fullname.

SELECT
    c.id AS candidate_id,
    c.fullname AS candidate_name,
    e.id AS employee_id,
    e.fullname AS employee_name
FROM
    hr.candidates c
    INNER JOIN hr.employees e
        ON c.fullname = e.fullname;


-- 2. Retrieve only those names that exist in both candidates and employees.

SELECT
    c.fullname
FROM
    hr.candidates c
    INNER JOIN hr.employees e
        ON c.fullname = e.fullname;


-- 3. Display all candidates and their matching employee records, including candidates who are not employees.

SELECT
    c.id,
    c.fullname,
    e.id,
    e.fullname
FROM
    hr.candidates c
    LEFT JOIN hr.employees e
        ON c.fullname = e.fullname;


-- 4. Display all employees and their matching candidate records, including employees who were never candidates.

SELECT
    e.id,
    e.fullname,
    c.id,
    c.fullname
FROM
    hr.candidates c
    RIGHT JOIN hr.employees e
        ON c.fullname = e.fullname;


-- 5. Display all records from both tables, showing matched and unmatched names.

SELECT
    c.id,
    c.fullname,
    e.id,
    e.fullname
FROM
    hr.candidates c
    FULL JOIN hr.employees e
        ON c.fullname = e.fullname;


-- 6. Find candidates who are not present in the employees table using a JOIN.

SELECT
    c.id,
    c.fullname
FROM
    hr.candidates c
    LEFT JOIN hr.employees e
        ON c.fullname = e.fullname
WHERE
    e.id IS NULL;


-- 7. Find employees who are not present in the candidates table using a JOIN.

SELECT
    e.id,
    e.fullname
FROM
    hr.candidates c
    RIGHT JOIN hr.employees e
        ON c.fullname = e.fullname
WHERE
    c.id IS NULL;


-- 8. Display candidate names and employee names side by side where the names match.

SELECT
    c.fullname AS CandidateName,
    e.fullname AS EmployeeName
FROM
    hr.candidates c
    INNER JOIN hr.employees e
        ON c.fullname = e.fullname;


-- 9. Show all possible combinations of candidates and employees (Cartesian Product).

SELECT *
FROM
    hr.candidates c
    CROSS JOIN hr.employees e;


-- 10. Generate a report with candidate name, employee name, and a status indicating whether the record is Matched, Candidate Only, or Employee Only.

SELECT
    c.fullname AS CandidateName,
    e.fullname AS EmployeeName,
    CASE
        WHEN c.fullname IS NOT NULL
         AND e.fullname IS NOT NULL
            THEN 'Matched'
        WHEN c.fullname IS NOT NULL
            THEN 'Candidate Only'
        ELSE 'Employee Only'
    END AS Status
FROM
    hr.candidates c
    FULL JOIN hr.employees e
        ON c.fullname = e.fullname;