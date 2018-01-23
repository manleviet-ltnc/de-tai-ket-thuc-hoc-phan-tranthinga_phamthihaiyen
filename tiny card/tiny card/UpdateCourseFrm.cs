using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tiny_card.entity;

namespace tiny_card
{
    public partial class UpdateCourseFrm : Form
    {
        public UpdateCourseFrm()
        {
            InitializeComponent();
        }

        private void btnChoseFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                tbAddPhoto.Text = openFileDialog1.FileName;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            CardList.WriteToFile(tbAddWord.Text, tbAddPhoto.Text, tbAddAlbum.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}