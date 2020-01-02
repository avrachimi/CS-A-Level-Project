using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoComputingProject
{
    public partial class InputBox : Form
    {
        public string input = "";
        public bool shouldClose = false;
        public InputBox(string title = "InputBox")
        {
            InitializeComponent();
            this.Text = title;
        }

        private void InputBox_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                shouldClose = true;
                input = txtInput.Text;
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            shouldClose = true;
            this.Hide();
        }

        private void InputBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            shouldClose = true;
        }

      
    }
}
