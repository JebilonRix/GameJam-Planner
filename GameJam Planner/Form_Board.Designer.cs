
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
            this.AddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toDoBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HintsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showOpeningSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickToBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RightClickBox = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickToDo = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackcolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStripPlanner.SuspendLayout();
            this.RightClickToBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPlanner
            // 
            this.menuStripPlanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStripPlanner.BackgroundImage")));
            this.menuStripPlanner.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenuItem,
            this.HintsMenuItem,
            this.ClearMenuItem,
            this.ExitMenuItem,
            this.showOpeningSceneToolStripMenuItem});
            this.menuStripPlanner.Location = new System.Drawing.Point(0, 0);
            this.menuStripPlanner.Name = "menuStripPlanner";
            this.menuStripPlanner.Size = new System.Drawing.Size(1337, 24);
            this.menuStripPlanner.TabIndex = 10;
            this.menuStripPlanner.Text = "PlannerManu";
            // 
            // AddMenuItem
            // 
            this.AddMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noteBoxToolStripMenuItem,
            this.ImageBoxToolStripMenuItem,
            this.toDoBoxToolStripMenuItem});
            this.AddMenuItem.Name = "AddMenuItem";
            this.AddMenuItem.Size = new System.Drawing.Size(41, 20);
            this.AddMenuItem.Text = "Add";
            // 
            // noteBoxToolStripMenuItem
            // 
            this.noteBoxToolStripMenuItem.Name = "noteBoxToolStripMenuItem";
            this.noteBoxToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.noteBoxToolStripMenuItem.Text = "Note Box";
            this.noteBoxToolStripMenuItem.Click += new System.EventHandler(this.noteBoxToolStripMenuItem_Click);
            // 
            // ImageBoxToolStripMenuItem
            // 
            this.ImageBoxToolStripMenuItem.Name = "ImageBoxToolStripMenuItem";
            this.ImageBoxToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ImageBoxToolStripMenuItem.Text = "Image Box";
            this.ImageBoxToolStripMenuItem.Click += new System.EventHandler(this.ImageBoxToolStripMenuItem_Click);
            // 
            // toDoBoxToolStripMenuItem
            // 
            this.toDoBoxToolStripMenuItem.Name = "toDoBoxToolStripMenuItem";
            this.toDoBoxToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.toDoBoxToolStripMenuItem.Text = "ToDo Box";
            this.toDoBoxToolStripMenuItem.Click += new System.EventHandler(this.toDoBoxToolStripMenuItem_Click);
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
            // showOpeningSceneToolStripMenuItem
            // 
            this.showOpeningSceneToolStripMenuItem.Name = "showOpeningSceneToolStripMenuItem";
            this.showOpeningSceneToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.showOpeningSceneToolStripMenuItem.Text = "Show Opening Scene";
            this.showOpeningSceneToolStripMenuItem.Click += new System.EventHandler(this.showOpeningSceneToolStripMenuItem_Click);
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
            // Form_Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1337, 581);
            this.ContextMenuStrip = this.RightClickToBox;
            this.Controls.Add(this.menuStripPlanner);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripPlanner;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_Board";
            this.Text = "GameJam Planner";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Form_Board_Load);
            this.menuStripPlanner.ResumeLayout(false);
            this.menuStripPlanner.PerformLayout();
            this.RightClickToBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripPlanner;
        private System.Windows.Forms.ToolStripMenuItem AddMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HintsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImageBoxToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip RightClickToBox;
        private System.Windows.Forms.ToolStripMenuItem RightClickBox;
        private System.Windows.Forms.ToolStripMenuItem RightClickPicture;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ToolStripMenuItem RightClickToDo;
        private System.Windows.Forms.ToolStripMenuItem toDoBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showOpeningSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBackcolorToolStripMenuItem;
    }
}

