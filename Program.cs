using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle anglerad = new  Angle( 0,  0,  0);
            anglerad.ToRadians();
            Console.ReadKey();
        }


    }
    class Angle
    {



         int gradus;
         int min;
         int sec;
       
        public int Gradus
        {
            set
            {
                if (value <= 360 || value >= -360)
                {
                      gradus=value;
                }
                else
                {
                    Console.WriteLine("Некорректное число");
                }

            }
            get
            {
                return gradus;

            }

        }
        public int Min
        {
            set
            {
                if (value <= 60 && value >= 0)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Некорректное число ");
                }

            }
            get
            {
                return min;

            }

        }
        public int Sec
        {
            set
            {
                if (value <= 60 && value >= 0)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Некорректное число");
                }

            }
            get
            {
                return sec;

            }

        }


         public Angle(int gradus, int min, int sec)

        
         {
            Console.WriteLine("Введите значения  градусы");
            try
            {
                Gradus = gradus = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Некорректный формат");
                Console.ReadKey();
            } 
            
            Console.WriteLine("Введите значения  минуты");
            try
            {
                Min = min = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Некорректный формат");
                Console.ReadKey();
            }
            Console.WriteLine("Введите значения секунды");
            try
            {
                Sec = sec = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Некорректный формат");
                Console.ReadKey();
            }
                       

         }
        

        public void ToRadians()
        {
            {
                double rad= (gradus + (double)min / 60 + (double)sec / 3600) * Math.PI / 180;
               
                 Console.WriteLine("Значение угла в радианах равно {0:f4} рад.", rad);
                

            }
            
            


              }
        }
    


    }  
