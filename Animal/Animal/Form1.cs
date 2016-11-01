using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Animal> zoo = new List<Animal>();
            zoo.Add(new Dog("Niko", true, false));
            zoo.Add(new Dog("Loke", true, false));
            zoo.Add(new Bird("Harry", false, true));
            foreach (var a in zoo)
            {
                listBox1.Items.Add(a);
            }
        }
    }
}
