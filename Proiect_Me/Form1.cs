using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Me
{
    public partial class Form1 : Form
    {
        string[] txtbox=new string[20];
        Calculator c0,c,c1,c2,c3;
        public Form1()
        {
            InitializeComponent();
        }
        private void but1_Click(object sender, EventArgs e)
        {
            if (TxtAfisare.Enabled == true)
                TxtAfisare.Text = TxtAfisare.Text + "1" ;  
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (TxtAfisare.Enabled == true)
                TxtAfisare.Text = TxtAfisare.Text + "2";
        }

        private void but3_Click(object sender, EventArgs e)
        {
            if (TxtAfisare.Enabled == true)
                TxtAfisare.Text = TxtAfisare.Text + "3";
        }

        private void butImul_Click(object sender, EventArgs e)
        {
            if (TxtAfisare.Enabled == true && TxtAfisare.Text.Length>0)
                TxtAfisare.Text = TxtAfisare.Text + " / ";
        }

        private void but4_Click(object sender, EventArgs e)
        {
            if (TxtAfisare.Enabled == true)
                TxtAfisare.Text = TxtAfisare.Text + "4";
        }

        private void but5_Click(object sender, EventArgs e)
        {
            if (TxtAfisare.Enabled == true)
                TxtAfisare.Text = TxtAfisare.Text + "5";
        }

        private void but6_Click(object sender, EventArgs e)
        {
            if (TxtAfisare.Enabled == true)
                TxtAfisare.Text = TxtAfisare.Text + "6";
        }

        private void butMul_Click(object sender, EventArgs e)
        {
            if (TxtAfisare.Enabled == true &&TxtAfisare.Text.Length > 0)
                TxtAfisare.Text = TxtAfisare.Text + " * ";
        }

        private void but7_Click(object sender, EventArgs e)
        {
            if (TxtAfisare.Enabled == true)
                TxtAfisare.Text = TxtAfisare.Text + "7";
        }

        private void but8_Click(object sender, EventArgs e)
        {
            if (TxtAfisare.Enabled == true)
                TxtAfisare.Text = TxtAfisare.Text + "8";
        }

        private void but9_Click(object sender, EventArgs e)
        {
            if (TxtAfisare.Enabled == true)
                TxtAfisare.Text = TxtAfisare.Text + "9";
        }

        private void butMinus_Click(object sender, EventArgs e)
        {
            if (TxtAfisare.Enabled == true && TxtAfisare.Text.Length==0)
            {
                TxtAfisare.Text = TxtAfisare.Text + "-";
            }
            else if (TxtAfisare.Enabled == true && TxtAfisare.Text.Length >=1)
                TxtAfisare.Text = TxtAfisare.Text + " - ";
           
        }

        private void but0_Click(object sender, EventArgs e)
        {
            if (TxtAfisare.Enabled == true)
                TxtAfisare.Text = TxtAfisare.Text + "0";
        }

        private void butVirgula_Click(object sender, EventArgs e)
        {
            if (TxtAfisare.Enabled == true)
                TxtAfisare.Text = TxtAfisare.Text + ".";
        }

        private void butPlus_Click(object sender, EventArgs e)
        {
            if(TxtAfisare.Enabled==true && TxtAfisare.Text.Length>=1)
                TxtAfisare.Text = TxtAfisare.Text + " + ";
        }

        private void ParantezaST_Click(object sender, EventArgs e)
        {
            if (TxtAfisare.Enabled == true)
                TxtAfisare.Text = TxtAfisare.Text + "(";
        }

        private void ParantezaDR_Click(object sender, EventArgs e)
        {
            if (TxtAfisare.Enabled == true)
                TxtAfisare.Text = TxtAfisare.Text + ")";
        }

        private void Radical_Click(object sender, EventArgs e)
        {
            if (TxtAfisare.Enabled == true)
                TxtAfisare.Text = TxtAfisare.Text + " √ ";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            TxtAfisare.Text = "";
        }

        private void Power_Click(object sender, EventArgs e)
        {
            if(TxtAfisare.Enabled==true)
            {
                TxtAfisare.Enabled = false;
                TxtAfisare.Text = null;
                Power.Text = "ON";
            }
           else
            { 
                TxtAfisare.Enabled = true;
                Power.Text = "OFF";
            }

        }

        private void butEqual_Click(object sender, EventArgs e)
        {
                txtbox = TxtAfisare.Text.Split(' ');
                if (txtbox.Length>1 && txtbox.Length <= 3)
                {
                    c1 = new Calculator(float.Parse(txtbox[0]), (txtbox[1]), float.Parse(txtbox[txtbox.Length - 1]));
                    TxtAfisare.Text = c1.Operatie().ToString();
                }
                else 
                if (txtbox.Length > 3 && txtbox.Length<=5)
                {
                    c2 = new Calculator(float.Parse(txtbox[0]), (txtbox[1]), float.Parse(txtbox[2]),txtbox[3],float.Parse(txtbox[txtbox.Length-1]));
                    TxtAfisare.Text = c2.Operatie2().ToString();
                }
                else
                if(txtbox.Length>=6)
                {
                c3 = new Calculator(float.Parse(txtbox[0]), (txtbox[1]), float.Parse(txtbox[2]), txtbox[3],float.Parse(txtbox[4]),txtbox[5],float.Parse(txtbox[txtbox.Length - 1]));
                TxtAfisare.Text = c3.Operatie3().ToString();
                }
        }
    }
}
