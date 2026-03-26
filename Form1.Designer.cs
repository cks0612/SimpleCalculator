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
            txtbx1 = new TextBox();
            txtbx2 = new TextBox();
            CEbtn = new Button();
            Cbtn = new Button();
            Delbtn = new Button();
            dvbtn = new Button();
            num9btn = new Button();
            mtpbtn = new Button();
            num8btn = new Button();
            num7btn = new Button();
            num6btn = new Button();
            mbtn = new Button();
            num5btn = new Button();
            num4btn = new Button();
            num3btn = new Button();
            pbtn = new Button();
            num2btn = new Button();
            num1btn = new Button();
            dotbtn = new Button();
            rstbtn = new Button();
            num0btn = new Button();
            pmbtn = new Button();
            SuspendLayout();
            // 
            // SPCCT
            // 
            SPCCT.AutoSize = true;
            SPCCT.Font = new Font("한컴 고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            SPCCT.ForeColor = Color.Navy;
            SPCCT.Location = new Point(34, 32);
            SPCCT.Name = "SPCCT";
            SPCCT.Size = new Size(309, 48);
            SPCCT.TabIndex = 0;
            SPCCT.Text = "Simple Caculator";
            // 
            // txtbx1
            // 
            txtbx1.Location = new Point(34, 121);
            txtbx1.Name = "txtbx1";
            txtbx1.Size = new Size(375, 23);
            txtbx1.TabIndex = 1;
            txtbx1.TextChanged += txtbx1_TextChanged;
            // 
            // txtbx2
            // 
            txtbx2.Location = new Point(34, 171);
            txtbx2.Name = "txtbx2";
            txtbx2.Size = new Size(375, 23);
            txtbx2.TabIndex = 2;
            txtbx2.TextChanged += txtbx2_TextChanged;
            // 
            // CEbtn
            // 
            CEbtn.Font = new Font("한컴 고딕", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            CEbtn.ForeColor = Color.Navy;
            CEbtn.Location = new Point(34, 257);
            CEbtn.Name = "CEbtn";
            CEbtn.Size = new Size(78, 45);
            CEbtn.TabIndex = 3;
            CEbtn.Text = "CE";
            CEbtn.UseVisualStyleBackColor = true;
            CEbtn.Click += CEbtn_Click;
            // 
            // Cbtn
            // 
            Cbtn.Font = new Font("한컴 고딕", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Cbtn.ForeColor = Color.Navy;
            Cbtn.Location = new Point(133, 257);
            Cbtn.Name = "Cbtn";
            Cbtn.Size = new Size(78, 45);
            Cbtn.TabIndex = 4;
            Cbtn.Text = "C";
            Cbtn.UseVisualStyleBackColor = true;
            Cbtn.Click += Cbtn_Click;
            // 
            // Delbtn
            // 
            Delbtn.Font = new Font("한컴 고딕", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Delbtn.ForeColor = Color.Navy;
            Delbtn.Location = new Point(232, 257);
            Delbtn.Name = "Delbtn";
            Delbtn.Size = new Size(78, 45);
            Delbtn.TabIndex = 6;
            Delbtn.Text = "Del";
            Delbtn.UseVisualStyleBackColor = true;
            Delbtn.Click += Delbtn_Click;
            // 
            // dvbtn
            // 
            dvbtn.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            dvbtn.ForeColor = Color.Red;
            dvbtn.Location = new Point(331, 257);
            dvbtn.Name = "dvbtn";
            dvbtn.Size = new Size(78, 45);
            dvbtn.TabIndex = 5;
            dvbtn.Text = "÷\r\n";
            dvbtn.UseVisualStyleBackColor = true;
            dvbtn.Click += dvbtn_Click;
            // 
            // num9btn
            // 
            num9btn.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            num9btn.ForeColor = Color.Blue;
            num9btn.Location = new Point(232, 320);
            num9btn.Name = "num9btn";
            num9btn.Size = new Size(78, 45);
            num9btn.TabIndex = 10;
            num9btn.Text = "9";
            num9btn.UseVisualStyleBackColor = true;
            num9btn.Click += num9btn_Click;
            // 
            // mtpbtn
            // 
            mtpbtn.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            mtpbtn.ForeColor = Color.Red;
            mtpbtn.Location = new Point(331, 320);
            mtpbtn.Name = "mtpbtn";
            mtpbtn.Size = new Size(78, 45);
            mtpbtn.TabIndex = 9;
            mtpbtn.Text = "x";
            mtpbtn.UseVisualStyleBackColor = true;
            mtpbtn.Click += mtpbtn_Click;
            // 
            // num8btn
            // 
            num8btn.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            num8btn.ForeColor = Color.Blue;
            num8btn.Location = new Point(133, 320);
            num8btn.Name = "num8btn";
            num8btn.Size = new Size(78, 45);
            num8btn.TabIndex = 8;
            num8btn.Text = "8";
            num8btn.UseVisualStyleBackColor = true;
            num8btn.Click += num8btn_Click;
            // 
            // num7btn
            // 
            num7btn.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            num7btn.ForeColor = Color.Blue;
            num7btn.Location = new Point(34, 320);
            num7btn.Name = "num7btn";
            num7btn.Size = new Size(78, 45);
            num7btn.TabIndex = 7;
            num7btn.Text = "7";
            num7btn.UseVisualStyleBackColor = true;
            num7btn.Click += num7btn_Click;
            // 
            // num6btn
            // 
            num6btn.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            num6btn.ForeColor = Color.Blue;
            num6btn.Location = new Point(232, 383);
            num6btn.Name = "num6btn";
            num6btn.Size = new Size(78, 45);
            num6btn.TabIndex = 14;
            num6btn.Text = "6";
            num6btn.UseVisualStyleBackColor = true;
            num6btn.Click += num6btn_Click;
            // 
            // mbtn
            // 
            mbtn.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            mbtn.ForeColor = Color.Red;
            mbtn.Location = new Point(331, 386);
            mbtn.Name = "mbtn";
            mbtn.Size = new Size(78, 45);
            mbtn.TabIndex = 13;
            mbtn.Text = "-";
            mbtn.UseVisualStyleBackColor = true;
            mbtn.Click += mbtn_Click;
            // 
            // num5btn
            // 
            num5btn.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            num5btn.ForeColor = Color.Blue;
            num5btn.Location = new Point(133, 383);
            num5btn.Name = "num5btn";
            num5btn.Size = new Size(78, 45);
            num5btn.TabIndex = 12;
            num5btn.Text = "5";
            num5btn.UseVisualStyleBackColor = true;
            num5btn.Click += num5btn_Click;
            // 
            // num4btn
            // 
            num4btn.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            num4btn.ForeColor = Color.Blue;
            num4btn.Location = new Point(34, 383);
            num4btn.Name = "num4btn";
            num4btn.Size = new Size(78, 45);
            num4btn.TabIndex = 11;
            num4btn.Text = "4";
            num4btn.UseVisualStyleBackColor = true;
            num4btn.Click += num4btn_Click;
            // 
            // num3btn
            // 
            num3btn.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            num3btn.ForeColor = Color.Blue;
            num3btn.Location = new Point(232, 446);
            num3btn.Name = "num3btn";
            num3btn.Size = new Size(78, 45);
            num3btn.TabIndex = 18;
            num3btn.Text = "3";
            num3btn.UseVisualStyleBackColor = true;
            num3btn.Click += num3btn_Click;
            // 
            // pbtn
            // 
            pbtn.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            pbtn.ForeColor = Color.Red;
            pbtn.Location = new Point(331, 446);
            pbtn.Name = "pbtn";
            pbtn.Size = new Size(78, 45);
            pbtn.TabIndex = 17;
            pbtn.Text = "+";
            pbtn.UseVisualStyleBackColor = true;
            pbtn.Click += pbtn_Click;
            // 
            // num2btn
            // 
            num2btn.Font = new Font("한컴 고딕", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            num2btn.ForeColor = Color.Blue;
            num2btn.Location = new Point(133, 446);
            num2btn.Name = "num2btn";
            num2btn.Size = new Size(78, 45);
            num2btn.TabIndex = 16;
            num2btn.Text = "2";
            num2btn.UseVisualStyleBackColor = true;
            num2btn.Click += num2btn_Click;
            // 
            // num1btn
            // 
            num1btn.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            num1btn.ForeColor = Color.Blue;
            num1btn.Location = new Point(34, 446);
            num1btn.Name = "num1btn";
            num1btn.Size = new Size(78, 45);
            num1btn.TabIndex = 15;
            num1btn.Text = "1";
            num1btn.UseVisualStyleBackColor = true;
            num1btn.Click += num1btn_Click;
            // 
            // dotbtn
            // 
            dotbtn.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            dotbtn.Location = new Point(232, 509);
            dotbtn.Name = "dotbtn";
            dotbtn.Size = new Size(78, 45);
            dotbtn.TabIndex = 22;
            dotbtn.Text = ".";
            dotbtn.UseVisualStyleBackColor = true;
            dotbtn.Click += dotbtn_Click;
            // 
            // rstbtn
            // 
            rstbtn.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rstbtn.Location = new Point(331, 509);
            rstbtn.Name = "rstbtn";
            rstbtn.Size = new Size(78, 45);
            rstbtn.TabIndex = 21;
            rstbtn.Text = "=";
            rstbtn.UseVisualStyleBackColor = true;
            rstbtn.Click += rstbtn_Click;
            // 
            // num0btn
            // 
            num0btn.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            num0btn.ForeColor = Color.Blue;
            num0btn.Location = new Point(133, 509);
            num0btn.Name = "num0btn";
            num0btn.Size = new Size(78, 45);
            num0btn.TabIndex = 20;
            num0btn.Text = "0";
            num0btn.UseVisualStyleBackColor = true;
            num0btn.Click += num0btn_Click;
            // 
            // pmbtn
            // 
            pmbtn.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            pmbtn.Location = new Point(34, 509);
            pmbtn.Name = "pmbtn";
            pmbtn.Size = new Size(78, 45);
            pmbtn.TabIndex = 19;
            pmbtn.Text = "+/-";
            pmbtn.UseVisualStyleBackColor = true;
            pmbtn.Click += pmbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 624);
            Controls.Add(dotbtn);
            Controls.Add(rstbtn);
            Controls.Add(num0btn);
            Controls.Add(pmbtn);
            Controls.Add(num3btn);
            Controls.Add(pbtn);
            Controls.Add(num2btn);
            Controls.Add(num1btn);
            Controls.Add(num6btn);
            Controls.Add(mbtn);
            Controls.Add(num5btn);
            Controls.Add(num4btn);
            Controls.Add(num9btn);
            Controls.Add(mtpbtn);
            Controls.Add(num8btn);
            Controls.Add(num7btn);
            Controls.Add(Delbtn);
            Controls.Add(dvbtn);
            Controls.Add(Cbtn);
            Controls.Add(CEbtn);
            Controls.Add(txtbx2);
            Controls.Add(txtbx1);
            Controls.Add(SPCCT);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SPCCT;
        private TextBox txtbx1;
        private TextBox txtbx2;
        private Button CEbtn;
        private Button Cbtn;
        private Button Delbtn;
        private Button dvbtn;
        private Button num9btn;
        private Button mtpbtn;
        private Button num8btn;
        private Button num7btn;
        private Button num6btn;
        private Button mbtn;
        private Button num5btn;
        private Button num4btn;
        private Button num3btn;
        private Button pbtn;
        private Button num2btn;
        private Button num1btn;
        private Button dotbtn;
        private Button rstbtn;
        private Button num0btn;
        private Button pmbtn;
    }
}
