using System;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace laba2s2
{
    class Program
    {
        static void Main(string[] args)
        {
            Text("x of vertex 1");
            double ver1x = double.Parse(Console.ReadLine());
            Text("y of vertex 1");
            double ver1y = double.Parse(Console.ReadLine());
            Text("x of vertex 2");
            double ver2x = double.Parse(Console.ReadLine());
            Text("y of vertex 2");
            double ver2y = double.Parse(Console.ReadLine());
            Text("x of vertex 3");
            double ver3x = double.Parse(Console.ReadLine());
            Text("y of vertex 3");
            double ver3y = double.Parse(Console.ReadLine());
            Console.Clear();
            Triangle triangle = new(ver1x, ver1y, ver2x, ver2y, ver3x, ver3y);
            WriteStats(triangle);
            OpenJsonFile();
            CreateJsonFile(triangle);
        }

        static void Text(string name)
        {
            Console.WriteLine($"Enter the {name}:");          
        }
            
        static void CreateJsonFile(Triangle triangle)
        {
            using FileStream fs = new("triangle.json", FileMode.OpenOrCreate);
            string jsonObject = JsonConvert.SerializeObject(triangle);
            byte[] bytes = Encoding.Default.GetBytes(jsonObject);
            fs.Write(bytes);
        }
        static void OpenJsonFile()
        {
            using FileStream fs = File.OpenRead("triangle.json");
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, bytes.Length);
            string jsonObject = Encoding.Default.GetString(bytes);
            Triangle newTriangle = JsonConvert.DeserializeObject<Triangle>(jsonObject);
            Console.WriteLine("\nTriangle from Json file");
            WriteStats(newTriangle);
        }
        static void WriteStats(Triangle triangle)
        {
            Console.WriteLine($"Vertex 1 ({triangle.Vertex1X}; {triangle.Vertex1Y})");
            Console.WriteLine($"Vertex 2 ({triangle.Vertex2X}; {triangle.Vertex2Y})");
            Console.WriteLine($"Vertex 3 ({triangle.Vertex3X}; {triangle.Vertex3Y})");
            Console.WriteLine("The type of this triangle: " + triangle.Type());
            if (triangle.Type() != "It's not a triangle.")
            {
                Console.WriteLine("Side 1: " + Math.Round(triangle.Side1(), 1));
                Console.WriteLine("Side 2: " + Math.Round(triangle.Side2(), 1));
                Console.WriteLine("Side 3: " + Math.Round(triangle.Side3(), 1));
                Console.WriteLine("Perimeter: " + Math.Round(triangle.Perimeter(), 1));
                Console.WriteLine("Square: " + Math.Round(triangle.Square(), 1));
                Console.WriteLine($"Cross of medians ({Math.Round(triangle.MedianX(), 1)}; {Math.Round(triangle.MedianY(), 1)})");
            }
        }


        
    }
}
