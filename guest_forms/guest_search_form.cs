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

namespace LAMM_PMS
{
    public partial class guest_search_form : UserControl
    {

        // Variable to serve as reference to main menu
        private main_menu topMenu;

        public guest_search_form(main_menu topMenu)
        {
            this.topMenu = topMenu;
            InitializeComponent();
        }

        private void guest_search_form_Load(object sender, EventArgs e)
        {
            guest_search_form_textbox_last_name.Focus();
            topMenu.changeMainMenuTitle("Guest Search");
        }

        private void guest_search_form_btn_manage_customers_Click(object sender, EventArgs e)
        {
            Panel parent = (Panel) Parent;
            parent.Controls.Clear();
            parent.Controls.Add(new guest_add_form(topMenu));
        }
    }
}
