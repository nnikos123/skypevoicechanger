﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace SkypeVoiceChanger.Views
{
    public partial class RecordingPage : MetroUserControl
    {
        public RecordingPage()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.markheath.net/skypevoicechangerpro");
        }
    }
}
