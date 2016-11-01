namespace Zavin.Eastereggs.Pong
{
    partial class Form1
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
            this.WorldFrame = new System.Windows.Forms.Panel();
            this.pb_Ball = new System.Windows.Forms.PictureBox();
            this.timer_Moveball = new System.Windows.Forms.Timer(this.components);
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.pb_Enemy = new System.Windows.Forms.PictureBox();
            this.WorldFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // WorldFrame
            // 
            this.WorldFrame.Controls.Add(this.pb_Enemy);
            this.WorldFrame.Controls.Add(this.pb_Player);
            this.WorldFrame.Controls.Add(this.pb_Ball);
            this.WorldFrame.Location = new System.Drawing.Point(12, 12);
            this.WorldFrame.Name = "WorldFrame";
            this.WorldFrame.Size = new System.Drawing.Size(366, 197);
            this.WorldFrame.TabIndex = 0;
            this.WorldFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pb_Ball
            // 
            this.pb_Ball.Location = new System.Drawing.Point(156, 25);
            this.pb_Ball.Name = "pb_Ball";
            this.pb_Ball.Size = new System.Drawing.Size(57, 50);
            this.pb_Ball.TabIndex = 0;
            this.pb_Ball.TabStop = false;
            // 
            // timer_Moveball
            // 
            this.timer_Moveball.Interval = 1;
            // 
            // pb_Player
            // 
            this.pb_Player.Location = new System.Drawing.Point(19, 60);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(39, 50);
            this.pb_Player.TabIndex = 1;
            this.pb_Player.TabStop = false;
            // 
            // pb_Enemy
            // 
            this.pb_Enemy.Location = new System.Drawing.Point(313, 60);
            this.pb_Enemy.Name = "pb_Enemy";
            this.pb_Enemy.Size = new System.Drawing.Size(39, 50);
            this.pb_Enemy.TabIndex = 2;
            this.pb_Enemy.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 261);
            this.Controls.Add(this.WorldFrame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WorldFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Enemy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WorldFrame;
        private System.Windows.Forms.PictureBox pb_Ball;
        private System.Windows.Forms.PictureBox pb_Player;
        private System.Windows.Forms.PictureBox pb_Enemy;
        private System.Windows.Forms.Timer timer_Moveball;
    }
}

