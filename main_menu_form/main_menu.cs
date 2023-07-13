using LAMM_PMS.employee_forms;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LAMM_PMS
{
    public partial class main_menu : Form
    {

        public main_menu main_menu_instance;

        // Initialize variable for the button that is currently selected
        private Button selectedButton;

        // Initialize back color variables for all buttons
        private Color originalColor = Color.FromArgb(23, 53, 53);
        private Color selectedColor = Color.FromName("OliveDrab");
        

        public main_menu()
        {
            InitializeComponent();
            selectedButton = main_menu_btn_home;
        }

        public void changeMainMenuTitle(string title)
        {
            this.Text = "LAAM PMS - " + title;
        }

        // Helper Methods
        private void resetButtonColor()
        {

            // Purpose: This method reverts the back color of the currently selected button stored in the selectedButton
            //          variable back to its original color. It is used when the selected button is changed via a user's click. 

            selectedButton.BackColor = originalColor;
        }
        private void clearMainPanelControls()
        {

            // Purpose: This method clears all of the controls of the main panel area in the main_menu_form.
            //          It is used to prepare the main panel area to receive a new set of controls (e.g. a new form)

            main_menu_panel_content_area.Controls.Clear();

        }
        private void setButtonColorToSelectedColor(Button button)
        {
            resetButtonColor();
            button.BackColor = selectedColor;
            selectedButton = button;
        }
        private void setMainContentAreaVisible(bool visible)
        {
            main_menu_panel_content_area.Visible = visible;
        }
        private void addFormToMainContentArea(UserControl form)
        {
            main_menu_panel_content_area.Controls.Add(form);
        }

        // Button Methods
        private void main_menu_btn_home_Click(object sender, EventArgs e)
        {
            setButtonColorToSelectedColor((Button)sender);
            setMainContentAreaVisible(false);
            clearMainPanelControls();
            changeMainMenuTitle("Main Menu");
        }

        private void main_menu_btn_reservations_Click(object sender, EventArgs e)
        {
            setButtonColorToSelectedColor((Button)sender);
        }

        private void main_menu_btn_room_availability_Click(object sender, EventArgs e)
        {
            setButtonColorToSelectedColor((Button)sender);
        }

        private void main_menu_btn_guests_Click(object sender, EventArgs e)
        {
            setButtonColorToSelectedColor((Button)sender);
            clearMainPanelControls();
            addFormToMainContentArea(new guest_search_form(this));
            setMainContentAreaVisible(true);
        }

        private void main_menu_btn_check_in_Click(object sender, EventArgs e)
        {
            setButtonColorToSelectedColor((Button)sender);
        }

        private void main_menu_btn_check_out_Click(object sender, EventArgs e)
        {
            setButtonColorToSelectedColor((Button)sender);
        }

        private void main_menu_btn_administrator_Click(object sender, EventArgs e)
        {
            setButtonColorToSelectedColor((Button)sender);
        }

        private void main_menu_Load(object sender, EventArgs e)
        {
            changeMainMenuTitle("Main Menu");
        }

        private void main_menu_btn_employees_Click(object sender, EventArgs e)
        {
            setButtonColorToSelectedColor((Button)sender);
            clearMainPanelControls();
            addFormToMainContentArea(new employee_search_form(this));
            setMainContentAreaVisible(true);
        }
    }
}