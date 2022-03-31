namespace Trie
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.cb_doc = new System.Windows.Forms.CheckBox();
            this.cb_img = new System.Windows.Forms.CheckBox();
            this.cb_msq = new System.Windows.Forms.CheckBox();
            this.cb_vid = new System.Windows.Forms.CheckBox();
            this.cb_stp = new System.Windows.Forms.CheckBox();
            this.cb_rar = new System.Windows.Forms.CheckBox();
            this.cb_dev = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog4 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog5 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog6 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog7 = new System.Windows.Forms.FolderBrowserDialog();
            this.tb_doc = new System.Windows.Forms.TextBox();
            this.tb_img = new System.Windows.Forms.TextBox();
            this.tb_msq = new System.Windows.Forms.TextBox();
            this.tb_vid = new System.Windows.Forms.TextBox();
            this.tb_stp = new System.Windows.Forms.TextBox();
            this.tb_dev = new System.Windows.Forms.TextBox();
            this.tb_rar = new System.Windows.Forms.TextBox();
            this.bt_doc = new System.Windows.Forms.Button();
            this.bt_img = new System.Windows.Forms.Button();
            this.bt_msq = new System.Windows.Forms.Button();
            this.bt_vid = new System.Windows.Forms.Button();
            this.bt_stp = new System.Windows.Forms.Button();
            this.bt_rar = new System.Windows.Forms.Button();
            this.bt_dev = new System.Windows.Forms.Button();
            this.cb_gif = new System.Windows.Forms.CheckBox();
            this.tb_gif = new System.Windows.Forms.TextBox();
            this.bt_gif = new System.Windows.Forms.Button();
            this.tb_dossier = new System.Windows.Forms.TextBox();
            this.bt_dossier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.bt_valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_doc
            // 
            this.cb_doc.AutoSize = true;
            this.cb_doc.Location = new System.Drawing.Point(45, 87);
            this.cb_doc.Name = "cb_doc";
            this.cb_doc.Size = new System.Drawing.Size(101, 21);
            this.cb_doc.TabIndex = 0;
            this.cb_doc.Text = "Documents";
            this.cb_doc.UseVisualStyleBackColor = true;
            this.cb_doc.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // cb_img
            // 
            this.cb_img.AutoSize = true;
            this.cb_img.Location = new System.Drawing.Point(45, 134);
            this.cb_img.Name = "cb_img";
            this.cb_img.Size = new System.Drawing.Size(75, 21);
            this.cb_img.TabIndex = 1;
            this.cb_img.Text = "Images";
            this.cb_img.UseVisualStyleBackColor = true;
            this.cb_img.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // cb_msq
            // 
            this.cb_msq.AutoSize = true;
            this.cb_msq.Location = new System.Drawing.Point(45, 184);
            this.cb_msq.Name = "cb_msq";
            this.cb_msq.Size = new System.Drawing.Size(90, 21);
            this.cb_msq.TabIndex = 2;
            this.cb_msq.Text = "Musiques";
            this.cb_msq.UseVisualStyleBackColor = true;
            this.cb_msq.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // cb_vid
            // 
            this.cb_vid.AutoSize = true;
            this.cb_vid.Location = new System.Drawing.Point(45, 230);
            this.cb_vid.Name = "cb_vid";
            this.cb_vid.Size = new System.Drawing.Size(73, 21);
            this.cb_vid.TabIndex = 3;
            this.cb_vid.Text = "Videos";
            this.cb_vid.UseVisualStyleBackColor = true;
            this.cb_vid.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // cb_stp
            // 
            this.cb_stp.AutoSize = true;
            this.cb_stp.Location = new System.Drawing.Point(45, 282);
            this.cb_stp.Name = "cb_stp";
            this.cb_stp.Size = new System.Drawing.Size(67, 21);
            this.cb_stp.TabIndex = 4;
            this.cb_stp.Text = "Setup";
            this.cb_stp.UseVisualStyleBackColor = true;
            this.cb_stp.CheckedChanged += new System.EventHandler(this.CheckBox5_CheckedChanged);
            // 
            // cb_rar
            // 
            this.cb_rar.AutoSize = true;
            this.cb_rar.Location = new System.Drawing.Point(45, 331);
            this.cb_rar.Name = "cb_rar";
            this.cb_rar.Size = new System.Drawing.Size(84, 21);
            this.cb_rar.TabIndex = 5;
            this.cb_rar.Text = "Archives";
            this.cb_rar.UseVisualStyleBackColor = true;
            this.cb_rar.CheckedChanged += new System.EventHandler(this.CheckBox6_CheckedChanged);
            // 
            // cb_dev
            // 
            this.cb_dev.AutoSize = true;
            this.cb_dev.Location = new System.Drawing.Point(45, 398);
            this.cb_dev.Name = "cb_dev";
            this.cb_dev.Size = new System.Drawing.Size(129, 21);
            this.cb_dev.TabIndex = 6;
            this.cb_dev.Text = "Developpement";
            this.cb_dev.UseVisualStyleBackColor = true;
            this.cb_dev.CheckedChanged += new System.EventHandler(this.CheckBox7_CheckedChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.FolderBrowserDialog1_HelpRequest);
            // 
            // tb_doc
            // 
            this.tb_doc.Enabled = false;
            this.tb_doc.Location = new System.Drawing.Point(197, 87);
            this.tb_doc.Name = "tb_doc";
            this.tb_doc.Size = new System.Drawing.Size(158, 22);
            this.tb_doc.TabIndex = 7;
            // 
            // tb_img
            // 
            this.tb_img.Enabled = false;
            this.tb_img.Location = new System.Drawing.Point(197, 134);
            this.tb_img.Name = "tb_img";
            this.tb_img.Size = new System.Drawing.Size(158, 22);
            this.tb_img.TabIndex = 8;
            // 
            // tb_msq
            // 
            this.tb_msq.Enabled = false;
            this.tb_msq.Location = new System.Drawing.Point(197, 183);
            this.tb_msq.Name = "tb_msq";
            this.tb_msq.Size = new System.Drawing.Size(158, 22);
            this.tb_msq.TabIndex = 9;
            // 
            // tb_vid
            // 
            this.tb_vid.Enabled = false;
            this.tb_vid.Location = new System.Drawing.Point(197, 230);
            this.tb_vid.Name = "tb_vid";
            this.tb_vid.Size = new System.Drawing.Size(158, 22);
            this.tb_vid.TabIndex = 10;
            // 
            // tb_stp
            // 
            this.tb_stp.Enabled = false;
            this.tb_stp.Location = new System.Drawing.Point(197, 282);
            this.tb_stp.Name = "tb_stp";
            this.tb_stp.Size = new System.Drawing.Size(158, 22);
            this.tb_stp.TabIndex = 11;
            // 
            // tb_dev
            // 
            this.tb_dev.Enabled = false;
            this.tb_dev.Location = new System.Drawing.Point(197, 396);
            this.tb_dev.Name = "tb_dev";
            this.tb_dev.Size = new System.Drawing.Size(158, 22);
            this.tb_dev.TabIndex = 12;
            // 
            // tb_rar
            // 
            this.tb_rar.Enabled = false;
            this.tb_rar.Location = new System.Drawing.Point(197, 331);
            this.tb_rar.Name = "tb_rar";
            this.tb_rar.Size = new System.Drawing.Size(158, 22);
            this.tb_rar.TabIndex = 12;
            // 
            // bt_doc
            // 
            this.bt_doc.Enabled = false;
            this.bt_doc.Location = new System.Drawing.Point(376, 85);
            this.bt_doc.Name = "bt_doc";
            this.bt_doc.Size = new System.Drawing.Size(75, 23);
            this.bt_doc.TabIndex = 13;
            this.bt_doc.Text = "dossier";
            this.bt_doc.UseVisualStyleBackColor = true;
            this.bt_doc.Click += new System.EventHandler(this.Bt_doc_Click);
            // 
            // bt_img
            // 
            this.bt_img.Enabled = false;
            this.bt_img.Location = new System.Drawing.Point(376, 134);
            this.bt_img.Name = "bt_img";
            this.bt_img.Size = new System.Drawing.Size(75, 23);
            this.bt_img.TabIndex = 14;
            this.bt_img.Text = "dossier";
            this.bt_img.UseVisualStyleBackColor = true;
            this.bt_img.Click += new System.EventHandler(this.Bt_img_Click);
            // 
            // bt_msq
            // 
            this.bt_msq.Enabled = false;
            this.bt_msq.Location = new System.Drawing.Point(376, 184);
            this.bt_msq.Name = "bt_msq";
            this.bt_msq.Size = new System.Drawing.Size(75, 23);
            this.bt_msq.TabIndex = 15;
            this.bt_msq.Text = "dossier";
            this.bt_msq.UseVisualStyleBackColor = true;
            this.bt_msq.Click += new System.EventHandler(this.Bt_msq_Click);
            // 
            // bt_vid
            // 
            this.bt_vid.Enabled = false;
            this.bt_vid.Location = new System.Drawing.Point(376, 230);
            this.bt_vid.Name = "bt_vid";
            this.bt_vid.Size = new System.Drawing.Size(75, 23);
            this.bt_vid.TabIndex = 16;
            this.bt_vid.Text = "dossier";
            this.bt_vid.UseVisualStyleBackColor = true;
            this.bt_vid.Click += new System.EventHandler(this.Bt_vid_Click);
            // 
            // bt_stp
            // 
            this.bt_stp.Enabled = false;
            this.bt_stp.Location = new System.Drawing.Point(376, 281);
            this.bt_stp.Name = "bt_stp";
            this.bt_stp.Size = new System.Drawing.Size(75, 23);
            this.bt_stp.TabIndex = 17;
            this.bt_stp.Text = "dossier";
            this.bt_stp.UseVisualStyleBackColor = true;
            this.bt_stp.Click += new System.EventHandler(this.Bt_stp_Click);
            // 
            // bt_rar
            // 
            this.bt_rar.Enabled = false;
            this.bt_rar.Location = new System.Drawing.Point(376, 329);
            this.bt_rar.Name = "bt_rar";
            this.bt_rar.Size = new System.Drawing.Size(75, 23);
            this.bt_rar.TabIndex = 18;
            this.bt_rar.Text = "dossier";
            this.bt_rar.UseVisualStyleBackColor = true;
            this.bt_rar.Click += new System.EventHandler(this.Bt_rar_Click);
            // 
            // bt_dev
            // 
            this.bt_dev.Enabled = false;
            this.bt_dev.Location = new System.Drawing.Point(376, 395);
            this.bt_dev.Name = "bt_dev";
            this.bt_dev.Size = new System.Drawing.Size(75, 23);
            this.bt_dev.TabIndex = 19;
            this.bt_dev.Text = "dossier";
            this.bt_dev.UseVisualStyleBackColor = true;
            this.bt_dev.Click += new System.EventHandler(this.Bt_dev_Click);
            // 
            // cb_gif
            // 
            this.cb_gif.AutoSize = true;
            this.cb_gif.Location = new System.Drawing.Point(497, 135);
            this.cb_gif.Name = "cb_gif";
            this.cb_gif.Size = new System.Drawing.Size(55, 21);
            this.cb_gif.TabIndex = 20;
            this.cb_gif.Text = "Gifs";
            this.cb_gif.UseVisualStyleBackColor = true;
            this.cb_gif.CheckedChanged += new System.EventHandler(this.CheckBox8_CheckedChanged);
            // 
            // tb_gif
            // 
            this.tb_gif.Enabled = false;
            this.tb_gif.Location = new System.Drawing.Point(574, 135);
            this.tb_gif.Name = "tb_gif";
            this.tb_gif.Size = new System.Drawing.Size(100, 22);
            this.tb_gif.TabIndex = 21;
            // 
            // bt_gif
            // 
            this.bt_gif.Enabled = false;
            this.bt_gif.Location = new System.Drawing.Point(700, 135);
            this.bt_gif.Name = "bt_gif";
            this.bt_gif.Size = new System.Drawing.Size(75, 23);
            this.bt_gif.TabIndex = 22;
            this.bt_gif.Text = "dossier";
            this.bt_gif.UseVisualStyleBackColor = true;
            this.bt_gif.Click += new System.EventHandler(this.Bt_gif_Click);
            // 
            // tb_dossier
            // 
            this.tb_dossier.Enabled = false;
            this.tb_dossier.Location = new System.Drawing.Point(98, 31);
            this.tb_dossier.Name = "tb_dossier";
            this.tb_dossier.Size = new System.Drawing.Size(100, 22);
            this.tb_dossier.TabIndex = 23;
            // 
            // bt_dossier
            // 
            this.bt_dossier.Location = new System.Drawing.Point(221, 31);
            this.bt_dossier.Name = "bt_dossier";
            this.bt_dossier.Size = new System.Drawing.Size(75, 23);
            this.bt_dossier.TabIndex = 24;
            this.bt_dossier.Text = "dossier";
            this.bt_dossier.UseVisualStyleBackColor = true;
            this.bt_dossier.Click += new System.EventHandler(this.Button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Dossier a trier";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(688, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 26);
            this.button10.TabIndex = 26;
            this.button10.Text = "Spécial";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(544, 376);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(162, 43);
            this.bt_valider.TabIndex = 27;
            this.bt_valider.Text = "Valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.Bt_valider_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_dossier);
            this.Controls.Add(this.tb_dossier);
            this.Controls.Add(this.bt_gif);
            this.Controls.Add(this.tb_gif);
            this.Controls.Add(this.cb_gif);
            this.Controls.Add(this.bt_dev);
            this.Controls.Add(this.bt_rar);
            this.Controls.Add(this.bt_stp);
            this.Controls.Add(this.bt_vid);
            this.Controls.Add(this.bt_msq);
            this.Controls.Add(this.bt_img);
            this.Controls.Add(this.bt_doc);
            this.Controls.Add(this.tb_rar);
            this.Controls.Add(this.tb_dev);
            this.Controls.Add(this.tb_stp);
            this.Controls.Add(this.tb_vid);
            this.Controls.Add(this.tb_msq);
            this.Controls.Add(this.tb_img);
            this.Controls.Add(this.tb_doc);
            this.Controls.Add(this.cb_dev);
            this.Controls.Add(this.cb_rar);
            this.Controls.Add(this.cb_stp);
            this.Controls.Add(this.cb_vid);
            this.Controls.Add(this.cb_msq);
            this.Controls.Add(this.cb_img);
            this.Controls.Add(this.cb_doc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Trieur de dossier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_doc;
        private System.Windows.Forms.CheckBox cb_img;
        private System.Windows.Forms.CheckBox cb_msq;
        private System.Windows.Forms.CheckBox cb_vid;
        private System.Windows.Forms.CheckBox cb_stp;
        private System.Windows.Forms.CheckBox cb_rar;
        private System.Windows.Forms.CheckBox cb_dev;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog7;
        private System.Windows.Forms.TextBox tb_doc;
        private System.Windows.Forms.TextBox tb_img;
        private System.Windows.Forms.TextBox tb_msq;
        private System.Windows.Forms.TextBox tb_vid;
        private System.Windows.Forms.TextBox tb_stp;
        private System.Windows.Forms.TextBox tb_dev;
        private System.Windows.Forms.TextBox tb_rar;
        private System.Windows.Forms.Button bt_doc;
        private System.Windows.Forms.Button bt_img;
        private System.Windows.Forms.Button bt_msq;
        private System.Windows.Forms.Button bt_vid;
        private System.Windows.Forms.Button bt_stp;
        private System.Windows.Forms.Button bt_rar;
        private System.Windows.Forms.Button bt_dev;
        private System.Windows.Forms.CheckBox cb_gif;
        private System.Windows.Forms.TextBox tb_gif;
        private System.Windows.Forms.Button bt_gif;
        private System.Windows.Forms.TextBox tb_dossier;
        private System.Windows.Forms.Button bt_dossier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button bt_valider;
    }
}