using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FAQButton_Click(object sender, EventArgs e)
        {
            ButtonOfCancel.Visible = true;
            ControlGameButton.Visible = false;
            CommonGameButton.Visible = false;
            MultipleGameButton.Visible = false;
            FAQButton.Visible = false;
            FAQCommonGame.Visible = true;
            FAQControlGame.Visible = true;
            FAQMultipleGame.Visible = true;
            Text1.Visible = true;
            Text2.Visible = true;
            Text5.Visible = true;
            Text3.Visible = true;
            Text4.Visible = true;
            Text5.Visible = true;
            Text6.Visible = true;
            Text7.Visible = true;
            Text8.Visible = true;
        }

        private void ButtonOfCancel_Click(object sender, EventArgs e)
        {
            ButtonOfCancel.Visible = false;
            Text1.Visible = false;
            Text2.Visible = false;
            Text5.Visible = false;
            Text3.Visible = false;
            Text4.Visible = false;
            Text5.Visible = false;
            Text6.Visible = false;
            Text7.Visible = false;
            Text8.Visible = false;
            ControlGameButton.Visible = true;
            CommonGameButton.Visible = true;
            MultipleGameButton.Visible = true;
            FAQButton.Visible = true;
            FAQCommonGame.Visible = false;
            FAQControlGame.Visible = false;
            FAQMultipleGame.Visible = false;

        }

        private void FAQCommonGame_Click(object sender, EventArgs e)
        {

            FAQCommonGame.BackColor = Color.Green;
            FAQControlGame.BackColor = Color.White;
            FAQMultipleGame.BackColor = Color.White;
        }

        private void FAQControlGame_Click(object sender, EventArgs e)
        {
            FAQCommonGame.BackColor = Color.White;
            FAQControlGame.BackColor = Color.Green;
            FAQMultipleGame.BackColor = Color.White;


        }

        private void FAQMultipleGame_Click(object sender, EventArgs e)
        {
            FAQCommonGame.BackColor = Color.White;
            FAQControlGame.BackColor = Color.White;
            FAQMultipleGame.BackColor = Color.Green;
        }
    }
}
