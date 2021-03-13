
namespace GameJam_Planner
{
    partial class Form_Board
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Board));
            this.menuStripPlanner = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HintsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickToBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RightClickBox = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickToDo = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackcolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.showOpeningSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripPlanner.SuspendLayout();
            this.RightClickToBox.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPlanner
            // 
            this.menuStripPlanner.BackColor = System.Drawing.Color.Gray;
            this.menuStripPlanner.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.HintsMenuItem,
            this.ClearMenuItem,
            this.ExitMenuItem,
            this.creditsToolStripMenuItem});
            this.menuStripPlanner.Location = new System.Drawing.Point(0, 0);
            this.menuStripPlanner.Name = "menuStripPlanner";
            this.menuStripPlanner.Size = new System.Drawing.Size(1350, 24);
            this.menuStripPlanner.TabIndex = 10;
            this.menuStripPlanner.Text = "PlannerManu";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
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
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // RightClickToBox
            // 
            this.RightClickToBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RightClickBox,
            this.RightClickPicture,
            this.RightClickToDo,
            this.changeBackcolorToolStripMenuItem});
            this.RightClickToBox.Name = "contextMenuStrip";
            this.RightClickToBox.Size = new System.Drawing.Size(171, 92);
            // 
            // RightClickBox
            // 
            this.RightClickBox.Name = "RightClickBox";
            this.RightClickBox.Size = new System.Drawing.Size(170, 22);
            this.RightClickBox.Text = "Add Box";
            this.RightClickBox.Click += new System.EventHandler(this.RightClickBox_Click);
            // 
            // RightClickPicture
            // 
            this.RightClickPicture.Name = "RightClickPicture";
            this.RightClickPicture.Size = new System.Drawing.Size(170, 22);
            this.RightClickPicture.Text = "AddPicture";
            this.RightClickPicture.Click += new System.EventHandler(this.RightClickPicture_Click);
            // 
            // RightClickToDo
            // 
            this.RightClickToDo.Name = "RightClickToDo";
            this.RightClickToDo.Size = new System.Drawing.Size(170, 22);
            this.RightClickToDo.Text = "AddToDo";
            this.RightClickToDo.Click += new System.EventHandler(this.RightClickToDo_Click);
            // 
            // changeBackcolorToolStripMenuItem
            // 
            this.changeBackcolorToolStripMenuItem.Name = "changeBackcolorToolStripMenuItem";
            this.changeBackcolorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.changeBackcolorToolStripMenuItem.Text = "Change Backcolor";
            this.changeBackcolorToolStripMenuItem.Click += new System.EventHandler(this.changeBackcolorToolStripMenuItem_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 60);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(219, 169);
            this.checkedListBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(146, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(19, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // showOpeningSceneToolStripMenuItem
            // 
            this.showOpeningSceneToolStripMenuItem.Name = "showOpeningSceneToolStripMenuItem";
            this.showOpeningSceneToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.showOpeningSceneToolStripMenuItem.Text = "Show Opening Scene";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Gray;
            this.panelMain.Controls.Add(this.button3);
            this.panelMain.Controls.Add(this.comboBox1);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.textBox5);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.textBox4);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.textBox3);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.textBox2);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.textBox1);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Enabled = false;
            this.panelMain.Location = new System.Drawing.Point(0, 24);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(233, 705);
            this.panelMain.TabIndex = 11;
            this.panelMain.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(109, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 29);
            this.button3.TabIndex = 12;
            this.button3.Text = "▲";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Godot",
            "Unity",
            "Unreal",
            "Game Maker"});
            this.comboBox1.Location = new System.Drawing.Point(109, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 23);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "-Select-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(19, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Game Engine:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(109, 153);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(115, 21);
            this.textBox5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(45, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Art Style:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(109, 118);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(115, 21);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(59, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genre:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(109, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 21);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(54, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Theme:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(109, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name Of Game:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(109, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name Of Group:";
            // 
            // Form_Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.ContextMenuStrip = this.RightClickToBox;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStripPlanner);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripPlanner;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_Board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameJam Planner";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Board_FormClosing);
            this.Load += new System.EventHandler(this.Form_Board_Load);
            this.menuStripPlanner.ResumeLayout(false);
            this.menuStripPlanner.PerformLayout();
            this.RightClickToBox.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripPlanner;
        private System.Windows.Forms.ToolStripMenuItem ClearMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HintsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ContextMenuStrip RightClickToBox;
        private System.Windows.Forms.ToolStripMenuItem RightClickBox;
        private System.Windows.Forms.ToolStripMenuItem RightClickPicture;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ToolStripMenuItem RightClickToDo;
        private System.Windows.Forms.ToolStripMenuItem changeBackcolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showOpeningSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
    }
}

