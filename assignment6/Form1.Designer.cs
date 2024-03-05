namespace assignment6
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
            txtStaticStartAmount = new Label();
            txtbxStartAmount = new TextBox();
            btnCalculate = new Button();
            txtStaticFinalCapital = new Label();
            txtFinalCapital = new Label();
            SuspendLayout();
            // 
            // txtStaticStartAmount
            // 
            txtStaticStartAmount.AutoSize = true;
            txtStaticStartAmount.Location = new Point(42, 66);
            txtStaticStartAmount.Name = "txtStaticStartAmount";
            txtStaticStartAmount.Size = new Size(95, 20);
            txtStaticStartAmount.TabIndex = 0;
            txtStaticStartAmount.Text = "Start amount";
            // 
            // txtbxStartAmount
            // 
            txtbxStartAmount.Location = new Point(179, 63);
            txtbxStartAmount.Name = "txtbxStartAmount";
            txtbxStartAmount.Size = new Size(125, 27);
            txtbxStartAmount.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(42, 128);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(262, 48);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate final capital";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtStaticFinalCapital
            // 
            txtStaticFinalCapital.AutoSize = true;
            txtStaticFinalCapital.Location = new Point(42, 240);
            txtStaticFinalCapital.Name = "txtStaticFinalCapital";
            txtStaticFinalCapital.Size = new Size(89, 20);
            txtStaticFinalCapital.TabIndex = 3;
            txtStaticFinalCapital.Text = "Final capital";
            // 
            // txtFinalCapital
            // 
            txtFinalCapital.AutoSize = true;
            txtFinalCapital.Location = new Point(254, 240);
            txtFinalCapital.Name = "txtFinalCapital";
            txtFinalCapital.Size = new Size(0, 20);
            txtFinalCapital.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 311);
            Controls.Add(txtFinalCapital);
            Controls.Add(txtStaticFinalCapital);
            Controls.Add(btnCalculate);
            Controls.Add(txtbxStartAmount);
            Controls.Add(txtStaticStartAmount);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtStaticStartAmount;
        private TextBox txtbxStartAmount;
        private Button btnCalculate;
        private Label txtStaticFinalCapital;
        private Label txtFinalCapital;
    }
}