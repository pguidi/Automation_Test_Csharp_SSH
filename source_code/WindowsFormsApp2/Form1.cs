using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using System.IO;

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Threading.ThreadStart threadStart = new System.Threading.ThreadStart(recvSSHData);
            System.Threading.Thread thread = new System.Threading.Thread(threadStart);

            thread.IsBackground = true;
            thread.Start();
        }
        private SshClient sshClient = null;
        private ShellStream shellStreamSSH = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void discbtn_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "MILAN")
                 {

                String sship = "";
                //String sshuser = "";
                String ipinicio = "IP*";
                String ipfim = "*IP";
                //String userinicio = "user*";
                //String userfim = "*user";

                StreamReader reader = File.OpenText("C:\\Test Cases\\DISCOVER_ONT\\DISCOVER_ONT_MILAN.txt");
                string input = reader.ReadToEnd();
                texttxtfile.Text = input;

                int pos1ip = input.IndexOf(ipinicio);
                int pos2ip = input.IndexOf(ipfim, pos1ip);
                //int pos1user = input.IndexOf(userinicio);
                //int pos2user = input.IndexOf(userfim, pos1user);

                if (pos1ip >= 0)
                {
                    if(pos2ip >= 0)
                    {
                        sship = input.Substring(pos1ip, pos2ip - pos1ip);
                    }
                }

                MessageBox.Show(sship);

                //if (input.IndexOf(milanconfig) > -1)
                //    MessageBox.Show(milanconfig);
                //else
                //    MessageBox.Show("não existe");         

                //TextReader reader = new StreamReader(@"C:\Test Cases\DISCOVER_ONT\DISCOVER_ONT_MILAN.txt");
                //texttxtfile.Text = reader.ReadToEnd();
                //MessageBox.Show(reader);
                //reader.Close();
                try
                    {

                    this.sshClient = new SshClient(sship, "root", "root");
                    this.sshClient.ConnectionInfo.Timeout = TimeSpan.FromSeconds(15);
                    this.sshClient.Connect();
                    this.shellStreamSSH = this.sshClient.CreateShellStream("DISCOVER ONT", 80, 60, 800, 600, 65536);
                    System.Threading.Thread.Sleep(300);
                    this.shellStreamSSH.Write("cli");
                    this.shellStreamSSH.Write("\r\n");
                    System.Threading.Thread.Sleep(300);
                    this.shellStreamSSH.Write("show discovered-onts");
                    this.shellStreamSSH.Write("\n");
                    System.Threading.Thread.Sleep(500);
                    this.sshClient.Disconnect();
                    }
                    catch (Exception exp)
                    {
                    MessageBox.Show("ERROR: " + exp.Message);
                    }
                  }              
        }

        private void appendTextBoxInThread(TextBox t, String s)
        {
            if(t.InvokeRequired)
            {
                t.Invoke(new Action<TextBox, string>(appendTextBoxInThread), new object[] { t, s });
            }
            else
            {
                t.AppendText(s);
            }
        }

        private void recvSSHData()
        {
            while(true)
            {
                try
                {
                    if(this.shellStreamSSH !=null && this.shellStreamSSH.DataAvailable)
                    {
                        String strData = this.shellStreamSSH.Read();
                        appendTextBoxInThread(Showdisc, strData);
                    }
                }
                catch
                {

                }
                System.Threading.Thread.Sleep(200);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (sshClient.IsConnected)         
             //   this.sshClient.Disconnect();        
            //else
             //   MessageBox.Show("Selecione uma OLT");        
        }
    }
}
