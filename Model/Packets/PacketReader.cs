using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace NetM.Model.Packets
{
    class PacketReader
    {
        byte[] buffer = new byte[4096];
        EndPoint EndPoint = new IPEndPoint(IPAddress.Any, 0);
        Socket socket;
        int sum = 0;

        public PacketReader()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP);
            socket.Bind(new IPEndPoint(IPAddress.Parse("192.168.178.14"), 0));
            socket.IOControl(IOControlCode.ReceiveAll, new byte[4] { 1, 0, 0, 0 }, new byte[4]);

            beginReceiveFrom();
        }

        private void beginReceiveFrom()
        {
            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), null);
        }

        private void ReceiveCallBack(IAsyncResult async)
        {
            int length = socket.EndReceive(async);
            sum += 1;
            //Console.WriteLine(String.Format("{0} received {1} from {2}", DateTime.Now, length, EndPoint));
            //WritePackage(length);
            Console.WriteLine(String.Format("{0} kilobytes received.", sum));
            //Thread.Sleep(500);
            beginReceiveFrom();

        }

        private void WritePackage(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(String.Format("{0} ", buffer[i]));
            }
            Console.WriteLine("");
        }
    }
}
