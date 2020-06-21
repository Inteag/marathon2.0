namespace marathon.Бегун
{
    partial class UpdateRunner
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
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtlable = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.daytime = new System.Windows.Forms.Timer(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.mtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtmd = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mtlastname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mtname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mthappy = new MetroFramework.Controls.MetroDateTime();
            this.mtcountry = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtpasspov = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mtpass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(626, 377);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(88, 34);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "Обновить";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(8, 372);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(68, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "Отмена";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.mtlable);
            this.panel1.Location = new System.Drawing.Point(-9, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 74);
            this.panel1.TabIndex = 9;
            // 
            // mtlable
            // 
            this.mtlable.AutoSize = true;
            this.mtlable.BackColor = System.Drawing.Color.Silver;
            this.mtlable.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mtlable.Location = new System.Drawing.Point(173, 28);
            this.mtlable.Name = "mtlable";
            this.mtlable.Size = new System.Drawing.Size(289, 25);
            this.mtlable.TabIndex = 1;
            this.mtlable.Text = "Осталось 00 дней 00 часа 00 минут";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(322, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(156, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Редактировать профиль";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(274, 82);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(143, 114);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 11;
            this.pbImage.TabStop = false;
            // 
            // daytime
            // 
            this.daytime.Tick += new System.EventHandler(this.daytime_Tick);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(285, 202);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(121, 23);
            this.metroButton1.TabIndex = 27;
            this.metroButton1.Text = "Загрузить фото";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // mtEmail
            // 
            this.mtEmail.Depth = 0;
            this.mtEmail.Enabled = false;
            this.mtEmail.Hint = "";
            this.mtEmail.Location = new System.Drawing.Point(82, 107);
            this.mtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtEmail.Name = "mtEmail";
            this.mtEmail.PasswordChar = '\0';
            this.mtEmail.SelectedText = "";
            this.mtEmail.SelectionLength = 0;
            this.mtEmail.SelectionStart = 0;
            this.mtEmail.Size = new System.Drawing.Size(135, 23);
            this.mtEmail.TabIndex = 28;
            this.mtEmail.UseSystemPasswordChar = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(32, 107);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Text = "Email:";
            // 
            // mtmd
            // 
            this.mtmd.FormattingEnabled = true;
            this.mtmd.ItemHeight = 23;
            this.mtmd.Location = new System.Drawing.Point(82, 200);
            this.mtmd.Name = "mtmd";
            this.mtmd.Size = new System.Drawing.Size(121, 29);
            this.mtmd.TabIndex = 35;
            this.mtmd.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(11, 203);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(33, 19);
            this.metroLabel8.TabIndex = 34;
            this.metroLabel8.Text = "Пол";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(11, 165);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(65, 19);
            this.metroLabel7.TabIndex = 33;
            this.metroLabel7.Text = "Фамилия";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(33, 136);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(35, 19);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "Имя";
            // 
            // mtlastname
            // 
            this.mtlastname.Depth = 0;
            this.mtlastname.Hint = "";
            this.mtlastname.Location = new System.Drawing.Point(82, 165);
            this.mtlastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtlastname.Name = "mtlastname";
            this.mtlastname.PasswordChar = '\0';
            this.mtlastname.SelectedText = "";
            this.mtlastname.SelectionLength = 0;
            this.mtlastname.SelectionStart = 0;
            this.mtlastname.Size = new System.Drawing.Size(135, 23);
            this.mtlastname.TabIndex = 31;
            this.mtlastname.UseSystemPasswordChar = false;
            this.mtlastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtlastname_KeyPress);
            // 
            // mtname
            // 
            this.mtname.Depth = 0;
            this.mtname.Hint = "";
            this.mtname.Location = new System.Drawing.Point(82, 136);
            this.mtname.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtname.Name = "mtname";
            this.mtname.PasswordChar = '\0';
            this.mtname.SelectedText = "";
            this.mtname.SelectionLength = 0;
            this.mtname.SelectionStart = 0;
            this.mtname.Size = new System.Drawing.Size(135, 23);
            this.mtname.TabIndex = 30;
            this.mtname.UseSystemPasswordChar = false;
            this.mtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtname_KeyPress);
            // 
            // mthappy
            // 
            this.mthappy.Location = new System.Drawing.Point(111, 247);
            this.mthappy.MinimumSize = new System.Drawing.Size(0, 29);
            this.mthappy.Name = "mthappy";
            this.mthappy.Size = new System.Drawing.Size(165, 29);
            this.mthappy.TabIndex = 39;
            // 
            // mtcountry
            // 
            this.mtcountry.FormattingEnabled = true;
            this.mtcountry.ItemHeight = 23;
            this.mtcountry.Location = new System.Drawing.Point(111, 283);
            this.mtcountry.Name = "mtcountry";
            this.mtcountry.Size = new System.Drawing.Size(165, 29);
            this.mtcountry.TabIndex = 38;
            this.mtcountry.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(33, 283);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(53, 19);
            this.metroLabel10.TabIndex = 37;
            this.metroLabel10.Text = "Страна";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(2, 247);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(103, 19);
            this.metroLabel9.TabIndex = 36;
            this.metroLabel9.Text = "Дата рождения";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(430, 336);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(124, 19);
            this.metroLabel5.TabIndex = 43;
            this.metroLabel5.Text = "Повторить пароль:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(489, 307);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(57, 19);
            this.metroLabel4.TabIndex = 42;
            this.metroLabel4.Text = "Пароль:";
            // 
            // mtpasspov
            // 
            this.mtpasspov.Depth = 0;
            this.mtpasspov.Hint = "";
            this.mtpasspov.Location = new System.Drawing.Point(560, 336);
            this.mtpasspov.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtpasspov.Name = "mtpasspov";
            this.mtpasspov.PasswordChar = '\0';
            this.mtpasspov.SelectedText = "";
            this.mtpasspov.SelectionLength = 0;
            this.mtpasspov.SelectionStart = 0;
            this.mtpasspov.Size = new System.Drawing.Size(135, 23);
            this.mtpasspov.TabIndex = 41;
            this.mtpasspov.UseSystemPasswordChar = false;
            // 
            // mtpass
            // 
            this.mtpass.Depth = 0;
            this.mtpass.Hint = "";
            this.mtpass.Location = new System.Drawing.Point(560, 307);
            this.mtpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtpass.Name = "mtpass";
            this.mtpass.PasswordChar = '\0';
            this.mtpass.SelectedText = "";
            this.mtpass.SelectionLength = 0;
            this.mtpass.SelectionStart = 0;
            this.mtpass.Size = new System.Drawing.Size(135, 23);
            this.mtpass.TabIndex = 40;
            this.mtpass.UseSystemPasswordChar = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(521, 260);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(177, 42);
            this.metroLabel2.TabIndex = 44;
            this.metroLabel2.Text = "Оставьте поля пустыми если не хотите изменять пароль";
            this.metroLabel2.WrapToLine = true;
            // 
            // UpdateRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 490);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mtpasspov);
            this.Controls.Add(this.mtpass);
            this.Controls.Add(this.mthappy);
            this.Controls.Add(this.mtcountry);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.mtmd);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.mtlastname);
            this.Controls.Add(this.mtname);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtEmail);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Name = "UpdateRunner";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Marathon Skills 2020";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.UpdateRunner_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel mtlable;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Timer daytime;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox mtmd;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtlastname;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtname;
        private MetroFramework.Controls.MetroDateTime mthappy;
        private MetroFramework.Controls.MetroComboBox mtcountry;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtpasspov;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtpass;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}