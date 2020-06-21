namespace marathon
{
    partial class AuthicationLogin
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
            this.Back = new MaterialSkin.Controls.MaterialFlatButton();
            this.authication = new MaterialSkin.Controls.MaterialRaisedButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.loginuse = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtlable = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.daytime = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Back.Depth = 0;
            this.Back.Location = new System.Drawing.Point(12, 217);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Back.MouseState = MaterialSkin.MouseState.HOVER;
            this.Back.Name = "Back";
            this.Back.Primary = false;
            this.Back.Size = new System.Drawing.Size(68, 36);
            this.Back.TabIndex = 4;
            this.Back.Text = "Отмена";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // authication
            // 
            this.authication.Depth = 0;
            this.authication.Location = new System.Drawing.Point(385, 224);
            this.authication.MouseState = MaterialSkin.MouseState.HOVER;
            this.authication.Name = "authication";
            this.authication.Primary = true;
            this.authication.Size = new System.Drawing.Size(75, 23);
            this.authication.TabIndex = 3;
            this.authication.Text = "Войти";
            this.authication.UseVisualStyleBackColor = true;
            this.authication.Click += new System.EventHandler(this.authication_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(132, 113);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Логин";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(125, 152);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Пароль";
            // 
            // loginuse
            // 
            this.loginuse.Depth = 0;
            this.loginuse.Hint = "";
            this.loginuse.Location = new System.Drawing.Point(201, 109);
            this.loginuse.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginuse.Name = "loginuse";
            this.loginuse.PasswordChar = '\0';
            this.loginuse.SelectedText = "";
            this.loginuse.SelectionLength = 0;
            this.loginuse.SelectionStart = 0;
            this.loginuse.Size = new System.Drawing.Size(121, 23);
            this.loginuse.TabIndex = 1;
            this.loginuse.UseSystemPasswordChar = false;
            // 
            // password
            // 
            this.password.Depth = 0;
            this.password.Hint = "";
            this.password.Location = new System.Drawing.Point(201, 152);
            this.password.MouseState = MaterialSkin.MouseState.HOVER;
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.Size = new System.Drawing.Size(121, 23);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.mtlable);
            this.panel1.Location = new System.Drawing.Point(-2, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 74);
            this.panel1.TabIndex = 6;
            // 
            // mtlable
            // 
            this.mtlable.AutoSize = true;
            this.mtlable.BackColor = System.Drawing.Color.Silver;
            this.mtlable.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mtlable.Location = new System.Drawing.Point(25, 20);
            this.mtlable.Name = "mtlable";
            this.mtlable.Size = new System.Drawing.Size(289, 25);
            this.mtlable.TabIndex = 1;
            this.mtlable.Text = "Осталось 00 дней 00 часа 00 минут";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(171, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(115, 25);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Авторизация";
            // 
            // daytime
            // 
            this.daytime.Tick += new System.EventHandler(this.datetime_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(179, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // AuthicationLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.loginuse);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.authication);
            this.Controls.Add(this.Back);
            this.Name = "AuthicationLogin";
            this.Text = "Marathon Skills 2020";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthicationLogin_FormClosed);
            this.Load += new System.EventHandler(this.AuthicationLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton Back;
        private MaterialSkin.Controls.MaterialRaisedButton authication;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginuse;
        private MaterialSkin.Controls.MaterialSingleLineTextField password;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel mtlable;
        private System.Windows.Forms.Timer daytime;
        private System.Windows.Forms.Label label1;
    }
}