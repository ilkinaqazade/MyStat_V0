using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStat
{
    public partial class UserControl1 : UserControl
    {

        public string FullName
        {
            get { return nameLbl.Text; }
            set { nameLbl.Text = value; }
        }
        public Image image
        {
            get { return stundetImagePbox.Image; }
            set { stundetImagePbox.Image = value; }
        }
    }

    
}
