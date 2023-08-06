// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using UdemyEfCore.DatabaseFirstByScaffold.Models;

Console.WriteLine("Hello, World!");

using (var context = new UdemyEfCoreDatabaseFirstDbContext())
{
    var products = await context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} :{p.Name} :{p.Stock}");
    });
}