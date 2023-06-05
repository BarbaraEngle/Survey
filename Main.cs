using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey
{
    //This is the code-behind file for the Main Form
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_Fill_out_Click(object sender, EventArgs e)
        {

            //When the 'Fill-out' button is clicked, an event is triggered and this code is called
            //The code instatiates a new copy of Form2 and displays it.  
            //The Main form will become invisible, because it is set to Visible = false.
            Form2 obj2 = new Form2();
            obj2.Show();
            this.Visible=false;
        }

        private void btn_View_Results_Click(object sender, EventArgs e)
        {
            //When the 'View Result' button is clicked, an event is triggered and this code is called
            //The code instatiates a new copy of Form3 and displays it.  
            //The Main form will become invisible, because it is set to Visible = false.
            Form3 obj3 = new Form3();
            obj3.Show();
            this.Visible=false;
        }

    }
}
