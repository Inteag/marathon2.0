namespace marathon.Спонсоры
{
    partial class chooseRunner
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
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtlable = new MetroFramework.Controls.MetroLabel();
            this.daytime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(146, 100);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(174, 38);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "Я участвовал ранее";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(146, 144);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(174, 38);
            this.materialRaisedButton2.TabIndex = 1;
            this.materialRaisedButton2.Text = "Я новый участник";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.mtlable);
            this.panel1.Location = new System.Drawing.Point(-4, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 74);
            this.panel1.TabIndex = 7;
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
            // daytime
            // 
            this.daytime.Tick += new System.EventHandler(this.daytime_Tick);
            // 
            // chooseRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 323);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Name = "chooseRunner";
            this.Text = "Marathon Skills 2020";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.chooseRunner_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel mtlable;
        private System.Windows.Forms.Timer daytime;
    }
}