using System;
using System.Windows.Forms;

namespace Survey
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Are you ready to Leave?";
            string caption = "Leaving Result Screen";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ReadFromDatabase();
        }

        private void ReadFromDatabase()
        {
            //This is where the records are going to be read from the database

            //Total No - the total number of surveys
            //Average Age - Sum of the ages divided by the number of surveys completed
            //Oldest person - age.maximum
            //Younger person = age.minimum
        }
    }
}
