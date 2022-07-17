using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Billing_System
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cl_CheckedChanged(object sender, EventArgs e)
        {
            if (chechBox1.Checked)
            {
                numericUpDown1.Enabled = true;
            }

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                numericUpDown2.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                numericUpDown3.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                numericUpDown4.Enabled = true;
            }
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                numericUpDown5.Enabled = true;
            }
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                numericUpDown6.Enabled = true;
            }
        }

        private void checkBox7_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                numericUpDown7.Enabled = true;
            }
        }

        private void checkBox8_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                numericUpDown8.Enabled = true;
            }
        }

        private void checkBox9_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                numericUpDown9.Enabled = true;
            }
        }

        private void checkBox10_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                numericUpDown10.Enabled = true;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                numericUpDown11.Enabled = true;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                numericUpDown12.Enabled = true;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                numericUpDown13.Enabled = true;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                numericUpDown14.Enabled = true;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                numericUpDown15.Enabled = true;
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                numericUpDown16.Enabled = true;
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
            {
                numericUpDown17.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cb1, cb2, cb3, cb4, cb5, cb6, cb7, cb8, cb9, cb10, cb11, cb12, cb13, cb14, cb15, cb16, cb17, cb18;
            cb1 = Convert.ToInt32(numericUpDown1.Text);
            cb2 = Convert.ToInt32(numericUpDown2.Text);
            cb3 = Convert.ToInt32(numericUpDown3.Text);
            cb4 = Convert.ToInt32(numericUpDown4.Text);
            cb5 = Convert.ToInt32(numericUpDown5.Text);
            cb6 = Convert.ToInt32(numericUpDown6.Text);
            cb7 = Convert.ToInt32(numericUpDown7.Text);
            cb8 = Convert.ToInt32(numericUpDown8.Text);
            cb9 = Convert.ToInt32(numericUpDown9.Text);
            cb10 = Convert.ToInt32(numericUpDown10.Text);
            cb11= Convert.ToInt32(numericUpDown11.Text);
            cb12 = Convert.ToInt32(numericUpDown12.Text);
            cb13 = Convert.ToInt32(numericUpDown13.Text);
            cb14 = Convert.ToInt32(numericUpDown14.Text);
            cb15 = Convert.ToInt32(numericUpDown15.Text);
            cb16 = Convert.ToInt32(numericUpDown16.Text);
            cb17 = Convert.ToInt32(numericUpDown17.Text);
            cb18 = Convert.ToInt32(numericUpDown18.Text);

            int cj = 300;
            int cj2 = 400;
            int ck = 500;
            int bc = 700;
            int dcc = 800;
            int ct = 999;
            int cjk = 600;
            int daal = 200;
            int ag = 700;
            int cq = 700;

            int menuBill = (cj * cb1) + (cj2 * cb2) + (ck * cb3) + (bc * cb4) + (dcc * cb5)
                + (ct * cb6) + (cjk * cb7) + (daal * cb8) + (ag * cb9) + (cq * cb10);
            int rc = 30;
            int rs=30;
            int r7 = 30;
            int rp = 30;
            int lc = 120;
            int ls = 120;
            int l7 = 120;
            int lp = 120;

            int drinksBill = (rc * cb11) + (rs * cb12) + (r7 * cb13) + (rp * cb14) + (lc * cb15)
                + (ls * cb16) + (l7 * cb17) + (lp * cb18);
            textBox1.Text =Convert.ToString(menuBill);
            textBox2.Text = Convert.ToString(drinksBill);
            int total = menuBill + drinksBill;
            textBox6.Text = Convert.ToString(total);

            double GST = (0.16 * total);
           
            double service_charges = (0.02 * total);
            double totalBill = total + GST + service_charges;
            textBox3.Text = Convert.ToString(GST);
            textBox4.Text = Convert.ToString(service_charges);
            textBox5.Text = Convert.ToString(totalBill);


        }

        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Receipt_Click(object sender, EventArgs e)
        {
            //btnReceipt
            richTextBox1.Clear();

            // rtfReceipt.AppendText(Environment.NewLine);
            richTextBox1.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            richTextBox1.AppendText("\t\t" + "Grill and Chill Resturan" + Environment.NewLine);
            richTextBox1.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            richTextBox1.AppendText("-------------------------------------------------------------" + Environment.NewLine);

            richTextBox1.AppendText("Customer Name \t\t" + textBox7.Text + Environment.NewLine);
            richTextBox1.AppendText("Contact Number \t\t" + textBox8.Text + Environment.NewLine);
            richTextBox1.AppendText("Gender \t\t\t" + label21.Text + Environment.NewLine);
            richTextBox1.AppendText("Payment Method \t\t" + label18.Text + Environment.NewLine);
            richTextBox1.AppendText("Table No.\t\t\t" + label19.Text + Environment.NewLine);
            richTextBox1.AppendText("Waiter Name \t\t" +label20.Text + Environment.NewLine);
            richTextBox1.AppendText("-------------------------------------------------------------" + Environment.NewLine);

            richTextBox1.AppendText("Chicken Jalfrezi \t\t" + numericUpDown1.Text + Environment.NewLine);
            richTextBox1.AppendText("Chicken Jeera \t\t" + numericUpDown2.Text + Environment.NewLine);
            richTextBox1.AppendText("Chicken Karai \t\t" + numericUpDown3.Text + Environment.NewLine);
            richTextBox1.AppendText("Butter Chicken \t\t" + numericUpDown4.Text + Environment.NewLine);
            richTextBox1.AppendText("Desi Chicken Curry \t\t" + numericUpDown5.Text + Environment.NewLine);
            richTextBox1.AppendText("Chicken Tawa \t\t" + numericUpDown6.Text + Environment.NewLine);
            richTextBox1.AppendText("Chicken Jalfrezi Tikka \t" + numericUpDown7.Text + Environment.NewLine);
            richTextBox1.AppendText("Daal \t\t\t" + numericUpDown8.Text + Environment.NewLine);
            richTextBox1.AppendText("Achar Gosht\t\t" + numericUpDown9.Text + Environment.NewLine);
            richTextBox1.AppendText("Chicken Kimma \t\t" + numericUpDown10.Text + Environment.NewLine);
            richTextBox1.AppendText("Regular Coke \t\t" + numericUpDown11.Text + Environment.NewLine);
            richTextBox1.AppendText("Regular Sprite\t\t" + numericUpDown12.Text + Environment.NewLine);
            richTextBox1.AppendText("Regular 7up \t\t" + numericUpDown13.Text + Environment.NewLine);
            richTextBox1.AppendText("Regular Pepsi\t\t" + numericUpDown14.Text + Environment.NewLine);
            richTextBox1.AppendText("Liter Coke \t\t" + numericUpDown15.Text + Environment.NewLine);
            richTextBox1.AppendText("Liter Sprite \t\t" + numericUpDown16.Text + Environment.NewLine);
            richTextBox1.AppendText("Liter Pepsi \t\t" + numericUpDown17.Text + Environment.NewLine);
            richTextBox1.AppendText("Liter 7up \t\t\t" + numericUpDown18.Text + Environment.NewLine);

            richTextBox1.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            richTextBox1.AppendText("Service Charge \t\t" + "2%" + Environment.NewLine);
            richTextBox1.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            richTextBox1.AppendText("GST \t\t\t" + "16%" + Environment.NewLine);
           
            richTextBox1.AppendText("Total Cost \t\t" + textBox5.Text + Environment.NewLine);
            richTextBox1.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            richTextBox1.AppendText("Date and Time is \t" + dateTimePicker1.Text );
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            numericUpDown1.Text = "0";
            numericUpDown2.Text = "0";
            numericUpDown3.Text = "0";
            numericUpDown4.Text = "0";
            numericUpDown5.Text = "0";
            numericUpDown6.Text = "0";
            numericUpDown7.Text = "0";
            numericUpDown8.Text = "0";
            numericUpDown9.Text = "0";
            numericUpDown10.Text = "0";
            numericUpDown11.Text = "0";
            numericUpDown12.Text = "0";
            numericUpDown13.Text = "0";
            numericUpDown14.Text = "0";
            numericUpDown15.Text = "0";
            numericUpDown16.Text = "0";
            numericUpDown17.Text = "0";
            numericUpDown18.Text = "0";
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            richTextBox1.Clear();



            chechBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
           checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;


        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox18.Checked)
            {
                numericUpDown18.Enabled = true;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //this code will save text files
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("if you need and help \n then contact with Administration");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label21.Text = "Male";
            }
            else if (radioButton2.Checked)
            {
                label21.Text = "Female";
            }
            else if(radioButton3.Checked)
            {
                label21.Text = "other";

            }
            if (radioButton4.Checked)
            {
                label18.Text = "Online";
            }
            else if(radioButton5.Checked)
            {
                label18.Text = "Cash";
            }
            label19.Text = comboBox1.Text;
            label20.Text = comboBox2.Text;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string number = (textBox8.Text);
            try
            {
              if ( number== " ")
            {
                    MessageBox.Show("plase enter the number");
                }
                if (number.Length < 10)
                {
                    MessageBox.Show("country code aded automatically");
                //    number = "+92" + number;
                }
              // number = number.Replace(" ", "");
               // MessageBox.Show(number);
            MessageBox.Show(richTextBox1.Text);
              System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=" + number + "&text=" + richTextBox1.Text);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
