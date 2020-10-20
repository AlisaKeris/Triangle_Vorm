using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1 : Form
    {
        TextBox txtA, txtB, txtC;
        Button button1;
        public Form1()
        {
            this.Height = 500;
            this.Width = 1000;
            button1 = new Button();
            button1.Text = "Запуск";
            button1.BackColor = Color.Coral;
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            button1.Location = new Point(200, 200);
            txtA.Location = new Point(50,100);
            txtB.Location = new Point(50,125);
            txtC.Location = new Point(50,150);
            this.Controls.Add(txtA);
            this.Controls.Add(txtB);
            this.Controls.Add(txtC);
            txtA.Text = "A";
            txtB.Text = "B";
            txtC.Text = "C";
            this.Controls.Add(button1);
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "A" && txtB.Text == "B" && txtC.Text == "C")
            {
                MessageBox.Show("Стороны не заданы", " ");
            }
            else
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new Point(300, 150);
                ListView listView1 = new ListView();
                listView1.Location = new Point(200, 20);
                listView1.Height = 300;
                pictureBox1.Size = new Size(200, 200);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                double a, b, c;
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);
                Triangle triangle = new Triangle(a, b, c, Triangle.Height(a, b, c));
                listView1.Items.Add("Сторона а");
                listView1.Items.Add("Сторона b");
                listView1.Items.Add("Сторона c");
                listView1.Items.Add("Периметр");
                listView1.Items.Add("Площадь");
                listView1.Items.Add("Существует?");
                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputB());
                listView1.Items[2].SubItems.Add(triangle.outputC());
                listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
                listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
                listView1.Columns[0].Width = 50;
                listView1.Columns[1].Width = 50;
                listView1.Columns[2].Width = 50;
                listView1.Columns[3].Width = 50;
                listView1.Columns[4].Width = 50;
                if (triangle.ExistTriangle) { listView1.Items[5].SubItems.Add("Существует"); }
                else listView1.Items[5].SubItems.Add("Не существует");
                pictureBox1.Image = triangle.TypeOfTriangle();

                this.Controls.Add(pictureBox1);
                this.Controls.Add(listView1);

            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Form Form2 = new Form();
            Form2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
