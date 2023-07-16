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
    public partial class employee_search_form : UserControl
    {

        // Variable to serve as reference to main menu
        private main_menu topMenu;

        public employee_search_form(main_menu topMenu)
        {
            this.topMenu = topMenu;
            InitializeComponent();
        }

        private void employee_search_form_Load(object sender, EventArgs e)
        {
            employee_search_form_textbox_lname.Focus();
            topMenu.changeMainMenuTitle("Employee Search");
        }

        private void employee_search_form_button_add_Click(object sender, EventArgs e)
        {
            Panel parent = (Panel) Parent;
            parent.Controls.Clear();
            parent.Controls.Add(new employee_add_form(topMenu));
        }

        private void employee_search_form_button_edit_employee_Click(object sender, EventArgs e)
        {
            int empID = 0; // This needs to be updated to reflect selected employee from dgv
            Panel parent = (Panel)Parent;
            parent.Controls.Clear();
            parent.Controls.Add(new employee_edit_form(topMenu, empID));
        }

        private void employee_search_form_button_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            topMenu.resetForm();
        }
    }
}
