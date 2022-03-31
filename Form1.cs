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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Settings settings = new Settings();
        }

        private void Btn_settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void Btn_create_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:/Users/Julien/Desktop/TrieAuto.bat");
            MessageBox.Show("Le fichier a bien été créé sur le bureau", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            for (int i = 0; i < 4; i++)
            {
                file.Write("Test");
                file.Write("\n");
            }
           
            file.Close();

            /*

            if (settings.textBoxDoc == "")
            {

            }
            if (settings.ChooseFolder(textBoxDoc) )
            {

            }*/
        }
    }
}
