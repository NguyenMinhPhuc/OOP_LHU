using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exam
{
    class Program
    {
        public struct Diem
        {
            private int x;
            private int y;
            public void nhapdiem(string diem)
            {
                Console.WriteLine("Nhap diem {0}:",diem);
                Console.Write("x:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("y:");
                y = Convert.ToInt32(Console.ReadLine());
            }
            public void xuatdiem(string diem)
            {
                Console.WriteLine("Diem:{0}=({1},{2})",diem, x, y);
            }
            public void xuatdiem1()
            {
                Console.WriteLine("(x,y)=(" + x + "," + y + ")");
            }

            public Diem Congdiem(params Diem[] param)
            {
                Diem c=new Diem();
                if (param != null)
                {
                    foreach (Diem item in param)
                    {
                        c.x += item.x;
                        c.y += item.y;
                    }
                }
               
                return c;
            }
           
            public Diem Congdiem(Diem a, Diem b)
            {
                Diem c;
                c.x = a.x + b.x;
                c.y = a.y + b.y;
                return c;
            }
            /// <summary>
            /// Phương thức trừ tọa độ 2 điểm
            /// </summary>
            /// <param name="a">điểm a(x,y)</param>
            /// <param name="b">điểm b(x,y)</param>
            /// <returns>điểm đã trừ c=a-b - c.x=a.x-b.x</returns>
            public Diem Trudiem(Diem a, Diem b)
            {
                Diem c;
                c.x = a.x - b.x;
                c.y = a.y - b.y;
                return c;
            }
        };
        static void Main(string[] args)
        {

            Diem a = new Diem();
            Diem b = new Diem();
            a.nhapdiem("a");
            b.nhapdiem("b");
            Console.WriteLine("Gia tri nhap lan 1");
            a.xuatdiem("a");
            b.xuatdiem("b");

            Diem c = new Diem();
            c = c.Congdiem(a, b);
            c.xuatdiem("C");


            Diem d = new Diem();
            List<Diem> danhdiem = new List<Diem>();
            danhdiem.Add(a);
            danhdiem.Add(b);
            danhdiem.Add(c);
        
            d=d.Congdiem(danhdiem.ToArray());
            d.xuatdiem("D");
            Console.ReadKey();
        }
    }
}
