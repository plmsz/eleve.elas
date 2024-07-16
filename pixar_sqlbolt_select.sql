/*
Find the title of each film 
Find the director of each film
Find the title and director of each film
Find the title and year of each film
Find all the information about each film
*/
SELECT title FROM films;
SELECT director FROM films;
SELECT title, director FROM films;
SELECT title, director FROM films;
SELECT title, year FROM films;
SELECT * FROM films;

/*
Find the movie with a row id of 6 
Find the films released in the years between 2000 and 2010
Find the films not released in the years between 2000 and 2010
Find the first 5 Pixar films and their release year
*/
SELECT * FROM films WHERE Id = 6;
SELECT * FROM films WHERE year BETWEEN 2000 AND 2010;
SELECT * FROM films WHERE year NOT BETWEEN 2000 AND 2010;
SELECT * FROM films WHERE ID BETWEEN 1 AND 5;

/*
Find all the Toy Story films ✓
Find all the films directed by John Lasseter
Find all the films (and director) not directed by John Lasseter
Find all the WALL-* films
*/
SELECT * FROM films WHERE Title LIKE 'toy story%';
SELECT * FROM films WHERE Director = 'John Lasseter';
SELECT * FROM films WHERE Director != 'John Lasseter';
SELECT * FROM films WHERE title LIKE 'wall-%';

/*
List all directors of Pixar films (alphabetically), without duplicates
List the last four Pixar films released (ordered from most recent to least)
List the first five Pixar films sorted alphabetically
List the next five Pixar films sorted alphabetically
*/

SELECT DISTINCT director FROM movies ORDER BY director ASC;
SELECT TOP 4 * FROM movies ORDER BY year DESC; --top tem que ser na frente
SELECT TOP 5 * FROM  movies ORDER BY Title ASC;
SELECT * FROM Movies ORDER BY Title ASC OFFSET 5 ROWS FETCH NEXT 5 ROWS ONLY;
-- Outros database
--SELECT * FROM  movies ORDER BY year DESC LIMIT 4;
--SELECT * FROM  movies ORDER BY year ASC LIMIT 5;
--SELECT * FROM  movies ORDER BY Title ASC LIMIT 5 OFFSET 5;

--https://sqlbolt.com/lesson/select_queries_review