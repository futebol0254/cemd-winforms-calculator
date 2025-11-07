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
            btnBina = new Button();
            button7 = new Button();
            btnPoten = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // inputTextY
            // 
            inputTextY.Location = new Point(83, 142);
            inputTextY.Name = "inputTextY";
            inputTextY.Size = new Size(187, 31);
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
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.BackColor = Color.FromArgb(40, 42, 54);
            labelOutput.ForeColor = Color.White;
            labelOutput.Location = new Point(373, 21);
            labelOutput.MaximumSize = new Size(400, 350);
            labelOutput.MinimumSize = new Size(400, 350);
            labelOutput.Name = "labelOutput";
            labelOutput.Padding = new Padding(10);
            labelOutput.Size = new Size(400, 350);
            labelOutput.TabIndex = 4;
            labelOutput.Text = "...";
            labelOutput.Visible = false;
            // 
            // inputTextX
            // 
            inputTextX.Location = new Point(83, 77);
            inputTextX.Name = "inputTextX";
            inputTextX.Size = new Size(187, 31);
            inputTextX.TabIndex = 1;
            inputTextX.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(12, 58);
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
            btnSub.Click += btnSub_Click;
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
            // 
            // btnBina
            // 
            btnBina.BackColor = SystemColors.Highlight;
            btnBina.Cursor = Cursors.Hand;
            btnBina.FlatAppearance.BorderColor = SystemColors.Window;
            btnBina.FlatAppearance.BorderSize = 3;
            btnBina.FlatStyle = FlatStyle.Flat;
            btnBina.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnBina.ForeColor = SystemColors.MenuText;
            btnBina.Location = new Point(137, 354);
            btnBina.MaximumSize = new Size(100, 65);
            btnBina.MinimumSize = new Size(100, 65);
            btnBina.Name = "btnBina";
            btnBina.RightToLeft = RightToLeft.Yes;
            btnBina.Size = new Size(100, 65);
            btnBina.TabIndex = 14;
            btnBina.Text = "010101";
            btnBina.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Highlight;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = SystemColors.Window;
            button7.FlatAppearance.BorderSize = 3;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button7.ForeColor = SystemColors.MenuText;
            button7.Location = new Point(258, 354);
            button7.MaximumSize = new Size(100, 65);
            button7.MinimumSize = new Size(100, 65);
            button7.Name = "button7";
            button7.RightToLeft = RightToLeft.Yes;
            button7.Size = new Size(100, 65);
            button7.TabIndex = 13;
            button7.Text = "x^y";
            button7.UseVisualStyleBackColor = false;
            // 
            // btnPoten
            // 
            btnPoten.BackColor = SystemColors.Highlight;
            btnPoten.Cursor = Cursors.Hand;
            btnPoten.FlatAppearance.BorderColor = SystemColors.Window;
            btnPoten.FlatAppearance.BorderSize = 3;
            btnPoten.FlatStyle = FlatStyle.Flat;
            btnPoten.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPoten.ForeColor = SystemColors.MenuText;
            btnPoten.Location = new Point(12, 354);
            btnPoten.MaximumSize = new Size(100, 65);
            btnPoten.MinimumSize = new Size(100, 65);
            btnPoten.Name = "btnPoten";
            btnPoten.RightToLeft = RightToLeft.Yes;
            btnPoten.Size = new Size(100, 65);
            btnPoten.TabIndex = 12;
            btnPoten.Text = "%";
            btnPoten.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(3, 123);
            label2.MaximumSize = new Size(65, 65);
            label2.MinimumSize = new Size(65, 65);
            label2.Name = "label2";
            label2.Size = new Size(65, 65);
            label2.TabIndex = 15;
            label2.Text = "Y";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(62, 83, 102);
            ClientSize = new Size(762, 431);
            Controls.Add(label2);
            Controls.Add(btnBina);
            Controls.Add(button7);
            Controls.Add(btnPoten);
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
            Text = "VLS CALCULATOR";
            Load += Form1_Load;
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
        private Button btnBina;
        private Button button7;
        private Button btnPoten;
        private Label label2;
    }
}
