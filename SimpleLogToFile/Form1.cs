using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleLogToFile.Utils;

namespace SimpleLogToFile
{
	public partial class FormLog : Form
	{
		public FormLog()
		{
			InitializeComponent();
		}

		//Simple example of form that uses logging, the same can be done with a console program
		//Exceptions can be cought and logged to file

		private void FormLog_Load(object sender, EventArgs e)
		{
			try
			{
				ActivityLog.Info("MAIN FORM", "Application Starting");
			}
			catch (Exception ex)
			{
				ActivityLog.Error("MAIN FORM", "There was an error : " + ex.Message);
			}
		}

		private void FormLog_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				ActivityLog.Info("MAIN FORM", "Application Closing");
			}
			catch (Exception ex)
			{
				ActivityLog.Error("MAIN FORM", "There was an error : " + ex.Message);
			}
		}

		private void btnLogInfo_Click(object sender, EventArgs e)
		{
			try
			{
				ActivityLog.Info("MAIN FORM", "This is an info message");
			}
			catch (Exception ex)
			{
				ActivityLog.Error("MAIN FORM", "There was an error : " + ex.Message);
			}
		}

		private void btnLogDebug_Click(object sender, EventArgs e)
		{
			try
			{
				ActivityLog.Debug("MAIN FORM", "This is an debug message");
			}
			catch (Exception ex)
			{
				ActivityLog.Error("MAIN FORM", "There was an error : " + ex.Message);
			}
		}
	}
}
