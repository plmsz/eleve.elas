CREATE TABLE Movies (
    Id INTEGER PRIMARY KEY,
    Title VARCHAR(MAX),
    Director VARCHAR(MAX),
    Year INTEGER,
    Length_minutes INTEGER
);

INSERT INTO Movies (Id, Title, Director, Year, Length_minutes)
VALUES
(1, 'Toy Story', 'John Lasseter', 1995, 81),
(2, 'A Bug''s Life', 'John Lasseter', 1998, 95),
(3, 'Toy Story 2', 'John Lasseter', 1999, 93),
(4, 'Monsters, Inc.', 'Pete Docter', 2001, 92),
(5, 'Finding Nemo', 'Andrew Stanton', 2003, 107),
(6, 'The Incredibles', 'Brad Bird', 2004, 116),
(7, 'Cars', 'John Lasseter', 2006, 117),
(8, 'Ratatouille', 'Brad Bird', 2007, 115),
(9, 'WALL-E', 'Andrew Stanton', 2008, 104),
(10, 'Up', 'Pete Docter', 2009, 101),
(11, 'Toy Story 3', 'Lee Unkrich', 2010, 103),
(12, 'Cars 2', 'John Lasseter', 2011, 120),
(13, 'Brave', 'Brenda Chapman', 2012, 102),
(14, 'Monsters University', 'Dan Scanlon', 2013, 110),
(87, 'WALL-G', 'Brenda Chapman', 2042, 97);

SELECT * FROM Movies;
EXEC sp_rename 'Movies', 'Films';

CREATE TABLE Movies(
    Id INTEGER PRIMARY KEY,
    Title VARCHAR(MAX),
    Director VARCHAR(MAX),
    Year INTEGER,
    Length_minutes INTEGER
);

INSERT INTO Movies(Id, Title, Director, Year, Length_minutes)
VALUES
(1, 'Ratatouille', 'Brad Bird', 2007, 115),
(2, 'Monsters, Inc.', 'Pete Docter', 2001, 92),
(3, 'Toy Story 2', 'John Lasseter', 1999, 93),
(4, 'The Incredibles', 'Brad Bird', 2004, 116),
(5, 'Cars', 'John Lasseter', 2006, 117),
(6, 'Cars 2', 'John Lasseter', 2011, 120),
(7, 'Toy Story 3', 'Lee Unkrich', 2010, 103),
(8, 'Finding Nemo', 'Andrew Stanton', 2003, 107),
(9, 'Brave', 'Brenda Chapman', 2012, 102),
(10, 'Toy Story', 'John Lasseter', 1995, 81),
(11, 'Monsters University', 'Dan Scanlon', 2013, 110),
(12, 'Up', 'Pete Docter', 2009, 101),
(13, 'WALL-E', 'Andrew Stanton', 2008, 104),
(14, 'A Bug''s Life', 'John Lasseter', 1998, 95);
