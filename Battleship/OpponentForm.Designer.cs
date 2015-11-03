using System.Drawing;

namespace Battleship
{
    partial class OpponentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpponentForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Fire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelVictory = new System.Windows.Forms.Label();
            this.labelDefeat = new System.Windows.Forms.Label();
            this.labelWaitingForEnemy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 550);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Fire
            // 
            this.Fire.Enabled = false;
            this.Fire.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fire.ForeColor = System.Drawing.Color.Red;
            this.Fire.Location = new System.Drawing.Point(565, 123);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(234, 145);
            this.Fire.TabIndex = 2;
            this.Fire.Text = "FIRE";
            this.Fire.UseVisualStyleBackColor = true;
            this.Fire.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Battleship";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(626, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enemy";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelVictory
            // 
            this.labelVictory.AutoSize = true;
            this.labelVictory.BackColor = System.Drawing.Color.Transparent;
            this.labelVictory.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVictory.Location = new System.Drawing.Point(63, 240);
            this.labelVictory.Name = "labelVictory";
            this.labelVictory.Size = new System.Drawing.Size(445, 145);
            this.labelVictory.TabIndex = 3;
            this.labelVictory.Text = "Victory!";
            // 
            // labelDefeat
            // 
            this.labelDefeat.AutoSize = true;
            this.labelDefeat.BackColor = System.Drawing.Color.Transparent;
            this.labelDefeat.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefeat.ForeColor = System.Drawing.Color.Red;
            this.labelDefeat.Location = new System.Drawing.Point(77, 240);
            this.labelDefeat.Name = "labelDefeat";
            this.labelDefeat.Size = new System.Drawing.Size(414, 145);
            this.labelDefeat.TabIndex = 3;
            this.labelDefeat.Text = "Defeat!";
            // 
            // labelWaitingForEnemy
            // 
            this.labelWaitingForEnemy.AutoSize = true;
            this.labelWaitingForEnemy.Location = new System.Drawing.Point(597, 271);
            this.labelWaitingForEnemy.Name = "labelWaitingForEnemy";
            this.labelWaitingForEnemy.Size = new System.Drawing.Size(162, 17);
            this.labelWaitingForEnemy.TabIndex = 5;
            this.labelWaitingForEnemy.Text = "Waiting for enemy to fire";
            // 
            // OpponentForm
            // 
            this.ClientSize = new System.Drawing.Size(811, 622);
            this.Controls.Add(this.labelWaitingForEnemy);
            this.Controls.Add(this.labelDefeat);
            this.Controls.Add(this.labelVictory);
            this.Controls.Add(this.Fire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OpponentForm";
            this.Text = "Battleship";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Fire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelVictory;
        private System.Windows.Forms.Label labelDefeat;
        private System.Windows.Forms.Label labelWaitingForEnemy;
    }
}