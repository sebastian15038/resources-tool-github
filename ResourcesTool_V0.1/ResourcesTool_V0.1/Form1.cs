using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResourcesTool_V0._1
{
    public partial class Form1 : Form
    {



        public Form1()
        {

            InitializeComponent();
            InitializeProfits();
                 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }


        /// <summary>
        /// Füllt den Tab ProfitCalculator mit GroupBoxen, Preisen etc
        /// </summary>
        private void InitializeProfits()
        {


          //  Panel[] panelArray = new Panel[22];
           // PictureBox[] pictureArray = new PictureBox[22];

                 
            for (int i = 0; i < 22; i++)
            {
         
                GroupBox blub = new GroupBox();
                panel2.Controls.Add(blub);
               blub.Dock = System.Windows.Forms.DockStyle.Top;
               blub.Size = new System.Drawing.Size(747, 119);
                blub.Text = "Heyy" +i;
 
            }


        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            

        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
