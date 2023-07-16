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
    public partial class location_form : UserControl
    {

        // main_menu        - serve as reference to main menu
        // addingLocation   - serve as a flag if the user is in the middle of adding a location
        private main_menu topMenu;
        private bool addingLocation;

        public location_form(main_menu topMenu)
        {
            this.topMenu = topMenu;
            InitializeComponent();
        }

        private void location_form_Load(object sender, EventArgs e)
        {
            location_form_combo_name.Focus();
            topMenu.changeMainMenuTitle("Location Management");
        }

        private void location_form_button_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            topMenu.resetForm();
        }

        private void location_form_button_add_Click(object sender, EventArgs e)
        {
            if (addingLocation)
            {
                AddMode(false);

                // Submit add code goes here, including validations
            }
            else
            {
                AddMode(true);
            }
        }

        // Toggles the enabled status of the fields on the form
        private void ToggleFields(bool toggle)
        {
            location_form_textbox_open_hour.Enabled = toggle;
            location_form_textbox_close_hour.Enabled = toggle;
            location_form_combobox_supervisor.Enabled = toggle;
            location_form_textbox_rooms.Enabled = toggle;
            location_form_textbox_phone.Enabled = toggle;
            location_form_textbox_address.Enabled = toggle;
        }

        private void AddMode(bool toggle)
        {
            if (toggle)
            {
                addingLocation = true;
                location_form_button_add.Text = "Submit";
                location_form_button_cancel.Text = "Cancel Add";
                ToggleFields(true);
            } else {
                addingLocation = false;
                location_form_button_add.Text = "Add a New Location";
                location_form_button_cancel.Text = "Cancel";
                ToggleFields(false);
            }
        }
    }
}
