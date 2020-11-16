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
    public partial class SaveDialog : Form
    {
        WorkSpace f1;
        public SaveDialog(WorkSpace f)
        {
            InitializeComponent();
            f1 = f;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            f1.savePictures();
            Close();
        }
    }
}
