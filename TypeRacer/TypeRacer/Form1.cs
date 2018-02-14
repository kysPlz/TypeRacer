﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TypeRacer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(415, 340);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #region Globale variabler
        string filNavn = "paragraf.txt";
        Random rnd = new Random();
        string[] paragraf = new string[5];
        #endregion

        #region Programoppstart
        private void Form1_Load(object sender, EventArgs e)
        {
            panelMeny.Location = new Point(0, 0);
            panelSpill.Location = new Point(0, 0);
            panelSpill.Visible = false;
            panelInnstillinger.Location = new Point(0, 0);
            panelInnstillinger.Visible = false;
            panelStatistikk.Location = new Point(0, 0);
            panelStatistikk.Visible = false;
            hentParagrafer();
        }
        #endregion

        #region panelMeny
        private void menyStart_Click(object sender, EventArgs e)
        {
            spillStart();
        }

        private void menyStatistikk_Click(object sender, EventArgs e)
        {
            panelStatistikk.Visible = true;
            panelMeny.Visible = false;
        }

        private void menyInnstillinger_Click(object sender, EventArgs e)
        {
            panelInnstillinger.Visible = true;
            panelMeny.Visible = false;
        }

        private void menyAvslutt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region panelSpill
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        #endregion

        private void spillStart()
        {
            panelSpill.Visible = true;
            panelMeny.Visible = false;

        }


        private void hentParagrafer()
        {
            string lestLinje = "";
            int i = 0;

            FileInfo fi = new FileInfo(filNavn);
            try
            {
                using (StreamReader sr = File.OpenText(filNavn))
                {
                    while ((lestLinje = sr.ReadLine()) != null)
                    {
                        paragraf[i] = lestLinje;
                        i++;
                    }
                }
            }
            catch { }

            spillParagraf.Text = paragraf[2];
        }
        //panelStatistikk og panelInnstillinger har ingen "Events" som er nødvendige (hittil).
    }
}
