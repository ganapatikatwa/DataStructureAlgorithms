using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithms
{
    public class BinarySearchProblem
    {
        public void BinarySearch()
        {
            string file = @"E:\.NET\16 and 17 Data Structure and Algorithms\DataStructureAlgorithms\DataStructureAlgorithms\word.txt";
            string str=File.ReadAllText(file);

            String[] strArray = str.Split(',');

            BubbleSort(strArray);


            for(int i=0; i<strArray.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i+1, strArray[i]);
            }

            Console.WriteLine("\n\n Enter Teaxt to be Searched: ");
            string word = Console.ReadLine();

            int left = 0;
            int right = strArray.Length - 1;

            int result = BinarySearch(strArray, left, right, word);
            Console.WriteLine((result==-1)?"\nElement Not Found":"\nElement Found at position "+(result+1));

        }
        public static int BinarySearch(String[] strArray, int left, int right, string word)
        {
            if (right>=left)
            {
                int mid = left + (right - left) / 2;
                if (strArray[mid]==word)
                {
                    return mid;
                }
                else if(word.CompareTo(strArray[mid]) < 0)
                {
                    return BinarySearch(strArray, left, mid-1, word);
                }
                else
                {
                    return BinarySearch(strArray, mid+1,right, word);
                }
            }

            return -1;
        }
        void BubbleSort(String[] arr)
        {
            for(int i = 0; i < arr.Length-1; i++)
            {
                for (int j=0; j<arr.Length-i-1; j++)
                {
                    if (arr[j].CompareTo(arr[j+1])>0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }
                }
            }
        }
    }
}
