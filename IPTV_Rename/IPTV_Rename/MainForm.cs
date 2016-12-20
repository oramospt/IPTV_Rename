/*
 * Created by SharpDevelop.
 * User: oramos
 * Date: 12/10/2016
 * Time: 11:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace m3u_Order
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
		
		void Button1Click(object sender, EventArgs e)
		{
			string path = textBox1.Text;
			string pathout = @"c:\IPTV\IPTV_" + textBox2.Text + ".m3u";
			
			//Hashtable _results = new Hashtable();
			SortedDictionary<string, string> 	_results = new SortedDictionary<string, string>();
			
        	try 
	        {
	            if (File.Exists(pathout)) 
	                File.Delete(pathout);

	            using (StreamReader sr = new StreamReader(path)) 
	            {
	            	
	            	int counter = 0;
	            	string _movieName = "";
	                string _movieURL = "";
	            	
	                while (sr.Peek() >= 0) 
	                {
	                	string _line = sr.ReadLine();
	                	
	                	
	                	
	                	if(counter ==0)
	                	{
	                		int pos = _line.IndexOf(',');
	                		_movieName = _line.Substring(pos+1);
	                		counter = 1;
	                	} 
	                	else if(counter ==1)
	                	{
	                		_movieURL = _line;

	                		_results.Add(_movieName, _movieURL);

	                		counter = 0;
	                		_movieName = "";
	                		_movieURL = "";
	                	}
//	                    Console.WriteLine(sr.ReadLine());
	                }
	            }
	            
				using (System.IO.StreamWriter file = new System.IO.StreamWriter(pathout, true))
		        {
		            foreach (KeyValuePair<string, string> element in _results) {
		            	file.WriteLine("#EXTINF:-1, group-title=\""+textBox2.Text+"\"," + element.Key);	
		            	file.WriteLine(element.Value);
		            }
		        }

				MessageBox.Show("The convertion is complete");
				
        	}
	        catch (Exception ex) 
	        {
	            Console.WriteLine("The process failed: {0}", ex.ToString());
	            MessageBox.Show("The process failed: {0}", ex.ToString());
        	}
		}
	}
}
