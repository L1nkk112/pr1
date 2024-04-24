using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            CitySize city = new CitySize();
            if (string.IsNullOrEmpty(textBox3.Text))
                errorProvider.SetError(textBox3, "Поле не должно быть пустым");
            if (int.TryParse(textBox3.Text, out int population))
            {
                if (population < 0 || population == 0)
                    errorProvider.SetError(textBox3, "Введите положительное число больше нуля");
                else
                {
                    city.citySize(population);
                    string citySize = city.CityPopulation(population);
                    textBox2.Text = $"{citySize}";
                }
            }
            else
            {
                errorProvider.SetError(textBox3, "Введите целое число");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender,e);
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox3, "Введите число!");
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show(); 
        }
    }
}
