using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace durak_final
{
    public partial class DurakMain : Form
    {
        private int rdd;

        public DurakMain()
        {
            InitializeComponent();
        }

        private void Cards_Load(object sender, EventArgs e)
        {

        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void ExitButtion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
