using System;
    class Eligibility
    {
        static void Main(string[] args)
        {
           int m, p, c, t, tmp;
            Console.WriteLine("Enter Math Marks: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Physics Marks: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Chemistry Marks: ");
            c = Convert.ToInt32(Console.ReadLine());
            t = m + p + c;
            tmp = m + p;
            if (m >= 65 && p >= 55 && c >= 50)
            {
                if (t >= 180 || tmp >= 140)
                {
                    Console.WriteLine("Student eligible for Admission with {0} marks in total and {1} in Math and Physics", t, tmp);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Student not eligible for Admission");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Student not eligible for Admission");
                Console.ReadLine();
            }
        }
    }

