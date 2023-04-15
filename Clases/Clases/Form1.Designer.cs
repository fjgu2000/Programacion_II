namespace Clases
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
            label1 = new Label();
            txtnum1 = new TextBox();
            btnres = new Button();
            txtnum2 = new TextBox();
            label2 = new Label();
            lbres = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            optsum = new RadioButton();
            optres = new RadioButton();
            optdiv = new RadioButton();
            optmul = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 0;
            label1.Text = "Nùmero 1";
            // 
            // txtnum1
            // 
            txtnum1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtnum1.Location = new Point(12, 44);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(100, 25);
            txtnum1.TabIndex = 1;
            // 
            // btnres
            // 
            btnres.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnres.Location = new Point(51, 123);
            btnres.Name = "btnres";
            btnres.Size = new Size(87, 30);
            btnres.TabIndex = 2;
            btnres.Text = "Resultado";
            btnres.UseVisualStyleBackColor = true;
            btnres.Click += btnres_Click;
            // 
            // txtnum2
            // 
            txtnum2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtnum2.Location = new Point(171, 44);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(100, 25);
            txtnum2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(171, 9);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 3;
            label2.Text = "Número 2";
            // 
            // lbres
            // 
            lbres.AutoSize = true;
            lbres.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbres.Location = new Point(187, 173);
            lbres.Name = "lbres";
            lbres.Size = new Size(0, 17);
            lbres.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(331, 9);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 6;
            label3.Text = "Operación";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "1 para Suma", "2 Para Resta", "3 Para Multiplicar", "4 Para Dividir" });
            listBox1.Location = new Point(318, 29);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // optsum
            // 
            optsum.AutoSize = true;
            optsum.Location = new Point(325, 141);
            optsum.Name = "optsum";
            optsum.Size = new Size(55, 19);
            optsum.TabIndex = 8;
            optsum.TabStop = true;
            optsum.Text = "Suma";
            optsum.UseVisualStyleBackColor = true;
            // 
            // optres
            // 
            optres.AutoSize = true;
            optres.Location = new Point(325, 166);
            optres.Name = "optres";
            optres.Size = new Size(53, 19);
            optres.TabIndex = 9;
            optres.TabStop = true;
            optres.Text = "Resta";
            optres.UseVisualStyleBackColor = true;
            // 
            // optdiv
            // 
            optdiv.AutoSize = true;
            optdiv.Location = new Point(325, 216);
            optdiv.Name = "optdiv";
            optdiv.Size = new Size(59, 19);
            optdiv.TabIndex = 11;
            optdiv.TabStop = true;
            optdiv.Text = "Dividir";
            optdiv.UseVisualStyleBackColor = true;
            // 
            // optmul
            // 
            optmul.AutoSize = true;
            optmul.Location = new Point(325, 191);
            optmul.Name = "optmul";
            optmul.Size = new Size(82, 19);
            optmul.TabIndex = 10;
            optmul.TabStop = true;
            optmul.Text = "Multiplicar";
            optmul.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 243);
            Controls.Add(optdiv);
            Controls.Add(optmul);
            Controls.Add(optres);
            Controls.Add(optsum);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(lbres);
            Controls.Add(txtnum2);
            Controls.Add(label2);
            Controls.Add(btnres);
            Controls.Add(txtnum1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnum1;
        private Button btnres;
        private TextBox txtnum2;
        private Label label2;
        private Label lbres;
        private Label label3;
        private ListBox listBox1;
        private RadioButton optsum;
        private RadioButton optres;
        private RadioButton optdiv;
        private RadioButton optmul;
    }
}