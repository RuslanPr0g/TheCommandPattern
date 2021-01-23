using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCommandPatterns.Commands;
using TheCommandPatterns.Controllers;
using TheCommandPatterns.Props;

namespace TheCommandPatterns
{
    public partial class Form1 : Form
    {
        RemoteController remote = new RemoteController();
        RemoteController remote2 = new RemoteController();
        Light light = new Light();
        LightOnCommand lightOnCommand;
        LightOffCommand lightOffCommand;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DarkGray;

            lightOnCommand = new LightOnCommand(light);
            lightOffCommand = new LightOffCommand(light);

            remote.SetCommand(lightOnCommand);
            remote2.SetCommand(lightOffCommand);

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                remote.Execute();
            else
                remote2.Execute();
        }
    }
}
