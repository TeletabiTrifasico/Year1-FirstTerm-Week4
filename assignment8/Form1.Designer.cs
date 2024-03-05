namespace assignment8
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
            txtStaticNumber = new Label();
            txtbxNumber = new TextBox();
            btnCompare = new Button();
            txtStaticNotFormula = new Label();
            txtStaticFormula = new Label();
            txtComparison = new Label();
            txtNotFormula = new Label();
            txtFormula = new Label();
            SuspendLayout();
            // 
            // txtStaticNumber
            // 
            txtStaticNumber.AutoSize = true;
            txtStaticNumber.Location = new Point(38, 45);
            txtStaticNumber.Name = "txtStaticNumber";
            txtStaticNumber.Size = new Size(132, 20);
            txtStaticNumber.TabIndex = 0;
            txtStaticNumber.Text = "Enter a number (n)";
            // 
            // txtbxNumber
            // 
            txtbxNumber.Location = new Point(230, 42);
            txtbxNumber.Name = "txtbxNumber";
            txtbxNumber.Size = new Size(125, 27);
            txtbxNumber.TabIndex = 1;
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(38, 119);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(317, 42);
            btnCompare.TabIndex = 2;
            btnCompare.Text = "Compare";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // txtStaticNotFormula
            // 
            txtStaticNotFormula.AutoSize = true;
            txtStaticNotFormula.Location = new Point(38, 207);
            txtStaticNotFormula.Name = "txtStaticNotFormula";
            txtStaticNotFormula.Size = new Size(135, 20);
            txtStaticNotFormula.TabIndex = 3;
            txtStaticNotFormula.Text = "sum = 0+1+2+...+n";
            // 
            // txtStaticFormula
            // 
            txtStaticFormula.AutoSize = true;
            txtStaticFormula.Location = new Point(38, 268);
            txtStaticFormula.Name = "txtStaticFormula";
            txtStaticFormula.Size = new Size(126, 20);
            txtStaticFormula.TabIndex = 4;
            txtStaticFormula.Text = "sum = n * (n+1)/2";
            // 
            // txtComparison
            // 
            txtComparison.AutoSize = true;
            txtComparison.Location = new Point(38, 336);
            txtComparison.Name = "txtComparison";
            txtComparison.Size = new Size(0, 20);
            txtComparison.TabIndex = 5;
            // 
            // txtNotFormula
            // 
            txtNotFormula.AutoSize = true;
            txtNotFormula.Location = new Point(305, 207);
            txtNotFormula.Name = "txtNotFormula";
            txtNotFormula.Size = new Size(0, 20);
            txtNotFormula.TabIndex = 6;
            // 
            // txtFormula
            // 
            txtFormula.AutoSize = true;
            txtFormula.Location = new Point(305, 268);
            txtFormula.Name = "txtFormula";
            txtFormula.Size = new Size(0, 20);
            txtFormula.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 390);
            Controls.Add(txtFormula);
            Controls.Add(txtNotFormula);
            Controls.Add(txtComparison);
            Controls.Add(txtStaticFormula);
            Controls.Add(txtStaticNotFormula);
            Controls.Add(btnCompare);
            Controls.Add(txtbxNumber);
            Controls.Add(txtStaticNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtStaticNumber;
        private TextBox txtbxNumber;
        private Button btnCompare;
        private Label txtStaticNotFormula;
        private Label txtStaticFormula;
        private Label txtComparison;
        private Label txtNotFormula;
        private Label txtFormula;
    }
}