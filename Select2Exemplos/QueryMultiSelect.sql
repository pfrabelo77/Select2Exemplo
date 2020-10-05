DECLARE @List VARCHAR(max) = '2,3,5' --Coloque aqui os valores dos IDs vindos do Select2 MultiSelect

SELECT *
FROM   Clientes
WHERE  (Id IN (SELECT item FROM dbo.SplitStrings_CTE(@list,',')) OR @List IS NULL)


