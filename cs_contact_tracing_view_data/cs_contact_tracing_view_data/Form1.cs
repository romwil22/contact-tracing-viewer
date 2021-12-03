using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cs_contact_tracing_view_data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void retrieveData()
        {
            string readStudentFile = @"C:\Users\Rom\Desktop\5TH YR 1ST SEM FILES\OOP\contact-tracing\student-data.txt";
            string printData = File.ReadAllText(readStudentFile);

            studentDataBox.Text = printData;

        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            retrieveData();
            MessageBox.Show("Retrieve successfully");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using");
            this.Close();
        }
    }
}
