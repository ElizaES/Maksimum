# Maximum

## A program that determines the maximum of four integers using a conditional expression

### Project creation steps:

**1. Declaration of total variables:**

   ulong a, b, c, d, max;


**2. Downloading variable values from the user:**

   Console.WriteLine("Podaj pierwszą wartość: ");
   a = Convert.ToUInt64(Console.ReadLine());
   Console.WriteLine("Podaj drugą wartość: ");
   b = Convert.ToUInt64(Console.ReadLine());
   Console.WriteLine("Podaj trzecią wartość: ");
   c = Convert.ToUInt64(Console.ReadLine());
   Console.WriteLine("Podaj czwartą wartość: ");
   d = Convert.ToUInt64(Console.ReadLine());
   
**3. Set the maximum value from the numbers a and b:**
   
   max = Math.Max(Math.Max(a, b), Math.Max(c, d));
      
**4. Negative maximal value, and then stop program operation:**
   
   Console.WriteLine("Wartość maksymalna wynosi {0}.", max);
   Console.ReadKey();
