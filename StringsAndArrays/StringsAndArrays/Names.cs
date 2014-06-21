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
        //initialize class variables
        string[] First = new string[50];
        string[] Middle = new string[50];
        string[] Last = new string[50];
        int intCount = 0;

        public frmNames()
        {
            InitializeComponent();
        }

        //takes text from text box and adds to array
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearLabels();
            int i, j;
            string strName, strFirst, strMiddle, strLast,strFirst1, strFirst2, strMiddle1, strMiddle2, strLast1,
                strLast2;

            try
            {
                //read in name and look for spaces to determine First, Middle, and Last
                strName = txtBxEnterName.Text;
                i = strName.IndexOf(" ");
                j = strName.LastIndexOf(" ");

                if (intCount < 50) //determines if array is full
                {
                    if (i == j) //determines if middle name entered
                    {
                        //no middle name entered
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
                    else //middle name entered
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
                    } //end if i=j
                    lblStatus.Text = "Added: " + Last[intCount] + ", " + First[intCount] + " " + Middle[intCount];
                    lblRecord.Text = "Record " + (intCount + 1).ToString() + " of " + Last.Length.ToString();
                    intCount++; //increases count for each entry in array
                    txtBxEnterName.Clear();
                    txtBxEnterName.Focus();
                }
                else
                {
                    //array is full, show message
                    MessageBox.Show("Too Many Variables. Clear All and Try Again.");
                } //end if intCount<50
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Entry. Try Again.");
            } //end try
        }

        //will display name as 'Last, First Middle' or 'Last, First'
        private void btnDisplay1_Click(object sender, EventArgs e)
        {
            string strOutput1 = "LIST 1".PadLeft(30)+"\n"; //initialize display string

            txtBxDisplay.Clear();
            ClearLabels();

            for (int k = 0; k < intCount; ++k) //cycles through array
            {
                //build string and print in text box
                strOutput1 += Last[k] + ", " + First[k] + " " + Middle[k] + "\n";
                txtBxDisplay.Text = strOutput1;
            }
        }

        //will display name as 'Last, F.(first initial)'
        private void btnDisplay2_Click(object sender, EventArgs e)
        {
            string strOutput2 = "LIST 2".PadLeft(30)+"\n"; //initialize display string

            txtBxDisplay.Clear();
            ClearLabels();

            for (int l = 0; l < intCount; ++l) //cycles through array
            {
                //builds string and prints in text box
                strOutput2 += Last[l] + ", " + First[l].Substring(0, 1) + ".\n";
                txtBxDisplay.Text = strOutput2;
            }
        }

        //will display name as 'Last, First' with 5 char in last and 3 char in first
        private void btnDisplay3_Click(object sender, EventArgs e)
        {
            string strOutput3 = "LIST 3".PadLeft(30)+"\n"; //initializes display string

            txtBxDisplay.Clear();
            ClearLabels();

            for (int m = 0; m < intCount; ++m) //cycles through array
            {
                //builds string and displays in text box
                if (Last[m].Length < 5) //if last is less than 5 characters, no substring created
                {
                    if (First[m].Length < 3) //if first is less than 3 characters, no substring needed
                    {
                        strOutput3 += Last[m].Substring(0, 5) + ", " + First[m] + "\n";
                        txtBxDisplay.Text = strOutput3;
                    }
                    else
                    {
                        strOutput3 += Last[m] + ", " + First[m].Substring(0, 3) + "\n";
                        txtBxDisplay.Text = strOutput3;
                    }
                }
                else
                {
                    if (First[m].Length < 3) //if first is less than 3 characters, no substring needed
                    {
                        strOutput3 += Last[m].Substring(0, 5) + ", " + First[m] + "\n";
                        txtBxDisplay.Text = strOutput3;
                    }
                    else
                    {
                        strOutput3 += Last[m].Substring(0, 5) + ", " + First[m].Substring(0, 3) + "\n";
                        txtBxDisplay.Text = strOutput3;
                    }
                }//end if
            }//end for
        }

        //resets everything to 0 or null and sets text box focux
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Clear();
            txtBxEnterName.Focus();
            ClearLabels();
            intCount = 0;

            for(int a=0;a<50;++a) //cycles through array
            {
                First[a]="";
                Middle[a]="";
                Last[a]="";
            }
        }

        //ends application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //if anything entered into text box, all displayed data will clear
        private void txtBxEnterName_TextChanged(object sender, EventArgs e)
        {
            txtBxDisplay.Clear();            
        }

        //clears all status labels and sets text box focus
        private void ClearLabels()
        {
            lblStatus.Text = "";
            lblRecord.Text = "";
            txtBxDisplay.Focus();
        }
    }
}
