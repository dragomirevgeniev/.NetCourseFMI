// Fig. 23.1: ChatServer.cs
// Set up a server that will receive a connection from a client, send a
// string to the client, chat with the client and close the connection.
using System;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections.Generic;

public partial class ChatServerForm : Form
{
    private Thread readThread; // Thread for processing incoming messages
    private Dictionary<Thread, BinaryWriter> writer;
    private Dictionary<Thread, Socket> reader;

    public ChatServerForm()
    {
        InitializeComponent();
        writer = new Dictionary<Thread, BinaryWriter>();
        reader = new Dictionary<Thread, Socket>();
    } // end constructor


    // initialize thread for reading
    private void ChatServerForm_Load(object sender, EventArgs e)
    {
        readThread = new Thread(new ThreadStart(RunServer));
        readThread.Start();
    } // end method CharServerForm_Load

    // close all threads associated with this application
    private void ChatServerForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        System.Environment.Exit(System.Environment.ExitCode);
    } // end method CharServerForm_FormClosing

    // delegate that allows method DisplayMessage to be called
    // in the thread that creates and maintains the GUI       
    private delegate void DisplayDelegate(string message);

    // method DisplayMessage sets displayTextBox's Text property
    // in a thread-safe manner
    private void DisplayMessage(string message)
    {
        // if modifying displayTextBox is not thread safe
        if (displayTextBox.InvokeRequired)
        {
            // use inherited method Invoke to execute DisplayMessage
            // via a delegate                                       
            Invoke(new DisplayDelegate(DisplayMessage), new object[] { message });
        } // end if
        else // OK to modify displayTextBox in current thread
            displayTextBox.Text += message;
    } // end method DisplayMessage

    // delegate that allows method DisableInput to be called 
    // in the thread that creates and maintains the GUI
    private delegate void DisableInputDelegate(bool value);

    // method DisableInput sets inputTextBox's ReadOnly property
    // in a thread-safe manner
    private void DisableInput(bool value)
    {
        // if modifying inputTextBox is not thread safe
        if (inputTextBox.InvokeRequired)
        {
            // use inherited method Invoke to execute DisableInput
            // via a delegate                                     
            Invoke(new DisableInputDelegate(DisableInput), new object[] { value });
        } // end if
        else // OK to modify inputTextBox in current thread
            inputTextBox.ReadOnly = value;
    } // end method DisableInput

    // send the text typed at the server to the client
    private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        // send the text to the client
        try
        {
            if (e.KeyCode == Keys.Enter && inputTextBox.ReadOnly == false)
            {
                displayTextBox.Text += "\r\nSERVER>>> " + inputTextBox.Text;
                var keys = writer.Keys;
                foreach (var key in keys)
                {
                    writer[key].Write("SERVER>>> " + inputTextBox.Text);
                }

                inputTextBox.Clear(); // clear the user’s input
            } // end if
            // if the user at the server signaled termination
            // sever the connection to the client
            if (inputTextBox.Text == "TERMINATE")
                Application.Exit();
        } // end try
        catch (SocketException)
        {
            displayTextBox.Text += "\nError writing object";
        } // end catch
    } // end method inputTextBox_KeyDown

    // allows a client to connect; displays text the client sends
    public void RunServer()
    {
        Socket connection; // Socket for accepting a connection
        TcpListener listener;
        int counter = 1;

        // wait for a client connection and display the text
        // that the client sends
        try
        {
            // Step 1: create TcpListener                    
            IPAddress local = IPAddress.Parse("127.0.0.1");
            listener = new TcpListener(local, 50000);

            // Step 2: TcpListener waits for connection request
            listener.Start();

            // Step 3: establish connection upon client request
            while (true)
            {
                DisplayMessage("Waiting for connection\r\n");

                // accept an incoming connection     
                connection = listener.AcceptSocket();
                DisplayMessage("Connection " + counter + " received.\r\n");
                counter++;
                Thread clientThread = new Thread(new ThreadStart(DoWorkInClient));
                clientThread.Start();
                this.reader[clientThread] = connection;
                //ThreadPool.QueueUserWorkItem(DoWorkInClient, connection);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    } // end method RunServer

    public void DoWorkInClient(object socket)
    {
        int counter = 1;
        Socket connection = (Socket)socket;
        // create NetworkStream object associated with socket
        NetworkStream socketStream = new NetworkStream(connection);

        // create objects for transferring data across stream
        BinaryWriter writer = new BinaryWriter(socketStream);
        BinaryReader reader = new BinaryReader(socketStream);
        this.writer[Thread.CurrentThread] = writer;
        DisplayMessage("Connection " + counter + " received.\r\n");

        // inform client that connection was successfull  
        writer.Write("SERVER>>> Connection successful");

        DisableInput(false); // enable inputTextBox

        string theReply = "";

        // Step 4: read string data sent from client
        do
        {
            try
            {
                // read the string sent to the server
                theReply = reader.ReadString();

                // display the message
                DisplayMessage("\r\n" + theReply);
            } // end try
            catch (Exception)
            {
                // handle exception if error reading data
                break;
            } // end catch
        } while (theReply != "CLIENT>>> TERMINATE" &&
           connection.Connected);

        DisplayMessage("\r\nUser terminated connection\r\n");

        // Step 5: close connection  
        writer.Close();
        reader.Close();
        socketStream.Close();
        connection.Close();
        this.writer.Remove(Thread.CurrentThread);
        this.reader.Remove(Thread.CurrentThread);
        if (this.writer.Count == 0)
        {
            DisableInput(true); // disable InputTextBox
        }

        counter++;
    }

    public void DoWorkInClient()
    {
        NetworkStream socketStream; // network data stream
        BinaryWriter writer; // facilitates writing to the stream
        BinaryReader reader; // faciliates reading from stream

        Socket connection = this.reader[Thread.CurrentThread];
        int counter = 1;
        // create NetworkStream object associated with socket
        socketStream = new NetworkStream(connection);

        // create objects for transferring data across stream
        writer = new BinaryWriter(socketStream);
        reader = new BinaryReader(socketStream);
        this.writer[Thread.CurrentThread] = writer;
        DisplayMessage("Connection " + counter + " received.\r\n");

        // inform client that connection was successfull  
        writer.Write("SERVER>>> Connection successful");

        DisableInput(false); // enable inputTextBox

        string theReply = "";

        // Step 4: read string data sent from client
        do
        {
            try
            {
                // read the string sent to the server
                theReply = reader.ReadString();

                // display the message
                DisplayMessage("\r\n" + theReply);
            } // end try
            catch (Exception)
            {
                // handle exception if error reading data
                break;
            } // end catch
        } while (theReply != "CLIENT>>> TERMINATE" &&
           connection.Connected);

        DisplayMessage("\r\nUser terminated connection\r\n");

        // Step 5: close connection  
        writer.Close();
        reader.Close();
        socketStream.Close();
        connection.Close();
        this.writer.Remove(Thread.CurrentThread);
        this.reader.Remove(Thread.CurrentThread);
        if (this.writer.Count == 0)
        {
            DisableInput(true); // disable InputTextBox
        }

        counter++;
    }
}


