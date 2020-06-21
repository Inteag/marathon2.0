namespace marathon.Бегун
{
    partial class RunnerReg
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mtlable = new MetroFramework.Controls.MetroLabel();
            this.daytime = new System.Windows.Forms.Timer(this.components);
            this.mtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mtpass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mtpasspov = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mtname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mtlastname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.mtmd = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.mtcountry = new MetroFramework.Controls.MetroComboBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.mthappy = new MetroFramework.Controls.MetroDateTime();
            this.error = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(315, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(167, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Регистрация бегуна";
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(48, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(704, 50);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Пожалуйста заполните всю информацию, чтобы зарегистрироваться в качестве бегуна";
            this.metroLabel2.WrapToLine = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.mtlable);
            this.panel2.Location = new System.Drawing.Point(-2, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 64);
            this.panel2.TabIndex = 6;
            // 
            // mtlable
            // 
            this.mtlable.AutoSize = true;
            this.mtlable.BackColor = System.Drawing.Color.Silver;
            this.mtlable.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mtlable.Location = new System.Drawing.Point(238, 17);
            this.mtlable.Name = "mtlable";
            this.mtlable.Size = new System.Drawing.Size(289, 25);
            this.mtlable.TabIndex = 0;
            this.mtlable.Text = "Осталось 00 дней 00 часа 00 минут";
            // 
            // daytime
            // 
            this.daytime.Tick += new System.EventHandler(this.daytime_Tick);
            // 
            // mtEmail
            // 
            this.mtEmail.Depth = 0;
            this.mtEmail.Hint = "";
            this.mtEmail.Location = new System.Drawing.Point(136, 166);
            this.mtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtEmail.Name = "mtEmail";
            this.mtEmail.PasswordChar = '\0';
            this.mtEmail.SelectedText = "";
            this.mtEmail.SelectionLength = 0;
            this.mtEmail.SelectionStart = 0;
            this.mtEmail.Size = new System.Drawing.Size(135, 23);
            this.mtEmail.TabIndex = 7;
            this.mtEmail.UseSystemPasswordChar = false;
            // 
            // mtpass
            // 
            this.mtpass.Depth = 0;
            this.mtpass.Hint = "";
            this.mtpass.Location = new System.Drawing.Point(136, 195);
            this.mtpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtpass.Name = "mtpass";
            this.mtpass.PasswordChar = '\0';
            this.mtpass.SelectedText = "";
            this.mtpass.SelectionLength = 0;
            this.mtpass.SelectionStart = 0;
            this.mtpass.Size = new System.Drawing.Size(135, 23);
            this.mtpass.TabIndex = 8;
            this.mtpass.UseSystemPasswordChar = false;
            // 
            // mtpasspov
            // 
            this.mtpasspov.Depth = 0;
            this.mtpasspov.Hint = "";
            this.mtpasspov.Location = new System.Drawing.Point(136, 224);
            this.mtpasspov.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtpasspov.Name = "mtpasspov";
            this.mtpasspov.PasswordChar = '\0';
            this.mtpasspov.SelectedText = "";
            this.mtpasspov.SelectionLength = 0;
            this.mtpasspov.SelectionStart = 0;
            this.mtpasspov.Size = new System.Drawing.Size(135, 23);
            this.mtpasspov.TabIndex = 9;
            this.mtpasspov.UseSystemPasswordChar = false;
            // 
            // mtname
            // 
            this.mtname.Depth = 0;
            this.mtname.Hint = "";
            this.mtname.Location = new System.Drawing.Point(136, 253);
            this.mtname.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtname.Name = "mtname";
            this.mtname.PasswordChar = '\0';
            this.mtname.SelectedText = "";
            this.mtname.SelectionLength = 0;
            this.mtname.SelectionStart = 0;
            this.mtname.Size = new System.Drawing.Size(135, 23);
            this.mtname.TabIndex = 10;
            this.mtname.UseSystemPasswordChar = false;
            this.mtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtname_KeyPress);
            // 
            // mtlastname
            // 
            this.mtlastname.Depth = 0;
            this.mtlastname.Hint = "";
            this.mtlastname.Location = new System.Drawing.Point(136, 282);
            this.mtlastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtlastname.Name = "mtlastname";
            this.mtlastname.PasswordChar = '\0';
            this.mtlastname.SelectedText = "";
            this.mtlastname.SelectionLength = 0;
            this.mtlastname.SelectionStart = 0;
            this.mtlastname.Size = new System.Drawing.Size(135, 23);
            this.mtlastname.TabIndex = 11;
            this.mtlastname.UseSystemPasswordChar = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(78, 166);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Email:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(65, 195);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(57, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Пароль:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(-2, 224);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(124, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Повторить пароль:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(87, 253);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(35, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Имя";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(65, 282);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(65, 19);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Фамилия";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(65, 320);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(33, 19);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Пол";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mtmd
            // 
            this.mtmd.FormattingEnabled = true;
            this.mtmd.ItemHeight = 23;
            this.mtmd.Location = new System.Drawing.Point(136, 317);
            this.mtmd.Name = "mtmd";
            this.mtmd.Size = new System.Drawing.Size(121, 29);
            this.mtmd.TabIndex = 18;
            this.mtmd.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(632, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(523, 272);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(103, 19);
            this.metroLabel9.TabIndex = 20;
            this.metroLabel9.Text = "Дата рождения";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(554, 308);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(53, 19);
            this.metroLabel10.TabIndex = 21;
            this.metroLabel10.Text = "Страна";
            // 
            // mtcountry
            // 
            this.mtcountry.FormattingEnabled = true;
            this.mtcountry.ItemHeight = 23;
            this.mtcountry.Location = new System.Drawing.Point(632, 308);
            this.mtcountry.Name = "mtcountry";
            this.mtcountry.Size = new System.Drawing.Size(165, 29);
            this.mtcountry.TabIndex = 23;
            this.mtcountry.UseSelectable = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(424, 351);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(162, 31);
            this.materialRaisedButton1.TabIndex = 24;
            this.materialRaisedButton1.Text = "Зарегистрироваться";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(328, 348);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(68, 36);
            this.materialFlatButton1.TabIndex = 25;
            this.materialFlatButton1.Text = "Отмена";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(656, 235);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(121, 23);
            this.metroButton1.TabIndex = 26;
            this.metroButton1.Text = "Загрузить фото";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // mthappy
            // 
            this.mthappy.Location = new System.Drawing.Point(632, 272);
            this.mthappy.MinimumSize = new System.Drawing.Size(0, 29);
            this.mthappy.Name = "mthappy";
            this.mthappy.Size = new System.Drawing.Size(165, 29);
            this.mthappy.TabIndex = 27;
            this.mthappy.Value = new System.DateTime(2020, 6, 3, 17, 11, 28, 0);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(315, 114);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 28;
            // 
            // RunnerReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.error);
            this.Controls.Add(this.mthappy);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.mtcountry);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtmd);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtlastname);
            this.Controls.Add(this.mtname);
            this.Controls.Add(this.mtpasspov);
            this.Controls.Add(this.mtpass);
            this.Controls.Add(this.mtEmail);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "RunnerReg";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Marathon Skills 2020";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RunnerReg_FormClosed);
            this.Load += new System.EventHandler(this.RunnerReg_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel mtlable;
        private System.Windows.Forms.Timer daytime;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtpass;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtpasspov;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtname;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtlastname;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox mtmd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroComboBox mtcountry;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroDateTime mthappy;
        private System.Windows.Forms.Label error;
    }
}