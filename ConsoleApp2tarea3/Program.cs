using static System.Console;

namespace Using
{
    class Program
    {
        public static void Main()
        {
         float CAN, CA200, CA100, CA50, CA20, CA10, CA5, CA1, CA050, CA025, CA010, CA05, CA01, mon;
            CAN = mon =CA200 = CA100 = CA50 = CA20 = CA10 = CA5 = CA1 = CA050 = CA025 = CA010 = CA05 = CA01 = 0;

            double cambio;
              
            Console.WriteLine("\ngrese cantidad en dólares:\n");
            mon = float.Parse(Console.ReadLine());
            cambio = 7.71f;            
            CAN = (mon * 7.71f);
            Console.WriteLine("$El tipo de cambio a moneda de Guatemala está a:\n" + cambio + "\n El monto total en Quetzales es de:" + CAN);
            

            if ((CAN >= 200))
            {
                CA200 = (int)(CAN / 200);
                CAN = CAN - (CA200 * 200);

            }

            if ((CAN >= 100))
            {
                CA100 = (int)(CAN / 100);
                CAN = CAN - (CA100 * 100);

            }

            if ((CAN >= 50))
            {
                CA50 = (int)(CAN / 50);
                CAN = CAN - (CA50 * 50);

            }

            if ((CAN >= 20))
            {
                CA20 = (int)(CAN / 20);
                CAN = CAN - (CA20 * 20);

            }

            if ((CAN >= 10))
            {
                CA10 = (int)(CAN / 10);
                CAN = CAN - (CA10 * 10);

            }

            if ((CAN >= 5))
            {
                CA5 = (int)(CAN / 5);
                CAN = CAN - (CA5 * 5);

            }

            if ((CAN >= 1))
            {
                CA1 = (int)(CAN / 1);
                CAN = CAN - (CA1 * 1);

            }

            if (CAN >= 0.50)
            {
                CA050 = (int) ((CAN / 0.50f));
                CAN = (CAN - (CA050 * 0.50f));

            }

            if ((CAN >= 0.25))
            {
                CA025 = ((int)(CAN / 0.25));
                CAN = (CAN - (CA025 * 0.25f));

            }

            if ((CAN >= 0.10))
            {
                CA010 = ((int)(CAN / 0.10));
                CAN = (CAN - (CA010 * 0.10f));

            }

            if ((CAN >= 0.05))
            {
                CA05 = ((int)(CAN / 0.05));
                CAN = ((CAN - (CA05 * 0.05f)));

            }

            if ((CAN >= 0.01))
            {
                CA01 = ((int)(CAN / 0.01));
                CAN = ((CAN - (CA01 * 0.01f)));


            }

            Console.WriteLine($"Billetes de 200:{CA200}");
            Console.WriteLine($"Billetes de 100:{CA100}");
            Console.WriteLine($"Billetes de 50:{CA50}");
            Console.WriteLine($"Billetes de 20:{CA20}");
            Console.WriteLine($"Billetes de 10:{CA10}");
            Console.WriteLine($"Billetes de 5:{CA5}");
            Console.WriteLine($"Billetes de 1:{CA1}");
            Console.WriteLine($"Monedas de 50 centavos:{CA050}");
            Console.WriteLine($"Monedas de 25 centavos:{CA025}");
            Console.WriteLine($"Monedas de 10 centavos:{CA010}");
            Console.WriteLine($"Monedas de 5 centavos:{CA05}");
            Console.WriteLine($"Monedas de 1 centavo:{CA01}");
            Main();

        }
    }
}
