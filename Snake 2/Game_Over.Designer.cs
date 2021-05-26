namespace Snake_2
{
    partial class Game_Over
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Snake_2.Properties.Resources.Snake_Img;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(240, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Over";
            // 
            // Restart
            // 
            this.Restart.AutoSize = true;
            this.Restart.BackColor = System.Drawing.Color.Transparent;
            this.Restart.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.ForeColor = System.Drawing.Color.White;
            this.Restart.Location = new System.Drawing.Point(56, 122);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(125, 42);
            this.Restart.TabIndex = 1;
            this.Restart.Text = "Restart";
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.BackColor = System.Drawing.Color.Transparent;
            this.Menu.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.Color.White;
            this.Menu.Location = new System.Drawing.Point(71, 177);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(92, 42);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menu";
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Game_Over
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake_2.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(480, 240);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game_Over";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game_Over";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Restart;
        private System.Windows.Forms.Label Menu;
    }
}