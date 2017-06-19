/*
 * Created by SharpDevelop.
 * User: Petko
 * Date: 05.06.2017
 * Time: 17:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Restart
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button2Click(object sender, EventArgs e)
		{
			Shutdown.Shut();
		}
		void Button1Click(object sender, EventArgs e)
		{
			Shutdown.Restart();
		}
		void Button3Click(object sender, EventArgs e)
		{
			Shutdown.LogOff();
		}

	}
}
