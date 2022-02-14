namespace Assignment_03_03
{
    partial class AddCustomer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.custTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.eBalanceTxt = new System.Windows.Forms.TextBox();
            this.iBalanceTxt = new System.Windows.Forms.TextBox();
            this.oBalanceTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add New Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(209, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Name :";
            // 
            // custTxt
            // 
            this.custTxt.Location = new System.Drawing.Point(411, 170);
            this.custTxt.Name = "custTxt";
            this.custTxt.Size = new System.Drawing.Size(205, 23);
            this.custTxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(198, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Everyday Balance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(176, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Investment Balance :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(209, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Omni Balance :";
            // 
            // eBalanceTxt
            // 
            this.eBalanceTxt.Location = new System.Drawing.Point(411, 222);
            this.eBalanceTxt.Name = "eBalanceTxt";
            this.eBalanceTxt.Size = new System.Drawing.Size(102, 23);
            this.eBalanceTxt.TabIndex = 7;
            // 
            // iBalanceTxt
            // 
            this.iBalanceTxt.Location = new System.Drawing.Point(411, 268);
            this.iBalanceTxt.Name = "iBalanceTxt";
            this.iBalanceTxt.Size = new System.Drawing.Size(102, 23);
            this.iBalanceTxt.TabIndex = 8;
            // 
            // oBalanceTxt
            // 
            this.oBalanceTxt.Location = new System.Drawing.Point(411, 316);
            this.oBalanceTxt.Name = "oBalanceTxt";
            this.oBalanceTxt.Size = new System.Drawing.Size(102, 23);
            this.oBalanceTxt.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oBalanceTxt);
            this.Controls.Add(this.iBalanceTxt);
            this.Controls.Add(this.eBalanceTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.custTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomer";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.custTxt, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.eBalanceTxt, 0);
            this.Controls.SetChildIndex(this.iBalanceTxt, 0);
            this.Controls.SetChildIndex(this.oBalanceTxt, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox custTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox eBalanceTxt;
        private System.Windows.Forms.TextBox iBalanceTxt;
        private System.Windows.Forms.TextBox oBalanceTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}