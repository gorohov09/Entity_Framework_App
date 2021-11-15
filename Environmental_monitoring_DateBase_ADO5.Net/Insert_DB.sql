INSERT INTO Source
VALUES
(N'Верхне-Тагильская ГРЭСС',N'Верхний Тагил'),
(N'Рефтинский мясокомбинат',N'Рефтинское'),
(N'Новоуральская станция',N'Новоуральск')

INSERT INTO Emission
VALUES
(3, 1000, N'Выбросы пепла', '2005-06-12')


SELECT *
FROM Source

SELECT *
FROM Emission

SELECT *
FROM Emission
JOIN Source ON Emission.ID_Source = Source.ID_Source;