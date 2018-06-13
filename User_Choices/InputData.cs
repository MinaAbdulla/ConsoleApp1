
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
using static Algo.Spacing.RafterCell;
using Algo.Pitch;
using Algo.Spacing;

namespace User_Choices
{
    public partial class InputData : Form
    {
      //public DialogResult Res = new DialogResult();
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
            var least = algorithm.GetLeastCost();
            // Class OutPut Solution 
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private Algo.InputData GetData()
        {
            var data = new Algo.InputData();
            // DeadLoad
            if (rbtn_10.Checked) data.DeadLoad = 10;
            else if (rbtn_20.Checked) data.DeadLoad = 20;
            // Species
            if (rbtn_Douglas_fir_larch.Checked)
                data.Species = Species.Douglas_fir_larch;
            else if (rbtn_Hem_fir.Checked)
                data.Species = Species.Hem_fir;
            else if (rbtn_Southern_pine.Checked)
                data.Species = Species.Southern_pine;
            else if(rbtn_Spruce_pine_fir.Checked)
                data.Species = Species.Spruce_pine_fir;
            //Grade 
            if (rbtn_ss.Checked) data.Grade = Grade.SS;
            else if (rbtn_1.Checked) data.Grade = Grade.G1;
            else if (rbtn_2.Checked) data.Grade = Grade.G2;
            else if (rbtn_3.Checked) data.Grade = Grade.G3;
            // GrSnowLoad 
            if (rbtn_209.Checked) data.GrSnowLoad = GrSnowLoad._209;
            else if (rbtn_30.Checked) data.GrSnowLoad = GrSnowLoad._30;
            else if (rbtn_50.Checked) data.GrSnowLoad = GrSnowLoad._50;
            else if (rbtn_70.Checked) data.GrSnowLoad = GrSnowLoad._70;
            
            return data;
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
