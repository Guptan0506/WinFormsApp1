namespace WinFormsApp1
{
    partial class Form1
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
            btnExit = new Button();
            btnCalc = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSubtotal = new TextBox();
            txtDiscPrt = new TextBox();
            txtDiscAmt = new TextBox();
            txtTotal = new TextBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(157, 357);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button1_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(462, 357);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(150, 46);
            btnCalc.TabIndex = 1;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 197);
            label1.Name = "label1";
            label1.Size = new Size(201, 32);
            label1.TabIndex = 2;
            label1.Text = "Discount Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 53);
            label2.Name = "label2";
            label2.Size = new Size(103, 32);
            label2.TabIndex = 3;
            label2.Text = "Subtotal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 126);
            label3.Name = "label3";
            label3.Size = new Size(233, 32);
            label3.TabIndex = 4;
            label3.Text = "Discount Percentage";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 260);
            label4.Name = "label4";
            label4.Size = new Size(65, 32);
            label4.TabIndex = 5;
            label4.Text = "Total";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(412, 53);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(200, 39);
            txtSubtotal.TabIndex = 6;
            // 
            // txtDiscPrt
            // 
            txtDiscPrt.Enabled = false;
            txtDiscPrt.Location = new Point(412, 119);
            txtDiscPrt.Name = "txtDiscPrt";
            txtDiscPrt.Size = new Size(200, 39);
            txtDiscPrt.TabIndex = 7;
            // 
            // txtDiscAmt
            // 
            txtDiscAmt.Enabled = false;
            txtDiscAmt.Location = new Point(412, 192);
            txtDiscAmt.Name = "txtDiscAmt";
            txtDiscAmt.Size = new Size(200, 39);
            txtDiscAmt.TabIndex = 8;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(412, 261);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(200, 39);
            txtTotal.TabIndex = 9;
            // 
            // Form1
            // 
            AcceptButton = btnCalc;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotal);
            Controls.Add(txtDiscAmt);
            Controls.Add(txtDiscPrt);
            Controls.Add(txtSubtotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalc);
            Controls.Add(btnExit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnCalc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSubtotal;
        private TextBox txtDiscPrt;
        private TextBox txtDiscAmt;
        private TextBox txtTotal;
    }
}
