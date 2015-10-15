using System.Drawing;

namespace Battleship
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PatrolBoat = new System.Windows.Forms.PictureBox();
            this.Destroyer = new System.Windows.Forms.PictureBox();
            this.Battleship = new System.Windows.Forms.PictureBox();
            this.AircraftCarrier = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatrolBoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Destroyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Battleship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AircraftCarrier)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 550);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // PatrolBoat
            // 
            this.PatrolBoat.Image = ((System.Drawing.Image)(resources.GetObject("PatrolBoat.Image")));
            this.PatrolBoat.Location = new System.Drawing.Point(12, 647);
            this.PatrolBoat.Name = "PatrolBoat";
            this.PatrolBoat.Size = new System.Drawing.Size(100, 50);
            this.PatrolBoat.TabIndex = 2;
            this.PatrolBoat.TabStop = false;
            this.PatrolBoat.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Destroyer
            // 
            this.Destroyer.Image = ((System.Drawing.Image)(resources.GetObject("Destroyer.Image")));
            this.Destroyer.Location = new System.Drawing.Point(278, 647);
            this.Destroyer.Name = "Destroyer";
            this.Destroyer.Size = new System.Drawing.Size(151, 50);
            this.Destroyer.TabIndex = 3;
            this.Destroyer.TabStop = false;
            // 
            // Battleship
            // 
            this.Battleship.Image = ((System.Drawing.Image)(resources.GetObject("Battleship.Image")));
            this.Battleship.Location = new System.Drawing.Point(12, 723);
            this.Battleship.Name = "Battleship";
            this.Battleship.Size = new System.Drawing.Size(200, 50);
            this.Battleship.TabIndex = 4;
            this.Battleship.TabStop = false;
            this.Battleship.Click += new System.EventHandler(this.Battleship_Click);
            // 
            // AircraftCarrier
            // 
            this.AircraftCarrier.Image = ((System.Drawing.Image)(resources.GetObject("AircraftCarrier.Image")));
            this.AircraftCarrier.Location = new System.Drawing.Point(278, 723);
            this.AircraftCarrier.Name = "AircraftCarrier";
            this.AircraftCarrier.Size = new System.Drawing.Size(252, 50);
            this.AircraftCarrier.TabIndex = 5;
            this.AircraftCarrier.TabStop = false;
            // 
            // GameForm
            // 
            this.ClientSize = new System.Drawing.Size(782, 809);
            this.Controls.Add(this.AircraftCarrier);
            this.Controls.Add(this.Battleship);
            this.Controls.Add(this.Destroyer);
            this.Controls.Add(this.PatrolBoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.Text = "Battleship";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatrolBoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Destroyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Battleship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AircraftCarrier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PatrolBoat;
        private System.Windows.Forms.PictureBox Destroyer;
        private System.Windows.Forms.PictureBox Battleship;
        private System.Windows.Forms.PictureBox AircraftCarrier;
    }
}

