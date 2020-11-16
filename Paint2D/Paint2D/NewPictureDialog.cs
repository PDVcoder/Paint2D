using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint2D
{
    public partial class NewPictureDialog : Form
    {
        WorkSpace f1;
        public int width = 720, height = 480;
        public NewPictureDialog(WorkSpace f)
        {
            InitializeComponent();
            f1 = f;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (comboBoxRes.SelectedIndex == 0)
            {
                try
                {
                    width = Convert.ToInt32(textBox1.Text);
                }
                catch (Exception)
                {
                    labelEx1.Text = "Incorrect value of width!";
                    return;
                }
                try
                {
                    height = Convert.ToInt32(textBox2.Text);
                }
                catch (Exception)
                {
                    labelEx.Text = "Incorrect value of height!";
                    return;
                }
            }
            else
            {
                switch (comboBoxRes.SelectedIndex)
                {
                    case 1:
                        width = 480;
                        height = 360;
                        break;
                    case 2:
                        width = 720;
                        height = 480;
                        break;
                    case 3:
                        width = 1024;
                        height = 720;
                        break;
                    case 4:
                        width = 1920;
                        height = 1080;
                        break;
                }
            }
            f1.newPCTR(width, height);
            Close();
        }


        public void comboBoxRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxRes.SelectedIndex)
            {
                case 0:
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    break;
                case 1:
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox1.Text = "480";
                    textBox2.Text = "360";
                    break;
                case 2:
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox1.Text = "720";
                    textBox2.Text = "480";
                    break;
                case 3:
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox1.Text = "1080";
                    textBox2.Text = "720";
                    break;
                case 4:
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox1.Text = "1920";
                    textBox2.Text = "1080";
                    break;
            }
        }
    }
}
