using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingnment_Classes_Object

{

    internal class Q8
    {
        public void data()
        {
            string name;
           
            double eng, math, sci, obt_marks, total_marks = 300, per;
            Console.WriteLine("Enter Student Name: ");
            name = Console.ReadLine();
            
            Console.WriteLine("Enter Marks of English: ");

            eng = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Marks of Math: ");
            math = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Student Science: ");
            sci = Convert.ToDouble(Console.ReadLine());
            obt_marks = eng + math + sci;
            per = (obt_marks / total_marks) * 100;
            Console.WriteLine("------------------------------------------\n\n");
            Console.WriteLine("Name of Student is: {0}", name);
            Console.WriteLine("Obtained Marks : {0}", obt_marks);
            Console.WriteLine("Percentage : {0}", per);
        }
    }
    class programe
    {
        public static void Main()
        {
            Q8 i = new Q8();
            i.data();
            Console.ReadKey();

        }
    }
}


