using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPserver
{
    public class Server
    {

        public void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Any, 3025);
            server.Start();

            Console.WriteLine("Server is running..");

            TcpClient socket = server.AcceptTcpClient();

            Task.Run(() =>
            {
                TcpClient temp = socket;
                DoClient(temp);
            });
        }


        public void DoClient(TcpClient client)
        {
            StreamReader sr = new StreamReader(client.GetStream());
            StreamWriter sw = new StreamWriter(client.GetStream());

            while (true)
            {
                string input = sr.ReadLine();

                switch (input.ToLower())
                {
                    case "random":
                        Random();
                        break;
                    case "add":
                        Add();
                        break;
                    case "sub":
                        Sub();
                        break;
                    default:
                        sw.WriteLine("Forkert Input. Prøv igen");
                        sw.Flush();
                        break;
                }
                void Random()
                {
                    sw.WriteLine("Input Numbers");
                    sw.Flush();
                    string numberInput = sr.ReadLine();
                    string[] numbers = numberInput.Split(' ');
                    if (numbers.Length == 2)
                    {
                        int numberOne = Int32.Parse(numbers[0]);
                        int numberTwo = Int32.Parse(numbers[1]);
                        Random random = new Random();
                        int randomNumber = random.Next(numberOne, numberTwo + 1);
                        sw.WriteLine(randomNumber);
                        sw.Flush();
                    }
                    else
                    {
                        sw.WriteLine("Forkert input. Prøv igen");
                        sw.Flush();
                    }
                }
                void Add()
                {
                    sw.WriteLine("Input Numbers");
                    sw.Flush();
                    string numberInput = sr.ReadLine();
                    string[] numbers = numberInput.Split();
                    if (numbers.Length == 2)
                    {
                        int numberOne = Int32.Parse(numbers[0]);
                        int numberTwo = Int32.Parse(numbers[1]);
                        int result = numberOne + numberTwo;
                        sw.WriteLine(result);
                        sw.Flush();
                    }
                    else
                    {
                        sw.WriteLine("Forkert Input. Prøv igen");
                        sw.Flush();
                    }
                }
                void Sub()
                {
                    sw.WriteLine("Input Numbers");
                    sw.Flush();
                    string numbersInput = sr.ReadLine();
                    string[] numbers = numbersInput.Split();
                    if (numbers.Length == 2)
                    {
                        int numberOne = Int32.Parse(numbers[0]);
                        int numberTwo = Int32.Parse(numbers[1]);
                        int result = numberOne - numberTwo;
                        sw.WriteLine(result);
                        sw.Flush();
                    }
                    else
                    {
                        sw.WriteLine("Forkert Input");
                        sw.Flush();
                    }
                }
            }
        }

    }
}
