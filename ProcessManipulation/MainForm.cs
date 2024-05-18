using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using System.Management;

namespace ProcessManipulation
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		List<Process> processes= new List<Process>();
		int counter = 0;
		delegate void ProcessDelegate(Process process);
		public MainForm()
		{
			InitializeComponent();
			LoadAvailableAssemblies();
		}
		private void process_Exited(object sender, EventArgs e)
		{
			Process process = sender as Process;
			listBoxStartedAssembles.Items.Remove(process.ProcessName);
			listBoxAvalibleAssembles.Items.Add(process.ProcessName);
			processes.Remove(process);
			counter--;
			for(int i=0;i<processes.Count;i++)
			{
				SetChildWindowText(process.MainWindowHandle, $"Child process {i+1}");
			}
		}
		void LoadAvailableAssemblies()
		{
			string except=new FileInfo(Application.ExecutablePath).Name.Split('.').First();
			string[] files = Directory.GetFiles(Application.StartupPath,"*.exe");
			for (int i=0;i<files.Length;i++)
			{
				listBoxAvalibleAssembles.Items.Add(files[i].Split('\\').Last().Split('.').First());
			}
			listBoxAvalibleAssembles.Items.Remove(except);
		}
		void RunProcess(string assemblyName)
		{
			Process process = Process.Start(assemblyName);
			processes.Add(process);
			if(Process.GetCurrentProcess().Id == GetParentProcessId(process.Id)) 
			{
				MessageBox.Show($"{process.ProcessName} является дочерним процессом");
			}
			process.EnableRaisingEvents = true;
			process.Exited+= process_Exited;
			SendMessage(process.MainWindowHandle, WM_SETTEXT, (System.IntPtr)0, $"Child process №{processes.Count}");
			listBoxStartedAssembles.Items.Add(process.ProcessName);
			listBoxAvalibleAssembles.Items.Remove(process.ProcessName);
		}
		void ExecuteOnProcessByName(string name, ProcessDelegate func)
		{
			Process[] processes=Process.GetProcessesByName(name);
			foreach(Process proc in processes)
			{
				if(Process.GetCurrentProcess().Id==GetParentProcessId(proc.Id))
					func(proc);
			}
		}
		int GetParentProcessId(int id)
		{
			int parentID;
			using (ManagementObject obj=new ManagementObject("win32_process.handle=" + id.ToString()))
			{
				obj.Get();
				parentID = Convert.ToInt32(obj["ParentProcessId"]);
			}
			return parentID;
		}
		void SetChildWindowText(IntPtr handle, string text)
		{
			SendMessage(handle, WM_SETTEXT, (System.IntPtr)0, text);
		}
		
		/// <summary>
		/// API functions:
		/// </summary>
		const uint WM_SETTEXT = 0x0C;
		[DllImport("user32.dll")]
		public static extern IntPtr SendMessage(IntPtr hwnd, uint uMsg, IntPtr wParam,
			[MarshalAs(UnmanagedType.LPStr)]string lParam);

		private void buttonStart_Click(object sender, EventArgs e)
		{
			if(listBoxAvalibleAssembles.SelectedItem!=null)
				RunProcess(listBoxAvalibleAssembles.SelectedItem.ToString());
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			foreach(Process proc in processes)
			{
				proc.CloseMainWindow();
				proc.Close();
			}
		}
		void Kill(Process process)
		{
			process.Kill();
		}
		private void buttonStop_Click(object sender, EventArgs e)
		{
			if (listBoxStartedAssembles.SelectedItem != null)
			{
				object obj = listBoxStartedAssembles.SelectedItem;
				listBoxStartedAssembles.Items.Remove(obj);
				ExecuteOnProcessByName(obj.ToString(), Kill);
			}	
		}
	}
}
