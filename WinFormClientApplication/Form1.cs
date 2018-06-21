using System;
using System.Windows.Forms;
using Eneter.Messaging.EndPoints.TypedMessages;
using Eneter.Messaging.MessagingSystems.MessagingSystemBase;
using Eneter.Messaging.MessagingSystems.TcpMessagingSystem;
using Eneter.Messaging.Threading.Dispatching;

namespace WinFormClientApplication
{
    public partial class Form1 : Form
    {
        // Sender which sends string request messages
        // and receives string response messages.
        IDuplexTypedMessageSender<string, string> mySender;

        public Form1()
        {
            InitializeComponent();

            // Create message sender.
            IDuplexTypedMessagesFactory aSenderFactory = new DuplexTypedMessagesFactory();
            mySender = aSenderFactory.CreateDuplexTypedMessageSender<string, string>();

            // Subscribe to handle when a message is received or if the client
            // is disconnected.
            mySender.ConnectionClosed += OnConnectionClosed;
            mySender.ResponseReceived += OnResponseReceived;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            mySender.DetachDuplexOutputChannel();
        }

        private void OnResponseReceived(object sender, TypedResponseReceivedEventArgs<string> e)
        {
            // Insert the received message at the beginning of the listbox.
            // Note: we can directly access the UI control here because we set threading mode of
            //       OutputChannelThreading to the main UI thread.
            ReceivedMessagesListBox.Items.Add(e.ResponseMessage);
        }

        private void OnConnectionClosed(object sender, DuplexChannelEventArgs e)
        {
            // The client got disconnected so set the status.
            // Note: we can directly access the UI control here because we set threading mode of
            //       OutputChannelThreading to the main UI thread.
            ConnectionStatusLabel.Text = "Client Not Connected";
        }

        private void OpenConnectionBtn_Click(object sender, EventArgs e)
        {
            if (!mySender.IsDuplexOutputChannelAttached)
            {
                // The output channel is not attached yet.
                // So attach the output channel and be able to send
                // request messagas and receive response messages.
                IMessagingSystemFactory aMessaging = new TcpMessagingSystemFactory()
                {
                    // Set to receive messages in the main UI thread.
                    // Note: if this is not set then methods OnResponseReceived and
                    //       OnConnectionClosed would not be called from main UI thread
                    //       but from a listener thread.
                    OutputChannelThreading = new WinFormsDispatching(this)
                };
                IDuplexOutputChannel anOutputChannel = aMessaging.CreateDuplexOutputChannel("tcp://127.0.0.1:8033/");
                mySender.AttachDuplexOutputChannel(anOutputChannel);

                ConnectionStatusLabel.Text = "Client Connected";
            }
            else if (!mySender.AttachedDuplexOutputChannel.IsConnected)
            {
                // The output channel is attached but the client got disconnected.
                // So jut reopen the connection.
                mySender.AttachedDuplexOutputChannel.OpenConnection();

                ConnectionStatusLabel.Text = "Client Connected";
            }
        }

        private void CloseConnectionBtn_Click(object sender, EventArgs e)
        {
            mySender.DetachDuplexOutputChannel();
        }

        private void SendMessageBtn_Click(object sender, EventArgs e)
        {
            // If the client is connected to the service.
            if (mySender.IsDuplexOutputChannelAttached &&
                mySender.AttachedDuplexOutputChannel.IsConnected)
            {
                string aMessage = MessageTextBox.Text;
                mySender.SendRequestMessage(aMessage);
            }
        }

        
    }
}
