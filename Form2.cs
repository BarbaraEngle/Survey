using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            //1. Set a boolean flag to true
            //2. Continue to loop thru the code until the flag (called checkers) is false
            //3. An error is set if
            //        the Surname is not filled in
            //        OR the Name is not filled in 
            //        OR the Contact Number is not filled in
            //        OR the Age is not filled in
            //4. The selected foods are saved to a list to be stored in a db later
            //5. The selected and the rating are saved to a list be be stored in a db later

            var error = false;
            try
            {
                    //Surname
                    //If the surname field is empty, show an error
                    if (tb_Surname.TextLength < 1 || tb_Surname.TextLength==0)
                    {
                        tb_Surname.Text = "ERROR";
                        
                    }


                    //Names
                    //If the names are empty, show an error
                    if (tb_Names.TextLength < 0 || tb_Names.TextLength==0)
                    {
                       tb_Names.Text = "ERROR";
                    }

                    //Contact Numbers
                    //If the numbers are empty, show an error
                    if (tb_Numbers.TextLength < 1 || tb_Numbers.TextLength == 0)
                    {
                        tb_Numbers.Text = "ERROR";
                    }

                    

                    //Age
                    //If the age is empty, show an error
                    if (tb_Age.TextLength < 1 || tb_Age.TextLength==0)
                    {
                        age.Text = "ERROR";
                    }


                    // pick food out of 6 pizza, pasta, pap and wors, Chicken Stir Fry, Beef Stir fry, other
                    // If the food has been selected, add it to a list

                    List <String> Foods= new List<string> ();

                    if (rb_Pizza.Checked)
                    {
                        Foods.Add("Pizza");
                    }
                    if (rb_Pasta.Checked)
                    {
                        Foods.Add("Pasta");
                    }
                    if (rb_PapWors.Checked)
                    {
                        Foods.Add("Pap and Wors");
                    }
                    if (rb_Chicken.Checked)
                    {
                        Foods.Add("Chicken Stir Fry");
                    }
                    if (rb_Beef.Checked)
                    {
                        Foods.Add("Beef Stir Fry");
                    }
                    if (rb_Other.Checked)
                    {
                        Foods.Add("Other");
                    }


                    //Save the selected activity and the rating to a list to be saved to the database later

                    List<String> Activities = new List<String>();
                    
                    //Eatout 1-5 Radio Button
                    if(rb_EatOut_1.Checked)
                    {
                        Activities.Add("EatOut 1");
                    } 
                    else if(rb_EatOut_2.Checked)
                    {
                            Activities.Add("EatOut 2");
                    }
                    else if (rb_EatOut_3.Checked)
                    {
                           Activities.Add("EatOut 3");
                    }
                    else if (rb_EatOut_4.Checked)
                    {
                            Activities.Add("EatOut 4");
                    }
                    else if (rb_EatOut_5.Checked)
                    {
                            Activities.Add("EatOut 5");
                    }

                    //Movies 1-5 Radio Button
                    
                        if (rb_Movies_1.Checked)
                        {
                            Activities.Add("Movies 1");
                        }
                        else if (rb_Movies_2.Checked)
                        {
                            Activities.Add("Movies 2");
                        }
                        else if (rb_Movies_3.Checked)
                        {
                            Activities.Add("Movies 3");
                        }
                        else if (rb_Movies_4.Checked)
                        {
                            Activities.Add("Movies 4");
                        }
                        else if (rb_Movies_5.Checked)
                        {
                            Activities.Add("Movies 5");
                        }

                    //TV 1-5 Radio Button
                        if (rb_TV_1.Checked)
                        {
                            Activities.Add("TV 1");
                        }
                        else if (rb_TV_2.Checked)
                        {
                            Activities.Add("TV 2");
                        }
                        else if (rb_TV_3.Checked)
                        {
                            Activities.Add("TV 3");
                        }
                        else if (rb_TV_4.Checked)
                        {
                            Activities.Add("TV 4");
                        }
                        else if (rb_TV_5.Checked)
                        {
                            Activities.Add("TV 5");
                        }
                    

                    //Radio 1-5 Radio Button
                    if (rb_Radio_1.Checked)
                        {
                            Activities.Add("Radio 1");
                        }
                        else if (rb_Radio_2.Checked)
                        {
                            Activities.Add("Radio 2");
                        }
                        else if (rb_Radio_3.Checked)
                        {
                            Activities.Add("Radio 3");
                        }
                        else if (rb_Radio_4.Checked)
                        {
                            Activities.Add("Radio 4");
                        }
                        else if (rb_Radio_5.Checked)
                        {
                            Activities.Add("Radio 5");
                        }


                    if (tb_Surname.Text=="ERROR" || tb_Names.Text=="ERROR" || tb_Numbers.Text=="ERROR"|| tb_Age.Text=="ERROR")
                    {
                        string message = "Please complete all the fields";
                        string caption = "Error on Capture";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons);
                        error = true;
    

                    }
                    else
                    {
                        SaveToDatabase(tb_Surname.Text, tb_Names.Text, tb_Numbers.Text, tb_Age.Text, Foods, Activities);
                    }
            }
            catch (Exception)
            {
                throw;
            }

            if (!error)
            {

                Form3 obj3 = new Form3();
                obj3.Show();
                this.Visible = false;
            }
        }

        private void SaveToDatabase(string surname, string names, string contactNumber, string age, List<string> foods, List<string> activities)
        {
            //Write to db;
        }


        //This needs to happen for all the radio button selections, Only 1 rb can be selected at a time.
        private void rb_EatOut_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_EatOut_1.Checked)
            {
                rb_EatOut_2.Checked = false;
                rb_EatOut_3.Checked = false;
                rb_EatOut_4.Checked = false;
                rb_EatOut_5.Checked = false;
            }

        }

        private void rb_EatOut_2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_EatOut_2.Checked)
            {
                rb_EatOut_1.Checked = false;
                rb_EatOut_3.Checked = false;
                rb_EatOut_4.Checked = false;
                rb_EatOut_5.Checked = false;
            }
        }

        private void rb_EatOut_3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_EatOut_3.Checked)
            {
                rb_EatOut_1.Checked = false;
                rb_EatOut_2.Checked = false;
                rb_EatOut_4.Checked = false;
                rb_EatOut_5.Checked = false;
            }
        }

        private void rb_EatOut_4_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_EatOut_4.Checked)
            {
                rb_EatOut_1.Checked = false;
                rb_EatOut_2.Checked = false;
                rb_EatOut_3.Checked = false;
                rb_EatOut_5.Checked = false;
            }
        }

        private void rb_EatOut_5_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_EatOut_5.Checked)
            {
                rb_EatOut_1.Checked = false;
                rb_EatOut_2.Checked = false;
                rb_EatOut_3.Checked = false;
                rb_EatOut_4.Checked = false;
            }

        }
    }
}
