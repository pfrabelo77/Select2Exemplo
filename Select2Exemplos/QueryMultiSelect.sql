DECLARE @List VARCHAR(max) = '2,3,5' --Coloque aqui os valores dos IDs vindos do Select2 MultiSelect

--SELECT item FROM dbo.SplitString(@list,',')

SELECT *
FROM   tbCarro
WHERE  (Id IN (SELECT item FROM dbo.SplitString(@list,',')) OR @List IS NULL) --Utilize esta function no where para buscar os IDs escolhido no Select2 MultiSelect


