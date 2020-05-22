using System;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Intrinsics.X86;

namespace TEXT5one
{
    public  abstract class Area
    {
        public abstract void GetArea();
        
    }
    public  sealed class Circle : Area
    {    double R;
        
        public Double GetR()
        {
            Console.WriteLine("请输入圆的半径：");
            return Double.Parse(Console.ReadLine());
        }
        public override void GetArea()
        {
            R = GetR();
            Console.WriteLine("圆的面积：" + Math.PI * R * R);          
        }
    }
    public class Rectangle : Area
    {
        double length;
        double width;
        public Double GetLength()
        {
            Console.WriteLine("请输入矩形的长：");
            return Double.Parse(Console.ReadLine());
        }
        public Double GetWidth()
        {
            Console.WriteLine("请输入矩形的宽：");
            return Double.Parse(Console.ReadLine());

        }
        public sealed override void GetArea()

        {
            length = GetLength();
            width = GetWidth();
            Console.WriteLine("矩形的面积：" + length * width);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.GetArea();
            Rectangle r = new Rectangle();
            r.GetArea();


        }
    }
}
