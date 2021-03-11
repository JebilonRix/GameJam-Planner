
namespace GameJam_Planner
{
    partial class Form_Enter
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
            System.Windows.Forms.GroupBox MainBox;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxEngines = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxArtStyle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTheme = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            MainBox = new System.Windows.Forms.GroupBox();
            MainBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(17, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(150, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(271, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainBox
            // 
            MainBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            MainBox.Controls.Add(this.comboBoxEngines);
            MainBox.Controls.Add(this.label6);
            MainBox.Controls.Add(this.label7);
            MainBox.Controls.Add(this.textBoxArtStyle);
            MainBox.Controls.Add(this.label8);
            MainBox.Controls.Add(this.textBoxTheme);
            MainBox.Controls.Add(this.textBoxGenre);
            MainBox.Controls.Add(this.label9);
            MainBox.Controls.Add(this.label10);
            MainBox.Controls.Add(this.textBoxGroupName);
            MainBox.Controls.Add(this.label12);
            MainBox.Controls.Add(this.textBoxName);
            MainBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            MainBox.ForeColor = System.Drawing.SystemColors.Info;
            MainBox.Location = new System.Drawing.Point(12, 12);
            MainBox.Name = "MainBox";
            MainBox.Size = new System.Drawing.Size(357, 249);
            MainBox.TabIndex = 6;
            MainBox.TabStop = false;
            MainBox.Text = "Main";
            // 
            // comboBoxEngines
            // 
            this.comboBoxEngines.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxEngines.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxEngines.FormattingEnabled = true;
            this.comboBoxEngines.Items.AddRange(new object[] {
            "CryEngine",
            "GameMaker",
            "Godot",
            "Unity",
            "Unreal"});
            this.comboBoxEngines.Location = new System.Drawing.Point(130, 205);
            this.comboBoxEngines.Name = "comboBoxEngines";
            this.comboBoxEngines.Size = new System.Drawing.Size(154, 27);
            this.comboBoxEngines.Sorted = true;
            this.comboBoxEngines.TabIndex = 5;
            this.comboBoxEngines.Text = "-Select-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(10, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Art Style:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(10, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Theme:";
            // 
            // textBoxArtStyle
            // 
            this.textBoxArtStyle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxArtStyle.Location = new System.Drawing.Point(130, 170);
            this.textBoxArtStyle.Name = "textBoxArtStyle";
            this.textBoxArtStyle.Size = new System.Drawing.Size(155, 29);
            this.textBoxArtStyle.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(10, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Genre:";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(10, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Game Engine:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(10, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Group:";
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxGroupName.Location = new System.Drawing.Point(130, 30);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(155, 29);
            this.textBoxGroupName.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(10, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxName.Location = new System.Drawing.Point(130, 100);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(155, 29);
            this.textBoxName.TabIndex = 2;
            // 
            // Form_Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(383, 317);
            this.Controls.Add(MainBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form_Enter";
            this.Text = "Form_Enter";
            this.Load += new System.EventHandler(this.Form_Enter_Load);
            MainBox.ResumeLayout(false);
            MainBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxEngines;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxArtStyle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTheme;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxName;
    }
}