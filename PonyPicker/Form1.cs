﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using WMPLib;

namespace ThePonyPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            LoadPonies();

            var player = new WindowsMediaPlayer();
            player.URL = @"C:\Solutions\Dustin\ponypicker\PonyPicker\assets\equestria girls.mp3";
            player.controls.play();
        }

        private void LoadPonies()
        {
            this.comboBox1.Items.Clear();
            foreach (var pony in PonyManager.GetAll())
            {
                this.comboBox1.Items.Add(pony.Name);
            }

            var items = new List<KeyValuePair<string, string>>();
            foreach (var item in this.comboBox1.Items)
            {
                items.Add(new KeyValuePair<string, string>(item.ToString(), item.ToString()));
            }
            this.comboBox1.Items.Clear();

            foreach (var item in items.OrderBy(i => i.Value))
                this.comboBox1.Items.Add(item.Value);

            this.comboBox1.Focus();
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
            if (this.comboBox1.SelectedItem == null)
                return;

            var pony = PonyManager.GetByName(this.comboBox1.SelectedItem.ToString());
            if (pony == null)
                return;

            this.saying.Text = pony.Name + " says\r" + pony.Saying;
            this.BackColor = pony.BackgroundColor;
            this.pictureBox1.ImageLocation = pony.Picture;

            var img = Image.FromFile(pony.Picture);
            
            this.pictureBox1.Size = new Size(img.Width, img.Height);
            this.Size = new Size(200 + img.Width, 200 + img.Height);
            

            SystemSounds.Asterisk.Play();
            //LoadPonies();

            if (this.BackColor == Color.Black)
                this.label1.ForeColor = Color.White;
            else
                this.label1.ForeColor = Color.Black;
            this.saying.ForeColor = this.label1.ForeColor;
        }
    }
}
