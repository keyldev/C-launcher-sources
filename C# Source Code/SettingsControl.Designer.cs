namespace launcher
{
    partial class SettingsControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsControl));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ChangePath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(274, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "НАСТРОЙКИ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btn_ChangePath
            // 
            this.btn_ChangePath.BackColor = System.Drawing.Color.Transparent;
            this.btn_ChangePath.FlatAppearance.BorderSize = 0;
            this.btn_ChangePath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ChangePath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_ChangePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ChangePath.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ChangePath.Location = new System.Drawing.Point(280, 135);
            this.btn_ChangePath.Name = "btn_ChangePath";
            this.btn_ChangePath.Size = new System.Drawing.Size(173, 40);
            this.btn_ChangePath.TabIndex = 18;
            this.btn_ChangePath.Text = "Указать путь к игре";
            this.btn_ChangePath.UseVisualStyleBackColor = false;
            this.btn_ChangePath.Click += new System.EventHandler(this.Btn_ChangePath_Click);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ChangePath);
            this.DoubleBuffered = true;
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(751, 347);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ChangePath;
    }
}
