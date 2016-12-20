/*
 * Created by SharpDevelop.
 * User: oramos
 * Date: 12/10/2016
 * Time: 11:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace m3u_Order
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(440, 103);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(106, 25);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(409, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "C:\\Users\\oramos\\Downloads\\teste_m3u.txt";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(31, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "File";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(31, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "TAG";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(106, 54);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(409, 20);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "Filmes";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 163);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "m3u_Order";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
	}
}
