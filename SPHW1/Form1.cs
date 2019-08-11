using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPHW1
{
	public partial class Form1 : Form
	{

		Process[] proc;
		int cntr;
		int updt;
		public Form1()
		{
			InitializeComponent();
			timer.Start();
			RefreshProcesses();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			lsbx.Items.Clear();
			RefreshProcesses();
		}

		private void RefreshProcesses()
		{
			proc = Process.GetProcesses();
			cntr = 0;

			foreach (Process i in proc)
			{
				cntr++;
				lsbx.Items.Add($"{i.ProcessName}\t\t\t\t\tId: {i.Id}");
			}

			lbl.Text = $"Current processes: {cntr}, Last update: {DateTime.Now.ToLongTimeString()}";
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			updt++;
			prb.PerformStep();
			if (updt == 10)
			{
				RefreshProcesses();

				prb.PerformStep();
				prb.Value = 0;
				updt = 0;
			}

		}
	}
}
