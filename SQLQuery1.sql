SELECT SUM(OrderRows.Price) Firstname, Lastname FROM Customers JOIN Orders ON Customers.Id=Orders.Customerid JOIN OrderRows ON Orders.Id=OrderRows.Orderid GROUP BY Orders.Id HAVING SUM(OrderRows.Price)

SELECT  SUM(OrderRows.Price) FROM OrderRows  JOIN Orders ON OrderRows.Orderid=Orders.Id GROUP BY OrderRows.Orderid 

SELECT Customers.Id ,Firstname,Lastname ,Orders.OrderDate, SUM(OrderRows.Price) FROM Customers JOIN Orders ON Customers.Id=Orders.Customerid JOIN OrderRows ON Orders.Id=OrderRows.Orderid 