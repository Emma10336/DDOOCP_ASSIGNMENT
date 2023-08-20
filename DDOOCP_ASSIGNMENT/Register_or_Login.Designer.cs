namespace DDOOCP_ASSIGNMENT
{
    partial class Register_or_Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_or_Login_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Register_or_Login_Label = new System.Windows.Forms.Label();
            this.RegisterSelectionBTN = new System.Windows.Forms.Button();
            this.LoginSelectionBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 168);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Register_or_Login_Label
            // 
            this.Register_or_Login_Label.AutoSize = true;
            this.Register_or_Login_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Register_or_Login_Label.ForeColor = System.Drawing.Color.Black;
            this.Register_or_Login_Label.Location = new System.Drawing.Point(326, 28);
            this.Register_or_Login_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Register_or_Login_Label.Name = "Register_or_Login_Label";
            this.Register_or_Login_Label.Size = new System.Drawing.Size(420, 25);
            this.Register_or_Login_Label.TabIndex = 0;
            this.Register_or_Login_Label.Text = "Welcome to our new appliance rental program! ";
            this.Register_or_Login_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterSelectionBTN
            // 
            this.RegisterSelectionBTN.BackColor = System.Drawing.Color.Peru;
            this.RegisterSelectionBTN.FlatAppearance.BorderSize = 0;
            this.RegisterSelectionBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegisterSelectionBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.RegisterSelectionBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegisterSelectionBTN.Location = new System.Drawing.Point(331, 138);
            this.RegisterSelectionBTN.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterSelectionBTN.Name = "RegisterSelectionBTN";
            this.RegisterSelectionBTN.Size = new System.Drawing.Size(185, 45);
            this.RegisterSelectionBTN.TabIndex = 1;
            this.RegisterSelectionBTN.Text = "Register";
            this.RegisterSelectionBTN.UseVisualStyleBackColor = false;
            this.RegisterSelectionBTN.Click += new System.EventHandler(this.RegisterSelectionBTN_Click);
            // 
            // LoginSelectionBTN
            // 
            this.LoginSelectionBTN.BackColor = System.Drawing.Color.Peru;
            this.LoginSelectionBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginSelectionBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LoginSelectionBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginSelectionBTN.Location = new System.Drawing.Point(561, 138);
            this.LoginSelectionBTN.Margin = new System.Windows.Forms.Padding(2);
            this.LoginSelectionBTN.Name = "LoginSelectionBTN";
            this.LoginSelectionBTN.Size = new System.Drawing.Size(185, 45);
            this.LoginSelectionBTN.TabIndex = 2;
            this.LoginSelectionBTN.Text = "Login";
            this.LoginSelectionBTN.UseVisualStyleBackColor = false;
            this.LoginSelectionBTN.Click += new System.EventHandler(this.LoginSelectionBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(366, 66);
            this.label1.MaximumSize = new System.Drawing.Size(400, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Would you like to register a new account or login to an existing one?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 235);
            this.panel1.TabIndex = 6;
            // 
            // Register_or_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(780, 196);
            this.Controls.Add(this.Register_or_Login_Label);
            this.Controls.Add(this.RegisterSelectionBTN);
            this.Controls.Add(this.LoginSelectionBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Register_or_Login_Form";
            this.Text = "Register or Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Register_or_Login_Label;
        private System.Windows.Forms.Button RegisterSelectionBTN;
        private System.Windows.Forms.Button LoginSelectionBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

