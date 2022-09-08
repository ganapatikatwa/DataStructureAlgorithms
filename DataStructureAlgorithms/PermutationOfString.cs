using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithms
{
    public class PermutationOfString
    {
        HashSet<String> set =new HashSet<String>();
        public void permutation()
        {

            Console.WriteLine("Enter a string: ");
            string str= Console.ReadLine();
            string result = "";
            permute(str, result);
            Console.WriteLine("/nPermutation of String {0} are: \n", str);
            foreach(var s in set)
            {
                Console.WriteLine(s);   
            }

        }

        void permute (string str, string result)
        {
            if (str.Length==0)
            {
                set.Add(result);
                return;
            }
            for (int i=0; i<str.Length; i++)
            {
                char ch= str[i];
                String left_substr=str.Substring(0, i);
                String right_substr=str.Substring(i+1);
                String rest = left_substr+right_substr;
                permute(rest, result + ch);
            }
        }
    }
}
