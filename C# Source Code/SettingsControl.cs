using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace launcher
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
        
        }

        private void Btn_ChangePath_Click(object sender, EventArgs e)
        {
            GamePath gamePath = new GamePath();
            gamePath.Show();
        }

        private void TbNickName_TextChanged(object sender, EventArgs e)
        {
                SaveClientInfo cis = new SaveClientInfo();
                cis.game_path = ClientInfo.game_path;

                //RegistryKey key = registry.SetValue("player_name", tbNickName);

                string serialized = JsonConvert.SerializeObject(cis);
                using (StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "/settings.json"))
                {
                    sw.Write(serialized);
                    sw.Close();
                }
  

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
