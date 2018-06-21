using System;
using System.Windows.Forms;
using Eneter.Messaging.EndPoints.TypedMessages;
using Eneter.Messaging.MessagingSystems.MessagingSystemBase;
using Eneter.Messaging.MessagingSystems.TcpMessagingSystem;
using Eneter.Messaging.Threading.Dispatching;

namespace WinFormServiceApplication
{
    
    public partial class Form1 : Form
    {
        // Receive string messages and send back string messages.
        IDuplexTypedMessageReceiver<MyResponse, MyRequest> myReceiver;

        public Form1()
        {
            InitializeComponent();

            // Create message receiver.
            // Note: it receives string and sends back string.
            IDuplexTypedMessagesFactory aReceiverFactory = new DuplexTypedMessagesFactory();
            myReceiver = aReceiverFactory.CreateDuplexTypedMessageReceiver<MyResponse, MyRequest>();
            // Subscribe to get notified when a client connects, disconnects
            // or sends a message.
         
            myReceiver.ResponseReceiverConnected += OnClientConnected;
            myReceiver.ResponseReceiverDisconnected += OnClientDisconnected;
            myReceiver.MessageReceived += OnMessageReceived;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Detach input channel and stop listening.
            myReceiver.DetachDuplexInputChannel();
        }

        private void OnClientConnected(object sender, ResponseReceiverEventArgs e)
        {
            // Add the client id to the listbox.
            // Note: we can directly access the listbox because we set threading mode of
            //       InputChannelThreading to the main UI thread.
            ConnectedClientsListBox.Items.Add(e.ResponseReceiverId);
        }

        private void OnClientDisconnected(object sender, ResponseReceiverEventArgs e)
        {
            // Remove the client from the listbox.
            // Note: we can directly access the listbox because we set threading mode of
            //       InputChannelThreading to the main UI thread.
            ConnectedClientsListBox.Items.Remove(e.ResponseReceiverId);
        }

        private void OnMessageReceived(object sender, TypedRequestReceivedEventArgs<MyRequest> e)
        {
            // Insert received message at the beginning of the listbox.
            // Note: we can directly access the listbox because we set threading mode of
            //       InputChannelThreading to the main UI thread.
            
            

            if(e.RequestMessage.Ack == false)
            {
                Random rnd = new Random();
                ReceivedMessagesListBox.Items.Insert(0, e.RequestMessage);
                MyResponse resp = new MyResponse();
                resp.Temperature = (float)rnd.Next(0, 300) / 10.0f;
                resp.Pressure = (float)rnd.Next(900, 1100) / 10.0f;
                resp.Humidity = (float)rnd.Next(0, 1000) / 10.0f;
                resp.Time = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

                // Send message to client which is selected in the listbox.
                myReceiver.SendResponseMessage(e.ResponseReceiverId, resp);
            }
            else
            {
                listBoxAcknowledge.Items.Insert(0, e.ResponseReceiverId + ": ACK");
            }
        }


        private void StartServiceBtn_Click(object sender, EventArgs e)
        {
            if (myReceiver.IsDuplexInputChannelAttached)
            {
                // The channel is already attached so nothing to do.
                return;
            }

            // Use TCP communication
            IMessagingSystemFactory aMessaging = new TcpMessagingSystemFactory()
            {
                // Set to receive messages in the main UI thread.
                // Note: if this is not set then methods OnMessageReceived, OnClientConnected
                //       and OnClientDisconnected would not be called from main UI thread
                //       but from a listener thread.
                MaxAmountOfConnections = 5,
                InputChannelThreading = new WinFormsDispatching(this)
            };

            // Create input channel.
            IDuplexInputChannel anInputChannel = aMessaging.CreateDuplexInputChannel("tcp://127.0.0.1:8060/");

            // Attach the input channel and be able to receive messages
            // and send back response messages.
            myReceiver.AttachDuplexInputChannel(anInputChannel);

            ServiceStatusLabel.Text = "Service Running";
        }

        private void StopServiceBtn_Click(object sender, EventArgs e)
        {
            // Detach input channel and stop listening.
            myReceiver.DetachDuplexInputChannel();

            ServiceStatusLabel.Text = "Service Not Running";
        }

        private void SendMessageBtn_Click(object sender, EventArgs e)
        {
            string aClientId = GetSelectedClient();
            if (!string.IsNullOrEmpty(aClientId))
            {
                string aMessage = MessageTextBox.Text;
                MyResponse resp = new MyResponse();
                //resp.Length = ReceivedMessagesListBox.Items[0].ToString().Length;
                // Send message to client which is selected in the listbox.
                myReceiver.SendResponseMessage(aClientId, resp);
            }
        }

        private void DisconnectClientBtn_Click(object sender, EventArgs e)
        {
            // Disconnect client which is selected in the listbox.
            string aClientId = GetSelectedClient();
            if (!string.IsNullOrEmpty(aClientId))
            {
                myReceiver.AttachedDuplexInputChannel.DisconnectResponseReceiver(aClientId);
            }
        }

        private string GetSelectedClient()
        {
            string aClientId = ConnectedClientsListBox.SelectedItem as string;
            return aClientId;
        }

        private void listBoxAcknowledge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
