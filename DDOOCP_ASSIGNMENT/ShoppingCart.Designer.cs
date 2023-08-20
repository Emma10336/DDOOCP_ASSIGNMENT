namespace DDOOCP_ASSIGNMENT
{
    partial class ShoppingCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCart));
            this.Cart_List = new System.Windows.Forms.ListBox();
            this.Checkout_BTN = new System.Windows.Forms.Button();
            this.CancelOrder_BTN = new System.Windows.Forms.Button();
            this.Amount_LBL = new System.Windows.Forms.Label();
            this.Total_LBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cart_List
            // 
            this.Cart_List.FormattingEnabled = true;
            this.Cart_List.Location = new System.Drawing.Point(6, 84);
            this.Cart_List.Margin = new System.Windows.Forms.Padding(2);
            this.Cart_List.Name = "Cart_List";
            this.Cart_List.Size = new System.Drawing.Size(587, 225);
            this.Cart_List.TabIndex = 2;
            this.Cart_List.SelectedIndexChanged += new System.EventHandler(this.Cart_List_SelectedIndexChanged);
            // 
            // Checkout_BTN
            // 
            this.Checkout_BTN.BackColor = System.Drawing.Color.Peru;
            this.Checkout_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Checkout_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold);
            this.Checkout_BTN.ForeColor = System.Drawing.Color.Transparent;
            this.Checkout_BTN.Location = new System.Drawing.Point(6, 364);
            this.Checkout_BTN.Name = "Checkout_BTN";
            this.Checkout_BTN.Size = new System.Drawing.Size(287, 72);
            this.Checkout_BTN.TabIndex = 3;
            this.Checkout_BTN.Text = "CHECKOUT";
            this.Checkout_BTN.UseVisualStyleBackColor = false;
            this.Checkout_BTN.Click += new System.EventHandler(this.Checkout_BTN_Click);
            // 
            // CancelOrder_BTN
            // 
            this.CancelOrder_BTN.BackColor = System.Drawing.Color.Peru;
            this.CancelOrder_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelOrder_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CancelOrder_BTN.ForeColor = System.Drawing.Color.White;
            this.CancelOrder_BTN.Location = new System.Drawing.Point(299, 364);
            this.CancelOrder_BTN.Name = "CancelOrder_BTN";
            this.CancelOrder_BTN.Size = new System.Drawing.Size(294, 72);
            this.CancelOrder_BTN.TabIndex = 4;
            this.CancelOrder_BTN.Text = "Cancel";
            this.CancelOrder_BTN.UseVisualStyleBackColor = false;
            this.CancelOrder_BTN.Click += new System.EventHandler(this.CancelOrder_BTN_Click);
            // 
            // Amount_LBL
            // 
            this.Amount_LBL.AutoSize = true;
            this.Amount_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Amount_LBL.Location = new System.Drawing.Point(164, 320);
            this.Amount_LBL.Name = "Amount_LBL";
            this.Amount_LBL.Size = new System.Drawing.Size(137, 31);
            this.Amount_LBL.TabIndex = 5;
            this.Amount_LBL.Text = "Amount: €";
            // 
            // Total_LBL
            // 
            this.Total_LBL.AutoSize = true;
            this.Total_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Total_LBL.Location = new System.Drawing.Point(307, 320);
            this.Total_LBL.Name = "Total_LBL";
            this.Total_LBL.Size = new System.Drawing.Size(67, 31);
            this.Total_LBL.TabIndex = 6;
            this.Total_LBL.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "SHOPPING CART";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(525, 0);
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
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 79);
            this.panel1.TabIndex = 42;
            // 
            // ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(598, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Total_LBL);
            this.Controls.Add(this.Amount_LBL);
            this.Controls.Add(this.CancelOrder_BTN);
            this.Controls.Add(this.Checkout_BTN);
            this.Controls.Add(this.Cart_List);
            this.Name = "ShoppingCart";
            this.Text = "Shopping Cart";
            this.Load += new System.EventHandler(this.ShoppingCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Cart_List;
        private System.Windows.Forms.Button Checkout_BTN;
        private System.Windows.Forms.Button CancelOrder_BTN;
        private System.Windows.Forms.Label Amount_LBL;
        private System.Windows.Forms.Label Total_LBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}