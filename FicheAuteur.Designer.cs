namespace WinFormsApp3
{
    partial class FicheAuteur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Num = new System.Windows.Forms.Label();
            this.label_Nom = new System.Windows.Forms.Label();
            this.label_Prenom = new System.Windows.Forms.Label();
            this.label_Nation = new System.Windows.Forms.Label();
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.txt_Prenom = new System.Windows.Forms.TextBox();
            this.txt_Nation = new System.Windows.Forms.TextBox();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Num
            // 
            this.label_Num.AutoSize = true;
            this.label_Num.Location = new System.Drawing.Point(48, 54);
            this.label_Num.Name = "label_Num";
            this.label_Num.Size = new System.Drawing.Size(51, 15);
            this.label_Num.TabIndex = 0;
            this.label_Num.Text = "Numéro";
            // 
            // label_Nom
            // 
            this.label_Nom.AutoSize = true;
            this.label_Nom.Location = new System.Drawing.Point(48, 83);
            this.label_Nom.Name = "label_Nom";
            this.label_Nom.Size = new System.Drawing.Size(34, 15);
            this.label_Nom.TabIndex = 1;
            this.label_Nom.Text = "Nom";
            // 
            // label_Prenom
            // 
            this.label_Prenom.AutoSize = true;
            this.label_Prenom.Location = new System.Drawing.Point(48, 112);
            this.label_Prenom.Name = "label_Prenom";
            this.label_Prenom.Size = new System.Drawing.Size(49, 15);
            this.label_Prenom.TabIndex = 2;
            this.label_Prenom.Text = "Prénom";
            // 
            // label_Nation
            // 
            this.label_Nation.AutoSize = true;
            this.label_Nation.Location = new System.Drawing.Point(48, 141);
            this.label_Nation.Name = "label_Nation";
            this.label_Nation.Size = new System.Drawing.Size(65, 15);
            this.label_Nation.TabIndex = 3;
            this.label_Nation.Text = "Nationalité";
            // 
            // txt_Num
            // 
            this.txt_Num.Enabled = false;
            this.txt_Num.Location = new System.Drawing.Point(127, 51);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(100, 23);
            this.txt_Num.TabIndex = 4;
            // 
            // txt_Nom
            // 
            this.txt_Nom.Location = new System.Drawing.Point(127, 80);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(100, 23);
            this.txt_Nom.TabIndex = 5;
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.Location = new System.Drawing.Point(127, 109);
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(100, 23);
            this.txt_Prenom.TabIndex = 6;
            // 
            // txt_Nation
            // 
            this.txt_Nation.Location = new System.Drawing.Point(127, 138);
            this.txt_Nation.Name = "txt_Nation";
            this.txt_Nation.Size = new System.Drawing.Size(100, 23);
            this.txt_Nation.TabIndex = 7;
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(48, 187);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuler.TabIndex = 8;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(152, 187);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(75, 23);
            this.btn_Valider.TabIndex = 9;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fiche de l\'auteur";
            // 
            // FicheAuteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 236);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.txt_Nation);
            this.Controls.Add(this.txt_Prenom);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.txt_Num);
            this.Controls.Add(this.label_Nation);
            this.Controls.Add(this.label_Prenom);
            this.Controls.Add(this.label_Nom);
            this.Controls.Add(this.label_Num);
            this.Name = "FicheAuteur";
            this.Text = "FicheAuteur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Num;
        private Label label_Nom;
        private Label label_Prenom;
        private Label label_Nation;
        private TextBox txt_Num;
        private TextBox txt_Nom;
        private TextBox txt_Prenom;
        private TextBox txt_Nation;
        private Button btn_Annuler;
        private Button btn_Valider;
        private Label label1;
    }
}