using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentClass
{
    internal class Program
    {

        static Dictionary<string,List<string>> courses = new Dictionary<string,List<string>>();
        static void Main(string[] args)
        {
            courses.Add("math", new List<string> { });
            courses.Add("science", new List<string> { });
            courses.Add("english", new List<string> { });

            //enroll students to courses

            courses["math"].Add("Peter");
            courses["science"].Add("Peter");
            courses["english"].Add("Peter");

            courses["math"].Add("Mary");
            courses["science"].Add("Mary");

            courses["science"].Add("John");
            courses["english"].Add("John");

            //display students in courses

            foreach(string key in courses.Keys)
            {
                Console.WriteLine("List student of " + key);
                foreach (string value in courses[key])
                {
                    Console.WriteLine(value);
                }
            }

            courses["math"].Remove("Peter");
            Console.WriteLine("\n\nRemove peter from math");

            //display students in courses

            foreach (string key in courses.Keys)
            {
                Console.WriteLine("List student of " + key);
                foreach (string value in courses[key])
                {
                    Console.WriteLine(" * "+value);
                }
            }

            Console.ReadLine();

        }


    }
}
