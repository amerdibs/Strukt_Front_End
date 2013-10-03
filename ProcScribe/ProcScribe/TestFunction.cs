using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace ProcScribe
{
    public partial class TestFunction : Form
    {
        public TestFunction()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Condition alternate_set = Condition.getConditionByTaskID ("2031343073");
            MessageBox.Show("Ok");

            /*List<PropertiesStrukt.Status> status = PropertiesStrukt.Status.getStatusByID("4");
            MessageBox.Show(status[0].id);
             List<PropertiesStrukt.Location> location = PropertiesStrukt.Location.getLocationAll();
             MessageBox.Show("Ok");
            List<Condition.Precondtion_set> precon = Condition.Precondtion_set.getPrecondtion_setsByTaskID("2031343073");
            MessageBox.Show(precon[0].id);*/

            //string json = JsonConvert.SerializeObject(precon, Formatting.Indented);
            //json = global.composeJSONforStrukt(json, Strukt.T_Precondition_set);
            //MessageBox.Show(json);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
