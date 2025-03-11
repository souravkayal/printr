# Printr
## https://www.nuget.org/packages/Printr/

Console.Write() is not unified and generic for all data type. It needs custom code to print various types of object like List<string> , Complex Object , Dicttinary etc. 

Printr simplifies it ! 

##### Step 1 : Include the nuget pachage from here - https://www.nuget.org/packages/Printr/

##### Step 2: Add namespace in your .cs file 

`using static Printmaster.Printr;`

##### Step 3 : Start printing anything. 

using System;
using static Printmaster.Printr;

```csharp
//Print numbers
Print(1,2,3);

//Print mixed data type
Print(1,true, false);

//Print List
Print(new List<string> { "Item1" , "Item2" });

//Print Object
var person = new { Name = "John", Age = 30 };
Print(person);

//Print 2D Array / Matrix
int[,] matrix =
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

Print(matrix);

```
##### Here it your output

![printr](https://github.com/user-attachments/assets/1dd3830a-aefc-4f12-9b5b-19744f4c7011)



