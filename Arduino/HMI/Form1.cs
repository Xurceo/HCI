using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Reflection.Emit;

namespace HMI
{

    public partial class Form1 : Form
    {
        string portName = "";
        SerialPort currentPort;
        bool ArduinoPortFound = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            currentPort.Close();
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string data = sp.ReadLine(); // Read the incoming data as a line
            Console.WriteLine(data);
            Invoke(new Action(() =>
            {
                if (int.Parse(data) == 1)
                {
                    state.Text = "ВКЛ";
                }
                else if (int.Parse(data) == 0)
                {
                    state.Text = "ВИКЛ";
                }
            }));
        }

        private void port_connect_click(object sender, EventArgs e)
        {
            portName = port_name.Text;
            Connect();
        }

        private void Connect()
        {
            currentPort = new SerialPort(portName, 9600);
            System.Threading.Thread.Sleep(500);
            currentPort.BaudRate = 9600;
            currentPort.DtrEnable = true;
            currentPort.ReadTimeout = 1000;

            currentPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            try
            {
                currentPort.Open();
                port.Text = "Порт: підключено";
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
