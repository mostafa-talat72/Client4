using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace Client4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Socket server;
        bool ok = false;
        byte[] data = new byte[1024];
        string input, stringData;
        EndPoint Remote;
        int recv;
        private void SendMsgBTN_Click(object sender, EventArgs e)
        {
            if (!ok)
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                string welcome = "Hello, are you there?";
                data = Encoding.ASCII.GetBytes(welcome);
                server.SendTo(data, data.Length, SocketFlags.None, ipep);
                IPEndPoint sende = new IPEndPoint(IPAddress.Any, 0);
                Remote = (EndPoint)sende;
                data = new byte[1024];
                recv = server.ReceiveFrom(data, ref Remote);
                InfoTxt.Text += "Message received from " + Remote.ToString() + " :\n";
                InfoTxt.Text += Encoding.ASCII.GetString(data, 0, recv) + "\n";

                IPTxt.Text = "127.0.0.1";
                MsgTxt.ReadOnly = false;
                MsgTxt.Text = "Connecting to server: 127.0.0.1";
                SendMsgBTN.Text = "Send Message";
                ok = true;
            }
            input = MsgTxt.Text;
            server.SendTo(Encoding.ASCII.GetBytes(input), Remote);
            data = new byte[1024];
            recv = server.ReceiveFrom(data, ref Remote);
            stringData = Encoding.ASCII.GetString(data, 0, recv);
            InfoTxt.Text += stringData + "\n";
            // Encode the data string into a byte array+
            if (MsgTxt.Text == "exit")
            {
                SendMsgBTN.Text = "Connect";
                MsgTxt.ReadOnly = true;
                InfoTxt.Text += "Stopping client\n";
                server.Close();
                server.Shutdown(SocketShutdown.Both);
                ok = false;
            }
            MsgTxt.Clear();
        }
    }
}