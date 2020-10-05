DECLARE @List VARCHAR(max) = '2,3,5'

SELECT *
FROM   Clientes
WHERE  (Id IN (SELECT item FROM dbo.SplitStrings_CTE(@list,',')) OR @List IS NULL)


