using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC2100_ICE4_RobertMacklem
{
    public partial class frmMain : Form
    {
        // CONSTANTS
        readonly string[] emojis = { "😍", "😡", "🤦‍♂️", "😎", "👌", "😒", "😘", "😅"};

        // VARIABLES
        List<string> emojiList = new List<string>();

        public frmMain()
        {
            InitializeComponent();
        }
    }
}
