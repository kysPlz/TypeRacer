namespace TypeRacer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panelSpill = new System.Windows.Forms.Panel();
            this.spillOrdteller = new System.Windows.Forms.Label();
            this.spillTid = new System.Windows.Forms.Label();
            this.spillInfo = new System.Windows.Forms.Label();
            this.spillParagraf = new System.Windows.Forms.RichTextBox();
            this.spillSkrivHer = new System.Windows.Forms.TextBox();
            this.panelStatistikk = new System.Windows.Forms.Panel();
            this.statistikkGjennomsnitt = new System.Windows.Forms.Label();
            this.statistikkFlestOrd = new System.Windows.Forms.Label();
            this.statistikkAntallOrd = new System.Windows.Forms.Label();
            this.statistikkTekst3 = new System.Windows.Forms.Label();
            this.statistikkTekst2 = new System.Windows.Forms.Label();
            this.statistikkTekst1 = new System.Windows.Forms.Label();
            this.statistikkInfo = new System.Windows.Forms.Label();
            this.panelMeny = new System.Windows.Forms.Panel();
            this.menyAvslutt = new System.Windows.Forms.Button();
            this.menyInnstillinger = new System.Windows.Forms.Button();
            this.menyStatistikk = new System.Windows.Forms.Button();
            this.menyStart = new System.Windows.Forms.Button();
            this.panelInnstillinger = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.innstillingerInfo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.spillTidMin = new System.Windows.Forms.Label();
            this.spillTidSek = new System.Windows.Forms.Label();
            this.panelSpill.SuspendLayout();
            this.panelStatistikk.SuspendLayout();
            this.panelMeny.SuspendLayout();
            this.panelInnstillinger.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSpill
            // 
            this.panelSpill.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelSpill.Controls.Add(this.spillTidSek);
            this.panelSpill.Controls.Add(this.spillTidMin);
            this.panelSpill.Controls.Add(this.spillOrdteller);
            this.panelSpill.Controls.Add(this.spillTid);
            this.panelSpill.Controls.Add(this.spillInfo);
            this.panelSpill.Controls.Add(this.spillParagraf);
            this.panelSpill.Controls.Add(this.spillSkrivHer);
            this.panelSpill.Location = new System.Drawing.Point(418, 12);
            this.panelSpill.Name = "panelSpill";
            this.panelSpill.Size = new System.Drawing.Size(400, 300);
            this.panelSpill.TabIndex = 0;
            // 
            // spillOrdteller
            // 
            this.spillOrdteller.AutoSize = true;
            this.spillOrdteller.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.spillOrdteller.ForeColor = System.Drawing.SystemColors.ControlText;
            this.spillOrdteller.Location = new System.Drawing.Point(307, 264);
            this.spillOrdteller.Name = "spillOrdteller";
            this.spillOrdteller.Size = new System.Drawing.Size(57, 26);
            this.spillOrdteller.TabIndex = 4;
            this.spillOrdteller.Text = "W/M";
            // 
            // spillTid
            // 
            this.spillTid.AutoSize = true;
            this.spillTid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.spillTid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.spillTid.Location = new System.Drawing.Point(255, 21);
            this.spillTid.Name = "spillTid";
            this.spillTid.Size = new System.Drawing.Size(52, 26);
            this.spillTid.TabIndex = 3;
            this.spillTid.Text = "TID:";
            // 
            // spillInfo
            // 
            this.spillInfo.AutoSize = true;
            this.spillInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.spillInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.spillInfo.Location = new System.Drawing.Point(15, 21);
            this.spillInfo.Name = "spillInfo";
            this.spillInfo.Size = new System.Drawing.Size(99, 26);
            this.spillInfo.TabIndex = 2;
            this.spillInfo.Text = "SPILLET";
            // 
            // spillParagraf
            // 
            this.spillParagraf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spillParagraf.Location = new System.Drawing.Point(20, 61);
            this.spillParagraf.Name = "spillParagraf";
            this.spillParagraf.Size = new System.Drawing.Size(357, 183);
            this.spillParagraf.TabIndex = 1;
            this.spillParagraf.Text = "richTextBox1";
            // 
            // spillSkrivHer
            // 
            this.spillSkrivHer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.spillSkrivHer.Location = new System.Drawing.Point(20, 258);
            this.spillSkrivHer.Name = "spillSkrivHer";
            this.spillSkrivHer.Size = new System.Drawing.Size(213, 32);
            this.spillSkrivHer.TabIndex = 0;
            this.spillSkrivHer.Text = "textBox1";
            this.spillSkrivHer.TextChanged += new System.EventHandler(this.tekstEndret);
            // 
            // panelStatistikk
            // 
            this.panelStatistikk.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelStatistikk.Controls.Add(this.statistikkGjennomsnitt);
            this.panelStatistikk.Controls.Add(this.statistikkFlestOrd);
            this.panelStatistikk.Controls.Add(this.statistikkAntallOrd);
            this.panelStatistikk.Controls.Add(this.statistikkTekst3);
            this.panelStatistikk.Controls.Add(this.statistikkTekst2);
            this.panelStatistikk.Controls.Add(this.statistikkTekst1);
            this.panelStatistikk.Controls.Add(this.statistikkInfo);
            this.panelStatistikk.Location = new System.Drawing.Point(12, 318);
            this.panelStatistikk.Name = "panelStatistikk";
            this.panelStatistikk.Size = new System.Drawing.Size(400, 300);
            this.panelStatistikk.TabIndex = 3;
            // 
            // statistikkGjennomsnitt
            // 
            this.statistikkGjennomsnitt.AutoSize = true;
            this.statistikkGjennomsnitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.statistikkGjennomsnitt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statistikkGjennomsnitt.Location = new System.Drawing.Point(292, 213);
            this.statistikkGjennomsnitt.Name = "statistikkGjennomsnitt";
            this.statistikkGjennomsnitt.Size = new System.Drawing.Size(82, 26);
            this.statistikkGjennomsnitt.TabIndex = 11;
            this.statistikkGjennomsnitt.Text = "label10";
            // 
            // statistikkFlestOrd
            // 
            this.statistikkFlestOrd.AutoSize = true;
            this.statistikkFlestOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.statistikkFlestOrd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statistikkFlestOrd.Location = new System.Drawing.Point(304, 158);
            this.statistikkFlestOrd.Name = "statistikkFlestOrd";
            this.statistikkFlestOrd.Size = new System.Drawing.Size(70, 26);
            this.statistikkFlestOrd.TabIndex = 10;
            this.statistikkFlestOrd.Text = "label9";
            // 
            // statistikkAntallOrd
            // 
            this.statistikkAntallOrd.AutoSize = true;
            this.statistikkAntallOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.statistikkAntallOrd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statistikkAntallOrd.Location = new System.Drawing.Point(304, 105);
            this.statistikkAntallOrd.Name = "statistikkAntallOrd";
            this.statistikkAntallOrd.Size = new System.Drawing.Size(70, 26);
            this.statistikkAntallOrd.TabIndex = 9;
            this.statistikkAntallOrd.Text = "label8";
            // 
            // statistikkTekst3
            // 
            this.statistikkTekst3.AutoSize = true;
            this.statistikkTekst3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.statistikkTekst3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statistikkTekst3.Location = new System.Drawing.Point(16, 213);
            this.statistikkTekst3.Name = "statistikkTekst3";
            this.statistikkTekst3.Size = new System.Drawing.Size(188, 26);
            this.statistikkTekst3.TabIndex = 8;
            this.statistikkTekst3.Text = "Average word/min";
            // 
            // statistikkTekst2
            // 
            this.statistikkTekst2.AutoSize = true;
            this.statistikkTekst2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.statistikkTekst2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statistikkTekst2.Location = new System.Drawing.Point(16, 158);
            this.statistikkTekst2.Name = "statistikkTekst2";
            this.statistikkTekst2.Size = new System.Drawing.Size(210, 26);
            this.statistikkTekst2.TabIndex = 7;
            this.statistikkTekst2.Text = "Best score word/min";
            // 
            // statistikkTekst1
            // 
            this.statistikkTekst1.AutoSize = true;
            this.statistikkTekst1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.statistikkTekst1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statistikkTekst1.Location = new System.Drawing.Point(16, 105);
            this.statistikkTekst1.Name = "statistikkTekst1";
            this.statistikkTekst1.Size = new System.Drawing.Size(206, 26);
            this.statistikkTekst1.TabIndex = 6;
            this.statistikkTekst1.Text = "Total words counted";
            // 
            // statistikkInfo
            // 
            this.statistikkInfo.AutoSize = true;
            this.statistikkInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.statistikkInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statistikkInfo.Location = new System.Drawing.Point(16, 30);
            this.statistikkInfo.Name = "statistikkInfo";
            this.statistikkInfo.Size = new System.Drawing.Size(81, 26);
            this.statistikkInfo.TabIndex = 5;
            this.statistikkInfo.Text = "STATS";
            // 
            // panelMeny
            // 
            this.panelMeny.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelMeny.Controls.Add(this.menyAvslutt);
            this.panelMeny.Controls.Add(this.menyInnstillinger);
            this.panelMeny.Controls.Add(this.menyStatistikk);
            this.panelMeny.Controls.Add(this.menyStart);
            this.panelMeny.Location = new System.Drawing.Point(12, 12);
            this.panelMeny.Name = "panelMeny";
            this.panelMeny.Size = new System.Drawing.Size(400, 300);
            this.panelMeny.TabIndex = 4;
            // 
            // menyAvslutt
            // 
            this.menyAvslutt.Location = new System.Drawing.Point(136, 223);
            this.menyAvslutt.Name = "menyAvslutt";
            this.menyAvslutt.Size = new System.Drawing.Size(130, 44);
            this.menyAvslutt.TabIndex = 3;
            this.menyAvslutt.Text = "Quit";
            this.menyAvslutt.UseVisualStyleBackColor = true;
            this.menyAvslutt.Click += new System.EventHandler(this.menyAvslutt_Click);
            // 
            // menyInnstillinger
            // 
            this.menyInnstillinger.Location = new System.Drawing.Point(136, 157);
            this.menyInnstillinger.Name = "menyInnstillinger";
            this.menyInnstillinger.Size = new System.Drawing.Size(130, 44);
            this.menyInnstillinger.TabIndex = 2;
            this.menyInnstillinger.Text = "Settings";
            this.menyInnstillinger.UseVisualStyleBackColor = true;
            this.menyInnstillinger.Click += new System.EventHandler(this.menyInnstillinger_Click);
            // 
            // menyStatistikk
            // 
            this.menyStatistikk.Location = new System.Drawing.Point(136, 94);
            this.menyStatistikk.Name = "menyStatistikk";
            this.menyStatistikk.Size = new System.Drawing.Size(130, 44);
            this.menyStatistikk.TabIndex = 1;
            this.menyStatistikk.Text = "Stats";
            this.menyStatistikk.UseVisualStyleBackColor = true;
            this.menyStatistikk.Click += new System.EventHandler(this.menyStatistikk_Click);
            // 
            // menyStart
            // 
            this.menyStart.Location = new System.Drawing.Point(136, 33);
            this.menyStart.Name = "menyStart";
            this.menyStart.Size = new System.Drawing.Size(130, 44);
            this.menyStart.TabIndex = 0;
            this.menyStart.Text = "Start";
            this.menyStart.UseVisualStyleBackColor = true;
            this.menyStart.Click += new System.EventHandler(this.menyStart_Click);
            // 
            // panelInnstillinger
            // 
            this.panelInnstillinger.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelInnstillinger.Controls.Add(this.checkBox3);
            this.panelInnstillinger.Controls.Add(this.checkBox2);
            this.panelInnstillinger.Controls.Add(this.checkBox1);
            this.panelInnstillinger.Controls.Add(this.label1);
            this.panelInnstillinger.Controls.Add(this.innstillingerInfo);
            this.panelInnstillinger.Location = new System.Drawing.Point(418, 318);
            this.panelInnstillinger.Name = "panelInnstillinger";
            this.panelInnstillinger.Size = new System.Drawing.Size(400, 300);
            this.panelInnstillinger.TabIndex = 4;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.checkBox3.Location = new System.Drawing.Point(20, 262);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(138, 30);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.checkBox2.Location = new System.Drawing.Point(20, 213);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(138, 30);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.checkBox1.Location = new System.Drawing.Point(20, 158);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 30);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(15, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // innstillingerInfo
            // 
            this.innstillingerInfo.AutoSize = true;
            this.innstillingerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.innstillingerInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.innstillingerInfo.Location = new System.Drawing.Point(15, 30);
            this.innstillingerInfo.Name = "innstillingerInfo";
            this.innstillingerInfo.Size = new System.Drawing.Size(120, 26);
            this.innstillingerInfo.TabIndex = 7;
            this.innstillingerInfo.Text = "SETTINGS";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // spillTidMin
            // 
            this.spillTidMin.AutoSize = true;
            this.spillTidMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.spillTidMin.Location = new System.Drawing.Point(307, 21);
            this.spillTidMin.Name = "spillTidMin";
            this.spillTidMin.Size = new System.Drawing.Size(24, 26);
            this.spillTidMin.TabIndex = 5;
            this.spillTidMin.Text = "0";
            // 
            // spillTidSek
            // 
            this.spillTidSek.AutoSize = true;
            this.spillTidSek.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.spillTidSek.Location = new System.Drawing.Point(340, 21);
            this.spillTidSek.Name = "spillTidSek";
            this.spillTidSek.Size = new System.Drawing.Size(24, 26);
            this.spillTidSek.TabIndex = 6;
            this.spillTidSek.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 628);
            this.Controls.Add(this.panelSpill);
            this.Controls.Add(this.panelInnstillinger);
            this.Controls.Add(this.panelMeny);
            this.Controls.Add(this.panelStatistikk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSpill.ResumeLayout(false);
            this.panelSpill.PerformLayout();
            this.panelStatistikk.ResumeLayout(false);
            this.panelStatistikk.PerformLayout();
            this.panelMeny.ResumeLayout(false);
            this.panelInnstillinger.ResumeLayout(false);
            this.panelInnstillinger.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSpill;
        private System.Windows.Forms.Label spillInfo;
        private System.Windows.Forms.RichTextBox spillParagraf;
        private System.Windows.Forms.TextBox spillSkrivHer;
        private System.Windows.Forms.Label spillOrdteller;
        private System.Windows.Forms.Label spillTid;
        private System.Windows.Forms.Panel panelStatistikk;
        private System.Windows.Forms.Label statistikkGjennomsnitt;
        private System.Windows.Forms.Label statistikkFlestOrd;
        private System.Windows.Forms.Label statistikkAntallOrd;
        private System.Windows.Forms.Label statistikkTekst3;
        private System.Windows.Forms.Label statistikkTekst2;
        private System.Windows.Forms.Label statistikkTekst1;
        private System.Windows.Forms.Label statistikkInfo;
        private System.Windows.Forms.Panel panelMeny;
        private System.Windows.Forms.Button menyAvslutt;
        private System.Windows.Forms.Button menyInnstillinger;
        private System.Windows.Forms.Button menyStatistikk;
        private System.Windows.Forms.Button menyStart;
        private System.Windows.Forms.Panel panelInnstillinger;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label innstillingerInfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label spillTidSek;
        private System.Windows.Forms.Label spillTidMin;
    }
}

