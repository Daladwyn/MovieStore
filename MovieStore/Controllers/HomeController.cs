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

        public ActionResult Steg1()
        {

            SET IDENTITY_INSERT Customers ON
            INSERT INTO Customers(Id, Firstname, Lastname, BillingAdress, BillingZip, BillingCity, DeliveryAdress, DeliveryZip, DeliveryCity, EmailAdress, PhoneNo)
                VALUES(1, 'Jonas', 'Gray', 'Testväg1', 22222, 'Testcity', 'Testväg1', 22222, 'Testcity', 'Jonas.Gray@gray.nu', 070123456)
            SET IDENTITY_INSERT Customers OFF

                SET IDENTITY_INSERT Customers ON
            INSERT INTO Customers(Id, Firstname, Lastname, BillingAdress, BillingZip, BillingCity, DeliveryAdress, DeliveryZip, DeliveryCity, EmailAdress, PhoneNo)
                VALUES(2, 'Peter', 'Birro', 'Testväg2', 22222, 'Testcity', 'Testväg2', 22222, 'Testcity', 'Peter.Birro@Birro.nu', 070234567)
                SET IDENTITY_INSERT Customers OFF

                SET IDENTITY_INSERT Movies ON
            INSERT INTO Movies(Id, Title, Director, ReleaseYear, Price)
                VALUES(1, 'Interstellar', 'Christopher Nolan', 2014, 179)
            INSERT INTO Movies(Id, Title, Director, ReleaseYear, Price)
                VALUES(2, 'Pulp Fiction', 'Quentin Tarantino', 1994, 49)
            INSERT INTO Movies(Id, Title, Director, ReleaseYear, Price)
                VALUES(3, 'The Wolf of Wall Street', 'Martin Scorsese', 2013, 119)
                SET IDENTITY_INSERT Movies OFF

            SET IDENTITY_INSERT Orders ON
            INSERT INTO Orders(Id, OrderDate, CustomerId)
                VALUES(1, 2015 - 01 - 01, 1);
            INSERT INTO Orders(Id, OrderDate, CustomerId)
                VALUES(2, 2015 - 01 - 15, 2);
            INSERT INTO Orders(Id, OrderDate, CustomerId)
                VALUES(3, 2014 - 12 - 20, 1);
            SET IDENTITY_INSERT Orders OFF


               SET IDENTITY_INSERT OrderRow ON
                INSERT INTO OrderRow(Id, OrderId, MovieId, Price)
                VALUES(1, 1, 1, 179)
                INSERT INTO OrderRow(Id, OrderId, MovieId, Price)
                VALUES(2, 1, 2, 49)
                INSERT INTO OrderRow(Id, OrderId, MovieId, Price)
                VALUES(3, 2, 3, 119)
                INSERT INTO OrderRow(Id, OrderId, MovieId, Price)
                VALUES(4, 2, 3, 119)
                INSERT INTO OrderRow(Id, OrderId, MovieId, Price)
                VALUES(5, 3, 3, 119)
                SET IDENTITY_INSERT OrderRow OFF





                return View();
        }

        public ActionResult Steg2()
        {
            UPDATE Movies SET Price = 169 WHERE ReleaseYear = 2014;


            return View();
        }


        public ActionResult Steg3()
        {
            USE MovieStoreConnection;
            SELECT Firstname, Lastname, PhoneNo, EmailAdress FROM Customers;

            SELECT* FROM Movies ORDER BY ReleaseYear DESC;

            SELECT Title, Price FROM Movies ORDER BY Price ASC




           SELECT Firstname, Lastname, DeliveryAdress, DeliveryZip, DeliveryCity FROM Customers, Orders INNER JOIN ON Customers.Id = Orders.CustomerId
           INTERSECT
           SELECT OrderId, MovieId ,Id ,CustomerId FROM OrderRows, Orders INNER JOIN ON  OrderRows.MovieId = 3 AND OrderRows.OrderId = Order.Id


                SELECT Id, OrderDate, 


                return View();
        }
    }
}
}