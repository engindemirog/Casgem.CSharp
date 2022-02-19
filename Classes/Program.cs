using Classes;

Category category1 = new Category();
category1.Id = 1;
category1.Name = "Meyve & Sebze";

//constructor
Product product1 = new Product();
product1.Id = 1;
product1.Name = "Elma";
product1.ImageUrl = "image1.jpg";
product1.UnitPrice = 15;
product1.DiscountRate = 10;
product1.Category = category1;

//overloading
Product product2 = new Product(2, "Armut", 25, 10, "image2.jpg");

Console.WriteLine(product1.Name + "/"+product1.DiscountedPrice);