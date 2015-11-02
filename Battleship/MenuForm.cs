using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class MenuForm : Form
    {
        saveUser s = save;
        public MenuForm()
        {
            InitializeComponent();
            labelWaiting.Hide();
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("last_user.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    textBox_Name.Text = line;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: or no old user");
                Console.WriteLine(e.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button_FindGame_Click(object sender, EventArgs e)
        {
            Form y = new FindGame(textBox_Name.Text,this);
            y.Show();
            s(textBox_Name.Text);
            this.Hide();
        }

        private void button_NewGame_Click(object sender, EventArgs e)
        {
            labelWaiting.Show();
            Form z = new NewGame(true,textBox_Name.Text,this);
            z.Show();
            s(textBox_Name.Text);
            this.Hide();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private delegate void saveUser(string name);

        private static void save(string name)
        {
            string[] temp = { name};
            System.IO.File.WriteAllLines("last_user.txt", temp);

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
