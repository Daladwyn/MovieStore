SELECT SUM(OrderRows.Price) Firstname, Lastname FROM Customers JOIN Orders ON Customers.Id=Orders.Customerid JOIN OrderRows ON Orders.Id=OrderRows.Orderid GROUP BY Orders.Id HAVING SUM(OrderRows.Price)

SELECT  SUM(OrderRows.Price) FROM OrderRows  JOIN Orders ON OrderRows.Orderid=Orders.Id GROUP BY OrderRows.Orderid 

SELECT Orders.Id ,  Orders.OrderDate, Customers.Firstname, Customers.Lastname, OrderRows.Price FROM Orders  JOIN Customers ON Orders.Customerid=Customers.Id JOIN OrderRows ON OrderRows.Orderid=Orders.Id 

SELECT  Orders.Id ,  Orders.OrderDate, Customers.Firstname, Customers.Lastname, SUM(OrderRows.Price) FROM Orders  JOIN Customers ON Orders.Customerid=Customers.Id JOIN OrderRows ON OrderRows.Orderid=Orders.Id GRoup by Orders.Id, Orders.OrderDate, Customers.Firstname, Customers.Lastname


GROUP BY Orders.Id

