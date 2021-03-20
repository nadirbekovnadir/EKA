USE taxi;

SELECT dr.name, ca.number, cd.using_time FROM dbo.cars_to_drivers cd 
	JOIN dbo.drivers dr ON dr.id = cd.driver_id
	JOIN dbo.cars ca ON ca.id = cd.cars_id;