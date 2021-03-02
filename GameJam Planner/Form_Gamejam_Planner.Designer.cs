
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
            this.groupBoxCode = new System.Windows.Forms.GroupBox();
            this.groupBoxMethod = new System.Windows.Forms.GroupBox();
            this.groupBoxClass = new System.Windows.Forms.GroupBox();
            this.groupBoxArt = new System.Windows.Forms.GroupBox();
            this.groupBoxAnimations = new System.Windows.Forms.GroupBox();
            this.groupBoxObjects = new System.Windows.Forms.GroupBox();
            this.groupBoxChracters = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxMusic = new System.Windows.Forms.GroupBox();
            this.groupBoxSounds = new System.Windows.Forms.GroupBox();
            this.groupBoxMusics = new System.Windows.Forms.GroupBox();
            this.groupBoxStyle = new System.Windows.Forms.GroupBox();
            this.groupBoxMechanics = new System.Windows.Forms.GroupBox();
            this.richTextBoxMec = new System.Windows.Forms.RichTextBox();
            this.groupBoxDynamics = new System.Windows.Forms.GroupBox();
            this.richTextBoxDy = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxArtStyle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTheme = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGameEngine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.richTextBoxCl = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMet = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAn = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOb = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCh = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMus = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSo = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxCode.SuspendLayout();
            this.groupBoxMethod.SuspendLayout();
            this.groupBoxClass.SuspendLayout();
            this.groupBoxArt.SuspendLayout();
            this.groupBoxAnimations.SuspendLayout();
            this.groupBoxObjects.SuspendLayout();
            this.groupBoxChracters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxMusic.SuspendLayout();
            this.groupBoxSounds.SuspendLayout();
            this.groupBoxMusics.SuspendLayout();
            this.groupBoxStyle.SuspendLayout();
            this.groupBoxMechanics.SuspendLayout();
            this.groupBoxDynamics.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCode
            // 
            this.groupBoxCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBoxCode.Controls.Add(this.groupBoxMethod);
            this.groupBoxCode.Controls.Add(this.groupBoxClass);
            this.groupBoxCode.Location = new System.Drawing.Point(3, 6);
            this.groupBoxCode.Name = "groupBoxCode";
            this.groupBoxCode.Size = new System.Drawing.Size(1230, 620);
            this.groupBoxCode.TabIndex = 0;
            this.groupBoxCode.TabStop = false;
            this.groupBoxCode.Text = "Code";
            // 
            // groupBoxMethod
            // 
            this.groupBoxMethod.Controls.Add(this.richTextBoxMet);
            this.groupBoxMethod.Location = new System.Drawing.Point(433, 38);
            this.groupBoxMethod.Name = "groupBoxMethod";
            this.groupBoxMethod.Size = new System.Drawing.Size(375, 265);
            this.groupBoxMethod.TabIndex = 5;
            this.groupBoxMethod.TabStop = false;
            this.groupBoxMethod.Text = "Methods";
            // 
            // groupBoxClass
            // 
            this.groupBoxClass.Controls.Add(this.richTextBoxCl);
            this.groupBoxClass.Location = new System.Drawing.Point(16, 38);
            this.groupBoxClass.Name = "groupBoxClass";
            this.groupBoxClass.Size = new System.Drawing.Size(375, 265);
            this.groupBoxClass.TabIndex = 4;
            this.groupBoxClass.TabStop = false;
            this.groupBoxClass.Text = "Classes";
            // 
            // groupBoxArt
            // 
            this.groupBoxArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBoxArt.Controls.Add(this.groupBoxAnimations);
            this.groupBoxArt.Controls.Add(this.groupBoxObjects);
            this.groupBoxArt.Controls.Add(this.groupBoxChracters);
            this.groupBoxArt.Controls.Add(this.pictureBox3);
            this.groupBoxArt.Controls.Add(this.pictureBox2);
            this.groupBoxArt.Controls.Add(this.pictureBox1);
            this.groupBoxArt.Controls.Add(this.label14);
            this.groupBoxArt.Controls.Add(this.label8);
            this.groupBoxArt.Controls.Add(this.label7);
            this.groupBoxArt.Location = new System.Drawing.Point(3, 6);
            this.groupBoxArt.Name = "groupBoxArt";
            this.groupBoxArt.Size = new System.Drawing.Size(1230, 620);
            this.groupBoxArt.TabIndex = 1;
            this.groupBoxArt.TabStop = false;
            this.groupBoxArt.Text = "Art";
            // 
            // groupBoxAnimations
            // 
            this.groupBoxAnimations.Controls.Add(this.richTextBoxAn);
            this.groupBoxAnimations.Location = new System.Drawing.Point(832, 308);
            this.groupBoxAnimations.Name = "groupBoxAnimations";
            this.groupBoxAnimations.Size = new System.Drawing.Size(375, 265);
            this.groupBoxAnimations.TabIndex = 5;
            this.groupBoxAnimations.TabStop = false;
            this.groupBoxAnimations.Text = "Animations";
            // 
            // groupBoxObjects
            // 
            this.groupBoxObjects.Controls.Add(this.richTextBoxOb);
            this.groupBoxObjects.Location = new System.Drawing.Point(420, 308);
            this.groupBoxObjects.Name = "groupBoxObjects";
            this.groupBoxObjects.Size = new System.Drawing.Size(375, 265);
            this.groupBoxObjects.TabIndex = 4;
            this.groupBoxObjects.TabStop = false;
            this.groupBoxObjects.Text = "Objects";
            // 
            // groupBoxChracters
            // 
            this.groupBoxChracters.Controls.Add(this.richTextBoxCh);
            this.groupBoxChracters.Location = new System.Drawing.Point(14, 308);
            this.groupBoxChracters.Name = "groupBoxChracters";
            this.groupBoxChracters.Size = new System.Drawing.Size(375, 265);
            this.groupBoxChracters.TabIndex = 4;
            this.groupBoxChracters.TabStop = false;
            this.groupBoxChracters.Text = "Chracters";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox3.Location = new System.Drawing.Point(832, 57);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(377, 240);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox2.Location = new System.Drawing.Point(420, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(377, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(14, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(828, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "Background";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(416, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Menu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(10, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "UI:";
            // 
            // groupBoxMusic
            // 
            this.groupBoxMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBoxMusic.Controls.Add(this.groupBoxSounds);
            this.groupBoxMusic.Controls.Add(this.groupBoxMusics);
            this.groupBoxMusic.Location = new System.Drawing.Point(0, 3);
            this.groupBoxMusic.Name = "groupBoxMusic";
            this.groupBoxMusic.Size = new System.Drawing.Size(1236, 626);
            this.groupBoxMusic.TabIndex = 1;
            this.groupBoxMusic.TabStop = false;
            this.groupBoxMusic.Text = "Music And Sound";
            // 
            // groupBoxSounds
            // 
            this.groupBoxSounds.Controls.Add(this.richTextBoxSo);
            this.groupBoxSounds.Location = new System.Drawing.Point(424, 40);
            this.groupBoxSounds.Name = "groupBoxSounds";
            this.groupBoxSounds.Size = new System.Drawing.Size(375, 265);
            this.groupBoxSounds.TabIndex = 4;
            this.groupBoxSounds.TabStop = false;
            this.groupBoxSounds.Text = "Sounds";
            // 
            // groupBoxMusics
            // 
            this.groupBoxMusics.Controls.Add(this.richTextBoxMus);
            this.groupBoxMusics.Location = new System.Drawing.Point(17, 40);
            this.groupBoxMusics.Name = "groupBoxMusics";
            this.groupBoxMusics.Size = new System.Drawing.Size(375, 265);
            this.groupBoxMusics.TabIndex = 4;
            this.groupBoxMusics.TabStop = false;
            this.groupBoxMusics.Text = "Musics";
            // 
            // groupBoxStyle
            // 
            this.groupBoxStyle.BackColor = System.Drawing.Color.Red;
            this.groupBoxStyle.Controls.Add(this.groupBoxMechanics);
            this.groupBoxStyle.Controls.Add(this.groupBoxDynamics);
            this.groupBoxStyle.Controls.Add(this.label11);
            this.groupBoxStyle.Controls.Add(this.label4);
            this.groupBoxStyle.Controls.Add(this.textBoxArtStyle);
            this.groupBoxStyle.Controls.Add(this.label2);
            this.groupBoxStyle.Controls.Add(this.textBoxTheme);
            this.groupBoxStyle.Controls.Add(this.textBoxGenre);
            this.groupBoxStyle.Controls.Add(this.label3);
            this.groupBoxStyle.Controls.Add(this.textBoxGameEngine);
            this.groupBoxStyle.Controls.Add(this.label1);
            this.groupBoxStyle.Controls.Add(this.textBoxName);
            this.groupBoxStyle.Location = new System.Drawing.Point(0, 3);
            this.groupBoxStyle.Name = "groupBoxStyle";
            this.groupBoxStyle.Size = new System.Drawing.Size(1230, 620);
            this.groupBoxStyle.TabIndex = 2;
            this.groupBoxStyle.TabStop = false;
            this.groupBoxStyle.Text = "Main";
            // 
            // groupBoxMechanics
            // 
            this.groupBoxMechanics.Controls.Add(this.richTextBoxMec);
            this.groupBoxMechanics.Location = new System.Drawing.Point(747, 28);
            this.groupBoxMechanics.Name = "groupBoxMechanics";
            this.groupBoxMechanics.Size = new System.Drawing.Size(375, 265);
            this.groupBoxMechanics.TabIndex = 4;
            this.groupBoxMechanics.TabStop = false;
            this.groupBoxMechanics.Text = "Mechanics";
            // 
            // richTextBoxMec
            // 
            this.richTextBoxMec.Location = new System.Drawing.Point(6, 28);
            this.richTextBoxMec.Name = "richTextBoxMec";
            this.richTextBoxMec.Size = new System.Drawing.Size(350, 186);
            this.richTextBoxMec.TabIndex = 5;
            this.richTextBoxMec.Text = "";
            // 
            // groupBoxDynamics
            // 
            this.groupBoxDynamics.Controls.Add(this.richTextBoxDy);
            this.groupBoxDynamics.Location = new System.Drawing.Point(344, 28);
            this.groupBoxDynamics.Name = "groupBoxDynamics";
            this.groupBoxDynamics.Size = new System.Drawing.Size(375, 265);
            this.groupBoxDynamics.TabIndex = 4;
            this.groupBoxDynamics.TabStop = false;
            this.groupBoxDynamics.Text = "Dynamics";
            // 
            // richTextBoxDy
            // 
            this.richTextBoxDy.Location = new System.Drawing.Point(9, 28);
            this.richTextBoxDy.Name = "richTextBoxDy";
            this.richTextBoxDy.Size = new System.Drawing.Size(350, 186);
            this.richTextBoxDy.TabIndex = 5;
            this.richTextBoxDy.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Art Style:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Theme:";
            // 
            // textBoxArtStyle
            // 
            this.textBoxArtStyle.Location = new System.Drawing.Point(89, 169);
            this.textBoxArtStyle.Name = "textBoxArtStyle";
            this.textBoxArtStyle.Size = new System.Drawing.Size(145, 29);
            this.textBoxArtStyle.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genre:";
            // 
            // textBoxTheme
            // 
            this.textBoxTheme.Location = new System.Drawing.Point(79, 65);
            this.textBoxTheme.Name = "textBoxTheme";
            this.textBoxTheme.Size = new System.Drawing.Size(155, 29);
            this.textBoxTheme.TabIndex = 0;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(79, 134);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(155, 29);
            this.textBoxGenre.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Game Engine:";
            // 
            // textBoxGameEngine
            // 
            this.textBoxGameEngine.Location = new System.Drawing.Point(129, 204);
            this.textBoxGameEngine.Name = "textBoxGameEngine";
            this.textBoxGameEngine.Size = new System.Drawing.Size(105, 29);
            this.textBoxGameEngine.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(79, 99);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(155, 29);
            this.textBoxName.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1230, 620);
            this.tabControl.TabIndex = 3;
            this.tabControl.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.groupBoxStyle);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1222, 585);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.groupBoxCode);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1222, 585);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBoxArt);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1222, 585);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBoxMusic);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1222, 585);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // richTextBoxCl
            // 
            this.richTextBoxCl.Location = new System.Drawing.Point(6, 28);
            this.richTextBoxCl.Name = "richTextBoxCl";
            this.richTextBoxCl.Size = new System.Drawing.Size(363, 179);
            this.richTextBoxCl.TabIndex = 0;
            this.richTextBoxCl.Text = "";
            // 
            // richTextBoxMet
            // 
            this.richTextBoxMet.Location = new System.Drawing.Point(6, 28);
            this.richTextBoxMet.Name = "richTextBoxMet";
            this.richTextBoxMet.Size = new System.Drawing.Size(363, 179);
            this.richTextBoxMet.TabIndex = 0;
            this.richTextBoxMet.Text = "";
            // 
            // richTextBoxAn
            // 
            this.richTextBoxAn.Location = new System.Drawing.Point(6, 43);
            this.richTextBoxAn.Name = "richTextBoxAn";
            this.richTextBoxAn.Size = new System.Drawing.Size(363, 179);
            this.richTextBoxAn.TabIndex = 1;
            this.richTextBoxAn.Text = "";
            // 
            // richTextBoxOb
            // 
            this.richTextBoxOb.Location = new System.Drawing.Point(6, 43);
            this.richTextBoxOb.Name = "richTextBoxOb";
            this.richTextBoxOb.Size = new System.Drawing.Size(363, 179);
            this.richTextBoxOb.TabIndex = 2;
            this.richTextBoxOb.Text = "";
            // 
            // richTextBoxCh
            // 
            this.richTextBoxCh.Location = new System.Drawing.Point(6, 43);
            this.richTextBoxCh.Name = "richTextBoxCh";
            this.richTextBoxCh.Size = new System.Drawing.Size(363, 179);
            this.richTextBoxCh.TabIndex = 3;
            this.richTextBoxCh.Text = "";
            // 
            // richTextBoxMus
            // 
            this.richTextBoxMus.Location = new System.Drawing.Point(6, 44);
            this.richTextBoxMus.Name = "richTextBoxMus";
            this.richTextBoxMus.Size = new System.Drawing.Size(363, 179);
            this.richTextBoxMus.TabIndex = 1;
            this.richTextBoxMus.Text = "";
            // 
            // richTextBoxSo
            // 
            this.richTextBoxSo.Location = new System.Drawing.Point(6, 44);
            this.richTextBoxSo.Name = "richTextBoxSo";
            this.richTextBoxSo.Size = new System.Drawing.Size(363, 179);
            this.richTextBoxSo.TabIndex = 2;
            this.richTextBoxSo.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // Form_Gamejam_Planner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_Gamejam_Planner";
            this.Text = "GameJam Planner";
            this.groupBoxCode.ResumeLayout(false);
            this.groupBoxMethod.ResumeLayout(false);
            this.groupBoxClass.ResumeLayout(false);
            this.groupBoxArt.ResumeLayout(false);
            this.groupBoxArt.PerformLayout();
            this.groupBoxAnimations.ResumeLayout(false);
            this.groupBoxObjects.ResumeLayout(false);
            this.groupBoxChracters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxMusic.ResumeLayout(false);
            this.groupBoxSounds.ResumeLayout(false);
            this.groupBoxMusics.ResumeLayout(false);
            this.groupBoxStyle.ResumeLayout(false);
            this.groupBoxStyle.PerformLayout();
            this.groupBoxMechanics.ResumeLayout(false);
            this.groupBoxDynamics.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCode;
        private System.Windows.Forms.GroupBox groupBoxArt;
        private System.Windows.Forms.GroupBox groupBoxMusic;
        private System.Windows.Forms.GroupBox groupBoxStyle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTheme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGameEngine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxArtStyle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBoxMethod;
        private System.Windows.Forms.GroupBox groupBoxClass;
        private System.Windows.Forms.GroupBox groupBoxMechanics;
        private System.Windows.Forms.GroupBox groupBoxDynamics;
        private System.Windows.Forms.GroupBox groupBoxAnimations;
        private System.Windows.Forms.GroupBox groupBoxObjects;
        private System.Windows.Forms.GroupBox groupBoxChracters;
        private System.Windows.Forms.GroupBox groupBoxSounds;
        private System.Windows.Forms.GroupBox groupBoxMusics;
        private System.Windows.Forms.RichTextBox richTextBoxMec;
        private System.Windows.Forms.RichTextBox richTextBoxDy;
        private System.Windows.Forms.RichTextBox richTextBoxMet;
        private System.Windows.Forms.RichTextBox richTextBoxCl;
        private System.Windows.Forms.RichTextBox richTextBoxAn;
        private System.Windows.Forms.RichTextBox richTextBoxOb;
        private System.Windows.Forms.RichTextBox richTextBoxCh;
        private System.Windows.Forms.RichTextBox richTextBoxSo;
        private System.Windows.Forms.RichTextBox richTextBoxMus;
        private System.Windows.Forms.Button button1;
    }
}

