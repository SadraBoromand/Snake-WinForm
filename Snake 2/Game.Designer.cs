namespace Snake_2
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.head = new System.Windows.Forms.PictureBox();
            this.body1 = new System.Windows.Forms.PictureBox();
            this.body2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.Apple = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.By_Wall = new System.Windows.Forms.RadioButton();
            this.By_Edge = new System.Windows.Forms.RadioButton();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.body1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.body2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apple)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Snake_2.Properties.Resources.back2;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(720, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 480);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.Transparent;
            this.head.BackgroundImage = global::Snake_2.Properties.Resources.head;
            this.head.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.head.Location = new System.Drawing.Point(90, 120);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(30, 30);
            this.head.TabIndex = 1;
            this.head.TabStop = false;
            // 
            // body1
            // 
            this.body1.BackColor = System.Drawing.Color.Transparent;
            this.body1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("body1.BackgroundImage")));
            this.body1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.body1.Location = new System.Drawing.Point(60, 120);
            this.body1.Name = "body1";
            this.body1.Size = new System.Drawing.Size(30, 30);
            this.body1.TabIndex = 1;
            this.body1.TabStop = false;
            // 
            // body2
            // 
            this.body2.BackColor = System.Drawing.Color.Transparent;
            this.body2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("body2.BackgroundImage")));
            this.body2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.body2.Location = new System.Drawing.Point(30, 120);
            this.body2.Name = "body2";
            this.body2.Size = new System.Drawing.Size(30, 30);
            this.body2.TabIndex = 1;
            this.body2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(748, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Snake_2.Properties.Resources.colorful_flat_snake_illustration_23_2148157118;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(741, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 167);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(748, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time : ";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Time.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.ForeColor = System.Drawing.Color.White;
            this.lbl_Time.Location = new System.Drawing.Point(855, 256);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(25, 29);
            this.lbl_Time.TabIndex = 2;
            this.lbl_Time.Text = "0";
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Score.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.ForeColor = System.Drawing.Color.White;
            this.lbl_Score.Location = new System.Drawing.Point(855, 201);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(37, 29);
            this.lbl_Score.TabIndex = 2;
            this.lbl_Score.Text = "00";
            // 
            // Apple
            // 
            this.Apple.BackColor = System.Drawing.Color.Transparent;
            this.Apple.BackgroundImage = global::Snake_2.Properties.Resources.apple;
            this.Apple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Apple.Location = new System.Drawing.Point(150, 120);
            this.Apple.Name = "Apple";
            this.Apple.Size = new System.Drawing.Size(30, 30);
            this.Apple.TabIndex = 1;
            this.Apple.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(886, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "S";
            // 
            // By_Wall
            // 
            this.By_Wall.AutoSize = true;
            this.By_Wall.BackColor = System.Drawing.Color.Transparent;
            this.By_Wall.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.By_Wall.ForeColor = System.Drawing.Color.White;
            this.By_Wall.Location = new System.Drawing.Point(753, 344);
            this.By_Wall.Name = "By_Wall";
            this.By_Wall.Size = new System.Drawing.Size(109, 33);
            this.By_Wall.TabIndex = 0;
            this.By_Wall.TabStop = true;
            this.By_Wall.Text = "By Wall";
            this.By_Wall.UseVisualStyleBackColor = false;
            // 
            // By_Edge
            // 
            this.By_Edge.AutoSize = true;
            this.By_Edge.BackColor = System.Drawing.Color.Transparent;
            this.By_Edge.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.By_Edge.ForeColor = System.Drawing.Color.White;
            this.By_Edge.Location = new System.Drawing.Point(753, 305);
            this.By_Edge.Name = "By_Edge";
            this.By_Edge.Size = new System.Drawing.Size(113, 33);
            this.By_Edge.TabIndex = 0;
            this.By_Edge.Text = "By Edge";
            this.By_Edge.UseVisualStyleBackColor = false;
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Menu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Menu.ForeColor = System.Drawing.Color.White;
            this.btn_Menu.Location = new System.Drawing.Point(766, 428);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(126, 40);
            this.btn_Menu.TabIndex = 0;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.Btn_Menu_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Start.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Start.ForeColor = System.Drawing.Color.White;
            this.btn_Start.Location = new System.Drawing.Point(766, 382);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(126, 40);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake_2.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(920, 480);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.By_Edge);
            this.Controls.Add(this.By_Wall);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.body2);
            this.Controls.Add(this.body1);
            this.Controls.Add(this.Apple);
            this.Controls.Add(this.head);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Game_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.body1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.body2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apple)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox head;
        private System.Windows.Forms.PictureBox body1;
        private System.Windows.Forms.PictureBox body2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.PictureBox Apple;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton By_Wall;
        private System.Windows.Forms.RadioButton By_Edge;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Start;
    }
}

