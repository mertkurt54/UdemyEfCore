// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using UdemyEfCore.CodeFirst;
using UdemyEfCore.CodeFirst.DAL;

Initializer.Build();

using (var _context = new AppDbContext())
{

    _context.Products.Add(new() { Name = "Kalem8", Price = 10, Stock = 200, Barcode = 12345 });
    _context.Products.Add(new() { Name = "Kalem8", Price = 10, Stock = 200, Barcode = 12345 });
    _context.Products.Add(new() { Name = "Kalem8", Price = 10, Stock = 200, Barcode = 12345 });
    _context.Products.Add(new() { Name = "Kalem8", Price = 10, Stock = 200, Barcode = 12345 });



    _context.SaveChanges();

    var products = await _context.Products.ToListAsync();

    //products.ForEach(p =>
    //{
    //    Console.WriteLine($"{p.Id} :{p.Name} :{p.Stock}");
    //});

    
   }
