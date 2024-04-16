using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form3 : Form
    {
        Random random = new Random();
        Bitmap drawingBitmap;

        public Form3()
        {
            InitializeComponent();
            drawingBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {

        }

        private void ColorButton_Click(object sender, EventArgs e)
        {

        }

        private void ColorButton_Click_1(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ColorButton.BackColor = colorDialog.Color;
            }
        }

        private void DrawButton_Click_1(object sender, EventArgs e)
        {
            if (TypeComboBox.SelectedItem != null)
            {
                int numberOfFigures;
                if (!int.TryParse(AmountTextBox.Text, out numberOfFigures) || numberOfFigures <= 0)
                {
                    MessageBox.Show("Enter the right amount of figures!");
                    return;
                }

                using (Graphics graphics = Graphics.FromImage(drawingBitmap))
                {
                    graphics.Clear(Color.White);

                    int size = (int)SizeNumericUpDown.Value;
                    Color color = colorDialog.Color;

                    for (int i = 0; i < numberOfFigures; i++)
                    {
                        int x = random.Next(pictureBox.Width - size);
                        int y = random.Next(pictureBox.Height - size);
                        Figure figure = null;

                        switch (TypeComboBox.SelectedItem.ToString())
                        {
                            case "Square":
                                figure = new Square(x, y, size, color);
                                break;
                            case "Right Triangle":
                                figure = new EquilateralTriangle(x, y, size, color);
                                break;
                            case "Circle":
                                string text = CircleTextBox.Text;
                                figure = new Circle(x, y, size, color, text);
                                break;
                        }

                        if (figure != null)
                        {
                            figure.Draw(graphics);
                        }
                    }
                }

                pictureBox.Image = drawingBitmap;
            }
            else
            {
                MessageBox.Show("Please choose the type of figure!");
            }
        }

        public abstract class Figure
        {
            protected int x, y, size;
            protected Color color;

            public Figure(int x, int y, int size, Color color)
            {
                this.x = x;
                this.y = y;
                this.size = size;
                this.color = color;
            }

            public abstract void Draw(Graphics graphics);
        }

        public class Square : Figure
        {
            public Square(int x, int y, int size, Color color) : base(x, y, size, color)
            {
            }

            public override void Draw(Graphics graphics)
            {
                graphics.FillRectangle(new SolidBrush(color), x, y, size, size);
            }
        }

        public class EquilateralTriangle : Figure
        {
            public EquilateralTriangle(int x, int y, int size, Color color) : base(x, y, size, color)
            {
            }

            public override void Draw(Graphics graphics)
            {
                Point[] points = {
                new Point(x, y + size),
                new Point(x + size / 2, y),
                new Point(x + size, y + size)
            };
                graphics.FillPolygon(new SolidBrush(color), points);
            }
        }

        public class Circle : Figure
        {
            private string text;
            public Circle(int x, int y, int size, Color color, string text) : base(x, y, size, color)
            {
                this.text = text;
            }

            public override void Draw(Graphics graphics)
            {
                graphics.FillEllipse(new SolidBrush(color), x, y, size, size);
                graphics.DrawString(text, new Font("Arial", 10), Brushes.Black, x + size / 4, y + size / 4);
            }
        }

    }
}
