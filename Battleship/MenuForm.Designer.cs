namespace Battleship
{
    partial class MenuForm
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
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Nickname = new System.Windows.Forms.Label();
            this.button_NewGame = new System.Windows.Forms.Button();
            this.button_FindGame = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.labelWaiting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(16, 15);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(281, 22);
            this.textBox_Name.TabIndex = 0;
            // 
            // label_Nickname
            // 
            this.label_Nickname.AutoSize = true;
            this.label_Nickname.Location = new System.Drawing.Point(307, 23);
            this.label_Nickname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Nickname.Name = "label_Nickname";
            this.label_Nickname.Size = new System.Drawing.Size(70, 17);
            this.label_Nickname.TabIndex = 1;
            this.label_Nickname.Text = "Nickname";
            this.label_Nickname.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_NewGame
            // 
            this.button_NewGame.Location = new System.Drawing.Point(16, 47);
            this.button_NewGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_NewGame.Name = "button_NewGame";
            this.button_NewGame.Size = new System.Drawing.Size(364, 65);
            this.button_NewGame.TabIndex = 2;
            this.button_NewGame.Text = "Start Game";
            this.button_NewGame.UseVisualStyleBackColor = true;
            this.button_NewGame.Click += new System.EventHandler(this.button_NewGame_Click);
            // 
            // button_FindGame
            // 
            this.button_FindGame.Location = new System.Drawing.Point(16, 119);
            this.button_FindGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_FindGame.Name = "button_FindGame";
            this.button_FindGame.Size = new System.Drawing.Size(364, 65);
            this.button_FindGame.TabIndex = 4;
            this.button_FindGame.Text = "Find Game";
            this.button_FindGame.UseVisualStyleBackColor = true;
            this.button_FindGame.Click += new System.EventHandler(this.button_FindGame_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(16, 192);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(364, 65);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // labelWaiting
            // 
            this.labelWaiting.AutoSize = true;
            this.labelWaiting.Location = new System.Drawing.Point(111, 261);
            this.labelWaiting.Name = "labelWaiting";
            this.labelWaiting.Size = new System.Drawing.Size(180, 17);
            this.labelWaiting.TabIndex = 6;
            this.labelWaiting.Text = "Waiting for players to join...";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 282);
            this.Controls.Add(this.labelWaiting);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_FindGame);
            this.Controls.Add(this.button_NewGame);
            this.Controls.Add(this.label_Nickname);
            this.Controls.Add(this.textBox_Name);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Nickname;
        private System.Windows.Forms.Button button_NewGame;
        private System.Windows.Forms.Button button_FindGame;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label labelWaiting;
    }
}