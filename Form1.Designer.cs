namespace Trie
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(623, 391);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(139, 47);
            this.btn_settings.TabIndex = 0;
            this.btn_settings.Text = "Paramètres";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.Btn_settings_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(309, 171);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(167, 78);
            this.btn_create.TabIndex = 1;
            this.btn_create.Text = "Créer fichier";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.Btn_create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_settings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_create;
    }
}

