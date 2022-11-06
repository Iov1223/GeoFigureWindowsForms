using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GeoFigureWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonShowResult_MouseClick(object sender, MouseEventArgs e)
        {
            switch (comboBoxNameFigure.Text)
            {
                case ("Прямоугольник"):
                    {
                        Rectangle rectangle = new Rectangle(textBoxBaseOrLengthOrRadius.Text,
                            textBoxHeightOrSide1.Text);
                        string resSquare = Convert.ToString(rectangle.Square());
                        string resPerimeter = Convert.ToString(rectangle.Perimeter());
                        if (rectangle.Square() != 0 & rectangle.Perimeter() != 0)
                        {
                            labelSquare.Text = $"Площадь прямоугольника = {resSquare}";
                            labelPerimeter.Text = $"Периметр прямоугольника = {resPerimeter}";
                        }
                        else
                        {
                            labelSquare.Text = "Площадь:";
                            labelPerimeter.Text = "Периметр:";
                        }
                    }
                    break;
                case ("Треугольник"):
                    {
                        Triangle triangle = new Triangle(textBoxBaseOrLengthOrRadius.Text,
                            textBoxHeightOrSide1.Text, textBoxSide2.Text);
                        string resSquare = Convert.ToString(triangle.Square());
                        string resPerimeter = Convert.ToString(triangle.Perimeter());
                        if (triangle.Square() != 0 & triangle.Perimeter() != 0)
                        {
                            labelSquare.Text = $"Площадь треугольника = {resSquare}";
                            labelPerimeter.Text = $"Периметр треугольника = {resPerimeter}";
                        }
                        else
                        {
                            labelSquare.Text = "Площадь:";
                            labelPerimeter.Text = "Периметр:";
                        }
                    }
                    break;
                case ("Круг"):
                    {
                        Сircle сircle = new Сircle(textBoxBaseOrLengthOrRadius.Text);
                        string resSquare = Convert.ToString(сircle.Square());
                        string resPerimeter = Convert.ToString(сircle.Perimeter());
                        if (сircle.Square() != 0 & сircle.Perimeter() != 0)
                        {
                            labelSquare.Text = $"Площадь окружности = {resSquare}";
                            labelPerimeter.Text = $"Периметр окружности = {resPerimeter}";
                        }
                        else
                        {
                            labelSquare.Text = "Площадь:";
                            labelPerimeter.Text = "Периметр:";
                        }
                    }
                    break;
                default:
                    {
                        MessageBox.Show("Выберите геометрическую фигуру");
                    }
                    break;
            }
        }
        private void comboBoxNameFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxNameFigure.Text)
            {
                case ("Прямоугольник"):
                    {
                        textBoxBaseOrLengthOrRadius.Enabled = true;
                        textBoxHeightOrSide1.Enabled = true;
                        textBoxSide2.Enabled = false;
                        textBoxBaseOrLengthOrRadius.Text = "";
                        textBoxHeightOrSide1.Text = "";
                        textBoxSide2.Text = "";
                        labelSquare.Text = "Площадь:";
                        labelPerimeter.Text = "Периметр:";
                        labelBaseOrLengthOrRadius.Text = "Введите длину";
                        labelHeightOrSide1.Text = "Введите высоту";
                        labelSide2.Text = "";
                    }
                    break;
                case ("Треугольник"):
                    {
                        textBoxBaseOrLengthOrRadius.Enabled = true;
                        textBoxHeightOrSide1.Enabled = true;
                        textBoxSide2.Enabled = true;
                        textBoxBaseOrLengthOrRadius.Text = "";
                        textBoxHeightOrSide1.Text = "";
                        textBoxSide2.Text = "";
                        labelSquare.Text = "Площадь:";
                        labelPerimeter.Text = "Периметр:";
                        labelBaseOrLengthOrRadius.Text = "Введите основание";
                        labelHeightOrSide1.Text = "Введите 1-ю сторону";
                        labelSide2.Text = "Введите 2-ю сторону";
                    }
                    break;
                case ("Круг"):
                    {
                        textBoxBaseOrLengthOrRadius.Enabled = true;
                        textBoxHeightOrSide1.Enabled = false;
                        textBoxSide2.Enabled = false;
                        textBoxBaseOrLengthOrRadius.Text = "";
                        textBoxHeightOrSide1.Text = "";
                        textBoxSide2.Text = "";
                        labelSquare.Text = "Площадь:";
                        labelPerimeter.Text = "Периметр:";
                        labelBaseOrLengthOrRadius.Text = "Введите радиус";
                        labelHeightOrSide1.Text = "";
                        labelSide2.Text = "";
                    }
                    break;
            }
        }
    }
}
