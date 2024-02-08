//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");




//FIZZBNUZZ CHALLENGE

//Here are the FizzBuzz rules that you need to implement in your code project:

//Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
//When the current value is divisible by 3, print the term Fizz next to the number.
//When the current value is divisible by 5, print the term Buzz next to the number.
//When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.

//for(int x = 1; x < 101; x++){
//    if ((x % 3 == 0) && (x % 5==0))
//    {
//        Console.WriteLine(x + " - FizzBuzz");
//    }
//    else if (x % 5 == 0){
//        Console.WriteLine(x + " - Buzz");
//    }else if(x%3==0){
//        Console.WriteLine(x + " - Fizz");
//    }
//    else {
//        Console.WriteLine(x);
//    }
//}


////Summ oif an array challenge:
///
//Given an array of integers, find the sum of its elements.
//For example, if the array , , so return .
//Function Description
//Complete the simpleArraySum function in the editor below. It must return the sum of the array elements as an integer.
//simpleArraySum has the following parameter(s):
//ar: an array of integers
//Input Format
//The first line contains an integer,n , denoting the size of the array.
//The second line contains n space-separated integers representing the array's elements.
//Print the sum of the array's elements as a single integer.
//Sample Input
//6
//1 2 3 4 10 11
//Sample Output

//31
//Explanation
//We print the sum of the array's elements: .

//Answer

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Read the size of the array from the user
//        int size = Convert.ToInt32(Console.ReadLine());

//        // Read the array elements from the user
//        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

//        // Calculate the sum of the array elements
//        int sum = SimpleArraySum(ar);

//        // Print the sum to the console
//        Console.WriteLine(sum);
//    }

//    static int SimpleArraySum(int[] ar)
//    {
//        // Initialize a variable to store the sum
//        int sum = 0;

//        // Iterate through the array and add each element to the sum
//        foreach (int num in ar)
//        {
//            sum += num;
//        }

//        // Return the sum
//        return sum;
//    }
//} 



//class Result{

//    /*
//     * Complete the 'plusMinus' function below.
//     *
//     * The function accepts INTEGER_ARRAY arr as parameter.
//     */

//public static void plusMinus(List<int> arr)
//    {
//var posCount = 0;
//var negCount = 0;
//var zeroCount = 0;
//var totalCount = arr.Count; // Get the total count of elements in the list

//foreach (int num in arr)
//{
//if (num > 0)
//{
//posCount++;
//}
//else if (num < 0)
//{
//negCount++;
//}
//else
//{
//zeroCount++;
//}
//}

//// Handle the case where totalCount is zero to avoid division by zero error
//// code calculates the positive ratio (posRatio) based on the counts of positive elements
////(posCount) and the total number of elements (totalCount). If there are no elements in the list
////(ie., totalCount == 0), posRatio is assigned the value 0. Otherwise, it calculates the ratio as
////(double)posCount / totalCount.
//double posRatio = totalCount != 0 ? (double)posCount / totalCount : 0;
//double negRatio = totalCount != 0 ? (double)negCount / totalCount : 0;
//double zerRatio = totalCount != 0 ? (double)zeroCount / totalCount : 0;

//// Print ratios with six decimal places
//Console.WriteLine(posRatio.ToString("F6"));
//Console.WriteLine(negRatio.ToString("F6"));
//Console.WriteLine(zerRatio.ToString("F6"));
//}

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine().Trim());

//        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//        Result.plusMinus(arr);
//    }
//}
 
