using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMM_PMS.employee_forms
{
    public partial class check_in_form : UserControl
    {

        // Variable to serve as reference to main menu
        private main_menu topMenu;

        public check_in_form(main_menu topMenu)
        {
            this.topMenu = topMenu;
            InitializeComponent();
        }

        private void check_in_form_Load(object sender, EventArgs e)
        {
            check_in_form_textbox_lname.Focus();
            topMenu.changeMainMenuTitle("Reservation Search");
        }

        private void check_in_form_button_cancel_Click(object sender, EventArgs e)
        {
            topMenu.resetForm();
            this.Dispose();
        }

        private void check_in_form_button_submit_Click(object sender, EventArgs e)
        {
            // Check in code goes here
        }
    }
}
