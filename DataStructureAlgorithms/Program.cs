using System;

namespace DataStructureAlgorithms
{
    class Program
    {
        static void Main(String[] args)
        {

            string flag = "Y";
            while(flag== "Y"||flag=="y")
            {
                Console.WriteLine("Welcome to Data Structure and Algorithms");
                Console.WriteLine("1. permutation using Recursion\n2.Binary Search");
                int num = Convert.ToInt32(Console.ReadLine());
                switch(num)
                {
                    case 1:
                        PermutationOfString permutationofstring= new PermutationOfString();
                        permutationofstring.permutation();
                        break;

                    case 2:
                        BinarySearchProblem binarydearchproblem= new BinarySearchProblem();
                        binarydearchproblem.BinarySearch();
                        break;


                    default:
                        Console.WriteLine("-----Enter the valid option----");
                        break;
                }
                Console.WriteLine("\nDo you want to continue");
                flag= Console.ReadLine();
            }
            Console.ReadKey();
        }
    }




}