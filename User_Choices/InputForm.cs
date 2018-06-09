
using Algo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace User_Choices
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InputForm_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            var data = GetData();
            Algorithm algorithm = new Algorithm(data);
            algorithm.Run();
            var lest = algorithm.GetLestCost();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private InputData GetData()
        {
            var data = new InputData();
            if (rbtn_10.Checked)
            {
                data.DeadLoad = 10;
            }
            else
            {
                data.DeadLoad = 20;
            }
            return data;
        }
    }
}
