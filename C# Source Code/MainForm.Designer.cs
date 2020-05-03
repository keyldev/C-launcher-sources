namespace launcher
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_site = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_MainMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dwnld_Progress = new System.Windows.Forms.ProgressBar();
            this.settingsControl1 = new launcher.SettingsControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_play.BackgroundImage")));
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Font = new System.Drawing.Font("FRACTAL", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_play.ForeColor = System.Drawing.Color.White;
            this.btn_play.Location = new System.Drawing.Point(568, 351);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(163, 46);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "Играть";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.Btn_play_Click);
            // 
            // btn_site
            // 
            this.btn_site.BackColor = System.Drawing.Color.Transparent;
            this.btn_site.FlatAppearance.BorderSize = 0;
            this.btn_site.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.btn_site.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_site.Font = new System.Drawing.Font("FRACTAL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_site.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_site.Location = new System.Drawing.Point(355, 9);
            this.btn_site.Name = "btn_site";
            this.btn_site.Size = new System.Drawing.Size(95, 32);
            this.btn_site.TabIndex = 1;
            this.btn_site.Text = "Сайт";
            this.btn_site.UseVisualStyleBackColor = false;
            this.btn_site.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_close.Location = new System.Drawing.Point(709, 10);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.BackColor = System.Drawing.Color.Transparent;
            this.btn_hide.FlatAppearance.BorderSize = 0;
            this.btn_hide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hide.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_hide.Location = new System.Drawing.Point(683, 8);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(25, 25);
            this.btn_hide.TabIndex = 3;
            this.btn_hide.Text = "__";
            this.btn_hide.UseVisualStyleBackColor = false;
            this.btn_hide.Click += new System.EventHandler(this.Btn_hide_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_settings.BackgroundImage")));
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_settings.Location = new System.Drawing.Point(652, 10);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(25, 23);
            this.btn_settings.TabIndex = 6;
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.Btn_settings_Click);
            // 
            // btn_MainMenu
            // 
            this.btn_MainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btn_MainMenu.FlatAppearance.BorderSize = 0;
            this.btn_MainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_MainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.btn_MainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MainMenu.Font = new System.Drawing.Font("FRACTAL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_MainMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_MainMenu.Location = new System.Drawing.Point(227, 8);
            this.btn_MainMenu.Name = "btn_MainMenu";
            this.btn_MainMenu.Size = new System.Drawing.Size(116, 32);
            this.btn_MainMenu.TabIndex = 10;
            this.btn_MainMenu.Text = "Главная";
            this.btn_MainMenu.UseVisualStyleBackColor = false;
            this.btn_MainMenu.Click += new System.EventHandler(this.Btn_MainMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 75);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // dwnld_Progress
            // 
            this.dwnld_Progress.Location = new System.Drawing.Point(0, 403);
            this.dwnld_Progress.Name = "dwnld_Progress";
            this.dwnld_Progress.Size = new System.Drawing.Size(748, 11);
            this.dwnld_Progress.TabIndex = 13;
            // 
            // settingsControl1
            // 
            this.settingsControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsControl1.BackgroundImage")));
            this.settingsControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsControl1.Location = new System.Drawing.Point(0, 67);
            this.settingsControl1.Name = "settingsControl1";
            this.settingsControl1.Size = new System.Drawing.Size(751, 347);
            this.settingsControl1.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 415);
            this.Controls.Add(this.settingsControl1);
            this.Controls.Add(this.dwnld_Progress);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_MainMenu);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_site);
            this.Controls.Add(this.btn_play);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "CyberTent";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_site;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_MainMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar dwnld_Progress;
        private SettingsControl settingsControl1;
    }
}

