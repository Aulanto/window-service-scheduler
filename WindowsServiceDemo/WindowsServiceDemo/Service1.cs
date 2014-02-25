using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace WindowsServiceDemo {
    public partial class Service1 : ServiceBase {
        public Service1() {
            InitializeComponent();
        }

        protected override void OnStart(string[] args) {

            timer1.Enabled = true;
            timer1.Start();

            timer1_Tick(timer1, null);
        }

        protected override void OnStop() {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e) {

            Scheduler.Record();

        }

    }
}
