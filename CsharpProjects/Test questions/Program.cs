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

//------------Compare THE TRIPLETS--------
//Alice and Bob each created one problem for HackerRank. A reviewer rates the two challenges, awarding points on a scale from 1 to 100 for three categories: problem clarity, originality, and difficulty.

//The rating for Alice's challenge is the triplet a = (a[0], a[1], a[2]), and the rating for Bob's challenge is the triplet b = (b[0], b[1], b[2]).

//The task is to find their comparison points by comparing a[0] with b[0], a[1] with b[1], and a[2] with b[2].

//If a[i] > b[i], then Alice is awarded 1 point.
//If a[i] < b[i], then Bob is awarded 1 point.
//If a[i] = b[i], then neither person receives a point.
//Comparison points is the total points a person earned.

//Given a and b, determine their respective comparison points.

//Example

//a = [1, 2, 3]
//b = [3, 2, 1]
//For elements *0*, Bob is awarded a point because a[0].
//For the equal elements a[1] and b[1], no points are earned.
//Finally, for elements 2, a[2] > b[2] so Alice receives a point.
//The return array is [1, 1] with Alice's score first and Bob's second.

//Function Description

//Complete the function compareTriplets in the editor below.

//compareTriplets has the following parameter(s):

//int a[3]: Alice's challenge rating
//int b[3]: Bob's challenge rating
//Return

//int[2]: Alice's score is in the first position, and Bob's score is in the second.
//Input Format

//The first line contains 3 space-separated integers, a[0], a[1], and a[2], the respective values in triplet a.
//The second line contains 3 space-separated integers, b[0], b[1], and b[2], the respective values in triplet b.



//public static List<int> compareTriplets(List<int> a, List<int> b)
//{
//    // Initialize variables to store Alice's and Bob's scores
//    int aliceScore = 0;
//    int bobScore = 0;

//    // Iterate through the elements of lists 'a' and 'b'
//    for (int i = 0; i < 3; i++)
//    {
//        // Compare the ith element of list 'a' with the ith element of list 'b'
//        // Increment Alice's score if her element is greater than Bob's
//        // Increment Bob's score if his element is greater than Alice's
//        if (a[i] > b[i])
//        {
//            aliceScore++;
//        }
//        else if (a[i] < b[i])
//        {
//            bobScore++;
//        }
//    }

//    // Create a list to store Alice's score followed by Bob's score
//    List<int> scores = new List<int>();
//    scores.Add(aliceScore);
//    scores.Add(bobScore);

//    // Return the list containing the scores
//    return scores;
//}

//}