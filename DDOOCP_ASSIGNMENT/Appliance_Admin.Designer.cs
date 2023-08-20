namespace DDOOCP_ASSIGNMENT
{
    partial class ApplianceAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplianceAdmin));
            this.ApplianceList = new System.Windows.Forms.ListBox();
            this.Type_Txt = new System.Windows.Forms.TextBox();
            this.Brand_Txt = new System.Windows.Forms.TextBox();
            this.Model_Txt = new System.Windows.Forms.TextBox();
            this.Dimensions_Txt = new System.Windows.Forms.TextBox();
            this.Colour_Txt = new System.Windows.Forms.TextBox();
            this.Energy_Txt = new System.Windows.Forms.TextBox();
            this.Fee_Txt = new System.Windows.Forms.TextBox();
            this.AddBTN = new System.Windows.Forms.Button();
            this.EditBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.Type_Lbl = new System.Windows.Forms.Label();
            this.Brand_LBL = new System.Windows.Forms.Label();
            this.Energy_LBL = new System.Windows.Forms.Label();
            this.Colour_LBL = new System.Windows.Forms.Label();
            this.Dimensions_LBL = new System.Windows.Forms.Label();
            this.Model_LBL = new System.Windows.Forms.Label();
            this.Fee_LBL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplianceList
            // 
            this.ApplianceList.FormattingEnabled = true;
            this.ApplianceList.Location = new System.Drawing.Point(8, 94);
            this.ApplianceList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ApplianceList.Name = "ApplianceList";
            this.ApplianceList.Size = new System.Drawing.Size(210, 277);
            this.ApplianceList.TabIndex = 0;
            this.ApplianceList.SelectedIndexChanged += new System.EventHandler(this.ApplianceList_SelectedIndexChanged);
            // 
            // Type_Txt
            // 
            this.Type_Txt.Location = new System.Drawing.Point(222, 111);
            this.Type_Txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Type_Txt.Name = "Type_Txt";
            this.Type_Txt.Size = new System.Drawing.Size(198, 20);
            this.Type_Txt.TabIndex = 1;
            // 
            // Brand_Txt
            // 
            this.Brand_Txt.Location = new System.Drawing.Point(222, 150);
            this.Brand_Txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Brand_Txt.Name = "Brand_Txt";
            this.Brand_Txt.Size = new System.Drawing.Size(198, 20);
            this.Brand_Txt.TabIndex = 2;
            // 
            // Model_Txt
            // 
            this.Model_Txt.Location = new System.Drawing.Point(222, 189);
            this.Model_Txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Model_Txt.Name = "Model_Txt";
            this.Model_Txt.Size = new System.Drawing.Size(198, 20);
            this.Model_Txt.TabIndex = 3;
            // 
            // Dimensions_Txt
            // 
            this.Dimensions_Txt.Location = new System.Drawing.Point(222, 232);
            this.Dimensions_Txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dimensions_Txt.Name = "Dimensions_Txt";
            this.Dimensions_Txt.Size = new System.Drawing.Size(198, 20);
            this.Dimensions_Txt.TabIndex = 4;
            // 
            // Colour_Txt
            // 
            this.Colour_Txt.Location = new System.Drawing.Point(222, 269);
            this.Colour_Txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Colour_Txt.Name = "Colour_Txt";
            this.Colour_Txt.Size = new System.Drawing.Size(198, 20);
            this.Colour_Txt.TabIndex = 5;
            // 
            // Energy_Txt
            // 
            this.Energy_Txt.Location = new System.Drawing.Point(222, 310);
            this.Energy_Txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Energy_Txt.Name = "Energy_Txt";
            this.Energy_Txt.Size = new System.Drawing.Size(198, 20);
            this.Energy_Txt.TabIndex = 6;
            // 
            // Fee_Txt
            // 
            this.Fee_Txt.Location = new System.Drawing.Point(222, 352);
            this.Fee_Txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Fee_Txt.Name = "Fee_Txt";
            this.Fee_Txt.Size = new System.Drawing.Size(198, 20);
            this.Fee_Txt.TabIndex = 7;
            // 
            // AddBTN
            // 
            this.AddBTN.BackColor = System.Drawing.Color.Peru;
            this.AddBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddBTN.ForeColor = System.Drawing.Color.White;
            this.AddBTN.Location = new System.Drawing.Point(8, 387);
            this.AddBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(128, 40);
            this.AddBTN.TabIndex = 8;
            this.AddBTN.Text = "Add";
            this.AddBTN.UseVisualStyleBackColor = false;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // EditBTN
            // 
            this.EditBTN.BackColor = System.Drawing.Color.Peru;
            this.EditBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.EditBTN.ForeColor = System.Drawing.Color.White;
            this.EditBTN.Location = new System.Drawing.Point(159, 387);
            this.EditBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditBTN.Name = "EditBTN";
            this.EditBTN.Size = new System.Drawing.Size(122, 40);
            this.EditBTN.TabIndex = 9;
            this.EditBTN.Text = "Edit";
            this.EditBTN.UseVisualStyleBackColor = false;
            this.EditBTN.Click += new System.EventHandler(this.EditBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.Color.Peru;
            this.DeleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.DeleteBTN.ForeColor = System.Drawing.Color.White;
            this.DeleteBTN.Location = new System.Drawing.Point(296, 387);
            this.DeleteBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(123, 40);
            this.DeleteBTN.TabIndex = 10;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // Type_Lbl
            // 
            this.Type_Lbl.AutoSize = true;
            this.Type_Lbl.Location = new System.Drawing.Point(220, 95);
            this.Type_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Type_Lbl.Name = "Type_Lbl";
            this.Type_Lbl.Size = new System.Drawing.Size(93, 13);
            this.Type_Lbl.TabIndex = 11;
            this.Type_Lbl.Text = "Type of Appliance";
            // 
            // Brand_LBL
            // 
            this.Brand_LBL.AutoSize = true;
            this.Brand_LBL.Location = new System.Drawing.Point(220, 134);
            this.Brand_LBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Brand_LBL.Name = "Brand_LBL";
            this.Brand_LBL.Size = new System.Drawing.Size(35, 13);
            this.Brand_LBL.TabIndex = 12;
            this.Brand_LBL.Text = "Brand";
            // 
            // Energy_LBL
            // 
            this.Energy_LBL.AutoSize = true;
            this.Energy_LBL.Location = new System.Drawing.Point(220, 294);
            this.Energy_LBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Energy_LBL.Name = "Energy_LBL";
            this.Energy_LBL.Size = new System.Drawing.Size(104, 13);
            this.Energy_LBL.TabIndex = 13;
            this.Energy_LBL.Text = "Energy Consumption";
            // 
            // Colour_LBL
            // 
            this.Colour_LBL.AutoSize = true;
            this.Colour_LBL.Location = new System.Drawing.Point(220, 254);
            this.Colour_LBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Colour_LBL.Name = "Colour_LBL";
            this.Colour_LBL.Size = new System.Drawing.Size(37, 13);
            this.Colour_LBL.TabIndex = 14;
            this.Colour_LBL.Text = "Colour";
            // 
            // Dimensions_LBL
            // 
            this.Dimensions_LBL.AutoSize = true;
            this.Dimensions_LBL.Location = new System.Drawing.Point(220, 216);
            this.Dimensions_LBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Dimensions_LBL.Name = "Dimensions_LBL";
            this.Dimensions_LBL.Size = new System.Drawing.Size(61, 13);
            this.Dimensions_LBL.TabIndex = 15;
            this.Dimensions_LBL.Text = "Dimensions";
            // 
            // Model_LBL
            // 
            this.Model_LBL.AutoSize = true;
            this.Model_LBL.Location = new System.Drawing.Point(220, 174);
            this.Model_LBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Model_LBL.Name = "Model_LBL";
            this.Model_LBL.Size = new System.Drawing.Size(36, 13);
            this.Model_LBL.TabIndex = 16;
            this.Model_LBL.Text = "Model";
            // 
            // Fee_LBL
            // 
            this.Fee_LBL.AutoSize = true;
            this.Fee_LBL.Location = new System.Drawing.Point(220, 337);
            this.Fee_LBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Fee_LBL.Name = "Fee_LBL";
            this.Fee_LBL.Size = new System.Drawing.Size(65, 13);
            this.Fee_LBL.TabIndex = 17;
            this.Fee_LBL.Text = "Monthly Fee";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(351, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 79);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "APPLIANCE - ADMIN VIEW";
            // 
            // ApplianceAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(430, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Fee_LBL);
            this.Controls.Add(this.Model_LBL);
            this.Controls.Add(this.Dimensions_LBL);
            this.Controls.Add(this.Colour_LBL);
            this.Controls.Add(this.Energy_LBL);
            this.Controls.Add(this.Brand_LBL);
            this.Controls.Add(this.Type_Lbl);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.EditBTN);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.Fee_Txt);
            this.Controls.Add(this.Energy_Txt);
            this.Controls.Add(this.Colour_Txt);
            this.Controls.Add(this.Dimensions_Txt);
            this.Controls.Add(this.Model_Txt);
            this.Controls.Add(this.Brand_Txt);
            this.Controls.Add(this.Type_Txt);
            this.Controls.Add(this.ApplianceList);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ApplianceAdmin";
            this.Text = "Appliance List [Admin]";
            this.Load += new System.EventHandler(this.ApplianceAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ApplianceList;
        private System.Windows.Forms.TextBox Type_Txt;
        private System.Windows.Forms.TextBox Brand_Txt;
        private System.Windows.Forms.TextBox Model_Txt;
        private System.Windows.Forms.TextBox Dimensions_Txt;
        private System.Windows.Forms.TextBox Colour_Txt;
        private System.Windows.Forms.TextBox Energy_Txt;
        private System.Windows.Forms.TextBox Fee_Txt;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Button EditBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Label Type_Lbl;
        private System.Windows.Forms.Label Brand_LBL;
        private System.Windows.Forms.Label Energy_LBL;
        private System.Windows.Forms.Label Colour_LBL;
        private System.Windows.Forms.Label Dimensions_LBL;
        private System.Windows.Forms.Label Model_LBL;
        private System.Windows.Forms.Label Fee_LBL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}