// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using UdemyEfCore.CodeFirst;
using UdemyEfCore.CodeFirst.DAL;

Initializer.Build();

using (var _context = new AppDbContext())
{
    //var newProduct = new Product { Name = "Kalem 200", Price = 200, Stock = 100, Barcode = 333 };

     var product = await _context.Products.FirstAsync();

    Console.WriteLine($"ilk state:{ _context.Entry(product).State}");

    _context.Remove(product);

    //await _context.AddAsync(newProduct);

    Console.WriteLine($"son state:{_context.Entry(product).State}");
    

    await _context.SaveChangesAsync();

    Console.WriteLine($"save changes state:{_context.Entry(product).State}");

    //var products = await _context.Products.ToListAsync();

    //products.ForEach(p =>
    //{
    //    var state = _context.Entry(p).State;
    //    Console.WriteLine($"{p.Id} :{p.Name} :{p.Stock} state:{state}");
    //});
}
