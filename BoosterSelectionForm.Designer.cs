using PokemonTCG;
using System.Windows.Forms;

namespace PokemonBooster
{
    partial class BoosterSelectionForm
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
        private void InitializeComponent()
        {
            this.SuspendLayout();

            Button btnBooster1 = new Button();
            btnBooster1.Location = new System.Drawing.Point(50, 50);
            btnBooster1.Size = new System.Drawing.Size(200, 50);
            btnBooster1.Text = "Booster Feu";
            btnBooster1.Click += (sender, e) => OpenMainForm("Feu");

            Button btnBooster2 = new Button();
            btnBooster2.Location = new System.Drawing.Point(50, 120);
            btnBooster2.Size = new System.Drawing.Size(200, 50);
            btnBooster2.Text = "Booster Eau";
            btnBooster2.Click += (sender, e) => OpenMainForm("Eau");

            Button btnBooster3 = new Button();
            btnBooster3.Location = new System.Drawing.Point(50, 190);
            btnBooster3.Size = new System.Drawing.Size(200, 50);
            btnBooster3.Text = "Booster Électrique";
            btnBooster3.Click += (sender, e) => OpenMainForm("Électrique");

            this.Controls.Add(btnBooster1);
            this.Controls.Add(btnBooster2);
            this.Controls.Add(btnBooster3);

            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Choisissez un Booster";
            this.ResumeLayout(false);
        }

        private void OpenMainForm(string boosterType)
        {
            MainForm mainForm = new MainForm(boosterType);
            this.Hide(); 
            mainForm.ShowDialog(); 
            this.Show();
        }
    }

    
}