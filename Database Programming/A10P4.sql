--List the names of pilots who have flown the most miles.
SELECT	P.EMP_LNAME, P.EMP_FNAME
FROM	PILOTDIM P INNER JOIN FACTS F ON P.PILOT_KEY = F.PILOT_KEY
GROUP BY P.EMP_LNAME, P.EMP_FNAME, P.EMP_NUM, F.PILOT_KEY
HAVING	SUM(F.CHAR_DISTANCE) = (SELECT TOP 1 SUM(CHAR_DISTANCE)
								FROM	FACTS
								GROUP BY PILOT_KEY
								ORDER BY SUM(CHAR_DISTANCE) DESC
								)

--List the revenue by model and month in ascending order.
SELECT	DISTINCT A.MOD_CODE, T.CHAR_MONTH, ROUND(SUM(F.MOD_CHG_MILE*F.CHAR_DISTANCE), 2) AS REVENUE
FROM	FACTS F INNER JOIN AIRCRAFTDIM A ON F.AIRCRAFT_KEY = A.AIRCRAFT_KEY
		INNER JOIN TIMEDIM T ON T.TIME_KEY = F.TIME_KEY
GROUP BY A.MOD_CODE, T.CHAR_MONTH
ORDER BY ROUND(SUM(F.MOD_CHG_MILE*F.CHAR_DISTANCE), 2)
