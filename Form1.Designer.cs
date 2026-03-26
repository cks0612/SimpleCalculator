namespace SimpleCalculator
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
            SPCCT = new Label();
            SuspendLayout();
            // 
            // SPCCT
            // 
            SPCCT.AutoSize = true;
            SPCCT.Font = new Font("한컴 고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            SPCCT.ForeColor = Color.Navy;
            SPCCT.Location = new Point(12, 37);
            SPCCT.Name = "SPCCT";
            SPCCT.Size = new Size(309, 48);
            SPCCT.TabIndex = 0;
            SPCCT.Text = "Simple Caculator";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 624);
            Controls.Add(SPCCT);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SPCCT;
    }
}
