namespace Crm.UI
{
    partial class ProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.inp_name = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.num_price = new System.Windows.Forms.NumericUpDown();
            this.num_count = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_count)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter name";
            // 
            // inp_name
            // 
            this.inp_name.Location = new System.Drawing.Point(88, 23);
            this.inp_name.Name = "inp_name";
            this.inp_name.Size = new System.Drawing.Size(100, 20);
            this.inp_name.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_save.Location = new System.Drawing.Point(377, 328);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(12, 60);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(59, 13);
            this.lbl_price.TabIndex = 3;
            this.lbl_price.Text = "Enter Price";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(12, 105);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(63, 13);
            this.lbl_count.TabIndex = 5;
            this.lbl_count.Text = "Enter Count";
            // 
            // num_price
            // 
            this.num_price.DecimalPlaces = 2;
            this.num_price.Location = new System.Drawing.Point(88, 60);
            this.num_price.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_price.Name = "num_price";
            this.num_price.Size = new System.Drawing.Size(120, 20);
            this.num_price.TabIndex = 7;
            // 
            // num_count
            // 
            this.num_count.Location = new System.Drawing.Point(88, 103);
            this.num_count.Name = "num_count";
            this.num_count.Size = new System.Drawing.Size(120, 20);
            this.num_count.TabIndex = 8;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 363);
            this.Controls.Add(this.num_count);
            this.Controls.Add(this.num_price);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.inp_name);
            this.Controls.Add(this.label1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inp_name;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.NumericUpDown num_price;
        private System.Windows.Forms.NumericUpDown num_count;
    }
}