using LAMM_PMS.employee_forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAMM_PMS
{
    public partial class reservation_edit_form : UserControl
    {
        // Variable to serve as reference to employee_search_form
        private main_menu topMenu;

        public reservation_edit_form(main_menu topMenu, int resID)
        {
            this.topMenu = topMenu;
            InitializeComponent();
        }

        private void reservation_edit_form_Load(object sender, EventArgs e)
        {
            reservation_edit_form_textbox_customer.Focus();
            topMenu.changeMainMenuTitle("Manage Reservations");
        }

        private void reservation_edit_form_button_cancel_Click(object sender, EventArgs e)
        {
            Panel parent = (Panel)Parent;
            parent.Controls.Clear();
            parent.Controls.Add(new reservation_search_form(topMenu));
            this.Dispose();
        }
    }
}
