namespace CS223LecAssignmentII
{
    partial class Form1
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.lblVAT = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(20, 20);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(20, 20, 10, 20);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(85, 24);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(125, 20);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(10, 20, 20, 20);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(173, 29);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // txtVAT
            // 
            this.txtVAT.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVAT.Location = new System.Drawing.Point(125, 89);
            this.txtVAT.Margin = new System.Windows.Forms.Padding(10, 20, 20, 20);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(173, 29);
            this.txtVAT.TabIndex = 3;
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.BackColor = System.Drawing.Color.Transparent;
            this.lblVAT.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVAT.ForeColor = System.Drawing.Color.White;
            this.lblVAT.Location = new System.Drawing.Point(20, 89);
            this.lblVAT.Margin = new System.Windows.Forms.Padding(20, 20, 10, 20);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(48, 24);
            this.lblVAT.TabIndex = 2;
            this.lblVAT.Text = "VAT:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(125, 158);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(10, 20, 20, 20);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(173, 29);
            this.txtTotal.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(20, 158);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(20, 20, 10, 20);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 24);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtAmount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAmount, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotal, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtVAT, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTotal, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblVAT, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(226, 105);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(343, 208);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(437, 333);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 39);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Tag = "15+aseryh";
            this.Text = "VAT Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClear;
    }
}

