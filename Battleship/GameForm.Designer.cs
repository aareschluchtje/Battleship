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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Submarine = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.ReadyButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatrolBoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Destroyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Battleship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AircraftCarrier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Submarine)).BeginInit();
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
            this.Destroyer.Click += new System.EventHandler(this.Destroyer_Click);
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
            this.AircraftCarrier.Click += new System.EventHandler(this.AircraftCarrier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 624);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Patrol Boat";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 624);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Destroyer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 700);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Battleship";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 700);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Aircraft Carrier";
            // 
            // Submarine
            // 
            this.Submarine.Image = ((System.Drawing.Image)(resources.GetObject("Submarine.Image")));
            this.Submarine.Location = new System.Drawing.Point(543, 647);
            this.Submarine.Name = "Submarine";
            this.Submarine.Size = new System.Drawing.Size(151, 50);
            this.Submarine.TabIndex = 3;
            this.Submarine.TabStop = false;
            this.Submarine.Click += new System.EventHandler(this.Submarine_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 624);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Submarine";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(615, 33);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(79, 17);
            this.PositionLabel.TabIndex = 7;
            this.PositionLabel.Text = "x = 0, Y = 0";
            // 
            // ReadyButton
            // 
            this.ReadyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadyButton.Location = new System.Drawing.Point(618, 139);
            this.ReadyButton.Name = "ReadyButton";
            this.ReadyButton.Size = new System.Drawing.Size(97, 34);
            this.ReadyButton.TabIndex = 9;
            this.ReadyButton.Text = "Ready";
            this.ReadyButton.UseVisualStyleBackColor = true;
            this.ReadyButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(627, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 41);
            this.label7.TabIndex = 10;
            this.label7.Text = "You";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            this.ClientSize = new System.Drawing.Size(782, 809);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ReadyButton);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AircraftCarrier);
            this.Controls.Add(this.Battleship);
            this.Controls.Add(this.Submarine);
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
            ((System.ComponentModel.ISupportInitialize)(this.Submarine)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Submarine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Button ReadyButton;
        private System.Windows.Forms.Label label7;
    }
}

