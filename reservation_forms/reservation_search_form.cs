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
    public partial class reservation_search_form : UserControl
    {

        // Variable to serve as reference to main menu
        private main_menu topMenu;

        public reservation_search_form(main_menu topMenu)
        {
            this.topMenu = topMenu;
            InitializeComponent();
        }

        private void reservation_search_form_Load(object sender, EventArgs e)
        {
            reservation_search_form_textbox_lname.Focus();
            topMenu.changeMainMenuTitle("Reservation Search");
        }

        private void reservation_search_form_button_cancel_Click(object sender, EventArgs e)
        {
            topMenu.resetForm();
            this.Dispose();
        }

        private void reservation_search_form_button_edit_reservation_Click(object sender, EventArgs e)
        {
            int resID = 0; // This needs to be updated to reflect selected reservation from dgv
            Panel parent = (Panel)Parent;
            parent.Controls.Clear();
            parent.Controls.Add(new reservation_edit_form(topMenu, resID));
            this.Dispose();
        }

        private void reservation_search_form_button_add_Click(object sender, EventArgs e)
        {
            Panel parent = (Panel)Parent;
            parent.Controls.Clear();
            parent.Controls.Add(new reservation_add_form(topMenu));
            this.Dispose();
        }
    }
}
