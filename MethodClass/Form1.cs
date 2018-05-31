using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStoreData_Click(object sender, EventArgs e)
        {
            try
            {
                ProfessorDetails pDetails = new ProfessorDetails();
                pDetails.ProfessorInfo(tBoxName.Text, Convert.ToInt32(txtBoxAge.Text), txtBoxUniversity.Text, txtBoxDeprtmnt.Text);
                pDetails.filepath = @"C:/Users/pavan/Desktop/NewRandom/MethodClassSample.txt";
                pDetails.StoreToFile();
                

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
    public class ProfessorDetails
    {
        public string filepath;
        public string fileContent;

        public void ProfessorInfo(string name, int age, string university, string department)
        {
            fileContent = name + "\r\n" + age + "\r\n" + university + "\r\n" + department;
        }

        public void StoreToFile()
        {
            StreamWriter professorDetailsData = File.AppendText(filepath);
            professorDetailsData.WriteLine(fileContent);
            professorDetailsData.Close();
        }

    }
}
