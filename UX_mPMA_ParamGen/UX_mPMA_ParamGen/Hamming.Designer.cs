﻿/*
 * Created by SharpDevelop.
 * User: Wiktor
 * Date: 30.05.2019
 * Time: 20:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UX_mPMA_ParamGen
{
	partial class Hamming
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			this.textCoder = new System.Windows.Forms.TextBox();
			this.Coder = new System.Windows.Forms.Label();
			this.Decoder = new System.Windows.Forms.Label();
			this.textDecoder = new System.Windows.Forms.TextBox();
			this.sendButtonCoder = new System.Windows.Forms.Button();
			this.sendButtonDecoder = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textCoder
			// 
			this.textCoder.Location = new System.Drawing.Point(26, 62);
			this.textCoder.Multiline = true;
			this.textCoder.Name = "textCoder";
			this.textCoder.Size = new System.Drawing.Size(202, 45);
			this.textCoder.TabIndex = 0;
			// 
			// Coder
			// 
			this.Coder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Coder.Location = new System.Drawing.Point(26, 27);
			this.Coder.Name = "Coder";
			this.Coder.Size = new System.Drawing.Size(205, 32);
			this.Coder.TabIndex = 1;
			this.Coder.Text = "Coder";
			this.Coder.Click += new System.EventHandler(this.Label1Click);
			// 
			// Decoder
			// 
			this.Decoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Decoder.Location = new System.Drawing.Point(310, 27);
			this.Decoder.Name = "Decoder";
			this.Decoder.Size = new System.Drawing.Size(205, 32);
			this.Decoder.TabIndex = 3;
			this.Decoder.Text = "Decoder";
			// 
			// textDecoder
			// 
			this.textDecoder.Location = new System.Drawing.Point(310, 62);
			this.textDecoder.Multiline = true;
			this.textDecoder.Name = "textDecoder";
			this.textDecoder.Size = new System.Drawing.Size(202, 45);
			this.textDecoder.TabIndex = 2;
			// 
			// sendButtonCoder
			// 
			this.sendButtonCoder.Location = new System.Drawing.Point(26, 139);
			this.sendButtonCoder.Name = "sendButtonCoder";
			this.sendButtonCoder.Size = new System.Drawing.Size(157, 41);
			this.sendButtonCoder.TabIndex = 5;
			this.sendButtonCoder.Text = "Send&Receive Coder";
			this.sendButtonCoder.UseVisualStyleBackColor = true;
			this.sendButtonCoder.Click += new System.EventHandler(this.SendButtonCoderClick);
			// 
			// sendButtonDecoder
			// 
			this.sendButtonDecoder.Location = new System.Drawing.Point(310, 139);
			this.sendButtonDecoder.Name = "sendButtonDecoder";
			this.sendButtonDecoder.Size = new System.Drawing.Size(157, 41);
			this.sendButtonDecoder.TabIndex = 6;
			this.sendButtonDecoder.Text = "Send&Receive Decoder";
			this.sendButtonDecoder.UseVisualStyleBackColor = true;
			this.sendButtonDecoder.Click += new System.EventHandler(this.SendButtonDecoderClick);
			// 
			// Hamming
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.sendButtonDecoder);
			this.Controls.Add(this.sendButtonCoder);
			this.Controls.Add(this.Decoder);
			this.Controls.Add(this.textDecoder);
			this.Controls.Add(this.Coder);
			this.Controls.Add(this.textCoder);
			this.Name = "Hamming";
			this.Size = new System.Drawing.Size(546, 200);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button sendButtonDecoder;
		private System.Windows.Forms.Button sendButtonCoder;
		private System.Windows.Forms.TextBox textDecoder;
		private System.Windows.Forms.Label Decoder;
		private System.Windows.Forms.Label Coder;
		private System.Windows.Forms.TextBox textCoder;
	}
}
