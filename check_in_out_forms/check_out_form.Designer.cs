namespace LAMM_PMS.employee_forms
{
    partial class check_out_form
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
            this.check_out_form_panel_main = new System.Windows.Forms.Panel();
            this.check_out_form_button_cancel = new System.Windows.Forms.Button();
            this.check_out_form_button_submit = new System.Windows.Forms.Button();
            this.check_out_form_combobox_parameter = new System.Windows.Forms.ComboBox();
            this.check_out_form_textbox_lname = new System.Windows.Forms.TextBox();
            this.check_out_form_label_title = new System.Windows.Forms.Label();
            this.check_out_form_dgv_results = new System.Windows.Forms.DataGridView();
            this.check_out_form_panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_out_form_dgv_results)).BeginInit();
            this.SuspendLayout();
            // 
            // check_out_form_panel_main
            // 
            this.check_out_form_panel_main.BackColor = System.Drawing.Color.White;
            this.check_out_form_panel_main.Controls.Add(this.check_out_form_combobox_parameter);
            this.check_out_form_panel_main.Controls.Add(this.check_out_form_textbox_lname);
            this.check_out_form_panel_main.Controls.Add(this.check_out_form_label_title);
            this.check_out_form_panel_main.Controls.Add(this.check_out_form_dgv_results);
            this.check_out_form_panel_main.Controls.Add(this.check_out_form_button_cancel);
            this.check_out_form_panel_main.Controls.Add(this.check_out_form_button_submit);
            this.check_out_form_panel_main.Location = new System.Drawing.Point(0, 0);
            this.check_out_form_panel_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_out_form_panel_main.Name = "check_out_form_panel_main";
            this.check_out_form_panel_main.Size = new System.Drawing.Size(1061, 752);
            this.check_out_form_panel_main.TabIndex = 24;
            // 
            // check_out_form_button_cancel
            // 
            this.check_out_form_button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.check_out_form_button_cancel.FlatAppearance.BorderSize = 0;
            this.check_out_form_button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_out_form_button_cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_out_form_button_cancel.ForeColor = System.Drawing.Color.White;
            this.check_out_form_button_cancel.Location = new System.Drawing.Point(-2, 708);
            this.check_out_form_button_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_out_form_button_cancel.Name = "check_out_form_button_cancel";
            this.check_out_form_button_cancel.Size = new System.Drawing.Size(552, 44);
            this.check_out_form_button_cancel.TabIndex = 29;
            this.check_out_form_button_cancel.Text = "Cancel";
            this.check_out_form_button_cancel.UseVisualStyleBackColor = false;
            this.check_out_form_button_cancel.Click += new System.EventHandler(this.check_out_form_button_cancel_Click);
            // 
            // check_out_form_button_submit
            // 
            this.check_out_form_button_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.check_out_form_button_submit.Enabled = false;
            this.check_out_form_button_submit.FlatAppearance.BorderSize = 0;
            this.check_out_form_button_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_out_form_button_submit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_out_form_button_submit.ForeColor = System.Drawing.Color.White;
            this.check_out_form_button_submit.Location = new System.Drawing.Point(546, 708);
            this.check_out_form_button_submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_out_form_button_submit.Name = "check_out_form_button_submit";
            this.check_out_form_button_submit.Size = new System.Drawing.Size(520, 44);
            this.check_out_form_button_submit.TabIndex = 28;
            this.check_out_form_button_submit.Text = "Check Guest Out";
            this.check_out_form_button_submit.UseVisualStyleBackColor = false;
            this.check_out_form_button_submit.Click += new System.EventHandler(this.check_out_form_button_submit_Click);
            // 
            // check_out_form_combobox_parameter
            // 
            this.check_out_form_combobox_parameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.check_out_form_combobox_parameter.FormattingEnabled = true;
            this.check_out_form_combobox_parameter.Items.AddRange(new object[] {
            "Last Name",
            "Reservation ID"});
            this.check_out_form_combobox_parameter.Location = new System.Drawing.Point(536, 142);
            this.check_out_form_combobox_parameter.Name = "check_out_form_combobox_parameter";
            this.check_out_form_combobox_parameter.Size = new System.Drawing.Size(207, 24);
            this.check_out_form_combobox_parameter.TabIndex = 34;
            // 
            // check_out_form_textbox_lname
            // 
            this.check_out_form_textbox_lname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_out_form_textbox_lname.Location = new System.Drawing.Point(283, 142);
            this.check_out_form_textbox_lname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_out_form_textbox_lname.Name = "check_out_form_textbox_lname";
            this.check_out_form_textbox_lname.Size = new System.Drawing.Size(227, 27);
            this.check_out_form_textbox_lname.TabIndex = 33;
            // 
            // check_out_form_label_title
            // 
            this.check_out_form_label_title.AutoSize = true;
            this.check_out_form_label_title.BackColor = System.Drawing.Color.White;
            this.check_out_form_label_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_out_form_label_title.Location = new System.Drawing.Point(382, 67);
            this.check_out_form_label_title.Name = "check_out_form_label_title";
            this.check_out_form_label_title.Size = new System.Drawing.Size(284, 28);
            this.check_out_form_label_title.TabIndex = 31;
            this.check_out_form_label_title.Text = "Search for Current Reservations";
            // 
            // check_out_form_dgv_results
            // 
            this.check_out_form_dgv_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.check_out_form_dgv_results.Location = new System.Drawing.Point(0, 230);
            this.check_out_form_dgv_results.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_out_form_dgv_results.Name = "check_out_form_dgv_results";
            this.check_out_form_dgv_results.RowHeadersWidth = 51;
            this.check_out_form_dgv_results.RowTemplate.Height = 24;
            this.check_out_form_dgv_results.Size = new System.Drawing.Size(1061, 409);
            this.check_out_form_dgv_results.TabIndex = 32;
            // 
            // check_out_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.check_out_form_panel_main);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "check_out_form";
            this.Size = new System.Drawing.Size(1061, 752);
            this.Load += new System.EventHandler(this.check_out_form_Load);
            this.check_out_form_panel_main.ResumeLayout(false);
            this.check_out_form_panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_out_form_dgv_results)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel check_out_form_panel_main;
        private System.Windows.Forms.Button check_out_form_button_submit;
        private System.Windows.Forms.Button check_out_form_button_cancel;
        private System.Windows.Forms.ComboBox check_out_form_combobox_parameter;
        private System.Windows.Forms.TextBox check_out_form_textbox_lname;
        private System.Windows.Forms.Label check_out_form_label_title;
        private System.Windows.Forms.DataGridView check_out_form_dgv_results;
    }
}
