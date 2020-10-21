using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Triangle
{
    class Triangle
    {
        public double a; // первая сторона
        public double b; // вторая сторона
        public double c; // третья сторона
        public double h; // высота
        public double ha;
        public Triangle(double A, double B, double C, double H) // Конструктор 
        {
            a = A;
            b = B;  // Создаем с заданными длинами сторон согласно заданию 
            c = C;
            h = H;
        }
        public Triangle() //треугольник без указания величин
        {
            a = 0;
            b = 0;
            c = 0;
            h = 0;

        }
        public Triangle(double A, double HA)
        {
            a = A; //основание
            ha = HA; //высота к основанию
        }
        public string outputA() // выводим сторону а, данный метод возвращает строковое значение
        {
            return Convert.ToString(a); // a - ссылка на внутренее поле обьекта класса
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }
        public string outputH()
        {
            return Convert.ToString(h);
        }
        public double Perimeter() //периметр
        {
            double p = 0;
            p = a + b + c; // вычисление
            return p; // возврат
        }
        public double SemPerimeter() //полупериметр
        {
            double p = 0;
            p = (a + b + c) / 2;
            return p;
        }

        public static double Height(double A, double B, double C)
        {
            double p = (A + B + C) / 2;
            double h = 2 * Math.Sqrt(p * (p - A) * (p - B) * (p - C)) / A;
            return h;
        }
        public double Surface() // аналогично периметру
        {
            double p = 0;
            p = SemPerimeter();
            double s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }
        public double Height() // аналогично периметру
        {
            double p = 0;
            p = SemPerimeter();
            double h =2* Math.Sqrt(p * (p - a) * (p - b) * (p - c)) /a;
            return h;
        }
        public double SurfaceAHA()
        {
            double s = (1 / 2) * a * h;
            return s;
        }
        public double Area() // Вычисление площади 
        {
            double S = 0;
            S = (a * h) / 2; // Формула 
            return S; // Выводим
        }
        public double GetSetA // свойство позволяющее установить либо изменить значение стороны а
        {
            get //устанавливаем
            { return a; }
            set // меняем
            { a = value; }
        }
        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC
        {
            get
            { return c; }
            set
            { c = value; }
        }
        public double GetSetH // Свойство для изменения стороны/высоты
        {
            get
            { return h; }
            set
            { h = value; }
        }
        public bool ExistTriangle // свойство позволяющее установить, существует ли треугольник с задаными сторонами
        {
            get
            {
                if ((a < b + c) && (b < a + c) && (c < a + b)) //сумма 2 сторон должна быть больше третьей
                    return true;
                else return false;
            }
        }
        public System.Drawing.Bitmap TypeOfTriangle()
        {
            if ((a == b) && (b == c) && (c == a)) // равносторонний
            {

                return Properties.Resources.giphy;
            }
            else if ((a == b) || (b == c) || (c == a)) // равнобедренный
            {
                return Properties.Resources.triangle3_jpg;
            }
            else
            {
                return Properties.Resources.giphy;
            }
        }
    }
}