using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Study._34강의
{
    public partial class EventLayout : Form
    {
        public EventLayout()
        {
            InitializeComponent();
        }

        private void EventLayout_Load(object sender, EventArgs e)
        {
            //ucCMenu.eColorSender += UccMenu_eColorSender;
            ucCMenu.eColorAction += UcCMenu_eColorAction;
        }

        private void UcCMenu_eColorAction(object arg1, Color arg2)
        {
            
        }

        private void UccMenu_eColorSender(object oSender, Color oColor)
        {
            
        }
    }
}
