// See https://aka.ms/new-console-template for more information
using ExerciceNorthwind.Models;
using Microsoft.EntityFrameworkCore;

NorthwindContext context = new NorthwindContext();

/*Console.WriteLine("Entrez une ville: ");
string? city = Console.ReadLine();

var customerByCity = from Customer in context.Customers
                     where Customer.City == city
                     select Customer;

foreach ( Customer customer in customerByCity )
{
    Console.WriteLine($"{customer.CustomerId}: {customer.ContactName}");
}
*/

/*IQueryable<Product> products = from p in context.Products
                               join c in context.Categories on p.CategoryId equals c.CategoryId 
                               where p.Category.CategoryName == "Beverages" || p.Category.CategoryName == "Condiments"
                               orderby p.Category.CategoryName
                               select p;

string? currentCategory = null;

foreach (var p in products)
{
    if (p.Category.CategoryName != currentCategory)
    {
        currentCategory = p.Category.CategoryName;
        Console.WriteLine("Catégorie: {0}", currentCategory);
    }
    Console.WriteLine("  {0}", p.ProductName);
}*/

/*IQueryable<Product> products = from p in context.Products
                               .Include("Category")
                               where p.Category.CategoryName == "Beverages" || p.Category.CategoryName == "Condiments"
                               select p;

string? currentCategory = null;

foreach (Product p in products)
{
    if (p.Category.CategoryName != currentCategory)
    {
        currentCategory = p.Category.CategoryName;
        Console.WriteLine("Catégorie: {0}", currentCategory);
    }
    Console.WriteLine("  {0}", p.ProductName);
}*/

/*Console.WriteLine("Entrez le nom du client:");
string clientID = Console.ReadLine();

IQueryable<Order> orders = from o in context.Orders
                           join c in context.Customers on o.CustomerId equals c.CustomerId
                           where c.CustomerId == clientID && o.ShippedDate != null
                           orderby o.OrderDate descending
                           select o;

foreach (Order order in orders)
{
    Console.WriteLine($"CustomerID: {order.CustomerId} orderDate: {order.OrderDate} shippedDate: {order.ShippedDate}");
}*/

/*Console.WriteLine("Total des ventes par produits: ");

var od = from o in context.OrderDetails
         orderby o.ProductId
         group o by o.ProductId into g
         select new
         {
             ProductID = g.Key,
             TotalSales = g.Sum(o => o.UnitPrice * o.Quantity)
         }
         into result
         orderby result.ProductID
         select result;

foreach (var detail in od)
{
    Console.WriteLine("{0} ----> Total : {1}", detail.ProductID, detail.TotalSales);
}*/

/*var customers = context.Customers.ToList();
foreach (var customer in customers)
{
    customer.ContactName = customer.ContactName.ToUpper();
}
context.SaveChanges();
Console.WriteLine("UPDATE customer's name to upper");

foreach(var customer in customers)
{
    Console.WriteLine($"Customer {customer.ContactName}");
}*/

/*Console.WriteLine("Entrez la nouvelle catégorie:");
string newCategory = Console.ReadLine();

var categories = context.Categories;

Category newC = new Category();
newC.CategoryName = newCategory;

categories.Add(newC);

context.SaveChanges();

foreach (var category in categories)
{
    Console.WriteLine(category.CategoryName);
}*/

