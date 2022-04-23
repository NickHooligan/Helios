using System;
using System.Diagnostics;
using System.IO;

namespace Helios.Models
{
	public class Branch
	{
		public string Name { get; }
		public bool Active { set; get; }
		private static readonly string _sarstrunkDir = @"C:\sandbox\sars\sarstrunk";
		public Branch(string Name)
		{
			this.Name = Name;
		}

		public static string GetCurrentActiveBranch()
        {
			Process Proc = new Process();
			Proc.StartInfo.UseShellExecute = false;
			Proc.StartInfo.FileName = "git.exe";
			Proc.StartInfo.Arguments = "branch --show-current";
			Proc.StartInfo.RedirectStandardError = true;
			Proc.StartInfo.RedirectStandardOutput = true;
			Proc.StartInfo.WorkingDirectory = _sarstrunkDir;
			Proc.Start();

			string Output = Proc.StandardOutput.ReadToEnd();
			string Error = Proc.StandardError.ReadToEnd();
			if (string.IsNullOrEmpty(Error)) return Output.Trim();
			return "";
		}
	}
}

