SELECT title FROM movie WHERE director = "Steven Spielberg";

SELECT DISTINCT m.year FROM movie m INNER JOIN rating r ON r.mID = m.mID
WHERE r.stars IN (4, 5) ORDER BY m.year ASC;

SELECT title FROM movie WHERE mID NOT IN (SELECT mID FROM rating);

SELECT re.name FROM reviewer re INNER JOIN rating ra ON ra.rID = re.rID 
WHERE ra.ratingDate IS NULL;

SELECT re.name, m.title, ra.stars, ra.ratingDate FROM rating ra 
JOIN movie m ON (m.mID = ra.mID)
JOIN reviewer re ON (re.rID = ra.rID)
ORDER BY re.name, m.title, ra.stars ASC;

SELECT re.name, m.title FROM rating ra
JOIN rating rb ON (rb.rID = ra.rID)
JOIN movie m ON (m.mID = ra.mID)
JOIN reviewer re ON (re.rID = ra.rID)
WHERE rb.rID = ra.rID AND rb.mID = ra.mID AND ra.stars > rb.stars AND ra.ratingDate > rb.ratingDate;