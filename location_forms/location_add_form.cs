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
    public partial class location_add_form : UserControl
    {

        // main_menu        - serve as reference to main menu
        // addingLocation   - serve as a flag if the user is in the middle of adding a location
        private main_menu topMenu;
        private bool addingLocation;

        public location_add_form(main_menu topMenu)
        {
            this.topMenu = topMenu;
            InitializeComponent();
        }

        private void location_add_form_button_cancel_Click(object sender, EventArgs e)
        {
            Panel parent = (Panel)Parent;
            parent.Controls.Clear();
            parent.Controls.Add(new location_search_form(topMenu));
            this.Dispose();
        }

        private void location_add_form_button_add_Click(object sender, EventArgs e)
        {

        }

        private void location_add_form_Load(object sender, EventArgs e)
        {
            location_add_form_combo_name.Focus();
            topMenu.changeMainMenuTitle("Add a New Location");
        }
    }
}
