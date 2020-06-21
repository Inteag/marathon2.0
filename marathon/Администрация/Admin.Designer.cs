namespace marathon.Администрация
{
    partial class Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtlable = new MetroFramework.Controls.MetroLabel();
            this.daytime = new System.Windows.Forms.Timer(this.components);
            this.Uzer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Volonter = new MaterialSkin.Controls.MaterialRaisedButton();
            this.blagorganiz = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Inventory = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(296, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(205, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Панель Администратора";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.mtlable);
            this.panel1.Location = new System.Drawing.Point(-3, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 83);
            this.panel1.TabIndex = 7;
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
            // Uzer
            // 
            this.Uzer.Depth = 0;
            this.Uzer.Location = new System.Drawing.Point(196, 162);
            this.Uzer.MouseState = MaterialSkin.MouseState.HOVER;
            this.Uzer.Name = "Uzer";
            this.Uzer.Primary = true;
            this.Uzer.Size = new System.Drawing.Size(203, 55);
            this.Uzer.TabIndex = 8;
            this.Uzer.Text = "Пользователи";
            this.Uzer.UseVisualStyleBackColor = true;
            this.Uzer.Click += new System.EventHandler(this.Uzer_Click);
            // 
            // Volonter
            // 
            this.Volonter.Depth = 0;
            this.Volonter.Location = new System.Drawing.Point(405, 162);
            this.Volonter.MouseState = MaterialSkin.MouseState.HOVER;
            this.Volonter.Name = "Volonter";
            this.Volonter.Primary = true;
            this.Volonter.Size = new System.Drawing.Size(203, 55);
            this.Volonter.TabIndex = 9;
            this.Volonter.Text = "Волонтеры";
            this.Volonter.UseVisualStyleBackColor = true;
            this.Volonter.Click += new System.EventHandler(this.Volonter_Click);
            // 
            // blagorganiz
            // 
            this.blagorganiz.Depth = 0;
            this.blagorganiz.Location = new System.Drawing.Point(196, 223);
            this.blagorganiz.MouseState = MaterialSkin.MouseState.HOVER;
            this.blagorganiz.Name = "blagorganiz";
            this.blagorganiz.Primary = true;
            this.blagorganiz.Size = new System.Drawing.Size(203, 55);
            this.blagorganiz.TabIndex = 10;
            this.blagorganiz.Text = "Благотворительные организации";
            this.blagorganiz.UseVisualStyleBackColor = true;
            this.blagorganiz.Click += new System.EventHandler(this.blagorganiz_Click);
            // 
            // Inventory
            // 
            this.Inventory.Depth = 0;
            this.Inventory.Location = new System.Drawing.Point(405, 223);
            this.Inventory.MouseState = MaterialSkin.MouseState.HOVER;
            this.Inventory.Name = "Inventory";
            this.Inventory.Primary = true;
            this.Inventory.Size = new System.Drawing.Size(203, 55);
            this.Inventory.TabIndex = 11;
            this.Inventory.Text = "Инвентарь";
            this.Inventory.UseVisualStyleBackColor = true;
            this.Inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.blagorganiz);
            this.Controls.Add(this.Volonter);
            this.Controls.Add(this.Uzer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Admin";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Marathon Skills 2020";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel mtlable;
        private System.Windows.Forms.Timer daytime;
        private MaterialSkin.Controls.MaterialRaisedButton Uzer;
        private MaterialSkin.Controls.MaterialRaisedButton Volonter;
        private MaterialSkin.Controls.MaterialRaisedButton blagorganiz;
        private MaterialSkin.Controls.MaterialRaisedButton Inventory;
    }
}