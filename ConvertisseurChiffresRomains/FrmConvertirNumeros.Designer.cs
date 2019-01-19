namespace ConvertisseurChiffresRomains
{
    partial class FrmConvertirNumeros
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
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelTitreNumero = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxChiffreRomain = new System.Windows.Forms.TextBox();
            this.labelChiffreRomain = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnConvertirGeneral = new System.Windows.Forms.Button();
            this.textBoxListeNumeros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(122, 9);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(249, 18);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Convertisseur Chiffres Romains";
            // 
            // labelTitreNumero
            // 
            this.labelTitreNumero.AutoSize = true;
            this.labelTitreNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreNumero.Location = new System.Drawing.Point(21, 50);
            this.labelTitreNumero.Name = "labelTitreNumero";
            this.labelTitreNumero.Size = new System.Drawing.Size(125, 18);
            this.labelTitreNumero.TabIndex = 1;
            this.labelTitreNumero.Text = "Entrez le numéro:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumero.Location = new System.Drawing.Point(24, 80);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(122, 24);
            this.textBoxNumero.TabIndex = 2;
            this.textBoxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumero_KeyPress);
            // 
            // textBoxChiffreRomain
            // 
            this.textBoxChiffreRomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChiffreRomain.Location = new System.Drawing.Point(358, 80);
            this.textBoxChiffreRomain.Name = "textBoxChiffreRomain";
            this.textBoxChiffreRomain.ReadOnly = true;
            this.textBoxChiffreRomain.Size = new System.Drawing.Size(122, 24);
            this.textBoxChiffreRomain.TabIndex = 4;
            // 
            // labelChiffreRomain
            // 
            this.labelChiffreRomain.AutoSize = true;
            this.labelChiffreRomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChiffreRomain.Location = new System.Drawing.Point(355, 50);
            this.labelChiffreRomain.Name = "labelChiffreRomain";
            this.labelChiffreRomain.Size = new System.Drawing.Size(105, 18);
            this.labelChiffreRomain.TabIndex = 3;
            this.labelChiffreRomain.Text = "Chiffre romain:";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(216, 78);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(88, 29);
            this.btnConvertir.TabIndex = 5;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnConvertirGeneral
            // 
            this.btnConvertirGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirGeneral.Location = new System.Drawing.Point(24, 142);
            this.btnConvertirGeneral.Name = "btnConvertirGeneral";
            this.btnConvertirGeneral.Size = new System.Drawing.Size(456, 29);
            this.btnConvertirGeneral.TabIndex = 6;
            this.btnConvertirGeneral.Text = "Convertir numéros entre 1 et 3999";
            this.btnConvertirGeneral.UseVisualStyleBackColor = true;
            this.btnConvertirGeneral.Click += new System.EventHandler(this.btnConvertirGeneral_Click);
            // 
            // textBoxListeNumeros
            // 
            this.textBoxListeNumeros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxListeNumeros.Location = new System.Drawing.Point(24, 194);
            this.textBoxListeNumeros.Multiline = true;
            this.textBoxListeNumeros.Name = "textBoxListeNumeros";
            this.textBoxListeNumeros.ReadOnly = true;
            this.textBoxListeNumeros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxListeNumeros.Size = new System.Drawing.Size(456, 151);
            this.textBoxListeNumeros.TabIndex = 7;
            // 
            // FrmConvertirNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 357);
            this.Controls.Add(this.textBoxListeNumeros);
            this.Controls.Add(this.btnConvertirGeneral);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.textBoxChiffreRomain);
            this.Controls.Add(this.labelChiffreRomain);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelTitreNumero);
            this.Controls.Add(this.labelTitre);
            this.Name = "FrmConvertirNumeros";
            this.Text = "Convertir numéros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelTitreNumero;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxChiffreRomain;
        private System.Windows.Forms.Label labelChiffreRomain;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnConvertirGeneral;
        private System.Windows.Forms.TextBox textBoxListeNumeros;
    }
}

