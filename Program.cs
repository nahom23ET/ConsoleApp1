// See https://aka.ms/new-console-template for more information
// Nahom Tefera
// 9/2/2022
// This project collects information from the user input and print it using
// Loops, List, ocsntructors and Tostring.


using projectnorthwindC;
using System;

Console.WriteLine("Hello, Please Fill in the Information Below");
Console.WriteLine("\n");

// creating new catagories
Catagory aCatagory1 = new Catagory();
Catagory aCatagory2 = new Catagory();
Catagory aCatagory3 = new Catagory();

Console.WriteLine("Enter the CatagoryID 1 ");
aCatagory1.CatagoryId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Catagory Name 1: ");
aCatagory1.CatagoryName = Console.ReadLine();
Console.WriteLine("Enter the Description 1: "); 
aCatagory1.Description = Console.ReadLine();

Console.WriteLine("\n");

Console.WriteLine("Enter the CatagoryID 2: ");
aCatagory2.CatagoryId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Catagory Name 2: ");
aCatagory2.CatagoryName = Console.ReadLine();
Console.WriteLine("Enter the Description 2: ");
aCatagory2.Description = Console.ReadLine();

Console.WriteLine("\n");

Console.WriteLine("Enter the CatagoryID 3: ");
aCatagory3.CatagoryId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Catagory Name 3: ");
aCatagory3.CatagoryName = Console.ReadLine();
Console.WriteLine("Enter the Description 3: ");
aCatagory3.Description = Console.ReadLine();

Console.WriteLine("\n");

// creating a new list for catagory

List<Catagory> aListOfCatagory = new List<Catagory>();
aListOfCatagory.Add(aCatagory1);
aListOfCatagory.Add(aCatagory2);
aListOfCatagory.Add(aCatagory3);



// creating new customers
Customer aCoustomer1 = new Customer();
Customer aCoustomer2 = new Customer();
Customer aCoustomer3 = new Customer();

Console.WriteLine("Enter the 1 Customer id:");
aCoustomer1.CustomerId = Console.ReadLine();
Console.WriteLine("Enter the 1 Company name:");
aCoustomer1.CompanyName = Console.ReadLine();
Console.WriteLine("Enter the 1 Contact Name:");
aCoustomer1.ContactName = Console.ReadLine();
Console.WriteLine("Enter the 1 Contact Title:");
aCoustomer1.ContactTitle = Console.ReadLine();
Console.WriteLine("Enter the 1 Address:");
aCoustomer1.Address = Console.ReadLine();
Console.WriteLine("Enter the 1 City:");
aCoustomer1.City = Console.ReadLine();
Console.WriteLine("Enter the 1 Region:");
aCoustomer1.Region = Console.ReadLine();
Console.WriteLine("Enter the 1 Postal Code:");
aCoustomer1.PostalCode = Console.ReadLine();
Console.WriteLine("Enter the 1 Country:");
aCoustomer1.Country = Console.ReadLine();
Console.WriteLine("Enter the 1 Phone:");
aCoustomer1.Phone = Console.ReadLine();
Console.WriteLine("Enter the 1 Fax:");
aCoustomer1.Fax = Console.ReadLine();
Console.WriteLine("\n");

Console.WriteLine("Enter the 2 Customer id:");
aCoustomer2.CustomerId = Console.ReadLine();
Console.WriteLine("Enter the 2 Company name:");
aCoustomer2.CompanyName = Console.ReadLine();
Console.WriteLine("Enter the 2 Contact Name:");
aCoustomer2.ContactName = Console.ReadLine();
Console.WriteLine("Enter the 2 Contact Title:");
aCoustomer2.ContactTitle = Console.ReadLine();
Console.WriteLine("Enter the 2 Address:");
aCoustomer2.Address = Console.ReadLine();
Console.WriteLine("Enter the 2 City:");
aCoustomer2.City = Console.ReadLine();
Console.WriteLine("Enter the 2 Region:");
aCoustomer2.Region = Console.ReadLine();
Console.WriteLine("Enter the 2 Postal Code:");
aCoustomer2.PostalCode = Console.ReadLine();
Console.WriteLine("Enter the 2 Country:");
aCoustomer2.Country = Console.ReadLine();
Console.WriteLine("Enter the 2 Phone:");
aCoustomer2.Phone = Console.ReadLine();
Console.WriteLine("Enter the 2 Fax:");
aCoustomer2.Fax = Console.ReadLine();
Console.WriteLine("\n");

Console.WriteLine("Enter the 3 Customer id:");
aCoustomer3.CustomerId = Console.ReadLine();
Console.WriteLine("Enter the 3 Company name:");
aCoustomer3.CompanyName = Console.ReadLine();
Console.WriteLine("Enter the 3 Contact Name:");
aCoustomer3.ContactName = Console.ReadLine();
Console.WriteLine("Enter the 3 Contact Title:");
aCoustomer3.ContactTitle = Console.ReadLine();
Console.WriteLine("Enter the 3 Address:");
aCoustomer3.Address = Console.ReadLine();
Console.WriteLine("Enter the 3 City:");
aCoustomer3.City = Console.ReadLine();
Console.WriteLine("Enter the 3 Region:");
aCoustomer3.Region = Console.ReadLine();
Console.WriteLine("Enter the 3 Postal Code:");
aCoustomer3.PostalCode = Console.ReadLine();
Console.WriteLine("Enter the 3 Country:");
aCoustomer3.Country = Console.ReadLine();
Console.WriteLine("Enter the 3 Phone:");
aCoustomer3.Phone = Console.ReadLine();
Console.WriteLine("Enter the 3 Fax:");
aCoustomer3.Fax = Console.ReadLine();
Console.WriteLine("\n");

//creating a list for customer
List<Customer> aListOfCustomer = new List<Customer>();
aListOfCustomer.Add(aCoustomer1);
aListOfCustomer.Add(aCoustomer2);
aListOfCustomer.Add(aCoustomer3);


// creating a new employee
Employee aEmployee1 = new Employee();
Employee aEmployee2 = new Employee();
Employee aEmployee3 = new Employee();

Console.WriteLine("Enter the 1 Employee ID");
aEmployee1.EmployeeId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 1 LastName");
aEmployee1.LastName= Console.ReadLine();
Console.WriteLine("Enter the 1 FirstName");
aEmployee1.FirstName = Console.ReadLine();
Console.WriteLine("Enter the 1 Title");
aEmployee1.Title = Console.ReadLine();
Console.WriteLine("Enter the 1 Title Od Courtesy");
aEmployee1.TitleOfCourtesy = Console.ReadLine();
Console.WriteLine("Enter the 1 BirthDay");
aEmployee1.BirthDay = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter the 1 HireDay");
aEmployee1.Hireday = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter the 1 Address");
aEmployee1.Address = Console.ReadLine();
Console.WriteLine("Enter the 1 City");
aEmployee1.City= Console.ReadLine();
Console.WriteLine("Enter the 1 Region");
aEmployee1.Region = Console.ReadLine();
Console.WriteLine("Enter the 1 Postal Code");
aEmployee1.PostalCode = Console.ReadLine();
Console.WriteLine("Enter the 1 Country");
aEmployee1.Country = Console.ReadLine();
Console.WriteLine("Enter the 1 Home Pone");
aEmployee1.HomePhone = Console.ReadLine();
Console.WriteLine("Enter the 1 Extension");
aEmployee1.Extension = Console.ReadLine();
Console.WriteLine("Enter the 1 Notes");
aEmployee1.Notes = Console.ReadLine();
Console.WriteLine("Enter the 1 Reports to");
aEmployee1.ReportsTo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n");


Console.WriteLine("Enter the 1 Employee ID");
aEmployee2.EmployeeId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 2 LastName");
aEmployee2.LastName = Console.ReadLine();
Console.WriteLine("Enter the 2 FirstName");
aEmployee2.FirstName = Console.ReadLine();
Console.WriteLine("Enter the 2 Title");
aEmployee2.Title = Console.ReadLine();
Console.WriteLine("Enter the 2 Title Od Courtesy");
aEmployee2.TitleOfCourtesy = Console.ReadLine();
Console.WriteLine("Enter the 2 BirthDay");
aEmployee2.BirthDay = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter the 2 HireDay");
aEmployee2.Hireday = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter the 2 Address");
aEmployee2.Address = Console.ReadLine();
Console.WriteLine("Enter the 2 City");
aEmployee2.City = Console.ReadLine();
Console.WriteLine("Enter the 2 Region");
aEmployee2.Region = Console.ReadLine();
Console.WriteLine("Enter the 2 Postal Code");
aEmployee2.PostalCode = Console.ReadLine();
Console.WriteLine("Enter the 2 Country");
aEmployee2.Country = Console.ReadLine();
Console.WriteLine("Enter the 2 Home Pone");
aEmployee2.HomePhone = Console.ReadLine();
Console.WriteLine("Enter the 2 Extension");
aEmployee2.Extension = Console.ReadLine();
Console.WriteLine("Enter the 2 Notes");
aEmployee2.Notes = Console.ReadLine();
Console.WriteLine("Enter the 2 Reports to");
aEmployee2.ReportsTo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n");

Console.WriteLine("Enter the 3 Employee ID");
aEmployee3.EmployeeId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 3 LastName");
aEmployee3.LastName = Console.ReadLine();
Console.WriteLine("Enter the 3 FirstName");
aEmployee3.FirstName = Console.ReadLine();
Console.WriteLine("Enter the 3 Title");
aEmployee3.Title = Console.ReadLine();
Console.WriteLine("Enter the 3 Title Od Courtesy");
aEmployee3.TitleOfCourtesy = Console.ReadLine();
Console.WriteLine("Enter the 3 BirthDay");
aEmployee3.BirthDay = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter the 3 HireDay");
aEmployee3.Hireday = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter the 3 Address");
aEmployee3.Address = Console.ReadLine();
Console.WriteLine("Enter the 3 City");
aEmployee3.City = Console.ReadLine();
Console.WriteLine("Enter the 3 Region");
aEmployee3.Region = Console.ReadLine();
Console.WriteLine("Enter the 3 Postal Code");
aEmployee3.PostalCode = Console.ReadLine();
Console.WriteLine("Enter the 3 Country");
aEmployee3.Country = Console.ReadLine();
Console.WriteLine("Enter the 3 Home Pone");
aEmployee3.HomePhone = Console.ReadLine();
Console.WriteLine("Enter the 3 Extension");
aEmployee3.Extension = Console.ReadLine();
Console.WriteLine("Enter the 3 Notes");
aEmployee3.Notes = Console.ReadLine();
Console.WriteLine("Enter the 3 Reports to");
aEmployee3.ReportsTo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n");

// creating a new list for employee
List<Employee> aListOfEmployee = new List<Employee>();
aListOfEmployee.Add(aEmployee1);
aListOfEmployee.Add(aEmployee2);
aListOfEmployee.Add(aEmployee3);




// Creating a new order
OrderDetail aOrderDetail1 = new OrderDetail();
OrderDetail aOrderDetail2 = new OrderDetail();
OrderDetail aOrderDetail3 = new OrderDetail();

Console.WriteLine("Enter The 1 OrderID");
aOrderDetail1.OrderId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The 1 ProductID");
aOrderDetail1.ProductId = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Enter The 1 ProductID");
aOrderDetail1.UnitPrice = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter The 1 Quantitiy");
aOrderDetail1.Quantity = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The 1 Discount");
aOrderDetail1.Discount = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n");


Console.WriteLine("Enter The 2 OrderID");
aOrderDetail2.OrderId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The 2 ProductID");
aOrderDetail2.ProductId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The 2 ProductID");
aOrderDetail2.UnitPrice = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter The 2 Quantitiy");
aOrderDetail2.Quantity = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The 2 Discount");
aOrderDetail2.Discount = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n");

Console.WriteLine("Enter The 3 OrderID");
aOrderDetail3.OrderId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The 3 ProductID");
aOrderDetail3.ProductId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The 3 ProductID");
aOrderDetail3.UnitPrice = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter The 3 Quantitiy");
aOrderDetail3.Quantity = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The 3 Discount");
aOrderDetail3.Discount = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n");

// creating a list for orderDetail
List<OrderDetail> aListOfOrderDetail = new List<OrderDetail>();
aListOfOrderDetail.Add(aOrderDetail1);
aListOfOrderDetail.Add(aOrderDetail2);
aListOfOrderDetail.Add(aOrderDetail3);


// Creating a new ordeer
Order aorder1 = new Order();
Order aorder2 = new Order();
Order aorder3 = new Order();

Console.WriteLine("Enter the 1 orderID");
aorder1.OrderId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 1 Customer ID");
aorder1.CustomerId= Console.ReadLine();
Console.WriteLine("Enter the 1 Employee ID");
aorder1.EmployeeId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 1 Order Date");
aorder1.OrederDate = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter the 1 Required Date");
aorder1.RequiredDate = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter the 1 Shipped Date");
aorder1.ShippedDate = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter the 1 Ship Via");
aorder1.ShipVia = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 1 Freight");
aorder1.Freight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the 1 Ship name");
aorder1.ShipName = Console.ReadLine();
Console.WriteLine("Enter the 1 Ship Address");
aorder1.ShipAddress = Console.ReadLine();
Console.WriteLine("Enter the 1 Ship Date");
aorder1.ShipCity = Console.ReadLine();
Console.WriteLine("Enter the 1 Ship Region");
aorder1.ShipRegion = Console.ReadLine();
Console.WriteLine("Enter the 1 Ship Postal Code");
aorder1.ShipPostalCode = Console.ReadLine();
Console.WriteLine("Enter the 1 Ship Country");
aorder1.ShipCountry = Console.ReadLine();
Console.WriteLine("\n");

Console.WriteLine("Enter the 2 orderID");
aorder2.OrderId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 2 Customer ID");
aorder2.CustomerId = Console.ReadLine();
Console.WriteLine("Enter the 2 Employee ID");
aorder2.EmployeeId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 2 Order Date");
aorder2.OrederDate = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter the 2 Required Date");
aorder2.RequiredDate = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter the 2 Shipped Date");
aorder2.ShippedDate = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter the 2 Ship Via");
aorder2.ShipVia = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 2 Freight");
aorder2.Freight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the 2 Ship name");
aorder2.ShipName = Console.ReadLine();
Console.WriteLine("Enter the 2 Ship Address");
aorder2.ShipAddress = Console.ReadLine();
Console.WriteLine("Enter the 2 Ship Date");
aorder2.ShipCity = Console.ReadLine();
Console.WriteLine("Enter the 2 Ship Region");
aorder2.ShipRegion = Console.ReadLine();
Console.WriteLine("Enter the 2 Ship Postal Code");
aorder2.ShipPostalCode = Console.ReadLine();
Console.WriteLine("Enter the 2 Ship Country");
aorder2.ShipCountry = Console.ReadLine();
Console.WriteLine("\n");

Console.WriteLine("Enter the 3 orderID");
aorder3.OrderId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 3 Customer ID");
aorder3.CustomerId = Console.ReadLine();
Console.WriteLine("Enter the 3 Employee ID");
aorder3.EmployeeId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 3 Order Date");
aorder3.OrederDate = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter the 3 Required Date");
aorder3.RequiredDate = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter the 3 Shipped Date");
aorder3.ShippedDate = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter the 3 Ship Via");
aorder3.ShipVia = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 3 Freight");
aorder3.Freight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the 3 Ship name");
aorder3.ShipName = Console.ReadLine();
Console.WriteLine("Enter the 3 Ship Address");
aorder3.ShipAddress = Console.ReadLine();
Console.WriteLine("Enter the 3 Ship Date");
aorder3.ShipCity = Console.ReadLine();
Console.WriteLine("Enter the 3 Ship Region");
aorder3.ShipRegion = Console.ReadLine();
Console.WriteLine("Enter the 3 Ship Postal Code");
aorder3.ShipPostalCode = Console.ReadLine();
Console.WriteLine("Enter the 3 Ship Country");
aorder3.ShipCountry = Console.ReadLine();
Console.WriteLine("\n");

// creating a list for order
List<Order> aListOfOrder = new List<Order>();
aListOfOrder.Add(aorder1);
aListOfOrder.Add(aorder2);
aListOfOrder.Add(aorder3);



// creating a new Product
Product aProduct1 = new Product();
Product aProduct2 = new Product();
Product aProduct3 = new Product();

Console.WriteLine("Enter the 1 ProductID");
aProduct1.ProductId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 1 Product Nme");
aProduct1.ProductName =Console.ReadLine();
Console.WriteLine("Enter the 1 Supplier ID");
aProduct1.SupplierId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 1 Quantity Per Unit");
aProduct1.QuantityPerUnit = Console.ReadLine();
Console.WriteLine("Enter the 1 Unit Price");
aProduct1.UnitPrice =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the 1 Unit in stock");
aProduct1.UnitsInStock = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 1 Unit On order");
aProduct1.UnitsOnOrder = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 1 Re Order Level");
aProduct1.ReOrderLevel = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 1 Discontinued?");
aProduct1.Discontinued = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("\n");

Console.WriteLine("Enter the 2 ProductID");
aProduct2.ProductId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 2 Product Nme");
aProduct2.ProductName = Console.ReadLine();
Console.WriteLine("Enter the 2 Supplier ID");
aProduct2.SupplierId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 2 Quantity Per Unit");
aProduct2.QuantityPerUnit = Console.ReadLine();
Console.WriteLine("Enter the 2 Unit Price");
aProduct2.UnitPrice = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the 2 Unit in stock");
aProduct2.UnitsInStock = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 2 Unit On order");
aProduct2.UnitsOnOrder = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 2 Re Order Level");
aProduct2.ReOrderLevel = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 2 Discontinued?");
aProduct2.Discontinued = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("\n");

Console.WriteLine("Enter the 3 ProductID");
aProduct3.ProductId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 3 Product Nme");
aProduct3.ProductName = Console.ReadLine();
Console.WriteLine("Enter the 3 Supplier ID");
aProduct3.SupplierId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 3 Quantity Per Unit");
aProduct3.QuantityPerUnit = Console.ReadLine();
Console.WriteLine("Enter the 3 Unit Price");
aProduct3.UnitPrice = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the 3 Unit in stock");
aProduct3.UnitsInStock = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 3 Unit On order");
aProduct3.UnitsOnOrder = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 3 Re Order Level");
aProduct3.ReOrderLevel = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 3 Discontinued?");
aProduct3.Discontinued = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("\n");

// creating a list for product
List<Product> aListOfProduct = new List<Product>();
aListOfProduct.Add(aProduct1);
aListOfProduct.Add(aProduct2);
aListOfProduct.Add(aProduct3);

// creating a new shipper
Shipper ashipper1 = new Shipper();
Shipper ashipper2 = new Shipper();
Shipper ashipper3 = new Shipper();

Console.WriteLine("Enter the 1 ShipperID");
ashipper1.ShipperID = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 1 CompanyNAme");
ashipper1.CompanyName = Console.ReadLine();
Console.WriteLine("Enter the 1 Phone");
ashipper1.Phone = Console.ReadLine();
Console.WriteLine("\n");

Console.WriteLine("Enter the 2 ShipperID");
ashipper2.ShipperID = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 2 CompanyNAme");
ashipper2.CompanyName = Console.ReadLine();
Console.WriteLine("Enter the 2 Phone");
ashipper2.Phone = Console.ReadLine();
Console.WriteLine("\n");

Console.WriteLine("Enter the 3 ShipperID");
ashipper3.ShipperID = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 3 CompanyNAme");
ashipper3.CompanyName = Console.ReadLine();
Console.WriteLine("Enter the 3 Phone");
ashipper3.Phone = Console.ReadLine();
Console.WriteLine("\n");

// crerating a new list for shipper
List<Shipper> aListOfShipper = new List<Shipper>();
aListOfShipper.Add(ashipper1);
aListOfShipper.Add(ashipper2);
aListOfShipper.Add(ashipper3);




// creating a new supplier
Supplier asupplier1 = new Supplier();
Supplier asupplier2 = new Supplier();
Supplier asupplier3 = new Supplier();

Console.WriteLine("Enter the 1 SupplierID");
asupplier1.SupplierId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 1 Company Name");
asupplier1.CompanyName = Console.ReadLine();
Console.WriteLine("Enter the 1 Contact Name");
asupplier1.ContactName = Console.ReadLine();
Console.WriteLine("Enter the 1 Contact title");
asupplier1.ContactTitle = Console.ReadLine();
Console.WriteLine("Enter the 1 Address");
asupplier1.Address = Console.ReadLine();
Console.WriteLine("Enter the 1 City");
asupplier1.City = Console.ReadLine();
Console.WriteLine("Enter the 1 Region");
asupplier1.Region = Console.ReadLine();
Console.WriteLine("Enter the 1 Postal code");
asupplier1.PostalCode = Console.ReadLine();
Console.WriteLine("Enter the 1 Country");
asupplier1.Country = Console.ReadLine();
Console.WriteLine("Enter the 1 Phone");
asupplier1.Phone = Console.ReadLine();
Console.WriteLine("Enter the 1 Fax");
asupplier1.Fax = Console.ReadLine();
Console.WriteLine("Enter the 1 Home Page");
asupplier1.HomePage = Console.ReadLine();
Console.WriteLine("\n");


Console.WriteLine("Enter the 2 SupplierID");
asupplier2.SupplierId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 2 Company Name");
asupplier2.CompanyName = Console.ReadLine();
Console.WriteLine("Enter the 2 Contact Name");
asupplier2.ContactName = Console.ReadLine();
Console.WriteLine("Enter the 2 Contact title");
asupplier2.ContactTitle = Console.ReadLine();
Console.WriteLine("Enter the 2 Address");
asupplier2.Address = Console.ReadLine();
Console.WriteLine("Enter the 2 City");
asupplier2.City = Console.ReadLine();
Console.WriteLine("Enter the 2 Region");
asupplier2.Region = Console.ReadLine();
Console.WriteLine("Enter the 2 Postal code");
asupplier2.PostalCode = Console.ReadLine();
Console.WriteLine("Enter the 2 Country");
asupplier2.Country = Console.ReadLine();
Console.WriteLine("Enter the 2 Phone");
asupplier2.Phone = Console.ReadLine();
Console.WriteLine("Enter the 2 Fax");
asupplier2.Fax = Console.ReadLine();
Console.WriteLine("Enter the 2 Home Page");
asupplier2.HomePage = Console.ReadLine();
Console.WriteLine("\n");

Console.WriteLine("Enter the 3 SupplierID");
asupplier3.SupplierId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 3 Company Name");
asupplier3.CompanyName = Console.ReadLine();
Console.WriteLine("Enter the 3 Contact Name");
asupplier3.ContactName = Console.ReadLine();
Console.WriteLine("Enter the 3 Contact title");
asupplier3.ContactTitle = Console.ReadLine();
Console.WriteLine("Enter the 3 Address");
asupplier3.Address = Console.ReadLine();
Console.WriteLine("Enter the 3 City");
asupplier3.City = Console.ReadLine();
Console.WriteLine("Enter the 3 Region");
asupplier3.Region = Console.ReadLine();
Console.WriteLine("Enter the 3 Postal code");
asupplier3.PostalCode = Console.ReadLine();
Console.WriteLine("Enter the 3 Country");
asupplier3.Country = Console.ReadLine();
Console.WriteLine("Enter the 3 Phone");
asupplier3.Phone = Console.ReadLine();
Console.WriteLine("Enter the 3 Fax");
asupplier3.Fax = Console.ReadLine();
Console.WriteLine("Enter the 3 Home Page");
asupplier3.HomePage = Console.ReadLine();
Console.WriteLine("\n");

// creating a list for supplier
List<Supplier> aListOfSupplier = new List<Supplier>();
aListOfSupplier.Add(asupplier1);
aListOfSupplier.Add(asupplier2);
aListOfSupplier.Add(asupplier3);
Console.WriteLine("\n\n\n");

// creating a loop for Catagory
foreach (var c in aListOfCatagory)
{
    Console.WriteLine(c.ToString());
    Console.WriteLine("\n\n\n");
}
// creating a loop for Customer
foreach (var d in aListOfCustomer)
{
    Console.WriteLine(d.ToString());
    Console.WriteLine("\n\n\n");
}
// creating a loop for Employee
foreach (var e in aListOfEmployee)
{
    Console.WriteLine(e.ToString);
    Console.WriteLine("\n\n\n");
}
// creating a loop for order details
foreach (var f in aListOfOrderDetail)
{
    Console.WriteLine(f.ToString);
    Console.WriteLine("\n\n\n");
}
// creating a loop for Order
foreach (var g in aListOfOrder)
{
    Console.WriteLine(g.ToString);
    Console.WriteLine("\n\n\n");
}

// creating a loop for product
foreach (var h in aListOfProduct)
{
    Console.WriteLine(h.ToString);
    Console.WriteLine("\n\n\n");
}
// creating a loop for shipper
foreach (var i in aListOfShipper)
{
    Console.WriteLine(i.ToString());
    Console.WriteLine("\n\n\n");
}

//creating a loop
foreach (var h in aListOfSupplier)
{
    Console.WriteLine(h.ToString);
    Console.WriteLine("\n\n\n");
}



























