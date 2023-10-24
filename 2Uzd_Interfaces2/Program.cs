namespace _2Uzd_Interfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle()
            {
                Base = 5,
                Heigth = 7,
            };
            Quadrilateral quadrilateral = new Quadrilateral()

            {
                Side = 5,
            };

            Pentagon pentagon = new Pentagon()

            {
                Base = 4,
                Heigth = 6,
            };

            List<IPolygon> polygons = new List<IPolygon>()
            {
              triangle, quadrilateral, pentagon
            };

            polygons.Sort();

            foreach (IPolygon polygon in polygons)
            {
                Console.WriteLine($"Figuros plotas: {polygon.GetArea()}");
            }
        }
    }
}