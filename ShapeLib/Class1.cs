namespace ShapeLib
{
    public static class Shaper
    {
        public static double getSquareArea(double size) => getRectangleArea(new double[] { size, size });
        public static dynamic getSquareArea(string size)
        {
            int value = 0;
            string[] sizes = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            switch (size.ToLower())
            {
                case "one": value = 1; break;
                case "two": value = 2; break;
                case "three": value = 3; break;
                case "four": value = 4; break;
                case "five": value = 5; break;
                case "six": value = 6; break;
                case "seven": value = 7; break;
                case "eight": value = 8; break;
                case "nine": value = 9; break;
                case "ten": value = 10; break;
                default: value = -1; break;
            }
            if (value == -1) return "Invalid string";
            else return getSquareArea(value);
        }
        public static double getRectangleArea(double[] size) => Math.Round(size[0] * size[1], 2);
        public static double getCircleRadius(double diameter) => Math.Round(diameter / 2, 2);
        public static double getCircleDiameter(double radius) => Math.Round(radius * 2, 2);
    }
}