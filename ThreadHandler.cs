using System;
using System.Threading;
using System.Net.Sockets;

namespace mySocket
{
    class  WorkerThreadhandler
 {
        public TcpListener myTcplistener;

        public void HandleThread()
        {
            Thread currentThread = Thread.CurrentThread;

            Socket mySocket = myTcplistener.AcceptSocket();


            byte[] buf = System.Text.Encoding.ASCII.GetBytes("hello");
            mySocket.Send(buf);
            mySocket.Close();
        }
    };
 

}