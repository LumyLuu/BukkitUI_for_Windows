﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Net;
using System.Threading;

namespace BukkitUI_Updater {
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm {
        public RadForm1() {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e) {
            // Connect to GitHub and check for new releases
            loadUpdates();
        }

        private void loadUpdates() {
            new Thread(() => {
                Invoke((MethodInvoker)delegate {

                });
            }).Start();
        }
    }
}