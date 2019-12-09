using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Sockets;
using System.Net;

namespace coat
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UDPSender : ContentPage
	{
		public UDPSender ()
		{
			InitializeComponent ();
		}


        public void SendPacket(object sender, EventArgs e)
        {
            
            int port = int.Parse(Port.Text);
            Byte[] data = Encoding.ASCII.GetBytes(Data.Text);
            UdpClient udpClient = new UdpClient();

            udpClient.SendAsync(data, Data.Text.Length, IP.Text, port);
        }
    }
}