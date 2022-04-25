using ShapeLib;

class Program
{
    static double[] sizeGetter(string type)
    {
        double rw;
        double rh;
        bool invalid = true;
        do
        {
            Console.Write($"Please enter the width of the {type}. ");
            invalid = !double.TryParse(Console.ReadLine(), out rw);
        } while (invalid);
        do
        {
            Console.Write($"Please enter the length of the {type}. ");
            invalid = !double.TryParse(Console.ReadLine(), out rh);
        } while (invalid);
        return new double[] { rw, rh };
    }
    static void Main(string[] args)
    {
        string? input = "exit";
        do
        {
            string[] instructions = { "square", "rectangle", "triangle", "parallelogram", "radius", "diameter", "exit" };
            Console.WriteLine("Type the name of the function you want to use.");
            foreach (string instruction in instructions) Console.WriteLine(instruction);
            input = Console.ReadLine();
            Console.WriteLine();
            switch (input)
            {
                case "square":
                    double s;
                    Console.WriteLine("Please enter the length of the sides of the square. ");
                    string? s2 = Console.ReadLine();
                    if (double.TryParse(s2, out s)) Console.WriteLine(Shaper.getSquareArea(s));
                    else Console.WriteLine(Shaper.getSquareArea(s2));
                    break;
                case "rectangle":
                    Console.WriteLine(Shaper.getRectangleArea(sizeGetter("rectangle")));
                    break;
                case "triangle":
                    Console.WriteLine(Shaper.getRectangleArea(sizeGetter("triangle")) / 2);
                    break;
                case "parallelogram":
                    Console.WriteLine(Shaper.getRectangleArea(sizeGetter("parallelogram")));
                    break;
                case "radius":
                    double d;
                    Console.WriteLine("Please enter the diameter of the circle. ");
                    double.TryParse(Console.ReadLine(), out d);
                    Console.WriteLine(Shaper.getCircleRadius(d));
                    break;
                case "diameter":
                    double r;
                    Console.WriteLine("Please enter the radius of the circle. ");
                    double.TryParse(Console.ReadLine(), out r);
                    Console.WriteLine(Shaper.getCircleDiameter(r));
                    break;
            }
            Console.WriteLine();
        } while (input != "exit");
        return;
    }
}
