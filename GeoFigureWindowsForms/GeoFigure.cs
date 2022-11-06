using System;
using System.Windows.Forms;


namespace GeoFigureWindowsForms
{
    public abstract class GeoFigure
    {
        private decimal Value001;

        public decimal value001
        {
            get { return Value001; }
            set { Value001 = value; }
        }
        private decimal Value002;

        public decimal value002
        {
            get { return Value002; }
            set { Value002 = value; }
        }
        public abstract decimal Square();
        public abstract decimal Perimeter();
    }
    public class Rectangle : GeoFigure
    {
        public Rectangle(string _length, string _height)
        {
            CheckingParameters CP = new CheckingParameters();
            try
            {
                CP.CheckParameters(_length);
                value001 = CP.ReturnValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message} Неверно введена длина!");
            }
            try
            {
                CP.CheckParameters(_height);
                value002 = CP.ReturnValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message} Неверно введена высота!");
            }
        }
        public override decimal Square()
        {
            decimal _square = this.value001 * this.value002;
            return _square;
        }
        public override decimal Perimeter()
        {
            decimal _perimeter = this.value001 + this.value001 + this.value002 + this.value002;
            return _perimeter;
        }
    }
    public class Triangle : GeoFigure
    {

        public Triangle(string _base, string _side1, string _side2)
        {
            CheckingParameters CP = new CheckingParameters();
            try
            {
                CP.CheckParameters(_base);
                AB = CP.ReturnValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message} Неверно введено основание!");
            }
            try
            {
                CP.CheckParameters(_side1);
                value001 = CP.ReturnValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message} Неверно введена сторона 1!");
            }
            try
            {
                CP.CheckParameters(_side2);
                value002 = CP.ReturnValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message} Неверно введена сторона 2!");
            }
            try
            {
                CP.CheckTriangle(AB, value001, value002);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        private decimal AB; // основание
        public decimal ab
        {
            get { return AB; }
            set { AB = value; }
        }
        public override decimal Perimeter()
        {
            decimal _perimeter = this.AB + this.value002 + this.value001;
            return _perimeter;
        }
        public override decimal Square()
        {
            decimal IfIsCorrect = 0;
            double _semiPerimeter = ((double)AB + (double)value002 + (double)value001) / 2;
            double _toСheckСorrectness = Math.Sqrt((double)(_semiPerimeter * (_semiPerimeter - (double)AB) * (_semiPerimeter - (double)value001) * (_semiPerimeter - (double)value002)));
            if (_toСheckСorrectness > 0)
            {
                IfIsCorrect = Convert.ToDecimal(_toСheckСorrectness);
            }
            return IfIsCorrect;
        }
    }
    public class Сircle : GeoFigure
    {
        public Сircle(string _radius)
        {
            CheckingParameters CP = new CheckingParameters();
            try
            {
                CP.CheckParameters(_radius);
                value001 = CP.ReturnValue();
                value002 = 3.14159m;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message} Неверно введён радиус!");

            }
        }
        public override decimal Perimeter()
        {
            decimal _perimeter = 2 * this.value001 * this.value002;
            return _perimeter;
        }
        public override decimal Square()
        {
            decimal _squere = this.value002 * (this.value001 * this.value001);
            return _squere;
        }
    }
}
