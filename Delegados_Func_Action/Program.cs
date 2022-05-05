using System;

namespace Delegados_Func_Action
{
    internal class Program
    {
        public delegate int Suma(int x, int y);
        static void Main(string[] args)
        {
            //Ejemplo de cómo utilizar delegado
            Suma suma = new Suma(SumaMeth);
            Console.WriteLine($"Delegado:{suma(4, 5)}");

            //Ejemplo de como utilizar Func
            Func<int,int,int> func = new Func<int,int,int>(SumaMeth);
            Console.WriteLine($"Func:{func(4,0)}");

            //Ejemplo de Action
            Action<int, int>  action = new Action<int, int>(SumaMethNoReturn);
            action(1, 1);

            Console.WriteLine("###########################################");

            ///////////////////////////////////////////////////////////////////

            //Ejemplo de cómo utilizar delegado con expresión lambda
            Suma sumalam = (x,y) => x+y;
            Console.WriteLine($"Delegado Lambda:{sumalam(3,3)}");

            //Ejemplo de como utilizar Func con expresión lambda
            Func<int, int, int> funclam = (x,y) => x+y;
            Console.WriteLine($"Func Lambda:{funclam(4, 20)}");

            //Ejemplo de Action con expresión lambda
            Action<int, int> actionlam = (x, y) => { Console.WriteLine($"Action Lambda:{x + y}"); };
            actionlam(1, 10);


            Console.ReadKey();
        }

        public static int SumaMeth(int x,int y)
        {
            return x+y;
        }

        public static void SumaMethNoReturn(int x, int y)
        {
            Console.WriteLine($"Action:{x+y}");
        }
    }
}
