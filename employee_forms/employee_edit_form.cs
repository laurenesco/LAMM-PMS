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
    public partial class employee_edit_form : UserControl
    {
        // Variable to serve as reference to employee_search_form
        private main_menu topMenu;

        public employee_edit_form(main_menu topMenu, int empID)
        {
            this.topMenu = topMenu;
            InitializeComponent();
        }

        private void employee_edit_form_button_cancel_Click(object sender, EventArgs e)
        {
            Panel parent = (Panel)Parent;
            parent.Controls.Clear();
            parent.Controls.Add(new employee_search_form(topMenu));
        }
    }
}
