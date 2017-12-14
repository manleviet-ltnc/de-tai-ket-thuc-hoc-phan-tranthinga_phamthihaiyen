using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiny_card
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        String albumName = "";
        private void cmbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            albumName = cmbAlbum.SelectedItem.ToString();
        }
        

        private void btnHoc_Click(object sender, EventArgs e)
        {
            if (!albumName.Equals(""))
            {
                frm1 frm = new frm1(albumName);
                frm.Show();
            }

        }
    }
}
