/*
 * Created by SharpDevelop.
 * User: Wiktor Widzisz
 * Date: 2019-03-01
 * Time: 12:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UX_mPMA_ParamGen
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		public System.ComponentModel.IContainer components = null;
		public UX_mPMA_ParamGen.ComPort comPort;
		public UX_mPMA_ParamGen.Logger logger;

		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.comPort = new UX_mPMA_ParamGen.ComPort();
			this.logger = new UX_mPMA_ParamGen.Logger();
			this.hamming1 = new UX_mPMA_ParamGen.Hamming();
			this.SuspendLayout();
			// 
			// comPort
			// 
			this.comPort.Location = new System.Drawing.Point(37, 524);
			this.comPort.Name = "comPort";
			this.comPort.Size = new System.Drawing.Size(864, 36);
			this.comPort.TabIndex = 0;
			// 
			// logger
			// 
			this.logger.Location = new System.Drawing.Point(37, 258);
			this.logger.Name = "logger";
			this.logger.Size = new System.Drawing.Size(864, 229);
			this.logger.TabIndex = 1;
			// 
			// hamming1
			// 
			this.hamming1.Location = new System.Drawing.Point(37, 27);
			this.hamming1.Name = "hamming1";
			this.hamming1.Size = new System.Drawing.Size(530, 209);
			this.hamming1.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(946, 572);
			this.Controls.Add(this.hamming1);
			this.Controls.Add(this.logger);
			this.Controls.Add(this.comPort);
			this.Name = "MainForm";
			this.Text = "UX_mPMA_ParamGen";
			this.ResumeLayout(false);
		}
		private UX_mPMA_ParamGen.Hamming hamming1;
	}
}
