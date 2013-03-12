using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var items = new List<KeyValuePair<string, string>>();
            foreach (var item in this.comboBox1.Items)
            {
                items.Add(new KeyValuePair<string, string>(item.ToString(), item.ToString()));
            }
            this.comboBox1.Items.Clear();

            foreach (var item in items.OrderBy(i => i.Value))
                this.comboBox1.Items.Add(item.Value);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PickPony();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.PickPony();
        }

        private void PickPony()
        {
            switch (this.comboBox1.SelectedItem.ToString())
            {
                case "Twilight Sparkle":
                    this.saying.Text = "B O O K S";
                    this.pictureBox1.ImageLocation = @"..\..\assets\twilight.png";
                    this.BackColor = Color.Purple;
                    break;
                case "Diamond Tiara":
                    this.saying.Text = "You don't have a cutie mark";
                    this.pictureBox1.ImageLocation = @"..\..\assets\diamond.jpg";
                    this.BackColor = Color.Purple;
                    break;

                case "Scootaloo":
                    this.saying.Text = "AWSOMENESS";
                    this.pictureBox1.ImageLocation = @"..\..\assets\scootaloo.png";
                    this.BackColor = Color.DarkOrange;
                    break;
                case "Sweety Bell":
                    this.saying.Text = "PRETTY";
                    this.pictureBox1.ImageLocation = @"..\..\assets\sweety.png";
                    this.BackColor = Color.LightPink;
                    break;
                case "Apple Bloom":
                    this.saying.Text = "YEEHAW";
                    this.pictureBox1.ImageLocation = @"..\..\assets\apple.gif";
                    this.BackColor = Color.Goldenrod;
                    break;

                case "Baba Seed":
                    this.saying.Text = "That's not how you talk to my friends.";
                    this.pictureBox1.ImageLocation = @"..\..\assets\baba.jpg";
                    this.BackColor = Color.Black;
                    break;
                case "Rarity":
                    this.saying.Text = "STYLE";
                    this.pictureBox1.ImageLocation = @"..\..\assets\rarity.png";
                    this.BackColor = Color.Gray;
                    break;
                case "Pinkie Pie":
                    this.saying.Text = "Party Time!";
                    this.pictureBox1.ImageLocation = @"..\..\assets\pinkie.png";
                    this.BackColor = Color.HotPink;
                    break;
                case "Rainbow Dash":
                    this.saying.Text = "Radicalness!";
                    this.pictureBox1.ImageLocation = @"..\..\assets\dash.png";
                    this.BackColor = Color.DarkRed;
                    break;
            }
            SystemSounds.Asterisk.Play();
        }
    }
}
