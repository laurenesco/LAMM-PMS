using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LAMM_PMS
{
    public partial class main_menu : Form
    {
        
        // Initialize variable for the button that is currently selected
        private Button selectedButton;

        // Initialize back color variables for all buttons
        private Color  originalColor = Color.FromArgb(23, 53, 53);
        private Color selectedColor = Color.FromName("OliveDrab");

        public main_menu()
        {
            InitializeComponent();
            selectedButton = main_menu_btn_home;
        }

        private void resetButtonColor() {
            selectedButton.BackColor = originalColor;
        }


        private void setButtonColorToSelectedColor(Button button)
        {
            resetButtonColor();
            button.BackColor = selectedColor;
            selectedButton = button;
        }

        private void main_menu_btn_home_Click(object sender, EventArgs e)
        {
            setButtonColorToSelectedColor((Button)sender);
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
    }
}