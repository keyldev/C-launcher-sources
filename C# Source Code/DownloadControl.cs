using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Ionic.Zip;
using System.IO;
using Newtonsoft.Json;

namespace launcher
{

    public partial class DownloadControl : UserControl
    {
        WebClient webClient = new WebClient();
        public DownloadControl()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
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
        private void dwnld()
        {
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri("http://dropbox.com/SSILKANAIGRU"), ClientInfo.game_path);
           /*using (ZipFile zip = ZipFile.Read(ExistingZipFile))
            {
                foreach (ZipEntry e in zip)
                {
                    e.Extract(TargetDirectory, ExtractExistingFileAction.OverwriteSilently); // перезаписывать существующие
                }
            }*/
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
                
            }
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}
