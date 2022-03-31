using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace Trie
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

        }

        public void ChooseFolder(ref string txt_box)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //tb_doc.Text = folderBrowserDialog1.SelectedPath;
                txt_box = folderBrowserDialog1.SelectedPath;
            }
        }

        private void FolderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_doc.Checked == true)
            {
                Bt_doc_Click(e, e);
                //tb_doc.Enabled = true;
                bt_doc.Enabled = true;
            }
            
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_img.Checked == true)
            {
                Bt_img_Click(e, e);
                tb_img.Enabled = true;
                bt_img.Enabled = true;
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_msq.Checked == true)
            {
                Bt_msq_Click(e, e);
                tb_msq.Enabled = true;
                bt_msq.Enabled = true;
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_vid.Checked == true)
            {
                Bt_vid_Click(e, e);
                tb_vid.Enabled = true;
                bt_vid.Enabled = true;
            }
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_stp.Checked == true)
            {
                Bt_stp_Click(e, e);
                tb_stp.Enabled = true;
                bt_stp.Enabled = true;
            }
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_rar.Checked == true)
            {
                Bt_rar_Click(e, e);
                tb_rar.Enabled = true;
                bt_rar.Enabled = true;
            }
        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_dev.Checked == true)
            {
                Bt_dev_Click(e, e);
                tb_dev.Enabled = true;
                bt_dev.Enabled = true;
            }
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            string f = "";
            ChooseFolder(ref f);
            tb_dossier.Text = f;
        }

        private void Bt_doc_Click(object sender, EventArgs e)
        {
            string f = "";
            ChooseFolder(ref f);
            tb_doc.Text = f;
        }

        private void Bt_img_Click(object sender, EventArgs e)
        {
            string f = "";
            ChooseFolder(ref f);
            tb_img.Text = f;
        }

        private void Bt_msq_Click(object sender, EventArgs e)
        {
            string f = "";
            ChooseFolder(ref f);
            tb_msq.Text = f;
        }

        private void Bt_vid_Click(object sender, EventArgs e)
        {
            string f = "";
            ChooseFolder(ref f);
            tb_vid.Text = f;
        }

        private void Bt_stp_Click(object sender, EventArgs e)
        {
            string f = "";
            ChooseFolder(ref f);
            tb_stp.Text = f;
        }

        private void Bt_rar_Click(object sender, EventArgs e)
        {
            string f = "";
            ChooseFolder(ref f);
            tb_rar.Text = f;
        }

        private void Bt_dev_Click(object sender, EventArgs e)
        {
            string f = "";
            ChooseFolder(ref f);
            tb_dev.Text = f;
        }

        private void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_gif.Checked == true)
            {
                Bt_gif_Click(e, e);
                tb_gif.Enabled = true;
                bt_gif.Enabled = true;
            }
        }

        private void Bt_gif_Click(object sender, EventArgs e)
        {
            string f = "";
            ChooseFolder(ref f);
            tb_gif.Text = f;
        }

        public string textBoxDossier
        {
            get
            {
                return this.tb_dossier.Text;
            }
            set
            {
                this.tb_dossier.Text = value;
            }
        }
        public string textBoxDoc
        {
            get
            {
                return this.tb_doc.Text;
            }
            set
            {
                this.tb_doc.Text = value;
            }
        }

        public string textBoxImg
        {
            get
            {
                return this.tb_img.Text;
            }
            set
            {
                this.tb_img.Text = value;
            }
        }

        public string textBoxGif
        {
            get
            {
                return this.tb_gif.Text;
            }
            set
            {
                this.tb_gif.Text = value;
            }
        }

        public string textBoxMsq
        {
            get
            {
                return this.tb_msq.Text;
            }
            set
            {
                this.tb_msq.Text = value;
            }
        }

        public string textBoxVid
        {
            get
            {
                return this.tb_msq.Text;
            }
            set
            {
                this.tb_msq.Text = value;
            }
        }
        public string textBoxStp
        {
            get
            {
                return this.tb_stp.Text;
            }
            set
            {
                this.tb_stp.Text = value;
            }
        }

        public string textBoxRar
        {
            get
            {
                return this.tb_rar.Text;
            }
            set
            {
                this.tb_rar.Text = value;
            }
        }

        public string textBoxDev
        {
            get
            {
                return this.tb_dev.Text;
            }
            set
            {
                this.tb_dev.Text = value;
            }
        }
        public string ligne_move(string dossierOrigine, string dossierDestination, string type)
        {
            //file.Write("move "origine\*.pdf; destination);
            return "move " + dossierOrigine + "\\*." + type + " " + dossierDestination;
        }

        private void Bt_valider_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:/Users/Julien/Desktop/TrieAuto.bat");

            string[] typesDocuments = new string[] {"pdf", "doc", "pptx", "odt", "odp", "xls", "xlsx", "xltx", "txt", "rtf", "csv"};
            string[] typesImages = new string[] { "jpg", "png", "jpeg", "gif", "bmp"};
            string[] typesMusiques = new string[] { "mp3", "flac", "wav"};
            string[] typesVideos = new string[] { "mp4", "mkv", "mov", "wmv", "flv", "avi"};
            string[] typesSetup = new string[] { "exe", "sdx", "iso", "apk", "msi"};
            string[] typesArchives = new string[] { "zip", "rar", "7z", "tar", "gzip", "lzw"};
            string[] typesDev = new string[] { "htm", "html", "css", "php", "js", "webp", "sql", "chm", "xml"};

            string origine = tb_dossier.Text;
            /*
            for (int i = 0; i < typesDocuments.Length; i++)
            {
                file.Write(ligne_move(origine));
                file.Write("\n");
            }*/

            //if name = "é" remplacer par ","
            

            if (cb_doc.Checked == true)
            {
                string destination = tb_doc.Text;
                destination = destination.Replace('é', ',');
                //char slash = '\';

                for (int i = 0; i < typesDocuments.Length; i++)
                {                    
                    file.Write(ligne_move(origine, destination, typesDocuments[i]));
                    file.Write("\n");
                }
                file.Write("\n");
                /*
                file.Write("move "); file.Write(origine); file.Write('\'); file.Write("*.pdf"); file.Write(destination);
                file.Write("\n");
                */
            }
            if (cb_gif.Checked == true)
            {
                //gère les gifs vers un dossier
                string destination = tb_gif.Text;
                destination = destination.Replace('é', ',');

                file.Write(ligne_move(origine, destination, "gif"));
                file.Write("\n");


                if (cb_img.Checked == true)
                {
                    //gère les imgs autres que gifs vers un dossier
                    string destination2 = tb_img.Text;
                    destination2 = destination2.Replace('é', ',');
                    for (int i = 0; i < typesImages.Length; i++)
                    {
                        file.Write(ligne_move(origine, destination2, typesImages[i]));
                        file.Write("\n");
                    }

                    file.Write(ligne_move(destination2, destination, "gif"));
                    file.Write("\n");
                }
                file.Write("\n");
            }
            else if (cb_img.Checked == true)
            {
                //envoi toutes les images gifs comprises vers un dossier
                string destination = tb_img.Text;
                destination = destination.Replace('é', ',');

                for (int i = 0; i < typesImages.Length; i++)
                {
                    file.Write(ligne_move(origine, destination, typesImages[i]));
                    file.Write("\n");
                }
                file.Write("\n");
            }
                
            if (cb_msq.Checked == true)
            {
                string destination = tb_msq.Text;
                destination = destination.Replace('é', ',');

                for (int i = 0; i < typesMusiques.Length; i++)
                {
                    file.Write(ligne_move(origine, destination, typesMusiques[i]));
                    file.Write("\n");
                }
                file.Write("\n");
            }
            if (cb_vid.Checked == true)
            {
                string destination = tb_vid.Text;
                destination = destination.Replace('é', ',');

                for (int i = 0; i < typesVideos.Length; i++)
                {
                    file.Write(ligne_move(origine, destination, typesVideos[i]));
                    file.Write("\n");
                }
                file.Write("\n");
            }
            if (cb_stp.Checked == true)
            {
                string destination = tb_stp.Text;
                destination = destination.Replace('é', ',');

                for (int i = 0; i < typesSetup.Length; i++)
                {
                    file.Write(ligne_move(origine, destination, typesSetup[i]));
                    file.Write("\n");
                }
                file.Write("\n");
            }
            if (cb_rar.Checked == true)
            {
                string destination = tb_rar.Text;
                destination = destination.Replace('é', ',');

                for (int i = 0; i < typesArchives.Length; i++)
                {
                    file.Write(ligne_move(origine, destination, typesArchives[i]));
                    file.Write("\n");
                }
                file.Write("\n");
            }
            if (cb_dev.Checked == true)
            {
                string destination = tb_dev.Text;
                destination = destination.Replace('é', ',');

                for (int i = 0; i < typesDev.Length; i++)
                {
                    file.Write(ligne_move(origine, destination, typesDev[i]));
                    file.Write("\n");
                }
                file.Write("\n");
            }
            file.Write("PAUSE");

            MessageBox.Show("Le fichier a bien été créé sur le bureau", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

            file.Close();



            
        }
    }
}
