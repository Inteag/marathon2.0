namespace marathon
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
            this.components = new System.ComponentModel.Container();
            this.begun = new System.Windows.Forms.Button();
            this.sponsor = new System.Windows.Forms.Button();
            this.marathon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.marathonlab = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mtlable = new MetroFramework.Controls.MetroLabel();
            this.daytime = new System.Windows.Forms.Timer(this.components);
            this.login = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // begun
            // 
            this.begun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.begun.ForeColor = System.Drawing.SystemColors.InfoText;
            this.begun.Location = new System.Drawing.Point(95, 112);
            this.begun.Name = "begun";
            this.begun.Size = new System.Drawing.Size(202, 44);
            this.begun.TabIndex = 1;
            this.begun.Text = "я хочу стать бегуном";
            this.begun.UseVisualStyleBackColor = true;
            this.begun.Click += new System.EventHandler(this.begun_Click);
            // 
            // sponsor
            // 
            this.sponsor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sponsor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.sponsor.Location = new System.Drawing.Point(95, 162);
            this.sponsor.Name = "sponsor";
            this.sponsor.Size = new System.Drawing.Size(202, 43);
            this.sponsor.TabIndex = 2;
            this.sponsor.Text = "Я хочу стать спонсором";
            this.sponsor.UseVisualStyleBackColor = true;
            this.sponsor.Click += new System.EventHandler(this.sponsor_Click);
            // 
            // marathon
            // 
            this.marathon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marathon.ForeColor = System.Drawing.SystemColors.InfoText;
            this.marathon.Location = new System.Drawing.Point(95, 211);
            this.marathon.Name = "marathon";
            this.marathon.Size = new System.Drawing.Size(202, 44);
            this.marathon.TabIndex = 3;
            this.marathon.Text = "Я хочу узнать больше о событии";
            this.marathon.UseVisualStyleBackColor = true;
            this.marathon.Click += new System.EventHandler(this.marathon_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.marathonlab);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 106);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(125, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Москва, Россия Вторник 24 Ноября 2020 ";
            // 
            // marathonlab
            // 
            this.marathonlab.BackColor = System.Drawing.Color.Silver;
            this.marathonlab.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.marathonlab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.marathonlab.Location = new System.Drawing.Point(118, 9);
            this.marathonlab.Name = "marathonlab";
            this.marathonlab.Size = new System.Drawing.Size(206, 35);
            this.marathonlab.TabIndex = 0;
            this.marathonlab.Text = "Marathon Skills 2020 ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.mtlable);
            this.panel2.Location = new System.Drawing.Point(-2, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 51);
            this.panel2.TabIndex = 5;
            // 
            // mtlable
            // 
            this.mtlable.AutoSize = true;
            this.mtlable.BackColor = System.Drawing.Color.Silver;
            this.mtlable.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mtlable.Location = new System.Drawing.Point(21, 16);
            this.mtlable.Name = "mtlable";
            this.mtlable.Size = new System.Drawing.Size(289, 25);
            this.mtlable.TabIndex = 0;
            this.mtlable.Text = "Осталось 00 дней 00 часа 00 минут";
            this.mtlable.Click += new System.EventHandler(this.mtlable_Click);
            // 
            // daytime
            // 
            this.daytime.Tick += new System.EventHandler(this.daytime_Tick);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login.Depth = 0;
            this.login.Location = new System.Drawing.Point(343, 243);
            this.login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.login.MouseState = MaterialSkin.MouseState.HOVER;
            this.login.Name = "login";
            this.login.Primary = false;
            this.login.Size = new System.Drawing.Size(58, 36);
            this.login.TabIndex = 6;
            this.login.Text = "Войти";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 338);
            this.Controls.Add(this.login);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.marathon);
            this.Controls.Add(this.sponsor);
            this.Controls.Add(this.begun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button begun;
        private System.Windows.Forms.Button sponsor;
        private System.Windows.Forms.Button marathon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer daytime;
        private MetroFramework.Controls.MetroLabel mtlable;
        private MetroFramework.Controls.MetroLabel marathonlab;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton login;
    }
}

