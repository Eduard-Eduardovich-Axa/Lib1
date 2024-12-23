using Lib1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib1;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CustomTextBox textBox1 = new CustomTextBox();
            textBox1.Location = new Point(10, 10);
            textBox1.Text = "вводи сюда";
            this.Controls.Add(textBox1);

            CustomButton button1 = new CustomButton();
            button1.Location = new Point(10, 50);
            button1.Text = "сюда тыкай";
            button1.BackColor = Color.FromArgb(175, 238, 238);

            CustomTextBox textBox2 = new CustomTextBox();
            textBox2.Location = new Point(10, 90);
            textBox2.Text = "сюда не вводи";
            textBox2.Width = 150;
            textBox2.ReadOnly = true;
            this.Controls.Add(textBox2);

            this.Controls.Add(button1);
            CustomLabel Label1 = new CustomLabel();
            Label1.Location = new Point(10, 90);
           // Label1.Text = "меняйзначение";
            this.Controls.Add(Label1);

            CustomListBox ListBox1 = new CustomListBox();
            ListBox1.Location = new Point(10, 130);
            //ListBox1.Items.Add(123);
            this.Controls.Add(ListBox1);

           /* textBox1.TextChanged += (sender, e) =>
            {
                button1.Text = textBox1.Text;
            };*/

            button1.Click += (sender, e) =>
            {
                ListBox1.Items.Add(textBox1.Text);
            };



            // Аналогично добавляем другие элементы
        }
    }
}
