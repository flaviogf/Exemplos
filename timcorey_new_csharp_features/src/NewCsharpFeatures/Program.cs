﻿using System;
using NewCsharpFeatures;

Console.WriteLine("Hello World");

Console.WriteLine(Add(10, 10));

var frank = new Person { Id = 1, FirstName = "Frank", LastName = "Fernandes" };

// frank.FirstName = "Something"; doesn't work

double Add(double x, double y)
{
    return x + y;
}