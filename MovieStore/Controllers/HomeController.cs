using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public ActionResult Steg1()
        //{

        //SET IDENTITY_INSERT Customers ON
        //    INSERT INTO Customers(Id, Firstname, Lastname, BillingAddress, BillingZip, BillingCity, DeliveryAddress, DeliveryZip, DeliveryCity, EmailAddress, PhoneNo)
        //        VALUES(1, 'Jonas', 'Gray', 'Testväg1', 22222, 'Testcity', 'Testväg1', 22222, 'Testcity', 'Jonas.Gray@gray.nu', 070123456)
        //    SET IDENTITY_INSERT Customers OFF

        //    SET IDENTITY_INSERT Customers ON
        //    INSERT INTO Customers(Id, Firstname, Lastname, BillingAddress, BillingZip, BillingCity, DeliveryAddress, DeliveryZip, DeliveryCity, EmailAddress, PhoneNo)
        //        VALUES(2, 'Peter', 'Birro', 'Testväg2', 22222, 'Testcity', 'Testväg2', 22222, 'Testcity', 'Peter.Birro@Birro.nu', 070234567)
        //        SET IDENTITY_INSERT Customers OFF

        //SET IDENTITY_INSERT Movies ON
        //            INSERT INTO Movies(Id, Title, Director, ReleaseYear, Price)
        //                VALUES(1, 'Interstellar', 'Christopher Nolan', 2014, 179)
        //            INSERT INTO Movies(Id, Title, Director, ReleaseYear, Price)
        //                VALUES(2, 'Pulp Fiction', 'Quentin Tarantino', 1994, 49)
        //            INSERT INTO Movies(Id, Title, Director, ReleaseYear, Price)
        //                VALUES(3, 'The Wolf of Wall Street', 'Martin Scorsese', 2013, 119)
        //                SET IDENTITY_INSERT Movies OFF

        //SET IDENTITY_INSERT Orders ON
        //        INSERT INTO Orders(Id, OrderDate, Customerid)
        //            VALUES(1, 2015 - 01 - 01, 1);
        //INSERT INTO Orders(Id, OrderDate, Customerid)
        //            VALUES(2, 2015 - 01 - 15, 2);
        //INSERT INTO Orders(Id, OrderDate, Customerid)
        //            VALUES(3, 2014 - 12 - 20, 1);
        //SET IDENTITY_INSERT Orders OFF


        //SET IDENTITY_INSERT OrderRows ON
        //            INSERT INTO OrderRows(Id, Orderid, Movieid, Price)
        //            VALUES(1, 1, 1, 179)
        //            INSERT INTO OrderRows(Id, Orderid, Movieid, Price)
        //            VALUES(2, 1, 2, 49)
        //            INSERT INTO OrderRows(Id, Orderid, Movieid, Price)
        //            VALUES(3, 2, 3, 119)
        //            INSERT INTO OrderRows(Id, Orderid, Movieid, Price)
        //            VALUES(4, 2, 3, 119)
        //            INSERT INTO OrderRows(Id, Orderid, Movieid, Price)
        //            VALUES(5, 3, 3, 119)
        //            SET IDENTITY_INSERT OrderRows OFF


        //            return View();
        //}
        //public ActionResult Steg2()
        //{
        //    UPDATE Movies SET Price = 169 WHERE ReleaseYear = 2014;

        //    return View();
        //}
        // public ActionResult Steg3()
        //  {
        //  SELECT Firstname, Lastname, PhoneNo, EmailAddress FROM Customers;

        // SELECT* FROM Movies ORDER BY ReleaseYear DESC;

        //    SELECT Title, Price FROM Movies ORDER BY Price ASC

        //SELECT Firstname, Lastname, DeliveryAddress, DeliveryZip, DeliveryCity FROM Customers JOIN Orders ON Customers.Id=Orders.Customerid JOIN OrderRows ON Orders.Id=OrderRows.Orderid WHERE OrderRows.Movieid=3

        //Customerid, Datum för inköpen, för och efternamn samt totala kostnaden av varje order


        //            Partial Assignment E:
        //                SELECT Id, Firstname, Lastname FROM Customers JOIN Orders ON Customers.Id=Orders.Customerid JOIN OrderRows ON Orders.Id=OrderRows.Orderid GROUP BY OrderRows.Orderid HAVING SUM (Price)

        //SELECT SUM(OrderRows.Price) Firstname, Lastname FROM Customers JOIN Orders ON Customers.Id= Orders.Customerid JOIN OrderRows ON Orders.Id= OrderRows.Orderid GROUP BY Orders.Id HAVING SUM(OrderRows.Price)

        //SELECT  SUM(OrderRows.Price) FROM OrderRows JOIN Orders ON OrderRows.Orderid= Orders.Id GROUP BY OrderRows.Orderid

        //SELECT Customers.Id ,Customers.Firstname, Customers.Lastname , Orders.OrderDate, SUM(OrderRows.Price) FROM Customers JOIN Orders ON Customers.Id= Orders.Customerid JOIN OrderRows ON Orders.Id= OrderRows.Orderid
   //     SELECT Customers.Id , Customers.Firstname, Customers.Lastname , Orders.OrderDate FROM Customers JOIN Orders ON Customers.Id= Orders.Customerid JOIN OrderRows ON Orders.Id= OrderRows.Orderid GROUP BY OrderRows.Orderid HAVING SUM(OrderRows.Price)




    }
        }
