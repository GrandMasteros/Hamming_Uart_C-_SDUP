﻿/*
 * Created by SharpDevelop.
 * User: Wiktor Widzisz
 * Date: 2019-03-01
 * Time: 12:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace UX_mPMA_ParamGen
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		SerialPort serialPort = new SerialPort();
		//MainForm mainForm =  new MainForm();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//		
			//
			comPort.SetLogReference(logger);
			comPort.SetSerialPortReference(serialPort);
			comPort.SetHammingReference(hamming1);
			hamming1.SetLogReference(logger);
			hamming1.Enabled = false;
			//comPort.SetMainFormReference(mainForm);
//			logger.Log("lll");
			//logger1.
		}
			
	}
}
