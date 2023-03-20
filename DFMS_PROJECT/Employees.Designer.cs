namespace DFMS_PROJECT
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.EDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.EGen = new System.Windows.Forms.ComboBox();
            this.EList = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.EAdd = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.EPhon = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.EName = new System.Windows.Forms.TextBox();
            this.EPass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.EList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EDate
            // 
            this.EDate.CustomFormat = "yyyy-MM-dd";
            this.EDate.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.EDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EDate.Location = new System.Drawing.Point(746, 177);
            this.EDate.Margin = new System.Windows.Forms.Padding(4);
            this.EDate.Name = "EDate";
            this.EDate.Size = new System.Drawing.Size(233, 40);
            this.EDate.TabIndex = 53;
            this.EDate.Value = new System.DateTime(2023, 2, 26, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(742, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 28);
            this.label4.TabIndex = 52;
            this.label4.Text = "DOB";
            // 
            // EGen
            // 
            this.EGen.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.EGen.FormattingEnabled = true;
            this.EGen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EGen.Location = new System.Drawing.Point(1064, 178);
            this.EGen.Margin = new System.Windows.Forms.Padding(4);
            this.EGen.Name = "EGen";
            this.EGen.Size = new System.Drawing.Size(228, 40);
            this.EGen.TabIndex = 51;
            // 
            // EList
            // 
            this.EList.AllowUserToAddRows = false;
            this.EList.AllowUserToDeleteRows = false;
            this.EList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EList.Location = new System.Drawing.Point(348, 542);
            this.EList.Margin = new System.Windows.Forms.Padding(4);
            this.EList.Name = "EList";
            this.EList.ReadOnly = true;
            this.EList.RowHeadersWidth = 51;
            this.EList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EList.Size = new System.Drawing.Size(1035, 401);
            this.EList.TabIndex = 50;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(790, 491);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(202, 32);
            this.label19.TabIndex = 49;
            this.label19.Text = "Employees List";
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(1111, 378);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(162, 54);
            this.ClearBtn.TabIndex = 48;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(884, 378);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(162, 54);
            this.DeleteBtn.TabIndex = 47;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(670, 378);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(162, 54);
            this.EditBtn.TabIndex = 46;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(442, 378);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(162, 54);
            this.SaveBtn.TabIndex = 45;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            // 
            // EAdd
            // 
            this.EAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.EAdd.Location = new System.Drawing.Point(748, 300);
            this.EAdd.Margin = new System.Windows.Forms.Padding(4);
            this.EAdd.Name = "EAdd";
            this.EAdd.Size = new System.Drawing.Size(218, 40);
            this.EAdd.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(742, 263);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 28);
            this.label16.TabIndex = 43;
            this.label16.Text = "Address";
            // 
            // EPhon
            // 
            this.EPhon.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.EPhon.Location = new System.Drawing.Point(439, 300);
            this.EPhon.Margin = new System.Windows.Forms.Padding(4);
            this.EPhon.Name = "EPhon";
            this.EPhon.Size = new System.Drawing.Size(218, 40);
            this.EPhon.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(433, 263);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 28);
            this.label17.TabIndex = 41;
            this.label17.Text = "Phone";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(1059, 263);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 28);
            this.label18.TabIndex = 40;
            this.label18.Text = "Password";
            // 
            // EName
            // 
            this.EName.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.EName.Location = new System.Drawing.Point(439, 177);
            this.EName.Margin = new System.Windows.Forms.Padding(4);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(218, 40);
            this.EName.TabIndex = 39;
            // 
            // EPass
            // 
            this.EPass.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.EPass.Location = new System.Drawing.Point(1064, 300);
            this.EPass.Margin = new System.Windows.Forms.Padding(4);
            this.EPass.Name = "EPass";
            this.EPass.Size = new System.Drawing.Size(218, 40);
            this.EPass.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(1059, 140);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 28);
            this.label11.TabIndex = 36;
            this.label11.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(776, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 37);
            this.label3.TabIndex = 35;
            this.label3.Text = "Employees";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(568, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "C F S";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(262, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 42);
            this.panel2.TabIndex = 34;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(65, 836);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(111, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 44);
            this.label2.TabIndex = 7;
            this.label2.Text = "C F S";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(433, 140);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 28);
            this.label12.TabIndex = 38;
            this.label12.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 1055);
            this.panel1.TabIndex = 33;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 1055);
            this.Controls.Add(this.EDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EGen);
            this.Controls.Add(this.EList);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.EAdd);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.EPhon);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.EName);
            this.Controls.Add(this.EPass);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.EList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker EDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EGen;
        private System.Windows.Forms.DataGridView EList;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox EAdd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox EPhon;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox EName;
        private System.Windows.Forms.TextBox EPass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
    }
}