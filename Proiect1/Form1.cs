using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Student> lista = new List<Student>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            byte[] note = new byte[5];
            note[0] = Convert.ToByte(comboBox2.Text);
            note[1] = Convert.ToByte(comboBox3.Text);
            note[2] = Convert.ToByte(comboBox4.Text);
            note[3] = Convert.ToByte(comboBox5.Text);
            note[4] = Convert.ToByte(comboBox6.Text);
           
            Student student = new Student(textBox1.Text, Convert.ToByte(numericUpDown1.Value), Convert.ToByte(comboBox1.Text), note);
            lista.Add(student);
            listBox1.Items.Add(student.NumeStudent + " , an " + student.AnStudiu );
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ComparaNume comp = new ComparaNume();
            lista.Sort(comp);
            foreach (Student s in lista)
                listBox1.Items.Add(s.NumeStudent + " , an " + s.AnStudiu );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ComparaMedie comp = new ComparaMedie();
            lista.Sort(comp);
            foreach (Student s in lista)
                listBox1.Items.Add(s.NumeStudent + ", an " + s.AnStudiu + ", varsta " + s.Varsta + ", med " + s.AfisMedie);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Student s in lista)
            {
                if(s.AnStudiu == Convert.ToByte(comboBox7.Text))
                    listBox1.Items.Add(s.NumeStudent + ", an " + s.AnStudiu + ", varsta " + s.Varsta );
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(Student s in lista)
            {
                if(s.NumeStudent == textBox2.Text)
                    listBox1.Items.Add(s.NumeStudent + ", an " + s.AnStudiu + ", varsta " + s.Varsta);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
