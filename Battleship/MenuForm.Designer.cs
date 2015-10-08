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
            this.button_LoadGame = new System.Windows.Forms.Button();
            this.button_FindGame = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(12, 15);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(212, 20);
            this.textBox_Name.TabIndex = 0;
            // 
            // label_Nickname
            // 
            this.label_Nickname.AutoSize = true;
            this.label_Nickname.Location = new System.Drawing.Point(230, 18);
            this.label_Nickname.Name = "label_Nickname";
            this.label_Nickname.Size = new System.Drawing.Size(55, 13);
            this.label_Nickname.TabIndex = 1;
            this.label_Nickname.Text = "Nickname";
            this.label_Nickname.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_NewGame
            // 
            this.button_NewGame.Location = new System.Drawing.Point(12, 59);
            this.button_NewGame.Name = "button_NewGame";
            this.button_NewGame.Size = new System.Drawing.Size(273, 53);
            this.button_NewGame.TabIndex = 2;
            this.button_NewGame.Text = "New Game";
            this.button_NewGame.UseVisualStyleBackColor = true;
            // 
            // button_LoadGame
            // 
            this.button_LoadGame.Location = new System.Drawing.Point(12, 129);
            this.button_LoadGame.Name = "button_LoadGame";
            this.button_LoadGame.Size = new System.Drawing.Size(273, 53);
            this.button_LoadGame.TabIndex = 3;
            this.button_LoadGame.Text = "Load Game";
            this.button_LoadGame.UseVisualStyleBackColor = true;
            this.button_LoadGame.Click += new System.EventHandler(this.button_LoadGame_Click);
            // 
            // button_FindGame
            // 
            this.button_FindGame.Location = new System.Drawing.Point(12, 207);
            this.button_FindGame.Name = "button_FindGame";
            this.button_FindGame.Size = new System.Drawing.Size(273, 53);
            this.button_FindGame.TabIndex = 4;
            this.button_FindGame.Text = "Find Game";
            this.button_FindGame.UseVisualStyleBackColor = true;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(12, 278);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(273, 53);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 353);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_FindGame);
            this.Controls.Add(this.button_LoadGame);
            this.Controls.Add(this.button_NewGame);
            this.Controls.Add(this.label_Nickname);
            this.Controls.Add(this.textBox_Name);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Nickname;
        private System.Windows.Forms.Button button_NewGame;
        private System.Windows.Forms.Button button_LoadGame;
        private System.Windows.Forms.Button button_FindGame;
        private System.Windows.Forms.Button button_Exit;
    }
}