namespace Exemplo
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
            inputTextY = new TextBox();
            btnSoma = new Button();
            labelTitle = new Label();
            labelOutput = new Label();
            inputTextX = new TextBox();
            label1 = new Label();
            btnMulti = new Button();
            btnSub = new Button();
            btnDobro = new Button();
            btnRaiz = new Button();
            btnDivi = new Button();
            btnToBinary = new Button();
            btnXpowOfY = new Button();
            btnPorcent = new Button();
            label2 = new Label();
            labelResult = new Label();
            SuspendLayout();
            // 
            // inputTextY
            // 
            inputTextY.Location = new Point(83, 142);
            inputTextY.Name = "inputTextY";
            inputTextY.Size = new Size(187, 23);
            inputTextY.TabIndex = 2;
            inputTextY.Text = "...";
            // 
            // btnSoma
            // 
            btnSoma.BackColor = SystemColors.Highlight;
            btnSoma.Cursor = Cursors.Hand;
            btnSoma.FlatAppearance.BorderColor = SystemColors.Window;
            btnSoma.FlatAppearance.BorderSize = 3;
            btnSoma.FlatStyle = FlatStyle.Flat;
            btnSoma.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSoma.ForeColor = SystemColors.MenuText;
            btnSoma.Location = new Point(12, 198);
            btnSoma.MaximumSize = new Size(100, 65);
            btnSoma.MinimumSize = new Size(100, 65);
            btnSoma.Name = "btnSoma";
            btnSoma.RightToLeft = RightToLeft.Yes;
            btnSoma.Size = new Size(100, 65);
            btnSoma.TabIndex = 3;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += onSomaClick;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Coral;
            labelTitle.Location = new Point(12, 9);
            labelTitle.MaximumSize = new Size(300, 65);
            labelTitle.MinimumSize = new Size(300, 65);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(300, 65);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Calculator";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.BackColor = Color.FromArgb(40, 42, 54);
            labelOutput.ForeColor = Color.White;
            labelOutput.Location = new Point(395, 23);
            labelOutput.MaximumSize = new Size(400, 350);
            labelOutput.MinimumSize = new Size(400, 350);
            labelOutput.Name = "labelOutput";
            labelOutput.Padding = new Padding(10);
            labelOutput.Size = new Size(400, 350);
            labelOutput.TabIndex = 4;
            labelOutput.Text = "...";
            labelOutput.TextAlign = ContentAlignment.TopCenter;
            labelOutput.Visible = false;
            // 
            // inputTextX
            // 
            inputTextX.Location = new Point(83, 77);
            inputTextX.Name = "inputTextX";
            inputTextX.Size = new Size(187, 23);
            inputTextX.TabIndex = 1;
            inputTextX.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(12, 53);
            label1.MaximumSize = new Size(65, 65);
            label1.MinimumSize = new Size(65, 65);
            label1.Name = "label1";
            label1.Size = new Size(65, 65);
            label1.TabIndex = 5;
            label1.Text = "X ";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = SystemColors.Highlight;
            btnMulti.Cursor = Cursors.Hand;
            btnMulti.FlatAppearance.BorderColor = SystemColors.Window;
            btnMulti.FlatAppearance.BorderSize = 3;
            btnMulti.FlatStyle = FlatStyle.Flat;
            btnMulti.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnMulti.ForeColor = SystemColors.MenuText;
            btnMulti.Location = new Point(258, 198);
            btnMulti.MaximumSize = new Size(100, 65);
            btnMulti.MinimumSize = new Size(100, 65);
            btnMulti.Name = "btnMulti";
            btnMulti.RightToLeft = RightToLeft.Yes;
            btnMulti.Size = new Size(100, 65);
            btnMulti.TabIndex = 7;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += onMultiply;
            // 
            // btnSub
            // 
            btnSub.BackColor = SystemColors.Highlight;
            btnSub.Cursor = Cursors.Hand;
            btnSub.FlatAppearance.BorderColor = SystemColors.Window;
            btnSub.FlatAppearance.BorderSize = 3;
            btnSub.FlatStyle = FlatStyle.Flat;
            btnSub.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSub.ForeColor = SystemColors.MenuText;
            btnSub.Location = new Point(137, 198);
            btnSub.MaximumSize = new Size(100, 65);
            btnSub.MinimumSize = new Size(100, 65);
            btnSub.Name = "btnSub";
            btnSub.RightToLeft = RightToLeft.Yes;
            btnSub.Size = new Size(100, 65);
            btnSub.TabIndex = 8;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += onSubClick;
            // 
            // btnDobro
            // 
            btnDobro.BackColor = SystemColors.Highlight;
            btnDobro.Cursor = Cursors.Hand;
            btnDobro.FlatAppearance.BorderColor = SystemColors.Window;
            btnDobro.FlatAppearance.BorderSize = 3;
            btnDobro.FlatStyle = FlatStyle.Flat;
            btnDobro.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnDobro.ForeColor = SystemColors.MenuText;
            btnDobro.Location = new Point(137, 278);
            btnDobro.MaximumSize = new Size(100, 65);
            btnDobro.MinimumSize = new Size(100, 65);
            btnDobro.Name = "btnDobro";
            btnDobro.RightToLeft = RightToLeft.Yes;
            btnDobro.Size = new Size(100, 65);
            btnDobro.TabIndex = 11;
            btnDobro.Text = "x²";
            btnDobro.UseVisualStyleBackColor = false;
            btnDobro.Click += onSquaredClick;
            // 
            // btnRaiz
            // 
            btnRaiz.BackColor = SystemColors.Highlight;
            btnRaiz.Cursor = Cursors.Hand;
            btnRaiz.FlatAppearance.BorderColor = SystemColors.Window;
            btnRaiz.FlatAppearance.BorderSize = 3;
            btnRaiz.FlatStyle = FlatStyle.Flat;
            btnRaiz.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnRaiz.ForeColor = SystemColors.MenuText;
            btnRaiz.Location = new Point(258, 280);
            btnRaiz.MaximumSize = new Size(100, 65);
            btnRaiz.MinimumSize = new Size(100, 65);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.RightToLeft = RightToLeft.Yes;
            btnRaiz.Size = new Size(100, 65);
            btnRaiz.TabIndex = 10;
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = false;
            btnRaiz.Click += onSquareRootClick;
            // 
            // btnDivi
            // 
            btnDivi.BackColor = SystemColors.Highlight;
            btnDivi.Cursor = Cursors.Hand;
            btnDivi.FlatAppearance.BorderColor = SystemColors.Window;
            btnDivi.FlatAppearance.BorderSize = 3;
            btnDivi.FlatStyle = FlatStyle.Flat;
            btnDivi.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnDivi.ForeColor = SystemColors.MenuText;
            btnDivi.Location = new Point(12, 278);
            btnDivi.MaximumSize = new Size(100, 65);
            btnDivi.MinimumSize = new Size(100, 65);
            btnDivi.Name = "btnDivi";
            btnDivi.RightToLeft = RightToLeft.Yes;
            btnDivi.Size = new Size(100, 65);
            btnDivi.TabIndex = 9;
            btnDivi.Text = "/";
            btnDivi.UseVisualStyleBackColor = false;
            btnDivi.Click += onDivideClick;
            // 
            // btnToBinary
            // 
            btnToBinary.BackColor = SystemColors.Highlight;
            btnToBinary.Cursor = Cursors.Hand;
            btnToBinary.FlatAppearance.BorderColor = SystemColors.Window;
            btnToBinary.FlatAppearance.BorderSize = 3;
            btnToBinary.FlatStyle = FlatStyle.Flat;
            btnToBinary.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnToBinary.ForeColor = SystemColors.MenuText;
            btnToBinary.Location = new Point(137, 354);
            btnToBinary.MaximumSize = new Size(100, 65);
            btnToBinary.MinimumSize = new Size(100, 65);
            btnToBinary.Name = "btnToBinary";
            btnToBinary.RightToLeft = RightToLeft.Yes;
            btnToBinary.Size = new Size(100, 65);
            btnToBinary.TabIndex = 14;
            btnToBinary.Text = "010101";
            btnToBinary.UseVisualStyleBackColor = false;
            btnToBinary.Click += onToBinarieClick;
            // 
            // btnXpowOfY
            // 
            btnXpowOfY.BackColor = SystemColors.Highlight;
            btnXpowOfY.Cursor = Cursors.Hand;
            btnXpowOfY.FlatAppearance.BorderColor = SystemColors.Window;
            btnXpowOfY.FlatAppearance.BorderSize = 3;
            btnXpowOfY.FlatStyle = FlatStyle.Flat;
            btnXpowOfY.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnXpowOfY.ForeColor = SystemColors.MenuText;
            btnXpowOfY.Location = new Point(258, 354);
            btnXpowOfY.MaximumSize = new Size(100, 65);
            btnXpowOfY.MinimumSize = new Size(100, 65);
            btnXpowOfY.Name = "btnXpowOfY";
            btnXpowOfY.RightToLeft = RightToLeft.Yes;
            btnXpowOfY.Size = new Size(100, 65);
            btnXpowOfY.TabIndex = 13;
            btnXpowOfY.Text = "x^y";
            btnXpowOfY.UseVisualStyleBackColor = false;
            btnXpowOfY.Click += onXRaisedToY;
            // 
            // btnPorcent
            // 
            btnPorcent.BackColor = SystemColors.Highlight;
            btnPorcent.Cursor = Cursors.Hand;
            btnPorcent.FlatAppearance.BorderColor = SystemColors.Window;
            btnPorcent.FlatAppearance.BorderSize = 3;
            btnPorcent.FlatStyle = FlatStyle.Flat;
            btnPorcent.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPorcent.ForeColor = SystemColors.MenuText;
            btnPorcent.Location = new Point(12, 354);
            btnPorcent.MaximumSize = new Size(100, 65);
            btnPorcent.MinimumSize = new Size(100, 65);
            btnPorcent.Name = "btnPorcent";
            btnPorcent.RightToLeft = RightToLeft.Yes;
            btnPorcent.Size = new Size(100, 65);
            btnPorcent.TabIndex = 12;
            btnPorcent.Text = "%";
            btnPorcent.UseVisualStyleBackColor = false;
            btnPorcent.Click += onPercentageClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(12, 123);
            label2.MaximumSize = new Size(65, 65);
            label2.MinimumSize = new Size(65, 65);
            label2.Name = "label2";
            label2.Size = new Size(65, 65);
            label2.TabIndex = 15;
            label2.Text = "Y";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelResult.ForeColor = Color.Coral;
            labelResult.Location = new Point(461, 156);
            labelResult.MaximumSize = new Size(300, 65);
            labelResult.MinimumSize = new Size(300, 65);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(300, 65);
            labelResult.TabIndex = 16;
            labelResult.Text = "...";
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            labelResult.Visible = false;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(62, 83, 102);
            ClientSize = new Size(807, 431);
            Controls.Add(labelResult);
            Controls.Add(label2);
            Controls.Add(btnToBinary);
            Controls.Add(btnXpowOfY);
            Controls.Add(btnPorcent);
            Controls.Add(btnDobro);
            Controls.Add(btnRaiz);
            Controls.Add(btnDivi);
            Controls.Add(btnSub);
            Controls.Add(btnMulti);
            Controls.Add(label1);
            Controls.Add(inputTextX);
            Controls.Add(labelOutput);
            Controls.Add(labelTitle);
            Controls.Add(btnSoma);
            Controls.Add(inputTextY);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CALCULATOR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextY;
        private Button btnSoma;
        private Label labelTitle;
        private Label labelOutput;
        private TextBox inputTextX;
        private Label label1;
        private Button btnMulti;
        private Button btnSub;
        private Button btnDobro;
        private Button btnRaiz;
        private Button btnDivi;
        private Button btnToBinary;
        private Button btnXpowOfY;
        private Button btnPorcent;
        private Label label2;
        private Label labelResult;
    }
}
