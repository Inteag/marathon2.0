namespace marathon.Администрация
{
    partial class VolonterAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.mtPath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtlable = new MetroFramework.Controls.MetroLabel();
            this.daytime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(327, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(139, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Загрузка волонтеров";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(493, 157);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Выбрать";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(309, 238);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(92, 33);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Загрузить";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(407, 238);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(92, 33);
            this.metroButton3.TabIndex = 3;
            this.metroButton3.Text = "Отмена";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // mtPath
            // 
            // 
            // 
            // 
            this.mtPath.CustomButton.Image = null;
            this.mtPath.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtPath.CustomButton.Name = "";
            this.mtPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtPath.CustomButton.TabIndex = 1;
            this.mtPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtPath.CustomButton.UseSelectable = true;
            this.mtPath.CustomButton.Visible = false;
            this.mtPath.Lines = new string[] {
        "metroTextBox1"};
            this.mtPath.Location = new System.Drawing.Point(327, 157);
            this.mtPath.MaxLength = 32767;
            this.mtPath.Name = "mtPath";
            this.mtPath.PasswordChar = '\0';
            this.mtPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtPath.SelectedText = "";
            this.mtPath.SelectionLength = 0;
            this.mtPath.SelectionStart = 0;
            this.mtPath.ShortcutsEnabled = true;
            this.mtPath.Size = new System.Drawing.Size(160, 23);
            this.mtPath.TabIndex = 4;
            this.mtPath.Text = "metroTextBox1";
            this.mtPath.UseSelectable = true;
            this.mtPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(173, 161);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(148, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "CSV файл волонтеров:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(327, 306);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(172, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Статус загрузки: ожидание";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(246, 328);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(322, 23);
            this.metroProgressBar1.TabIndex = 7;
            this.metroProgressBar1.Value = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.mtlable);
            this.panel1.Location = new System.Drawing.Point(-17, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 83);
            this.panel1.TabIndex = 8;
            // 
            // mtlable
            // 
            this.mtlable.AutoSize = true;
            this.mtlable.BackColor = System.Drawing.Color.Silver;
            this.mtlable.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mtlable.Location = new System.Drawing.Point(260, 26);
            this.mtlable.Name = "mtlable";
            this.mtlable.Size = new System.Drawing.Size(289, 25);
            this.mtlable.TabIndex = 1;
            this.mtlable.Text = "Осталось 00 дней 00 часа 00 минут";
            // 
            // daytime
            // 
            this.daytime.Tick += new System.EventHandler(this.daytime_Tick);
            // 
            // VolonterAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtPath);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "VolonterAdd";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "MarathonSkills";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.VolonterAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroTextBox mtPath;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel mtlable;
        private System.Windows.Forms.Timer daytime;
    }
}