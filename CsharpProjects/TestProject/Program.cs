﻿//Evaluate Boolean expressions to make decisions in C#

/*
//example 1 - 
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");


example 2 - 
using System.Runtime.CompilerServices;

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

example 3 - 
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");

eample 4 - 
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);


example 5-
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

//// These two lines of code will create the same output
//Console.WriteLine(pangram.Contains("fox") == false);
//Console.WriteLine(!pangram.Contains("fox"));



int a = 7;
int b = 6;
Console.WriteLine(a != b); //output: true
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); //output: false

*/


/*
Exercise - Implement the conditional operator
<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

*/

/*Exercise - Complete a challenge activity using conditional operators
 * Code challenge: write code to display the result of a coin flip


Random coin = new Random();//creating a new random obj
Console.WriteLine((coin.Next(0, 1) == 0) ? "heads" : "tails");//printing out "coin value which is random between 0 or 1 inside the brackets, then is what comes out of the first set of brackets= to 0? if yes, then heads, otherwise tails"
 */


//Exercise - Complete a challenge activity using Boolean expressions

/*
 


string permission = "Admin";
int level = 55;
string permission = "Admin";
int level = 45;
string permission = "Manager";
int level = 21;
 */

/*
 * Evaluate Boolean Expressions to Make Decisions in C#
string permission = "someone";
int level = 1;

if (permission.Contains("Admin") && level >=55)
{
    Console.WriteLine("Welcome, Super Admin user.\r\n");
}
else if (permission.Contains("Admin") && level <= 55)
{
    Console.WriteLine("Welcome, Admin user.\r\n");
}
else if (permission.Contains("Manager") && level >= 20)
{
    Console.WriteLine("Contact Admin for access.\r\n");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}
*/

//Exercise - Code blocks and variable scope
/*
bool flag = true;
int value = 0;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}
Console.WriteLine($"Outside of code block: {value}");
*/


//Exercise - Remove code blocks from if statements

//bool flag = true;
//if (flag)
//    Console.WriteLine(flag);

//bool flag = true;
//if (flag) Console.WriteLine(flag);


/*

Readability - example 1 not so good:

string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");


Exmaple 2 - much better:

string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve")
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");
*/


//Code challenge: update problematic code in the code editor
// Smaple code supplied at start:

/*
int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (int number in numbers)
{
    int total;

    total += number;

    if (number == 42)
    {
        bool found = true;

    }

}

if (found)
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");
*/

//example of code that works as intended
/*
 * 
 * The biggest changes to the problematic code included:

Moving the declaration of the total and found variables outside of the foreach statement.
Initializing both the total and found variables with sensible default values.
Removing the code blocks (curly braces) from the if statements.
 * 
 * 
 * 

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");


*



int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");

*/

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>


/*
 * 
 * The problem
 * 
 * 
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
}
else if (product[0] == "02")
{
    type = "T-Shirt";
}
else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
}
else if (product[1] == "MN")
{
    color = "Maroon";
}
else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
}
else if (product[2] == "M")
{
    size = "Medium";
}
else if (product[2] == "L")
{
    size = "Large";
}
else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");


// The Solution

// SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");
*/



//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}


//for (int i = 10; i >= 0; i--)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < 10; i+=3)
//{
//    Console.WriteLine(i);
//}


for (int i =0; i <10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}