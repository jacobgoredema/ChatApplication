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
    public partial class frmChatClient : Form
    {
        public frmChatClient()
        {
            InitializeComponent();
        }

        private void btnNewChatClient_Click(object sender, EventArgs e)
        {
            frmChat frmChat = new frmChat();
            frmChat.Show();
        }

        private void frmChatClient_Load(object sender, EventArgs e)
        {

        }
    }
}
