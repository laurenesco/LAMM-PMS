namespace LAMM_PMS.employee_forms
{
    partial class reservation_search_form
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reservation_search_form_panel_main = new System.Windows.Forms.Panel();
            this.reservation_search_form_combobox_parameter = new System.Windows.Forms.ComboBox();
            this.reservation_search_form_button_cancel = new System.Windows.Forms.Button();
            this.reservation_search_form_button_edit_reservation = new System.Windows.Forms.Button();
            this.reservation_search_form_textbox_lname = new System.Windows.Forms.TextBox();
            this.reservation_search_form_button_add = new System.Windows.Forms.Button();
            this.reservation_search_form_label_title = new System.Windows.Forms.Label();
            this.reservation_search_form_dgv_results = new System.Windows.Forms.DataGridView();
            this.reservation_search_form_panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservation_search_form_dgv_results)).BeginInit();
            this.SuspendLayout();
            // 
            // reservation_search_form_panel_main
            // 
            this.reservation_search_form_panel_main.BackColor = System.Drawing.Color.White;
            this.reservation_search_form_panel_main.Controls.Add(this.reservation_search_form_combobox_parameter);
            this.reservation_search_form_panel_main.Controls.Add(this.reservation_search_form_button_cancel);
            this.reservation_search_form_panel_main.Controls.Add(this.reservation_search_form_button_edit_reservation);
            this.reservation_search_form_panel_main.Controls.Add(this.reservation_search_form_textbox_lname);
            this.reservation_search_form_panel_main.Controls.Add(this.reservation_search_form_button_add);
            this.reservation_search_form_panel_main.Controls.Add(this.reservation_search_form_label_title);
            this.reservation_search_form_panel_main.Controls.Add(this.reservation_search_form_dgv_results);
            this.reservation_search_form_panel_main.Location = new System.Drawing.Point(0, 0);
            this.reservation_search_form_panel_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservation_search_form_panel_main.Name = "reservation_search_form_panel_main";
            this.reservation_search_form_panel_main.Size = new System.Drawing.Size(1061, 752);
            this.reservation_search_form_panel_main.TabIndex = 24;
            // 
            // reservation_search_form_combobox_parameter
            // 
            this.reservation_search_form_combobox_parameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reservation_search_form_combobox_parameter.FormattingEnabled = true;
            this.reservation_search_form_combobox_parameter.Items.AddRange(new object[] {
            "Last Name",
            "Reservation ID"});
            this.reservation_search_form_combobox_parameter.Location = new System.Drawing.Point(546, 132);
            this.reservation_search_form_combobox_parameter.Name = "reservation_search_form_combobox_parameter";
            this.reservation_search_form_combobox_parameter.Size = new System.Drawing.Size(207, 24);
            this.reservation_search_form_combobox_parameter.TabIndex = 30;
            // 
            // reservation_search_form_button_cancel
            // 
            this.reservation_search_form_button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.reservation_search_form_button_cancel.FlatAppearance.BorderSize = 0;
            this.reservation_search_form_button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservation_search_form_button_cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation_search_form_button_cancel.ForeColor = System.Drawing.Color.White;
            this.reservation_search_form_button_cancel.Location = new System.Drawing.Point(-2, 708);
            this.reservation_search_form_button_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservation_search_form_button_cancel.Name = "reservation_search_form_button_cancel";
            this.reservation_search_form_button_cancel.Size = new System.Drawing.Size(360, 44);
            this.reservation_search_form_button_cancel.TabIndex = 29;
            this.reservation_search_form_button_cancel.Text = "Cancel";
            this.reservation_search_form_button_cancel.UseVisualStyleBackColor = false;
            this.reservation_search_form_button_cancel.Click += new System.EventHandler(this.reservation_search_form_button_cancel_Click);
            // 
            // reservation_search_form_button_edit_reservation
            // 
            this.reservation_search_form_button_edit_reservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.reservation_search_form_button_edit_reservation.Enabled = false;
            this.reservation_search_form_button_edit_reservation.FlatAppearance.BorderSize = 0;
            this.reservation_search_form_button_edit_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservation_search_form_button_edit_reservation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation_search_form_button_edit_reservation.ForeColor = System.Drawing.Color.White;
            this.reservation_search_form_button_edit_reservation.Location = new System.Drawing.Point(732, 708);
            this.reservation_search_form_button_edit_reservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservation_search_form_button_edit_reservation.Name = "reservation_search_form_button_edit_reservation";
            this.reservation_search_form_button_edit_reservation.Size = new System.Drawing.Size(334, 44);
            this.reservation_search_form_button_edit_reservation.TabIndex = 28;
            this.reservation_search_form_button_edit_reservation.Text = "Edit Reservation";
            this.reservation_search_form_button_edit_reservation.UseVisualStyleBackColor = false;
            this.reservation_search_form_button_edit_reservation.Click += new System.EventHandler(this.reservation_search_form_button_edit_reservation_Click);
            // 
            // reservation_search_form_textbox_lname
            // 
            this.reservation_search_form_textbox_lname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation_search_form_textbox_lname.Location = new System.Drawing.Point(293, 132);
            this.reservation_search_form_textbox_lname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservation_search_form_textbox_lname.Name = "reservation_search_form_textbox_lname";
            this.reservation_search_form_textbox_lname.Size = new System.Drawing.Size(227, 27);
            this.reservation_search_form_textbox_lname.TabIndex = 27;
            // 
            // reservation_search_form_button_add
            // 
            this.reservation_search_form_button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.reservation_search_form_button_add.FlatAppearance.BorderSize = 0;
            this.reservation_search_form_button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservation_search_form_button_add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation_search_form_button_add.ForeColor = System.Drawing.Color.White;
            this.reservation_search_form_button_add.Location = new System.Drawing.Point(357, 708);
            this.reservation_search_form_button_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservation_search_form_button_add.Name = "reservation_search_form_button_add";
            this.reservation_search_form_button_add.Size = new System.Drawing.Size(376, 44);
            this.reservation_search_form_button_add.TabIndex = 26;
            this.reservation_search_form_button_add.Text = "Add Reservation";
            this.reservation_search_form_button_add.UseVisualStyleBackColor = false;
            this.reservation_search_form_button_add.Click += new System.EventHandler(this.reservation_search_form_button_add_Click);
            // 
            // reservation_search_form_label_title
            // 
            this.reservation_search_form_label_title.AutoSize = true;
            this.reservation_search_form_label_title.BackColor = System.Drawing.Color.White;
            this.reservation_search_form_label_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation_search_form_label_title.Location = new System.Drawing.Point(433, 48);
            this.reservation_search_form_label_title.Name = "reservation_search_form_label_title";
            this.reservation_search_form_label_title.Size = new System.Drawing.Size(176, 28);
            this.reservation_search_form_label_title.TabIndex = 14;
            this.reservation_search_form_label_title.Text = "Reservation Search";
            // 
            // reservation_search_form_dgv_results
            // 
            this.reservation_search_form_dgv_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservation_search_form_dgv_results.Location = new System.Drawing.Point(0, 205);
            this.reservation_search_form_dgv_results.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservation_search_form_dgv_results.Name = "reservation_search_form_dgv_results";
            this.reservation_search_form_dgv_results.RowHeadersWidth = 51;
            this.reservation_search_form_dgv_results.RowTemplate.Height = 24;
            this.reservation_search_form_dgv_results.Size = new System.Drawing.Size(1061, 409);
            this.reservation_search_form_dgv_results.TabIndex = 15;
            // 
            // reservation_search_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reservation_search_form_panel_main);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "reservation_search_form";
            this.Size = new System.Drawing.Size(1061, 752);
            this.Load += new System.EventHandler(this.reservation_search_form_Load);
            this.reservation_search_form_panel_main.ResumeLayout(false);
            this.reservation_search_form_panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservation_search_form_dgv_results)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel reservation_search_form_panel_main;
        private System.Windows.Forms.Button reservation_search_form_button_add;
        private System.Windows.Forms.DataGridView reservation_search_form_dgv_results;
        private System.Windows.Forms.Label reservation_search_form_label_title;
        private System.Windows.Forms.TextBox reservation_search_form_textbox_lname;
        private System.Windows.Forms.Button reservation_search_form_button_edit_reservation;
        private System.Windows.Forms.Button reservation_search_form_button_cancel;
        private System.Windows.Forms.ComboBox reservation_search_form_combobox_parameter;
    }
}
