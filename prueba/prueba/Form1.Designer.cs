namespace prueba
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
            btnenviar = new Button();
            txtusu = new TextBox();
            txtcon = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnenviar
            // 
            btnenviar.Location = new Point(71, 126);
            btnenviar.Name = "btnenviar";
            btnenviar.Size = new Size(75, 23);
            btnenviar.TabIndex = 0;
            btnenviar.Text = "Enviar";
            btnenviar.UseVisualStyleBackColor = true;
            btnenviar.Click += btnenviar_Click;
            // 
            // txtusu
            // 
            txtusu.Location = new Point(71, 24);
            txtusu.Name = "txtusu";
            txtusu.Size = new Size(100, 23);
            txtusu.TabIndex = 1;
            // 
            // txtcon
            // 
            txtcon.Location = new Point(71, 72);
            txtcon.Name = "txtcon";
            txtcon.Size = new Size(100, 23);
            txtcon.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 6);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 50);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 183);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtcon);
            Controls.Add(txtusu);
            Controls.Add(btnenviar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnenviar;
        private TextBox txtusu;
        private TextBox txtcon;
        private Label label1;
        private Label label2;
    }
}