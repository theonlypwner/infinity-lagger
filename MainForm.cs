using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace InfinityLagger
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		protected List<Thread> threads = new List<Thread>();
		protected byte optype;

		private void tglRunning_CheckedChanged(object sender, EventArgs e)
		{
			if (tglRunning.Checked)
			{
				// update GUI
				progress.Style = ProgressBarStyle.Marquee;
				btnLatency.Enabled = true;
				radIncrement.Enabled = radDecrement.Enabled = radLeft.Enabled = radRight.Enabled = false;
				// what are we doing?
				if (radIncrement.Checked) optype = 0;
				else if (radDecrement.Checked) optype = 1;
				else if (radLeft.Checked) optype = 2;
				else if (radRight.Checked) optype = 3;
				// start thread
				// inits
				counter = endticks = 0;
				i = 1;
				startticks = (ulong)DateTime.Now.Ticks;
				// start it
				for (byte j = 0; j < 2; ++j)
				{
					Thread thread = new Thread(process);
					this.threads.Add(thread);
				}
				foreach (var thread in threads)
				{
					thread.TrySetApartmentState(ApartmentState.MTA);
					thread.Start();
				}
			}
			else {
				// update GUI
				btnLatency.Enabled = false;
				radIncrement.Enabled = radDecrement.Enabled = radLeft.Enabled = radRight.Enabled = true;
				progress.Style = ProgressBarStyle.Blocks;
				// cancel threads
				foreach(var thread in threads)
					thread.Abort();
				threads.Clear();
				// save end time
				endticks = (ulong)DateTime.Now.Ticks;
				// update latency
				updateLatency(this, null);
			}
		}

		long i = 1;
		ulong counter = 0, startticks = 0, endticks = 0;
		protected void process() {
			while (tglRunning.Checked) unchecked{
				switch(optype){
					case 0: ++i; break;
					case 1: --i; break;
					case 2: i <<= 1; break;
					case 3: i >>= 1; break;
				}
				if (counter < ulong.MaxValue) ++counter;
			}
		}

		private void updateLatency(object sender, EventArgs e)
		{
			if (this.InvokeRequired) {
				this.Invoke(new EventHandler(updateLatency), sender, e);
				return;
			}
			lblCount.Text = counter.ToString();
			ulong latency = (endticks == 0) ? (ulong)DateTime.Now.Ticks - startticks : endticks - startticks;
			if (latency == 0) latency = 1; // prevent divide by zero
			lblOps.Text = (counter * 10000000 / latency).ToString();
		}

		private void MainForm_Close(object sender, FormClosingEventArgs e)
		{
			if (tglRunning.Checked || threads.Count > 0) {
				e.Cancel = true;
				tglRunning.Checked = false;
			}
		}
	}
}
