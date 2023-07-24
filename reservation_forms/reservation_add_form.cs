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
    public partial class reservation_add_form : UserControl
    {
        // Variable to serve as reference to employee_search_form
        private main_menu topMenu;

        public reservation_add_form(main_menu topMenu)
        {
            this.topMenu = topMenu;
            InitializeComponent();
        }

        private void reservation_add_form_button_cancel_Click(object sender, EventArgs e)
        {
            Panel parent = (Panel)Parent;
            parent.Controls.Clear();
            parent.Controls.Add(new reservation_search_form(topMenu));
            this.Dispose();
        }

        private void reservation_add_form_Load(object sender, EventArgs e)
        {
            reservation_add_form_textbox_customer.Focus();
            topMenu.changeMainMenuTitle("Add a Reservation");
        }
    }
}
