using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCommandPatterns.Props;

namespace TheCommandPatterns
{
    public partial class Form1 : Form
    {
        Light light = new Light();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DarkGray;

            light.onActiveChanged += Lightning;
        }

        private void Lightning(bool state)
        {
            if (state.Equals(true))
            {
                panel1.BackColor = Color.Green;
            }
            else
            {
                panel1.BackColor = Color.DarkGray;
            }
        }
    }
}
