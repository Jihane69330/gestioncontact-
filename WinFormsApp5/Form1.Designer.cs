namespace WinFormsApp5
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
            groupBox1 = new GroupBox();
            txtNom = new Label();
            txtEmail = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnAfficheresultat = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAfficheresultat);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtNom);
            groupBox1.Location = new Point(134, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(495, 265);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contact";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtNom
            // 
            txtNom.AutoSize = true;
            txtNom.Location = new Point(74, 63);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(42, 20);
            txtNom.TabIndex = 0;
            txtNom.Text = "Nom";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Location = new Point(74, 113);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(46, 20);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(302, 63);
            label3.Name = "label3";
            label3.Size = new Size(192, 20);
            label3.TabIndex = 2;
            label3.Text = "Le champs doit être remplit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(302, 113);
            label4.Name = "label4";
            label4.Size = new Size(192, 20);
            label4.TabIndex = 3;
            label4.Text = "Le champs doit être remplit";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(134, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(111, 27);
            textBox2.TabIndex = 5;
            // 
            // btnAfficheresultat
            // 
            btnAfficheresultat.Location = new Point(134, 191);
            btnAfficheresultat.Name = "btnAfficheresultat";
            btnAfficheresultat.Size = new Size(138, 29);
            btnAfficheresultat.TabIndex = 6;
            btnAfficheresultat.Text = "Afficher le résultat";
            btnAfficheresultat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAfficheresultat;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label txtEmail;
        private Label txtNom;
    }
}