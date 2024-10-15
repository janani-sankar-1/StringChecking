using System;
using System.Collections.Generic;

namespace StringChecking
{
     class Program
    {
        static void Main(string[] args)
        {
            string str = "Universe";
            string str2 = "Universe";

            bool eq=str.Equals(str2);
            bool eq2 = str == str2;

            Console.WriteLine("Equals:" + eq);
            Console.WriteLine("==:" + eq2);

            bool sw = str.StartsWith("U");
            Console.WriteLine("StartsWith:" + sw);
            bool sw2 = str.StartsWith("e");
            Console.WriteLine("StartsWith:" + sw2);

            bool ew = str.EndsWith("e");
            Console.WriteLine("EndsWith:" + ew);

            bool c = str.Contains("e");
            Console.WriteLine("Contains:" + c);

            string name = "developer";
            int ind = name.IndexOf("e");
            Console.WriteLine("Index : " + ind);
            int ind2 = name.IndexOf("e",2);
            Console.WriteLine("Index : " + ind2);
            int ind3 = name.IndexOf("vel");
            Console.WriteLine("Index : " + ind3);

            int lind = name.LastIndexOf("e");
            Console.WriteLine("Last Index : " + lind);
            int lind2 = name.LastIndexOf("e", 2);
            Console.WriteLine("Last Index : " + lind2);
            int lind3 = name.LastIndexOf("vel");
            Console.WriteLine("Last Index : " + lind3);

            string u1 = null;
            string u2 = "";
            string u3 = " ";
            bool n1=string.IsNullOrEmpty(u1);
            bool n2=string.IsNullOrEmpty(u2);
            bool n3=string.IsNullOrEmpty(u3);
            Console.WriteLine("IsNullOrEmpty-null:" + n1);
            Console.WriteLine("IsNullOrEmpty-\"\":" + n2);
            Console.WriteLine("IsNullOrEmpty-\" \":" + n3);

            bool nn1 = string.IsNullOrWhiteSpace(u1);
            bool nn2 = string.IsNullOrWhiteSpace(u2);
            bool nn3 = string.IsNullOrWhiteSpace(u3);
            Console.WriteLine("IsNullOrWhiteSpace-null:" + nn1);
            Console.WriteLine("IsNullOrWhiteSpace-\"\":" + nn2);
            Console.WriteLine("IsNullOrWhiteSpace-\" \":" + nn3);




            Console.ReadKey();
        }
    }
}
