﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeRacer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Globale variabler
        int dette = 0;
        string denHer = "hei";
        int osv = 5;
        #endregion

        #region Programoppstart
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region panelMeny
        private void menyStart_Click(object sender, EventArgs e)
        {

        }

        private void menyStatistikk_Click(object sender, EventArgs e)
        {

        }

        private void menyInnstillinger_Click(object sender, EventArgs e)
        {

        }

        private void menyAvslutt_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region panelSpill
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        #endregion

        //panelStatistikk og panelInnstillinger har ingen "Events" som er nødvendige (hittil).
    }
}