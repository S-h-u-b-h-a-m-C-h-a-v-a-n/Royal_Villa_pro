using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VILL_s_Managment_Rent_System
{
    public partial class FRM_Home : Form
    {
        public FRM_Home()
        {
            InitializeComponent();
            PNL_SEARCH.BringToFront();
            PNL_SEARCH.Parent = pictureBox2;
        }

        private void FRM_Home_Load(object sender, EventArgs e)
        {
            IconOffer1.Location = new Point(UserIcon1.Location.X-IconOffer1.Width -75,20);
            IconCity1.Location = new Point(IconOffer1.Location.X - IconCity1.Width - 50, 20);
            lbl1.Parent = pictureBox2;
            PNL_SEARCH.Location = new Point((pictureBox2.Size.Width/2)-(PNL_SEARCH.Size.Width/2),pictureBox2.Location.Y + pictureBox2.Size.Height - 175 - PNL_SEARCH.Size.Height);

        }

      
    }
}
