using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha15._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальное значение для создания прогрессий: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Проверка работы класса ArithProgression
            ArithProgression arith = new ArithProgression();
            arith.setStart(x);
            Console.Write("Первые пять членов арифметической прогрессии (кроме начального значения): ");
            for (int i = 0; i < 5; i++)
            {
                int arithX = arith.getNext();
                Console.Write("{0} ",arithX);
            }
            Console.WriteLine();
            arith.reset();
            Console.WriteLine("Начальное значение: {0}", arith.X); //Проверка работы метода reset.
            Console.WriteLine();

            //Проверка работы класса GeomProgression
            GeomProgression geom = new GeomProgression();
            geom.setStart(x);
            Console.Write("Первые пять членов геометрической прогрессии (кроме начального значения): ");
            for (int i = 0; i < 5; i++)
            {
                int geomX = geom.getNext();
                Console.Write("{0} ",geomX);
            }
            Console.WriteLine();
            geom.reset();
            Console.WriteLine("Начальное значение: {0}", geom.X); //Проверка работы метода reset.
            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        public int X { get; set; }
        int origin;
        readonly int step = 10;
        public void setStart(int x)
        {
            X = x;
            origin = x;
        }

        public int getNext()
        {
            X += step;
            return X;
        }

        public void reset()
        {
            X = origin;
        }
    }
    class GeomProgression : ISeries
    {
        public int X { get; set; }
        int origin;
        readonly int step = 10;
        public void setStart(int x)
        {
            X = x;
            origin = x;
        }

        public int getNext()
        {
            X *= step;
            return X;
        }

        public void reset()
        {
            X = origin;
        } 
    }
}
