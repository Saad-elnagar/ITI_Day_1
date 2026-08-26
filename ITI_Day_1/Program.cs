namespace ITI_Day_1
{
    internal class Program
    {
        class Point
        {
            public int X;

        }



        static void Main(string[] args)
        {

            #region Question 1. Simple Arithmetic Operation with Double Numbers

            
            double a = 10.5;
            double b = 2.0;
            double result = a / b;

            Console.WriteLine($"Result: {result}");
            #endregion

            #region Question 2. Assigning one value type variable to another and modifying it.

            int x = 10;
            int y = x;  

            y = 20;

            Console.WriteLine($"x: {x}, y: {y}"); 
            #endregion


            #region Question 3. Assigning Reference Type Variables
            // 3. 
            Point p1 = new Point { X = 1 };
            Point p2 = new Point { X = 2 };

            p2 = p1;
            p2.X = 3;
            Console.WriteLine($"p1.X: {p1.X}, p2.X: {p2.X}");
            #endregion



            #region Question 4 - MCQ 1 
            static void RunQuestion4()
            {
                Console.WriteLine("--- [Question 4] ---");
                Console.WriteLine("Code: Console.WriteLine(13 / 2 + \" \" + 13 % 2);");

             
                Console.Write("Output: ");
                Console.WriteLine(13 / 2 + " " + 13 % 2);

            }
            #endregion

            #region Question 5 - MCQ 2 
            static void Question5()
            {
                Console.WriteLine("--- [Question 5] ---");

                int num = 1, z = 5;
                Console.Write("Output: ");
                if (!(num <= 0))
                    Console.WriteLine(++num + z++ + " " + ++z);
                else
                    Console.WriteLine(--num + z-- + " " + --z);

            }
            #endregion


            //RunQuestion4();
            //           Question5();

        }
    }
}
