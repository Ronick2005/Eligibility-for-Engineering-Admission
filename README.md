# Eligibility-for-Engineering-Admission
## Aim:
To write a C# program to check whether the student is eligibile for the engineering admission

## Algorithm:
### Step1: 
Get the maths, chemistry and physics marks from the user using ReadLine().

### Step2: 
Calculate the sum of all three subjects and check whether the sum is greater than and equal to 180

### Step3:
Calculate the sum of physics and maths and check the condition

### Step4:
Print the result accordingly

## Program:
```cs
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


```
## Output:
![](exp1.png)
## Result:
Thus the above C# program to check the eligibility of engineering admission is successfully executed

