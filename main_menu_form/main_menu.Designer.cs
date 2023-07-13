using System.Windows.Forms;

namespace LAMM_PMS
{
    partial class main_menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_menu));
            this.main_menu_panel_navigation_menu = new System.Windows.Forms.Panel();
            this.main_menu_btn_logout = new System.Windows.Forms.Button();
            this.main_menu_panel_administrator_menu = new System.Windows.Forms.Panel();
            this.main_menu_btn_employees = new System.Windows.Forms.Button();
            this.main_menu_btn_administrator = new System.Windows.Forms.Button();
            this.main_menu_btn_check_out = new System.Windows.Forms.Button();
            this.main_menu_btn_check_in = new System.Windows.Forms.Button();
            this.main_menu_btn_guests = new System.Windows.Forms.Button();
            this.main_menu_btn_room_availability = new System.Windows.Forms.Button();
            this.main_menu_btn_reservations = new System.Windows.Forms.Button();
            this.main_menu_btn_home = new System.Windows.Forms.Button();
            this.main_menu_panel_top_left_spacer = new System.Windows.Forms.Panel();
            this.main_menu_panel_content_area = new System.Windows.Forms.Panel();
            this.main_menu_panel_top_right_spacer = new System.Windows.Forms.Panel();
            this.main_menu_panel_main_center_area = new System.Windows.Forms.Panel();
            this.main_menu_button_locations = new System.Windows.Forms.Button();
            this.main_menu_panel_navigation_menu.SuspendLayout();
            this.main_menu_panel_administrator_menu.SuspendLayout();
            this.main_menu_panel_main_center_area.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menu_panel_navigation_menu
            // 
            this.main_menu_panel_navigation_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.main_menu_panel_navigation_menu.Controls.Add(this.main_menu_btn_logout);
            this.main_menu_panel_navigation_menu.Controls.Add(this.main_menu_panel_administrator_menu);
            this.main_menu_panel_navigation_menu.Controls.Add(this.main_menu_btn_check_out);
            this.main_menu_panel_navigation_menu.Controls.Add(this.main_menu_btn_check_in);
            this.main_menu_panel_navigation_menu.Controls.Add(this.main_menu_btn_guests);
            this.main_menu_panel_navigation_menu.Controls.Add(this.main_menu_btn_room_availability);
            this.main_menu_panel_navigation_menu.Controls.Add(this.main_menu_btn_reservations);
            this.main_menu_panel_navigation_menu.Controls.Add(this.main_menu_btn_home);
            this.main_menu_panel_navigation_menu.Controls.Add(this.main_menu_panel_top_left_spacer);
            this.main_menu_panel_navigation_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.main_menu_panel_navigation_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu_panel_navigation_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main_menu_panel_navigation_menu.Name = "main_menu_panel_navigation_menu";
            this.main_menu_panel_navigation_menu.Size = new System.Drawing.Size(251, 814);
            this.main_menu_panel_navigation_menu.TabIndex = 0;
            // 
            // main_menu_btn_logout
            // 
            this.main_menu_btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.main_menu_btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_menu_btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.main_menu_btn_logout.FlatAppearance.BorderSize = 0;
            this.main_menu_btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_menu_btn_logout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.main_menu_btn_logout.ForeColor = System.Drawing.Color.White;
            this.main_menu_btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.main_menu_btn_logout.Location = new System.Drawing.Point(0, 754);
            this.main_menu_btn_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main_menu_btn_logout.Name = "main_menu_btn_logout";
            this.main_menu_btn_logout.Size = new System.Drawing.Size(251, 60);
            this.main_menu_btn_logout.TabIndex = 7;
            this.main_menu_btn_logout.Text = "Logout";
            this.main_menu_btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.main_menu_btn_logout.UseVisualStyleBackColor = false;
            // 
            // main_menu_panel_administrator_menu
            // 
            this.main_menu_panel_administrator_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.main_menu_panel_administrator_menu.Controls.Add(this.main_menu_button_locations);
            this.main_menu_panel_administrator_menu.Controls.Add(this.main_menu_btn_employees);
            this.main_menu_panel_administrator_menu.Controls.Add(this.main_menu_btn_administrator);
            this.main_menu_panel_administrator_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_menu_panel_administrator_menu.Location = new System.Drawing.Point(0, 422);
            this.main_menu_panel_administrator_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main_menu_panel_administrator_menu.Name = "main_menu_panel_administrator_menu";
            this.main_menu_panel_administrator_menu.Size = new System.Drawing.Size(251, 195);
            this.main_menu_panel_administrator_menu.TabIndex = 6;
            // 
            // main_menu_btn_employees
            // 
            this.main_menu_btn_employees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.main_menu_btn_employees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_menu_btn_employees.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_menu_btn_employees.FlatAppearance.BorderSize = 0;
            this.main_menu_btn_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_menu_btn_employees.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.main_menu_btn_employees.ForeColor = System.Drawing.Color.White;
            this.main_menu_btn_employees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.main_menu_btn_employees.Location = new System.Drawing.Point(0, 60);
            this.main_menu_btn_employees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main_menu_btn_employees.Name = "main_menu_btn_employees";
            this.main_menu_btn_employees.Size = new System.Drawing.Size(251, 60);
            this.main_menu_btn_employees.TabIndex = 7;
            this.main_menu_btn_employees.Text = "Employees";
            this.main_menu_btn_employees.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.main_menu_btn_employees.UseVisualStyleBackColor = false;
            this.main_menu_btn_employees.Click += new System.EventHandler(this.main_menu_btn_employees_Click);
            // 
            // main_menu_btn_administrator
            // 
            this.main_menu_btn_administrator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.main_menu_btn_administrator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_menu_btn_administrator.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_menu_btn_administrator.FlatAppearance.BorderSize = 0;
            this.main_menu_btn_administrator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_menu_btn_administrator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.main_menu_btn_administrator.ForeColor = System.Drawing.Color.White;
            this.main_menu_btn_administrator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.main_menu_btn_administrator.Location = new System.Drawing.Point(0, 0);
            this.main_menu_btn_administrator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main_menu_btn_administrator.Name = "main_menu_btn_administrator";
            this.main_menu_btn_administrator.Size = new System.Drawing.Size(251, 60);
            this.main_menu_btn_administrator.TabIndex = 6;
            this.main_menu_btn_administrator.Text = "Administrator";
            this.main_menu_btn_administrator.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.main_menu_btn_administrator.UseVisualStyleBackColor = false;
            this.main_menu_btn_administrator.Click += new System.EventHandler(this.main_menu_btn_administrator_Click);
            // 
            // main_menu_btn_check_out
            // 
            this.main_menu_btn_check_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.main_menu_btn_check_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_menu_btn_check_out.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_menu_btn_check_out.FlatAppearance.BorderSize = 0;
            this.main_menu_btn_check_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_menu_btn_check_out.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.main_menu_btn_check_out.ForeColor = System.Drawing.Color.White;
            this.main_menu_btn_check_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.main_menu_btn_check_out.Location = new System.Drawing.Point(0, 362);
            this.main_menu_btn_check_out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main_menu_btn_check_out.Name = "main_menu_btn_check_out";
            this.main_menu_btn_check_out.Size = new System.Drawing.Size(251, 60);
            this.main_menu_btn_check_out.TabIndex = 5;
            this.main_menu_btn_check_out.Text = "Check-Out";
            this.main_menu_btn_check_out.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.main_menu_btn_check_out.UseVisualStyleBackColor = false;
            this.main_menu_btn_check_out.Click += new System.EventHandler(this.main_menu_btn_check_out_Click);
            // 
            // main_menu_btn_check_in
            // 
            this.main_menu_btn_check_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.main_menu_btn_check_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_menu_btn_check_in.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_menu_btn_check_in.FlatAppearance.BorderSize = 0;
            this.main_menu_btn_check_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_menu_btn_check_in.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.main_menu_btn_check_in.ForeColor = System.Drawing.Color.White;
            this.main_menu_btn_check_in.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.main_menu_btn_check_in.Location = new System.Drawing.Point(0, 302);
            this.main_menu_btn_check_in.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main_menu_btn_check_in.Name = "main_menu_btn_check_in";
            this.main_menu_btn_check_in.Size = new System.Drawing.Size(251, 60);
            this.main_menu_btn_check_in.TabIndex = 4;
            this.main_menu_btn_check_in.Text = "Check-In";
            this.main_menu_btn_check_in.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.main_menu_btn_check_in.UseVisualStyleBackColor = false;
            this.main_menu_btn_check_in.Click += new System.EventHandler(this.main_menu_btn_check_in_Click);
            // 
            // main_menu_btn_guests
            // 
            this.main_menu_btn_guests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.main_menu_btn_guests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_menu_btn_guests.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_menu_btn_guests.FlatAppearance.BorderSize = 0;
            this.main_menu_btn_guests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_menu_btn_guests.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.main_menu_btn_guests.ForeColor = System.Drawing.Color.White;
            this.main_menu_btn_guests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.main_menu_btn_guests.Location = new System.Drawing.Point(0, 242);
            this.main_menu_btn_guests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main_menu_btn_guests.Name = "main_menu_btn_guests";
            this.main_menu_btn_guests.Size = new System.Drawing.Size(251, 60);
            this.main_menu_btn_guests.TabIndex = 3;
            this.main_menu_btn_guests.Text = "Guests";
            this.main_menu_btn_guests.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.main_menu_btn_guests.UseVisualStyleBackColor = false;
            this.main_menu_btn_guests.Click += new System.EventHandler(this.main_menu_btn_guests_Click);
            // 
            // main_menu_btn_room_availability
            // 
            this.main_menu_btn_room_availability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.main_menu_btn_room_availability.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_menu_btn_room_availability.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_menu_btn_room_availability.FlatAppearance.BorderSize = 0;
            this.main_menu_btn_room_availability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_menu_btn_room_availability.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.main_menu_btn_room_availability.ForeColor = System.Drawing.Color.White;
            this.main_menu_btn_room_availability.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.main_menu_btn_room_availability.Location = new System.Drawing.Point(0, 182);
            this.main_menu_btn_room_availability.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main_menu_btn_room_availability.Name = "main_menu_btn_room_availability";
            this.main_menu_btn_room_availability.Size = new System.Drawing.Size(251, 60);
            this.main_menu_btn_room_availability.TabIndex = 2;
            this.main_menu_btn_room_availability.Text = "Room Availability";
            this.main_menu_btn_room_availability.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.main_menu_btn_room_availability.UseVisualStyleBackColor = false;
            this.main_menu_btn_room_availability.Click += new System.EventHandler(this.main_menu_btn_room_availability_Click);
            // 
            // main_menu_btn_reservations
            // 
            this.main_menu_btn_reservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.main_menu_btn_reservations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_menu_btn_reservations.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_menu_btn_reservations.FlatAppearance.BorderSize = 0;
            this.main_menu_btn_reservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_menu_btn_reservations.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.main_menu_btn_reservations.ForeColor = System.Drawing.Color.White;
            this.main_menu_btn_reservations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.main_menu_btn_reservations.Location = new System.Drawing.Point(0, 122);
            this.main_menu_btn_reservations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main_menu_btn_reservations.Name = "main_menu_btn_reservations";
            this.main_menu_btn_reservations.Size = new System.Drawing.Size(251, 60);
            this.main_menu_btn_reservations.TabIndex = 1;
            this.main_menu_btn_reservations.Text = "Reservations";
            this.main_menu_btn_reservations.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.main_menu_btn_reservations.UseVisualStyleBackColor = false;
            this.main_menu_btn_reservations.Click += new System.EventHandler(this.main_menu_btn_reservations_Click);
            // 
            // main_menu_btn_home
            // 
            this.main_menu_btn_home.BackColor = System.Drawing.Color.OliveDrab;
            this.main_menu_btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_menu_btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_menu_btn_home.FlatAppearance.BorderSize = 0;
            this.main_menu_btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_menu_btn_home.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.main_menu_btn_home.ForeColor = System.Drawing.Color.White;
            this.main_menu_btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.main_menu_btn_home.Location = new System.Drawing.Point(0, 62);
            this.main_menu_btn_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main_menu_btn_home.Name = "main_menu_btn_home";
            this.main_menu_btn_home.Size = new System.Drawing.Size(251, 60);
            this.main_menu_btn_home.TabIndex = 8;
            this.main_menu_btn_home.Text = "Home";
            this.main_menu_btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.main_menu_btn_home.UseVisualStyleBackColor = false;
            this.main_menu_btn_home.Click += new System.EventHandler(this.main_menu_btn_home_Click);
            // 
            // main_menu_panel_top_left_spacer
            // 
            this.main_menu_panel_top_left_spacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.main_menu_panel_top_left_spacer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main_menu_panel_top_left_spacer.BackgroundImage")));
            this.main_menu_panel_top_left_spacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.main_menu_panel_top_left_spacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_menu_panel_top_left_spacer.Location = new System.Drawing.Point(0, 0);
            this.main_menu_panel_top_left_spacer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main_menu_panel_top_left_spacer.Name = "main_menu_panel_top_left_spacer";
            this.main_menu_panel_top_left_spacer.Size = new System.Drawing.Size(251, 62);
            this.main_menu_panel_top_left_spacer.TabIndex = 0;
            // 
            // main_menu_panel_content_area
            // 
            this.main_menu_panel_content_area.BackColor = System.Drawing.Color.White;
            this.main_menu_panel_content_area.Location = new System.Drawing.Point(0, 0);
            this.main_menu_panel_content_area.Margin = new System.Windows.Forms.Padding(4);
            this.main_menu_panel_content_area.Name = "main_menu_panel_content_area";
            this.main_menu_panel_content_area.Size = new System.Drawing.Size(1061, 752);
            this.main_menu_panel_content_area.TabIndex = 0;
            this.main_menu_panel_content_area.Visible = false;
            // 
            // main_menu_panel_top_right_spacer
            // 
            this.main_menu_panel_top_right_spacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.main_menu_panel_top_right_spacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_menu_panel_top_right_spacer.Location = new System.Drawing.Point(251, 0);
            this.main_menu_panel_top_right_spacer.Margin = new System.Windows.Forms.Padding(4);
            this.main_menu_panel_top_right_spacer.Name = "main_menu_panel_top_right_spacer";
            this.main_menu_panel_top_right_spacer.Size = new System.Drawing.Size(1061, 62);
            this.main_menu_panel_top_right_spacer.TabIndex = 0;
            // 
            // main_menu_panel_main_center_area
            // 
            this.main_menu_panel_main_center_area.BackColor = System.Drawing.Color.Transparent;
            this.main_menu_panel_main_center_area.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main_menu_panel_main_center_area.BackgroundImage")));
            this.main_menu_panel_main_center_area.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.main_menu_panel_main_center_area.Controls.Add(this.main_menu_panel_content_area);
            this.main_menu_panel_main_center_area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_menu_panel_main_center_area.Location = new System.Drawing.Point(251, 62);
            this.main_menu_panel_main_center_area.Margin = new System.Windows.Forms.Padding(4);
            this.main_menu_panel_main_center_area.Name = "main_menu_panel_main_center_area";
            this.main_menu_panel_main_center_area.Size = new System.Drawing.Size(1061, 752);
            this.main_menu_panel_main_center_area.TabIndex = 4;
            // 
            // main_menu_button_locations
            // 
            this.main_menu_button_locations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.main_menu_button_locations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_menu_button_locations.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_menu_button_locations.FlatAppearance.BorderSize = 0;
            this.main_menu_button_locations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_menu_button_locations.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.main_menu_button_locations.ForeColor = System.Drawing.Color.White;
            this.main_menu_button_locations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.main_menu_button_locations.Location = new System.Drawing.Point(0, 120);
            this.main_menu_button_locations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main_menu_button_locations.Name = "main_menu_button_locations";
            this.main_menu_button_locations.Size = new System.Drawing.Size(251, 60);
            this.main_menu_button_locations.TabIndex = 8;
            this.main_menu_button_locations.Text = "Locations";
            this.main_menu_button_locations.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.main_menu_button_locations.UseVisualStyleBackColor = false;
            this.main_menu_button_locations.Click += new System.EventHandler(this.main_menu_button_locations_Click);
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 814);
            this.Controls.Add(this.main_menu_panel_main_center_area);
            this.Controls.Add(this.main_menu_panel_top_right_spacer);
            this.Controls.Add(this.main_menu_panel_navigation_menu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1327, 851);
            this.Name = "main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAAM PMS - Main Menu";
            this.main_menu_panel_navigation_menu.ResumeLayout(false);
            this.main_menu_panel_administrator_menu.ResumeLayout(false);
            this.main_menu_panel_main_center_area.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel main_menu_panel_navigation_menu;
        private Panel main_menu_panel_top_left_spacer;
        private Button main_menu_btn_check_out;
        private Button main_menu_btn_check_in;
        private Button main_menu_btn_guests;
        private Button main_menu_btn_room_availability;
        private Button main_menu_btn_reservations;
        private Button main_menu_btn_logout;
        private Panel main_menu_panel_administrator_menu;
        private Panel main_menu_panel_top_right_spacer;
        private Button main_menu_btn_administrator;
        private Button main_menu_btn_home;
        private Panel main_menu_panel_main_center_area;
        private Panel main_menu_panel_content_area;
        private Button main_menu_btn_employees;
        private Button main_menu_button_locations;
    }
}