﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace CDS.Client.Desktop.Main
{
    public partial class SplashScreen : DevExpress.XtraSplashScreen.SplashScreen
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);            
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}