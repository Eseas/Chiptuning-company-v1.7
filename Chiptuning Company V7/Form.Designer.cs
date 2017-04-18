namespace Chiptuning_Company_V7
{
    partial class Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SQL_select_button = new System.Windows.Forms.Button();
            this.SQL_insert_button = new System.Windows.Forms.Button();
            this.SQL_update_button = new System.Windows.Forms.Button();
            this.SQL_delete_button = new System.Windows.Forms.Button();
            this.EF_select_button = new System.Windows.Forms.Button();
            this.EF_insert_button = new System.Windows.Forms.Button();
            this.EF_update_button = new System.Windows.Forms.Button();
            this.EF_delete_button = new System.Windows.Forms.Button();
            this.Join_customer_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Select_box = new System.Windows.Forms.TextBox();
            this.Vin_box = new System.Windows.Forms.TextBox();
            this.Make_box = new System.Windows.Forms.TextBox();
            this.Model_box = new System.Windows.Forms.TextBox();
            this.Year_box = new System.Windows.Forms.TextBox();
            this.Displacement_box = new System.Windows.Forms.TextBox();
            this.Fuel_box = new System.Windows.Forms.TextBox();
            this.Power_box = new System.Windows.Forms.TextBox();
            this.Delete_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(72, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(761, 209);
            this.dataGridView.TabIndex = 0;
            // 
            // SQL_select_button
            // 
            this.SQL_select_button.Location = new System.Drawing.Point(700, 269);
            this.SQL_select_button.Name = "SQL_select_button";
            this.SQL_select_button.Size = new System.Drawing.Size(75, 23);
            this.SQL_select_button.TabIndex = 1;
            this.SQL_select_button.Text = "Select";
            this.SQL_select_button.UseVisualStyleBackColor = true;
            this.SQL_select_button.Click += new System.EventHandler(this.SQL_select_button_Click);
            // 
            // SQL_insert_button
            // 
            this.SQL_insert_button.Location = new System.Drawing.Point(700, 298);
            this.SQL_insert_button.Name = "SQL_insert_button";
            this.SQL_insert_button.Size = new System.Drawing.Size(75, 23);
            this.SQL_insert_button.TabIndex = 2;
            this.SQL_insert_button.Text = "Insert";
            this.SQL_insert_button.UseVisualStyleBackColor = true;
            this.SQL_insert_button.Click += new System.EventHandler(this.SQL_insert_button_Click);
            // 
            // SQL_update_button
            // 
            this.SQL_update_button.Location = new System.Drawing.Point(700, 327);
            this.SQL_update_button.Name = "SQL_update_button";
            this.SQL_update_button.Size = new System.Drawing.Size(75, 23);
            this.SQL_update_button.TabIndex = 3;
            this.SQL_update_button.Text = "Update";
            this.SQL_update_button.UseVisualStyleBackColor = true;
            this.SQL_update_button.Click += new System.EventHandler(this.SQL_update_button_Click);
            // 
            // SQL_delete_button
            // 
            this.SQL_delete_button.Location = new System.Drawing.Point(700, 356);
            this.SQL_delete_button.Name = "SQL_delete_button";
            this.SQL_delete_button.Size = new System.Drawing.Size(75, 23);
            this.SQL_delete_button.TabIndex = 4;
            this.SQL_delete_button.Text = "Delete";
            this.SQL_delete_button.UseVisualStyleBackColor = true;
            this.SQL_delete_button.Click += new System.EventHandler(this.SQL_delete_button_Click);
            // 
            // EF_select_button
            // 
            this.EF_select_button.Location = new System.Drawing.Point(793, 269);
            this.EF_select_button.Name = "EF_select_button";
            this.EF_select_button.Size = new System.Drawing.Size(75, 23);
            this.EF_select_button.TabIndex = 5;
            this.EF_select_button.Text = "Select";
            this.EF_select_button.UseVisualStyleBackColor = true;
            this.EF_select_button.Click += new System.EventHandler(this.EF_select_button_Click);
            // 
            // EF_insert_button
            // 
            this.EF_insert_button.Location = new System.Drawing.Point(793, 298);
            this.EF_insert_button.Name = "EF_insert_button";
            this.EF_insert_button.Size = new System.Drawing.Size(75, 23);
            this.EF_insert_button.TabIndex = 6;
            this.EF_insert_button.Text = "Insert";
            this.EF_insert_button.UseVisualStyleBackColor = true;
            this.EF_insert_button.Click += new System.EventHandler(this.EF_insert_button_Click);
            // 
            // EF_update_button
            // 
            this.EF_update_button.Location = new System.Drawing.Point(793, 327);
            this.EF_update_button.Name = "EF_update_button";
            this.EF_update_button.Size = new System.Drawing.Size(75, 23);
            this.EF_update_button.TabIndex = 7;
            this.EF_update_button.Text = "Update";
            this.EF_update_button.UseVisualStyleBackColor = true;
            this.EF_update_button.Click += new System.EventHandler(this.EF_update_button_Click);
            // 
            // EF_delete_button
            // 
            this.EF_delete_button.Location = new System.Drawing.Point(793, 356);
            this.EF_delete_button.Name = "EF_delete_button";
            this.EF_delete_button.Size = new System.Drawing.Size(75, 23);
            this.EF_delete_button.TabIndex = 8;
            this.EF_delete_button.Text = "Delete";
            this.EF_delete_button.UseVisualStyleBackColor = true;
            this.EF_delete_button.Click += new System.EventHandler(this.EF_delete_button_Click);
            // 
            // Join_customer_button
            // 
            this.Join_customer_button.Location = new System.Drawing.Point(72, 227);
            this.Join_customer_button.Name = "Join_customer_button";
            this.Join_customer_button.Size = new System.Drawing.Size(89, 23);
            this.Join_customer_button.TabIndex = 9;
            this.Join_customer_button.Text = "Join customer";
            this.Join_customer_button.UseVisualStyleBackColor = true;
            this.Join_customer_button.Click += new System.EventHandler(this.Join_customer_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(167, 227);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(75, 23);
            this.Back_button.TabIndex = 10;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(723, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "SQL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(818, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "EF";
            // 
            // Select_box
            // 
            this.Select_box.Location = new System.Drawing.Point(581, 271);
            this.Select_box.Name = "Select_box";
            this.Select_box.Size = new System.Drawing.Size(100, 20);
            this.Select_box.TabIndex = 13;
            // 
            // Vin_box
            // 
            this.Vin_box.Location = new System.Drawing.Point(28, 317);
            this.Vin_box.Name = "Vin_box";
            this.Vin_box.Size = new System.Drawing.Size(100, 20);
            this.Vin_box.TabIndex = 14;
            // 
            // Make_box
            // 
            this.Make_box.Location = new System.Drawing.Point(134, 317);
            this.Make_box.Name = "Make_box";
            this.Make_box.Size = new System.Drawing.Size(100, 20);
            this.Make_box.TabIndex = 15;
            // 
            // Model_box
            // 
            this.Model_box.Location = new System.Drawing.Point(240, 317);
            this.Model_box.Name = "Model_box";
            this.Model_box.Size = new System.Drawing.Size(100, 20);
            this.Model_box.TabIndex = 16;
            // 
            // Year_box
            // 
            this.Year_box.Location = new System.Drawing.Point(346, 317);
            this.Year_box.Name = "Year_box";
            this.Year_box.Size = new System.Drawing.Size(64, 20);
            this.Year_box.TabIndex = 17;
            // 
            // Displacement_box
            // 
            this.Displacement_box.Location = new System.Drawing.Point(416, 317);
            this.Displacement_box.Name = "Displacement_box";
            this.Displacement_box.Size = new System.Drawing.Size(86, 20);
            this.Displacement_box.TabIndex = 18;
            // 
            // Fuel_box
            // 
            this.Fuel_box.Location = new System.Drawing.Point(508, 317);
            this.Fuel_box.Name = "Fuel_box";
            this.Fuel_box.Size = new System.Drawing.Size(100, 20);
            this.Fuel_box.TabIndex = 19;
            // 
            // Power_box
            // 
            this.Power_box.Location = new System.Drawing.Point(614, 317);
            this.Power_box.Name = "Power_box";
            this.Power_box.Size = new System.Drawing.Size(67, 20);
            this.Power_box.TabIndex = 20;
            // 
            // Delete_box
            // 
            this.Delete_box.Location = new System.Drawing.Point(581, 359);
            this.Delete_box.Name = "Delete_box";
            this.Delete_box.Size = new System.Drawing.Size(100, 20);
            this.Delete_box.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(69, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Vin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(166, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Make";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(270, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(361, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(422, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Displacement";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(541, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Fuel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(625, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Power";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(541, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Make";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(553, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Vin";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chiptuning_Company_V7.Properties.Resources.image6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 429);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Delete_box);
            this.Controls.Add(this.Power_box);
            this.Controls.Add(this.Fuel_box);
            this.Controls.Add(this.Displacement_box);
            this.Controls.Add(this.Year_box);
            this.Controls.Add(this.Model_box);
            this.Controls.Add(this.Make_box);
            this.Controls.Add(this.Vin_box);
            this.Controls.Add(this.Select_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Join_customer_button);
            this.Controls.Add(this.EF_delete_button);
            this.Controls.Add(this.EF_update_button);
            this.Controls.Add(this.EF_insert_button);
            this.Controls.Add(this.EF_select_button);
            this.Controls.Add(this.SQL_delete_button);
            this.Controls.Add(this.SQL_update_button);
            this.Controls.Add(this.SQL_insert_button);
            this.Controls.Add(this.SQL_select_button);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOCPAT® Database";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button SQL_select_button;
        private System.Windows.Forms.Button SQL_insert_button;
        private System.Windows.Forms.Button SQL_update_button;
        private System.Windows.Forms.Button SQL_delete_button;
        private System.Windows.Forms.Button EF_select_button;
        private System.Windows.Forms.Button EF_insert_button;
        private System.Windows.Forms.Button EF_update_button;
        private System.Windows.Forms.Button EF_delete_button;
        private System.Windows.Forms.Button Join_customer_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Select_box;
        private System.Windows.Forms.TextBox Vin_box;
        private System.Windows.Forms.TextBox Make_box;
        private System.Windows.Forms.TextBox Model_box;
        private System.Windows.Forms.TextBox Year_box;
        private System.Windows.Forms.TextBox Displacement_box;
        private System.Windows.Forms.TextBox Fuel_box;
        private System.Windows.Forms.TextBox Power_box;
        private System.Windows.Forms.TextBox Delete_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

