﻿
using System;
using System.Windows.Forms;

namespace Proyecto
{
	class Program
	{
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		
		}
	}
}