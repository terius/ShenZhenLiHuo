using System;
using System.IO.Ports;

namespace Helpers
{
    public class COMServer
    {
        SerialPort sp1; //COM1-接收
        SerialPort sp2; //COM2-发送
        public Action<string> OnReceiveCOMData;
        public bool IsAutoScan { get; set; }
        public COMServer()
        {
            this.IsAutoScan = true;
            sp1 = new SerialPort();
            sp1.DataReceived += Sp1_DataReceived;
            //准备就绪              
            sp1.DtrEnable = true;
            sp1.RtsEnable = true;
            //设置数据读取超时为1秒
            sp1.ReadTimeout = 1000;
            OpenSerialPort(sp1, "COM1");
            sp2 = new SerialPort();
        }

        private void Sp1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (IsAutoScan)
            {
                if (!sp1.IsOpen)
                {
                    OpenSerialPort(sp1, "COM1");
                }
                string str = sp1.ReadLine().Trim(new char[] { '\r', '\n', ' ' }); //注意：回车换行必须这样写，单独使用"\r"和"\n"都不会有效果
                sp1.DiscardInBuffer();
                OnReceiveCOMData(str);
            }
        }

        public void Send(string message)
        {
            if (IsAutoScan)
            {
                OpenSerialPort(sp2, "COM2");
                sp2.WriteLine(message);    //写入数据
            }
            StringHelper.WriteLog(message + " " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }



        private void OpenSerialPort(SerialPort sp, string portName)
        {
            if (!sp.IsOpen)
            {
                sp.PortName = portName;
                sp.BaudRate = 9600;
                sp.DataBits = 8;
                sp.StopBits = StopBits.One;
                sp.Parity = Parity.None;
                if (sp.IsOpen)//如果打开状态，则先关闭一下
                {
                    sp.Close();
                }
                sp.Open();     //打开串口
            }
        }

        public void CloseSerialPort()
        {
            if (sp1.IsOpen)
            {
                sp1.Close();
            }

            if (sp2.IsOpen)
            {
                sp2.Close();
            }
        }
    }
}
