# AreaOfFigure C#

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

-Юнит-тесты

-Легкость добавления других фигур

-Вычисление площади фигуры без знания типа фигуры в compile-time

-Проверку на то, является ли треугольник прямоугольным 


# SQLServer

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

SELECT Products.Name, Categories.Name

FROM Products

LEFT JOIN Categories ON Products.CategoryId = Categories.Id;


SELECT - перечисляем все столбцы, которые нам нужны

FROM - таблица для соединения

LEFT JOIN - условие соединения, благодаря LEFT данные из левой таблицы попадут в результат в любом случае