﻿// See https://aka.ms/new-console-template for more information
using TCPserver;

Console.WriteLine("Hello, World!");

Server server = new Server();

server.Start();

Console.ReadKey();