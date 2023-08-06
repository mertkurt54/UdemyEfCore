﻿// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using UdemyEfCore.CodeFirst;
using UdemyEfCore.CodeFirst.DAL;

Initializer.Build();

using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} :{p.Name} :{p.Stock}");
    });
}
