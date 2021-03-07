﻿
namespace GameJam_Planner
{
    partial class Form_Gamejam_Planner
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Gamejam_Planner));
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.comboBoxEngines = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxMechanics = new System.Windows.Forms.GroupBox();
            this.richTextBoxMec = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxArtStyle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTheme = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.menuStripPlanner = new System.Windows.Forms.MenuStrip();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HintsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStripOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeletePic = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customGroupBox1 = new GameJam_Planner.CustomGroupBox(this.components);
            this.groupBoxMain.SuspendLayout();
            this.groupBoxMechanics.SuspendLayout();
            this.menuStripPlanner.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStripOptions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxMain.Controls.Add(this.comboBoxEngines);
            this.groupBoxMain.Controls.Add(this.label11);
            this.groupBoxMain.Controls.Add(this.groupBoxMechanics);
            this.groupBoxMain.Controls.Add(this.label4);
            this.groupBoxMain.Controls.Add(this.textBoxArtStyle);
            this.groupBoxMain.Controls.Add(this.label2);
            this.groupBoxMain.Controls.Add(this.textBoxTheme);
            this.groupBoxMain.Controls.Add(this.textBoxGenre);
            this.groupBoxMain.Controls.Add(this.label3);
            this.groupBoxMain.Controls.Add(this.label5);
            this.groupBoxMain.Controls.Add(this.textBoxGroupName);
            this.groupBoxMain.Controls.Add(this.label1);
            this.groupBoxMain.Controls.Add(this.textBoxName);
            this.groupBoxMain.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBoxMain.Location = new System.Drawing.Point(12, 38);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(357, 265);
            this.groupBoxMain.TabIndex = 1;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Main";
            // 
            // comboBoxEngines
            // 
            this.comboBoxEngines.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxEngines.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxEngines.FormattingEnabled = true;
            this.comboBoxEngines.Location = new System.Drawing.Point(130, 205);
            this.comboBoxEngines.Name = "comboBoxEngines";
            this.comboBoxEngines.Size = new System.Drawing.Size(154, 27);
            this.comboBoxEngines.TabIndex = 5;
            this.comboBoxEngines.Text = "-Select-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(10, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Art Style:";
            // 
            // groupBoxMechanics
            // 
            this.groupBoxMechanics.Controls.Add(this.richTextBoxMec);
            this.groupBoxMechanics.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBoxMechanics.Location = new System.Drawing.Point(357, 210);
            this.groupBoxMechanics.Name = "groupBoxMechanics";
            this.groupBoxMechanics.Size = new System.Drawing.Size(250, 230);
            this.groupBoxMechanics.TabIndex = 4;
            this.groupBoxMechanics.TabStop = false;
            this.groupBoxMechanics.Text = "Mechanics";
            // 
            // richTextBoxMec
            // 
            this.richTextBoxMec.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBoxMec.Location = new System.Drawing.Point(9, 35);
            this.richTextBoxMec.Name = "richTextBoxMec";
            this.richTextBoxMec.Size = new System.Drawing.Size(235, 180);
            this.richTextBoxMec.TabIndex = 5;
            this.richTextBoxMec.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Theme:";
            // 
            // textBoxArtStyle
            // 
            this.textBoxArtStyle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxArtStyle.Location = new System.Drawing.Point(130, 170);
            this.textBoxArtStyle.Name = "textBoxArtStyle";
            this.textBoxArtStyle.Size = new System.Drawing.Size(155, 29);
            this.textBoxArtStyle.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genre:";
            // 
            // textBoxTheme
            // 
            this.textBoxTheme.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxTheme.Location = new System.Drawing.Point(130, 65);
            this.textBoxTheme.Name = "textBoxTheme";
            this.textBoxTheme.Size = new System.Drawing.Size(155, 29);
            this.textBoxTheme.TabIndex = 1;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxGenre.Location = new System.Drawing.Point(130, 135);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(155, 29);
            this.textBoxGenre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Game Engine:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Group:";
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxGroupName.Location = new System.Drawing.Point(130, 30);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(155, 29);
            this.textBoxGroupName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxName.Location = new System.Drawing.Point(130, 100);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(155, 29);
            this.textBoxName.TabIndex = 2;
            // 
            // menuStripPlanner
            // 
            this.menuStripPlanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStripPlanner.BackgroundImage")));
            this.menuStripPlanner.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveMenuItem,
            this.AddMenuItem,
            this.HintsMenuItem,
            this.ClearMenuItem,
            this.ExitMenuItem});
            this.menuStripPlanner.Location = new System.Drawing.Point(0, 0);
            this.menuStripPlanner.Name = "menuStripPlanner";
            this.menuStripPlanner.Size = new System.Drawing.Size(1430, 24);
            this.menuStripPlanner.TabIndex = 10;
            this.menuStripPlanner.Text = "PlannerManu";
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(43, 20);
            this.SaveMenuItem.Text = "Save";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // AddMenuItem
            // 
            this.AddMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noteBoxToolStripMenuItem,
            this.ımageBoxToolStripMenuItem,
            this.soundBoxToolStripMenuItem});
            this.AddMenuItem.Name = "AddMenuItem";
            this.AddMenuItem.Size = new System.Drawing.Size(41, 20);
            this.AddMenuItem.Text = "Add";
            // 
            // noteBoxToolStripMenuItem
            // 
            this.noteBoxToolStripMenuItem.Name = "noteBoxToolStripMenuItem";
            this.noteBoxToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.noteBoxToolStripMenuItem.Text = "Note Box";
            this.noteBoxToolStripMenuItem.Click += new System.EventHandler(this.noteBoxToolStripMenuItem_Click);
            // 
            // ımageBoxToolStripMenuItem
            // 
            this.ımageBoxToolStripMenuItem.Name = "ımageBoxToolStripMenuItem";
            this.ımageBoxToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ımageBoxToolStripMenuItem.Text = "Image Box";
            // 
            // soundBoxToolStripMenuItem
            // 
            this.soundBoxToolStripMenuItem.Name = "soundBoxToolStripMenuItem";
            this.soundBoxToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.soundBoxToolStripMenuItem.Text = "Sound Box";
            this.soundBoxToolStripMenuItem.Click += new System.EventHandler(this.soundBoxToolStripMenuItem_Click);
            // 
            // HintsMenuItem
            // 
            this.HintsMenuItem.Name = "HintsMenuItem";
            this.HintsMenuItem.Size = new System.Drawing.Size(47, 20);
            this.HintsMenuItem.Text = "Hints";
            this.HintsMenuItem.Click += new System.EventHandler(this.HintsMenuItem_Click);
            // 
            // ClearMenuItem
            // 
            this.ClearMenuItem.Name = "ClearMenuItem";
            this.ClearMenuItem.Size = new System.Drawing.Size(46, 20);
            this.ClearMenuItem.Text = "Clear";
            this.ClearMenuItem.Click += new System.EventHandler(this.ClearMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(38, 20);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.ContextMenuStrip = this.contextMenuStripOptions;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(967, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 200);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // contextMenuStripOptions
            // 
            this.contextMenuStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemName,
            this.toolStripMenuItemColor,
            this.toolStripMenuItemDeleteTxt,
            this.toolStripMenuItemDeletePic});
            this.contextMenuStripOptions.Name = "contextMenuStripOptions";
            this.contextMenuStripOptions.Size = new System.Drawing.Size(215, 114);
            // 
            // toolStripMenuItemName
            // 
            this.toolStripMenuItemName.Name = "toolStripMenuItemName";
            this.toolStripMenuItemName.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItemName.Text = "Change Name";
            this.toolStripMenuItemName.Click += new System.EventHandler(this.toolStripMenuItemName_Click);
            // 
            // toolStripMenuItemColor
            // 
            this.toolStripMenuItemColor.Name = "toolStripMenuItemColor";
            this.toolStripMenuItemColor.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItemColor.Text = "Change Background Color";
            this.toolStripMenuItemColor.Click += new System.EventHandler(this.toolStripMenuItemColor_Click);
            // 
            // toolStripMenuItemDeleteTxt
            // 
            this.toolStripMenuItemDeleteTxt.Name = "toolStripMenuItemDeleteTxt";
            this.toolStripMenuItemDeleteTxt.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItemDeleteTxt.Text = "Delete All Text";
            this.toolStripMenuItemDeleteTxt.Click += new System.EventHandler(this.toolStripMenuItemDeleteTxt_Click);
            // 
            // toolStripMenuItemDeletePic
            // 
            this.toolStripMenuItemDeletePic.Name = "toolStripMenuItemDeletePic";
            this.toolStripMenuItemDeletePic.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItemDeletePic.Text = "Delete Picture";
            this.toolStripMenuItemDeletePic.Click += new System.EventHandler(this.toolStripMenuItemDeletePic_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(200, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.richTextBox1.Location = new System.Drawing.Point(6, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(220, 156);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Location = new System.Drawing.Point(715, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 200);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox1.Location = new System.Drawing.Point(6, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // customGroupBox1
            // 
            this.customGroupBox1.ContextMenuStrip = this.contextMenuStripOptions;
            this.customGroupBox1.Location = new System.Drawing.Point(987, 148);
            this.customGroupBox1.Name = "customGroupBox1";
            this.customGroupBox1.Size = new System.Drawing.Size(200, 119);
            this.customGroupBox1.TabIndex = 14;
            this.customGroupBox1.TabStop = false;
            this.customGroupBox1.Text = "customGroupBox1";
            // 
            // Form_Gamejam_Planner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1430, 727);
            this.Controls.Add(this.customGroupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.menuStripPlanner);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStripPlanner;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_Gamejam_Planner";
            this.Text = "GameJam Planner";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Form_Gamejam_Planner_Load);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.groupBoxMechanics.ResumeLayout(false);
            this.menuStripPlanner.ResumeLayout(false);
            this.menuStripPlanner.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStripOptions.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTheme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxArtStyle;
        private System.Windows.Forms.GroupBox groupBoxMechanics;
        private System.Windows.Forms.RichTextBox richTextBoxMec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.ComboBox comboBoxEngines;
        private System.Windows.Forms.MenuStrip menuStripPlanner;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HintsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ımageBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundBoxToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private CustomGroupBox customGroupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemColor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteTxt;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeletePic;
    }
}

