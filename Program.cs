internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("*** Chương trình giải phương trình bậc 2 ***");
        double a, b, c;
        double x1, x2, delta;
        Console.Write("\nHãy nhập vào số a : ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nHãy nhập vào số b : ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nHãy nhập vào số c : ");
        c = Convert.ToDouble(Console.ReadLine());
        if(a==0)
        {
            if (b == 0)
            {
                if(c == 0)
                {
                    Console.WriteLine("\nPhuowng trình vô số nghiệm");
                }
                else
                {
                    Console.WriteLine("\n Phương trình vô nghiệm");
                }
            }
            else
            {
                x1 = (double)-c / b;
                Console.WriteLine("\n Phuong trinh co nghiem duy nhat x = " +x1);
            } 
                

        }
        else
        {
            delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("\n Phương trình vô nghiệm");
            }
            else if (delta == 0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine("\n Phương trình có nghiệm kép là : x1 = x2 = " +x1);
            }

            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("\n Phương trình có hai nghiệm phân biệt là :x1 =" +x1, "x2 = " +x2);
            }
        }
    }
}



          