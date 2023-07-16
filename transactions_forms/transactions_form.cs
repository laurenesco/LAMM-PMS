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
    public partial class transactions_form : UserControl
    {
        // Variable to serve as reference to main_menu
        private main_menu topMenu;

        public transactions_form(main_menu topMenu)
        {
            this.topMenu = topMenu;
            InitializeComponent();
        }

        private void transactions_form_button_cancel_Click(object sender, EventArgs e)
        {
            topMenu.resetForm();
        }
    }
}
