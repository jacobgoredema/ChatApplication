using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class frmChat : Form
    {
        public frmChat()
        {
            InitializeComponent();
        }
        ChatCoordinator chatCoordinator = ChatCoordinator.GetObject();
        private void frmChat_Load(object sender, EventArgs e)
        {
            //chatCoordinator.Register(ReceiveMessage);
            chatCoordinator.ReceiveMessage += new MessageHandler(ReceiveMessage);
        }

        private void ReceiveMessage(string message)
        {
            txtReceive.Text += message + Environment.NewLine;
        }

        private void btnBroadcast_Click(object sender, EventArgs e)
        {
            chatCoordinator.Broadcast(txtSend.Text);
            txtSend.Text="";
        }
    }
}
