namespace weather
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.datetime = new System.Windows.Forms.Label();
            this.countryCity = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.presHum = new System.Windows.Forms.Label();
            this.windVis = new System.Windows.Forms.Label();
            this.sunrise = new System.Windows.Forms.Label();
            this.sunset = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datetime
            // 
            this.datetime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datetime.BackColor = System.Drawing.Color.Transparent;
            this.datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datetime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datetime.Location = new System.Drawing.Point(-184, 10);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(987, 24);
            this.datetime.TabIndex = 3;
            this.datetime.Text = "Дата и время";
            this.datetime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countryCity
            // 
            this.countryCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.countryCity.BackColor = System.Drawing.Color.Transparent;
            this.countryCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countryCity.Location = new System.Drawing.Point(-184, 39);
            this.countryCity.Name = "countryCity";
            this.countryCity.Size = new System.Drawing.Size(987, 37);
            this.countryCity.TabIndex = 4;
            this.countryCity.Text = "Страна, город";
            this.countryCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temp
            // 
            this.temp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.temp.BackColor = System.Drawing.Color.Transparent;
            this.temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.temp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.temp.Location = new System.Drawing.Point(-185, 81);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(988, 37);
            this.temp.TabIndex = 5;
            this.temp.Text = "0°C";
            this.temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // description
            // 
            this.description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.description.BackColor = System.Drawing.Color.Transparent;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.description.Location = new System.Drawing.Point(-184, 129);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(987, 24);
            this.description.TabIndex = 6;
            this.description.Text = "Описание";
            this.description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(212, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // presHum
            // 
            this.presHum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.presHum.BackColor = System.Drawing.Color.Transparent;
            this.presHum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.presHum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.presHum.Location = new System.Drawing.Point(-184, 368);
            this.presHum.Name = "presHum";
            this.presHum.Size = new System.Drawing.Size(987, 24);
            this.presHum.TabIndex = 8;
            this.presHum.Text = "Давление и влажность";
            this.presHum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windVis
            // 
            this.windVis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.windVis.BackColor = System.Drawing.Color.Transparent;
            this.windVis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windVis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.windVis.Location = new System.Drawing.Point(-184, 394);
            this.windVis.Name = "windVis";
            this.windVis.Size = new System.Drawing.Size(987, 24);
            this.windVis.TabIndex = 9;
            this.windVis.Text = "Ветер и видимость";
            this.windVis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sunrise
            // 
            this.sunrise.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sunrise.BackColor = System.Drawing.Color.Transparent;
            this.sunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sunrise.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sunrise.Location = new System.Drawing.Point(-184, 420);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(987, 24);
            this.sunrise.TabIndex = 10;
            this.sunrise.Text = "Восход";
            this.sunrise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sunset
            // 
            this.sunset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sunset.BackColor = System.Drawing.Color.Transparent;
            this.sunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sunset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sunset.Location = new System.Drawing.Point(-184, 446);
            this.sunset.Name = "sunset";
            this.sunset.Size = new System.Drawing.Size(987, 24);
            this.sunset.TabIndex = 11;
            this.sunset.Text = "Закат";
            this.sunset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(486, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(619, 482);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sunset);
            this.Controls.Add(this.sunrise);
            this.Controls.Add(this.windVis);
            this.Controls.Add(this.presHum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.countryCity);
            this.Controls.Add(this.datetime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label datetime;
        private System.Windows.Forms.Label countryCity;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label presHum;
        private System.Windows.Forms.Label windVis;
        private System.Windows.Forms.Label sunrise;
        private System.Windows.Forms.Label sunset;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

