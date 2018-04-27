namespace AndyWeather
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.input_cityname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.city_name = new System.Windows.Forms.Label();
            this.city_weather = new System.Windows.Forms.Label();
            this.city_temper = new System.Windows.Forms.Label();
            this.message_text = new System.Windows.Forms.Label();
            this.wind = new System.Windows.Forms.Label();
            this.wind_speed = new System.Windows.Forms.Label();
            this.update_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(68, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入城市：";
            // 
            // input_cityname
            // 
            this.input_cityname.Location = new System.Drawing.Point(183, 41);
            this.input_cityname.Name = "input_cityname";
            this.input_cityname.Size = new System.Drawing.Size(100, 21);
            this.input_cityname.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(385, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // city_name
            // 
            this.city_name.AutoSize = true;
            this.city_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.city_name.Location = new System.Drawing.Point(72, 103);
            this.city_name.Name = "city_name";
            this.city_name.Size = new System.Drawing.Size(62, 16);
            this.city_name.TabIndex = 3;
            this.city_name.Text = "label2";
            // 
            // city_weather
            // 
            this.city_weather.AutoSize = true;
            this.city_weather.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.city_weather.Location = new System.Drawing.Point(201, 103);
            this.city_weather.Name = "city_weather";
            this.city_weather.Size = new System.Drawing.Size(62, 16);
            this.city_weather.TabIndex = 4;
            this.city_weather.Text = "label2";
            // 
            // city_temper
            // 
            this.city_temper.AutoSize = true;
            this.city_temper.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.city_temper.Location = new System.Drawing.Point(330, 103);
            this.city_temper.Name = "city_temper";
            this.city_temper.Size = new System.Drawing.Size(62, 16);
            this.city_temper.TabIndex = 5;
            this.city_temper.Text = "label2";
            // 
            // message_text
            // 
            this.message_text.AutoSize = true;
            this.message_text.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.message_text.Location = new System.Drawing.Point(72, 314);
            this.message_text.Name = "message_text";
            this.message_text.Size = new System.Drawing.Size(56, 16);
            this.message_text.TabIndex = 6;
            this.message_text.Text = "label2";
            // 
            // wind
            // 
            this.wind.AutoSize = true;
            this.wind.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wind.Location = new System.Drawing.Point(204, 157);
            this.wind.Name = "wind";
            this.wind.Size = new System.Drawing.Size(62, 16);
            this.wind.TabIndex = 7;
            this.wind.Text = "label2";
            // 
            // wind_speed
            // 
            this.wind_speed.AutoSize = true;
            this.wind_speed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wind_speed.Location = new System.Drawing.Point(333, 160);
            this.wind_speed.Name = "wind_speed";
            this.wind_speed.Size = new System.Drawing.Size(62, 16);
            this.wind_speed.TabIndex = 8;
            this.wind_speed.Text = "label2";
            // 
            // update_time
            // 
            this.update_time.AutoSize = true;
            this.update_time.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.update_time.Location = new System.Drawing.Point(227, 314);
            this.update_time.Name = "update_time";
            this.update_time.Size = new System.Drawing.Size(56, 16);
            this.update_time.TabIndex = 9;
            this.update_time.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.update_time);
            this.Controls.Add(this.wind_speed);
            this.Controls.Add(this.wind);
            this.Controls.Add(this.message_text);
            this.Controls.Add(this.city_temper);
            this.Controls.Add(this.city_weather);
            this.Controls.Add(this.city_name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.input_cityname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "安迪天气";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_cityname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label city_name;
        private System.Windows.Forms.Label city_weather;
        private System.Windows.Forms.Label city_temper;
        private System.Windows.Forms.Label message_text;
        private System.Windows.Forms.Label wind;
        private System.Windows.Forms.Label wind_speed;
        private System.Windows.Forms.Label update_time;
    }
}

