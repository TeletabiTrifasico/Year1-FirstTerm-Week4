namespace assignment7
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
            txtStaticSide = new Label();
            txtbxSide = new TextBox();
            btnCreateSquare = new Button();
            txtSquare = new Label();
            SuspendLayout();
            // 
            // txtStaticSide
            // 
            txtStaticSide.AutoSize = true;
            txtStaticSide.Location = new Point(42, 61);
            txtStaticSide.Name = "txtStaticSide";
            txtStaticSide.Size = new Size(38, 20);
            txtStaticSide.TabIndex = 0;
            txtStaticSide.Text = "Side";
            // 
            // txtbxSide
            // 
            txtbxSide.Location = new Point(269, 54);
            txtbxSide.Name = "txtbxSide";
            txtbxSide.Size = new Size(125, 27);
            txtbxSide.TabIndex = 1;
            // 
            // btnCreateSquare
            // 
            btnCreateSquare.Location = new Point(42, 113);
            btnCreateSquare.Name = "btnCreateSquare";
            btnCreateSquare.Size = new Size(352, 48);
            btnCreateSquare.TabIndex = 2;
            btnCreateSquare.Text = "Create square";
            btnCreateSquare.UseVisualStyleBackColor = true;
            btnCreateSquare.Click += btnCreateSquare_Click;
            // 
            // txtSquare
            // 
            txtSquare.Font = new Font("Courier New", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtSquare.Location = new Point(42, 198);
            txtSquare.Name = "txtSquare";
            txtSquare.Size = new Size(352, 487);
            txtSquare.TabIndex = 3;
            txtSquare.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 707);
            Controls.Add(txtSquare);
            Controls.Add(btnCreateSquare);
            Controls.Add(txtbxSide);
            Controls.Add(txtStaticSide);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtStaticSide;
        private TextBox txtbxSide;
        private Button btnCreateSquare;
        private Label txtSquare;
    }
}