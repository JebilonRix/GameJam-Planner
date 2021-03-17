
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
            this.panelSummary = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewSummary = new System.Windows.Forms.DataGridView();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSummary = new System.Windows.Forms.Button();
            this.buttonCredits = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonHints = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonMain = new System.Windows.Forms.Button();
            this.RightClickToBox.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSummary)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.RightClickBox.Click += new System.EventHandler(this.RightClickNote_Click);
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
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(233, 729);
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
            // panelSummary
            // 
            this.panelSummary.BackColor = System.Drawing.Color.Gray;
            this.panelSummary.Controls.Add(this.label7);
            this.panelSummary.Controls.Add(this.button4);
            this.panelSummary.Controls.Add(this.dataGridViewSummary);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSummary.Enabled = false;
            this.panelSummary.Location = new System.Drawing.Point(1110, 0);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(343, 729);
            this.panelSummary.TabIndex = 19;
            this.panelSummary.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Summary";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 611);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 29);
            this.button4.TabIndex = 13;
            this.button4.Text = "▲";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewSummary
            // 
            this.dataGridViewSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSummary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridViewSummary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSummary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewSummary.Location = new System.Drawing.Point(23, 25);
            this.dataGridViewSummary.MultiSelect = false;
            this.dataGridViewSummary.Name = "dataGridViewSummary";
            this.dataGridViewSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewSummary.Size = new System.Drawing.Size(308, 580);
            this.dataGridViewSummary.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gray;
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.buttonLoad);
            this.panelMenu.Controls.Add(this.buttonSummary);
            this.panelMenu.Controls.Add(this.buttonCredits);
            this.panelMenu.Controls.Add(this.buttonClear);
            this.panelMenu.Controls.Add(this.buttonHints);
            this.panelMenu.Controls.Add(this.buttonSave);
            this.panelMenu.Controls.Add(this.buttonMain);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(233, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(877, 40);
            this.panelMenu.TabIndex = 20;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonExit.Location = new System.Drawing.Point(588, 8);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLoad.Location = new System.Drawing.Point(183, 9);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSummary
            // 
            this.buttonSummary.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSummary.Location = new System.Drawing.Point(99, 8);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(78, 23);
            this.buttonSummary.TabIndex = 6;
            this.buttonSummary.Text = "Summary";
            this.buttonSummary.UseVisualStyleBackColor = true;
            this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // buttonCredits
            // 
            this.buttonCredits.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCredits.Location = new System.Drawing.Point(507, 9);
            this.buttonCredits.Name = "buttonCredits";
            this.buttonCredits.Size = new System.Drawing.Size(75, 23);
            this.buttonCredits.TabIndex = 4;
            this.buttonCredits.Text = "Credits";
            this.buttonCredits.UseVisualStyleBackColor = true;
            this.buttonCredits.Click += new System.EventHandler(this.buttonCredits_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClear.Location = new System.Drawing.Point(426, 8);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonHints
            // 
            this.buttonHints.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonHints.Location = new System.Drawing.Point(345, 8);
            this.buttonHints.Name = "buttonHints";
            this.buttonHints.Size = new System.Drawing.Size(75, 23);
            this.buttonHints.TabIndex = 2;
            this.buttonHints.Text = "Hints";
            this.buttonHints.UseVisualStyleBackColor = true;
            this.buttonHints.Click += new System.EventHandler(this.buttonHints_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSave.Location = new System.Drawing.Point(264, 9);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonMain
            // 
            this.buttonMain.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMain.Location = new System.Drawing.Point(18, 8);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(75, 23);
            this.buttonMain.TabIndex = 0;
            this.buttonMain.Text = "Main";
            this.buttonMain.UseVisualStyleBackColor = true;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // Form_Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1453, 729);
            this.ContextMenuStrip = this.RightClickToBox;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_Board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameJam Planner";
            this.Load += new System.EventHandler(this.Form_Board_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Board_KeyDown);
            this.RightClickToBox.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelSummary.ResumeLayout(false);
            this.panelSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSummary)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip RightClickToBox;
        private System.Windows.Forms.ToolStripMenuItem RightClickBox;
        private System.Windows.Forms.ToolStripMenuItem RightClickPicture;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ToolStripMenuItem RightClickToDo;
        private System.Windows.Forms.ToolStripMenuItem changeBackcolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showOpeningSceneToolStripMenuItem;
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
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.DataGridView dataGridViewSummary;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonCredits;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonHints;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.Button buttonSummary;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonExit;
    }
}

