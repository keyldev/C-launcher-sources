using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;
using System.Threading;
using AutoUpdaterDotNET;
using Ionic.Zip;

namespace launcher

{
    public partial class MainForm : Form
    {
        int iFormX, iFormY, iMouseX, iMouseY;//глобальные 
        WebClient webClient = new WebClient();
        
        public MainForm()
        {
            InitializeComponent();
            AutoUpdater.Start("http://www.dropbox.com/s/mi2263029498i6a/testfile.xml?dl=1");
            SaveClientInfo cis = new SaveClientInfo();
            settingsControl1.Visible = false;
            try
            {
                using (StreamReader sw = new StreamReader(Directory.GetCurrentDirectory() + "/settings.json"))
                {
                    string json = sw.ReadToEnd();
                    cis = JsonConvert.DeserializeObject<SaveClientInfo>(json);
                    ClientInfo.game_path = cis.game_path;
                    ClientInfo.gameInstall = cis.gameInstall;
                    sw.Close();
                }
            }
            catch
            { 
            }
            if (ClientInfo.gameInstall == 1) dwnld_Progress.Value = 100;

        }
        private void Btn_play_Click(object sender, EventArgs e)
        {
            if (ClientInfo.gameInstall == 1)
            {
                Process.Start(ClientInfo.game_path + "/WindowsNoEditor/hunger.exe");
                

            }
            else
            {
                if (ClientInfo.game_path == "")
                {
                    MessageBox.Show("Выберите папку с игрой в настройках!", "Ошибка:");
                }
                else
                {
                    dwnld();

                }
            }
        }
        private void dwnld()
        {
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri("https://www.dropbox.com/s/vlk0weqktv7logt/HungerGame.zip?dl=1"), ClientInfo.game_path + "/game.zip") ;
           // webClient.DownloadFile(new Uri("https://www.dropbox.com/s/vlk0weqktv7logt/HungerGame.zip?dl=1"), @"C:\Users\skeych\Desktop\file.zip");
        }

        private void completed(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                MessageBox.Show("Скачивание успешно завершено, распаковка.");
                ClientInfo.gameInstall = 1;
                SaveClientInfo cis = new SaveClientInfo();

                cis.gameInstall = ClientInfo.gameInstall;
                string serialized = JsonConvert.SerializeObject(cis);
                using (StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "/settings.json"))
                {
                    sw.Write(serialized);
                    sw.Close();
                }
                using (ZipFile zip = ZipFile.Read(ClientInfo.game_path + "/game.zip"))
                {
                    foreach (ZipEntry i in zip)
                    {
                        i.Extract(ClientInfo.game_path, ExtractExistingFileAction.OverwriteSilently); // перезаписывать существующие
                    }
                }

            }
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            dwnld_Progress.Value = e.ProgressPercentage;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start(ServerInfo.site);
        }
        private void Btn_close_Click(object sender, EventArgs e)
        {
            SaveClientInfo cis = new SaveClientInfo();

            cis.game_path = ClientInfo.game_path;
            cis.gameInstall = ClientInfo.gameInstall;
            string serialized = JsonConvert.SerializeObject(cis);
            using (StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "/settings.json"))
            {
                sw.Write(serialized);
                sw.Close();
            }
            Application.Exit();
        }
        private void Btn_hide_Click(object sender, EventArgs e)
        {   
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_vklogo_Click(object sender, EventArgs e)
        {
            Process.Start(ServerInfo.group);
        }
        private void Btn_settings_Click(object sender, EventArgs e)
        {
            settingsControl1.Visible = true;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }
        private void Btn_MainMenu_Click(object sender, EventArgs e)
        {
            settingsControl1.Visible = false;
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }
    }
}
static class ServerInfo
{
    public static readonly string group = "http://vk.com/cybertent";
    public static readonly string site = "http://zalatoff.xyz/";
    public static readonly bool allowInstallGame = true;
}
static class ClientInfo
{ 
    public static string game_path = " ";
    public static int gameInstall = 0;

}
public class SaveClientInfo
{
    public string nick = "";
    public string game_path = "";
    public int gameInstall;

}