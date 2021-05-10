using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTrainings
{
    class Program
    {
        static void WriteT(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.Angle = 270;
            Turtle.Move(size / 3);
            Turtle.Angle = 90;
            Turtle.Move(size / 3 * 2);
        }
        static void WriteO(int size)
        {
            Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(size);
                Turtle.TurnRight();
            }
        }
        static void WriteR(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move(size / 2);
            WriteO(size / 2);
        }
       
        static void Main(string[] args)
        {
            Turtle.Speed = 9;

            // Буква "Т" начало
            Turtle.X = 200;
            Turtle.Y = 200;
            WriteT(60);

            // Буква "о" начало
            Turtle.X = 230;
            Turtle.Y = 200;
            WriteO(30);

            // Буква "р" начало
            Turtle.X = 270;
            Turtle.Y = 200;
            WriteR(30);

            // Буква "Т" маленькая, начало
            Turtle.X = 302.5;
            Turtle.Y = 200;
            WriteT(30);

            Turtle.X = 375;
            Turtle.Y = 200;




            //PRO 1 DZ
            //for (int i = 0; i < 4; i++)
            //{
            //    Turtle.Move(20);
            //    Turtle.TurnRight();
            //    Turtle.Move(20);
            //    Turtle.TurnRight();
            //    Turtle.Move(20);
            //    Turtle.TurnLeft();
            //    Turtle.Move(20);
            //    Turtle.TurnLeft();
            //}
            //ДЗ-1-4 урок
            //while (i < 4)
            //{
            //    Turtle.Move(20);
            //    Turtle.TurnRight();
            //    Turtle.Move(20);
            //    Turtle.TurnRight();
            //    Turtle.Move(20);
            //    Turtle.TurnLeft();
            //    Turtle.Move(20);
            //    Turtle.TurnLeft();
            //    i++;
            //}
            // дз-2-4 урок
            //while (i < 6)
            //{
            //    Turtle.Move(120);
            //    Turtle.Turn(60);
            //    i++;
            //}
        }
    }
}
