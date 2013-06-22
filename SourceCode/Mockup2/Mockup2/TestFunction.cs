using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockup2
{
    public partial class TestFunction : Form
    {
        public TestFunction()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            List<Conditions.Precondtion_sets> precon = Conditions.Precondtion_sets.getPrecondtion_setsByTaskID("2031343073");
            MessageBox.Show(precon[0].id);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
