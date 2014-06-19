using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Stephanie Goedde
//Programming I
//String and Array Names
//4-6-11

namespace StringsAndArrays
{
    public partial class frmNames : Form
    {
        string[] First = new string[50];
        string[] Middle = new string[50];
        string[] Last = new string[50];
        int intCount = 0;

        public frmNames()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i, j;
            string strName, strFirst, strMiddle, strLast,strFirst1, strFirst2, strMiddle1, strMiddle2, strLast1,
                strLast2;

            try
            {
                strName = txtBxEnterName.Text;
                i = strName.IndexOf(" ");
                j = strName.LastIndexOf(" ");

                if (intCount < 50)
                {
                    if (i == j)
                    {
                        strFirst = strName.Substring(0, i);
                        strFirst1 = strFirst.Substring(0, 1).ToUpper();
                        strFirst2 = strFirst.Substring(1).ToLower();
                        strFirst = strFirst1 + strFirst2;
                        strLast = strName.Substring(i + 1);
                        strLast1 = strLast.Substring(0, 1).ToUpper();
                        strLast2 = strLast.Substring(1).ToLower();
                        strLast = strLast1 + strLast2;
                        First[intCount] = strFirst;
                        Last[intCount] = strLast;
                        Middle[intCount] = "";
                    }
                    else
                    {
                        strFirst = strName.Substring(0, i);
                        strFirst1 = strFirst.Substring(0, 1).ToUpper();
                        strFirst2 = strFirst.Substring(1).ToLower();
                        strFirst = strFirst1 + strFirst2;
                        strMiddle = strName.Substring(i + 1, j - (i + 1));
                        strMiddle1 = strMiddle.Substring(0, 1).ToUpper();
                        strMiddle2 = strMiddle.Substring(1).ToLower();
                        strMiddle = strMiddle1 + strMiddle2;
                        strLast = strName.Substring(j + 1);
                        strLast1 = strLast.Substring(0, 1).ToUpper();
                        strLast2 = strLast.Substring(1).ToLower();
                        strLast = strLast1 + strLast2;
                        First[intCount] = strFirst;
                        Middle[intCount] = strMiddle;
                        Last[intCount] = strLast;
                    }
                    intCount++;
                    txtBxEnterName.Clear();
                    txtBxEnterName.Focus();
                }
                else
                {
                    MessageBox.Show("Too Many Variables. Clear All and Try Again.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Entry. Try Again.");
            }
        }

        private void btnDisplay1_Click(object sender, EventArgs e)
        {
            string strOutput1 = "LIST 1".PadLeft(30)+"\n";

            txtBxDisplay.Clear();

            for (int k = 0; k < intCount; ++k)
            {
                strOutput1 += Last[k] + ", " + First[k] + " " + Middle[k] + "\n";
                txtBxDisplay.Text = strOutput1;
            }
        }

        private void btnDisplay2_Click(object sender, EventArgs e)
        {
            string strOutput2 = "LIST 2".PadLeft(30)+"\n";

            txtBxDisplay.Clear();

            for (int l = 0; l < intCount; ++l)
            {
                strOutput2 += Last[l] + ", " + First[l].Substring(0, 1) + ".\n";
                txtBxDisplay.Text = strOutput2;
            }
        }

        private void btnDisplay3_Click(object sender, EventArgs e)
        {
            string strOutput3 = "LIST 3".PadLeft(30)+"\n";

            txtBxDisplay.Clear();

            for (int m = 0; m < intCount; ++m)
            {
                strOutput3 += Last[m].Substring(0, 5) + ", " + First[m].Substring(0, 3) + "\n";
                txtBxDisplay.Text = strOutput3;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Clear();
            txtBxEnterName.Focus();
            intCount = 0;

            for(int a=0;a<50;++a)
            {
                First[a]="";
                Middle[a]="";
                Last[a]="";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBxEnterName_TextChanged(object sender, EventArgs e)
        {
            txtBxDisplay.Clear();
        }
    }
}
