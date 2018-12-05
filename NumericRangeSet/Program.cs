using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericRangeSet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> includeList = new List<int>();
            List<int> excludeList = new List<int>();
            List<int> finalList = new List<int>();
            
            //INCLUDE Set
            Console.WriteLine("Enter Include Set numbers:");
            string includeSetNo = Console.ReadLine();

            int includeSetNoValue = int.Parse(includeSetNo);

            while (includeSetNoValue > 0)
            {
                Console.WriteLine("\n\nEnter Include Set ");
                string includeString = Console.ReadLine();

                if (!includeString.Contains('-'))
                {
                    Console.WriteLine("\nRange separator should be '-'.");
                    continue;
                }
                
                string[] includeRange = includeString.Split('-');
                
                for (int i = int.Parse(includeRange[0]); i <= int.Parse(includeRange[1]); ++i)
                {
                    includeList.Add(i);
                }

                Console.WriteLine("\nInclude Set is: ");

                foreach (var item in includeList)
                {
                    Console.Write(item + " ");
                }

                includeSetNoValue--;
            }

            //EXCLUDE set

            Console.WriteLine("\n\nEnter Exclude Set numbers:");
            string excludeSetNo = Console.ReadLine();

            int excludeSetNoValue = int.Parse(excludeSetNo);

            while (excludeSetNoValue > 0)
            {
                Console.WriteLine("\n\nEnter exclude Set ");
                string excludeString = Console.ReadLine();

                if (!excludeString.Contains('-'))
                {
                    Console.WriteLine("\nRange separator should be '-'.");
                    continue;
                }

                string[] excludeRange = excludeString.Split('-');


                for (int i = int.Parse(excludeRange[0]); i <= int.Parse(excludeRange[1]); ++i)
                {
                    excludeList.Add(i);
                }

                Console.WriteLine("\nExclude Set is: ");

                foreach (var item in excludeList)
                {
                    Console.Write(item + " ");
                }

                excludeSetNoValue--;
            }

            finalList = includeList.Except(excludeList).ToList();

            Console.WriteLine("\n\nFinal list is: ");
            Console.WriteLine("\n***************");

            foreach (var item in finalList)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
        }
    }

