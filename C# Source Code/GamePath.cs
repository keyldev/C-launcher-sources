using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace launcher
{
    public partial class GamePath : Form
    {
        public GamePath()
        {
            InitializeComponent();
            textPath.Text = ClientInfo.game_path;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            ClientInfo.game_path = textPath.Text;
            this.Close();
        }

        private void Btn_Change_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog ofd = new FolderBrowserDialog())
            {
                //ofd.CheckFileExists = false;
                //ofd.Filter = "GTA SA|gta_sa.exe";
               // ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textPath.Text = ofd.SelectedPath;
                    ClientInfo.game_path = textPath.Text;
                }
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
