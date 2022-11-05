using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FermatPrimalityTest;
using static System.Net.Mime.MediaTypeNames;

namespace PrimalityNumbers
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Button check click. Split the TextBox and use the method TestChecker
        private void btChecker_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            string[] numbersList = tbNumbers.Text.Split(',');
            TestChecker(numbersList);
            
        }

        //Button load file using the method LoadFile
        private void btLoadFile_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        //Button cancel - Close the application
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        //Button Save using method Save.
        private void btSave_Click(object sender, EventArgs e)
        {
            Save();
        }


        //Method save - Open Save File Dialog, and using a Stream Writer save the report.
        void Save()
        {
            string fileName = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save report";
            saveFileDialog.Filter = "Text File (.txt) | *.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                if (fileName != "")
                {
                    using (StreamWriter sw = new StreamWriter(fileName))
                    {
                        //getting each item in list view
                        foreach (ListViewItem item in lvReport.Items)
                        {
                            sw.WriteLine(item.Text);
                        }
                    }
                }
                // return a successfully message box. 
                MessageBox.Show("Report saved successfully!", "File saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        //Method LoadFile to load a text file and read each line, after use the method TestChecker to check if the number is prime or not. 
        void LoadFile()
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Text File (.txt) | *.txt";

                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {   
                    //open the file
                    using(StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        //read the first line
                        string line = reader.ReadLine();

                        //if the line is not empty
                        while(line != null)
                        {
                            string[] numbersList = line.Split(",");
                            TestChecker(numbersList);

                            //read the next line
                            line = reader.ReadLine();
                        }
                    }                    
                }

                //return a successfully message box
                MessageBox.Show("File read successfully!", "File loaded", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }


        //method TestChecker - using the FermatPrimalityTest as reference. 
        //Checking if the number is prime or not and add in the Report (ListView).
        private void TestChecker(string[] numbersList)
        {
            //initialize test from FermatPrimalityTest
            Test test = new Test();
            
            //checking each elemnt in the list
            foreach (string number in numbersList)
            {
                
                //try to convert the string to integer
                try
                {
                    //converting
                    int numberToCheck = Int32.Parse(number);
                    
                    //negatives number can not be prime
                    if (numberToCheck < 0)
                    {
                        MessageBox.Show("Negative numbers can not be prime.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //positive numbers
                    else
                    {
                        //checking the primality
                        bool result = test.CheckPrimality(Convert.ToInt32(number));
                        
                        //prime
                        if (result)
                        {
                            lvReport.Items.Add(number + " - " + "PRIME");
                        }
                        
                        //not prime
                        else
                        {
                            lvReport.Items.Add(number + " - " + "COMPOSITE");
                        }
                    }

                }
                
                //if it was impossible to convert the string to integer
                catch (FormatException)
                {
                    MessageBox.Show(number + " is not a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            //Make the last item in list view visible
            lvReport.EnsureVisible(lvReport.Items.Count - 1);

            //clear the textbox for a new number and active. 
            tbNumbers.Text = "";
            tbNumbers.Focus();
        }

        //Tool Strip Menu
        private void newReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvReport.Items.Clear();
            tbNumbers.ResetText();
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile();
        }
        private void saveReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
