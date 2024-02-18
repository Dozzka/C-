namespace ClassKvadr;

internal class Program
{

    class Kvadr
    {
        double a;
        double b;
        double c;


        public string Type_eq() { return a != 0 ? "Quadratic" : b != 0 ? "Linear" : "None"; }
        public double Disk()
        {
            return a != 0 ? Math.Sqrt(Math.Pow(b, 2) - 4 * a * c) : double.NaN;
        }

        public string Solution()
        {
            if (a != 0)
            {
                if (Disk() > 0)
                {

                    double x1 = (-b + Disk()) / (2 * a);
                    double x2 = (-b - Disk()) / (2 * a);
                    return Convert.ToString(x1) + '\t' + Convert.ToString(x2);
                }
                else if (Disk() == 0)
                {
                    return Convert.ToString(-b / (2 * a));
                }
                else { return Convert.ToString(double.NaN); }
            }
            else { return Convert.ToString(b == 0 ? double.NaN : -c / b); }
        }




            public Kvadr(double num_a, double num_b, double num_c)
            {
                a = num_a;
                b = num_b;
                c = num_c;
            }
        }


  

    static void Main(string[] args)
    {
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        Kvadr kvadr = new Kvadr(a, b, c);

        Console.WriteLine("Type of equation: " + kvadr.Type_eq());
        Console.Write((double.IsNaN(kvadr.Disk()) ? "" : "Disk = " + kvadr.Disk()) + '\n');
        string[] words = kvadr.Solution().Split('\t');
        Console.WriteLine(words[0] != Convert.ToString(double.NaN)? words.Length == 2 ? "X1 = " + words[0] + '\n' + "X2 = " + words[1] : "X = " + words[0] : "No solutions");


    }
}