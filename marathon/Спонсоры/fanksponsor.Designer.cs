namespace marathon.Спонсоры
{
    partial class fanksponsor
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
            this.Back = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Runname = new MetroFramework.Controls.MetroLabel();
            this.Currency = new MetroFramework.Controls.MetroLabel();
            this.Fondname = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtlable = new MetroFramework.Controls.MetroLabel();
            this.daytime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(284, 281);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 0;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(148, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(345, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Спасибо за вашу спонсорскую поддержку";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(128, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(452, 47);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "спасибо за поддержку бегуна в Marathon skills 2020!  Ваше пожертвование пойдёт в " +
    "его благотворительную организацию";
            this.metroLabel2.WrapToLine = true;
            // 
            // Runname
            // 
            this.Runname.AutoSize = true;
            this.Runname.Location = new System.Drawing.Point(294, 167);
            this.Runname.Name = "Runname";
            this.Runname.Size = new System.Drawing.Size(43, 19);
            this.Runname.TabIndex = 3;
            this.Runname.Text = "бегун";
            // 
            // Currency
            // 
            this.Currency.AutoSize = true;
            this.Currency.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Currency.Location = new System.Drawing.Point(284, 240);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(189, 25);
            this.Currency.TabIndex = 4;
            this.Currency.Text = "Сумма пожертвования";
            // 
            // Fondname
            // 
            this.Fondname.AutoSize = true;
            this.Fondname.Location = new System.Drawing.Point(295, 204);
            this.Fondname.Name = "Fondname";
            this.Fondname.Size = new System.Drawing.Size(42, 19);
            this.Fondname.TabIndex = 5;
            this.Fondname.Text = "Фонд";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.mtlable);
            this.panel1.Location = new System.Drawing.Point(-3, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 104);
            this.panel1.TabIndex = 6;
            // 
            // mtlable
            // 
            this.mtlable.AutoSize = true;
            this.mtlable.BackColor = System.Drawing.Color.Silver;
            this.mtlable.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mtlable.Location = new System.Drawing.Point(168, 36);
            this.mtlable.Name = "mtlable";
            this.mtlable.Size = new System.Drawing.Size(289, 25);
            this.mtlable.TabIndex = 7;
            this.mtlable.Text = "Осталось 00 дней 00 часа 00 минут";
            // 
            // daytime
            // 
            this.daytime.Tick += new System.EventHandler(this.daytime_Tick);
            // 
            // fanksponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 449);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Fondname);
            this.Controls.Add(this.Currency);
            this.Controls.Add(this.Runname);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Back);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fanksponsor";
            this.Text = "Marathon skills 2020";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.fanksponsor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel Runname;
        private MetroFramework.Controls.MetroLabel Currency;
        private MetroFramework.Controls.MetroLabel Fondname;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel mtlable;
        private System.Windows.Forms.Timer daytime;
    }
}