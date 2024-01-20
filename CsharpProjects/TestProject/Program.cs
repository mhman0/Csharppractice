//Evaluate Boolean expressions to make decisions in C#

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

