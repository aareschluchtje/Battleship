﻿namespace Battleship
{
    partial class NewGame
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
            this.label_PlayerOne = new System.Windows.Forms.Label();
            this.label_Player2 = new System.Windows.Forms.Label();
            this.label_IP = new System.Windows.Forms.Label();
            this.label_Port = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_LoadGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_PlayerOne
            // 
            this.label_PlayerOne.AutoSize = true;
            this.label_PlayerOne.Location = new System.Drawing.Point(15, 17);
            this.label_PlayerOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_PlayerOne.Name = "label_PlayerOne";
            this.label_PlayerOne.Size = new System.Drawing.Size(64, 17);
            this.label_PlayerOne.TabIndex = 0;
            this.label_PlayerOne.Text = "Player1: ";
            this.label_PlayerOne.Click += new System.EventHandler(this.label_PlayerOne_Click);
            // 
            // label_Player2
            // 
            this.label_Player2.AutoSize = true;
            this.label_Player2.Location = new System.Drawing.Point(15, 48);
            this.label_Player2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Player2.Name = "label_Player2";
            this.label_Player2.Size = new System.Drawing.Size(64, 17);
            this.label_Player2.TabIndex = 1;
            this.label_Player2.Text = "Player2: ";
            this.label_Player2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Location = new System.Drawing.Point(15, 91);
            this.label_IP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(24, 17);
            this.label_IP.TabIndex = 2;
            this.label_IP.Text = "IP:";
            this.label_IP.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Location = new System.Drawing.Point(15, 118);
            this.label_Port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(38, 17);
            this.label_Port.TabIndex = 3;
            this.label_Port.Text = "Port:";
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(9, 149);
            this.button_Start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(193, 34);
            this.button_Start.TabIndex = 4;
            this.button_Start.Text = "Start Game";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(229, 149);
            this.button_Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(211, 34);
            this.button_Back.TabIndex = 5;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_LoadGame
            // 
            this.button_LoadGame.Location = new System.Drawing.Point(333, 15);
            this.button_LoadGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_LoadGame.Name = "button_LoadGame";
            this.button_LoadGame.Size = new System.Drawing.Size(107, 42);
            this.button_LoadGame.TabIndex = 6;
            this.button_LoadGame.Text = "Ready";
            this.button_LoadGame.UseVisualStyleBackColor = true;
            this.button_LoadGame.Click += new System.EventHandler(this.button_LoadGame_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 196);
            this.Controls.Add(this.button_LoadGame);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label_Port);
            this.Controls.Add(this.label_IP);
            this.Controls.Add(this.label_Player2);
            this.Controls.Add(this.label_PlayerOne);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewGame";
            this.Text = "New Game";
            this.Load += new System.EventHandler(this.NewGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_PlayerOne;
        private System.Windows.Forms.Label label_Player2;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_LoadGame;
    }
}