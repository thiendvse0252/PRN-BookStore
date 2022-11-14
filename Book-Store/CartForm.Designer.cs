namespace Book_Store {
    partial class CartForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbImage = new System.Windows.Forms.TextBox();
            this.nudPriceCart = new System.Windows.Forms.NumericUpDown();
            this.nudQuantityCart = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteCart = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityCart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Purchase Quantity";
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Location = new System.Drawing.Point(433, 95);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.RowHeadersWidth = 51;
            this.dataGridViewCart.RowTemplate.Height = 29;
            this.dataGridViewCart.Size = new System.Drawing.Size(774, 413);
            this.dataGridViewCart.TabIndex = 7;
            this.dataGridViewCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellContentClick);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(268, 95);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(125, 27);
            this.tbID.TabIndex = 8;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(268, 161);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(125, 27);
            this.tbName.TabIndex = 9;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(268, 231);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.ReadOnly = true;
            this.tbAuthor.Size = new System.Drawing.Size(125, 27);
            this.tbAuthor.TabIndex = 10;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(268, 294);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(125, 27);
            this.tbDescription.TabIndex = 11;
            // 
            // tbImage
            // 
            this.tbImage.Location = new System.Drawing.Point(268, 355);
            this.tbImage.Name = "tbImage";
            this.tbImage.ReadOnly = true;
            this.tbImage.Size = new System.Drawing.Size(125, 27);
            this.tbImage.TabIndex = 12;
            // 
            // nudPriceCart
            // 
            this.nudPriceCart.Location = new System.Drawing.Point(268, 418);
            this.nudPriceCart.Name = "nudPriceCart";
            this.nudPriceCart.ReadOnly = true;
            this.nudPriceCart.Size = new System.Drawing.Size(125, 27);
            this.nudPriceCart.TabIndex = 13;
            // 
            // nudQuantityCart
            // 
            this.nudQuantityCart.Location = new System.Drawing.Point(268, 481);
            this.nudQuantityCart.Name = "nudQuantityCart";
            this.nudQuantityCart.ReadOnly = true;
            this.nudQuantityCart.Size = new System.Drawing.Size(125, 27);
            this.nudQuantityCart.TabIndex = 14;
            // 
            // btnDeleteCart
            // 
            this.btnDeleteCart.Enabled = false;
            this.btnDeleteCart.Location = new System.Drawing.Point(135, 547);
            this.btnDeleteCart.Name = "btnDeleteCart";
            this.btnDeleteCart.Size = new System.Drawing.Size(122, 49);
            this.btnDeleteCart.TabIndex = 15;
            this.btnDeleteCart.Text = "Delete";
            this.btnDeleteCart.UseVisualStyleBackColor = true;
            this.btnDeleteCart.Click += new System.EventHandler(this.btnDeleteCart_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Enabled = false;
            this.btnCheckOut.Location = new System.Drawing.Point(271, 547);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(122, 49);
            this.btnCheckOut.TabIndex = 16;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 625);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnDeleteCart);
            this.Controls.Add(this.nudQuantityCart);
            this.Controls.Add(this.nudPriceCart);
            this.Controls.Add(this.tbImage);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CartForm";
            this.Text = "CartForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dataGridViewCart;
        private TextBox tbID;
        private TextBox tbName;
        private TextBox tbAuthor;
        private TextBox tbDescription;
        private TextBox tbImage;
        private NumericUpDown nudPriceCart;
        private NumericUpDown nudQuantityCart;
        private Button btnDeleteCart;
        private Button btnCheckOut;
    }
}