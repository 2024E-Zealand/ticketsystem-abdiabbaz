
using TCPserver;

Server server = new Server();
ServerJson serverJson = new ServerJson(); 
serverJson.Start();
server.Start();

Console.ReadKey();