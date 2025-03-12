A package to simplify Print() statement in C# .NET. Inspired by print() function of Python.

Refer the github project - https://github.com/souravkayal/printr

It's easy to use. 

Step 1 : Add namespace in your .cs file

using static Printmaster.Printr;

Step 3 : Start printing anything.

Print(1,2,3);

Print(1,true, false);

Print(new List<string> { "Item1" , "Item2" });

var person = new { Name = "John", Age = 30 };
Print(person);

int[,] matrix =
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

Print(matrix);