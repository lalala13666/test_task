namespace ClassLibraryTestTask
{
    public class CalculationArea
    {

        public double CalcArea(double radius) //TriangleWithRadius
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }
        public double CalcArea(double a, double b, double c) //CircleWithThreeSides
        {
            var rightAngle = false;
            var list = new List<double> { a, b, c };
            list.Sort();
            if (Math.Pow(list[0], 2) + Math.Pow(list[1], 2) == Math.Pow(list[2], 2)) // RightAngleCheck
            {
                rightAngle = true;
            }
            var p = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
        }
    }

}