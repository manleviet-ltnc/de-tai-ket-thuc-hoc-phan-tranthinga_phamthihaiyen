using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tiny_card.entity;

namespace tiny_card
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            foreach(string album in CardList.GetAllAlbumFolder())
            {
                cmbAlbum.Items.Add(album);
            }
        }

        String albumName = "";
        List<Card> cardList;

        private void cmbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            albumName = cmbAlbum.SelectedItem.ToString();
            cardList = CardList.ReadFromFile(albumName);
            showGrid(cardList);
        }
        
        private void showGrid(List<Card> cardList)
        {
            dataGridView1.Rows.Clear();
            foreach(Card card in cardList)
                dataGridView1.Rows.Add(card.Word, card.Path);
        }

        private void btnHoc_Click(object sender, EventArgs e)
        {
            if (!albumName.Equals(""))
            {
                frm1 frm = new frm1(albumName);
                frm.Show();
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddAlbumFrm frm = new AddAlbumFrm();
            frm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UpdateCourseFrm frm = new UpdateCourseFrm();
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 0)
            {
                int i = dataGridView1.SelectedCells[0].RowIndex;
                string word = dataGridView1.Rows[i].Cells[0].Value.ToString();
                string photo = dataGridView1.Rows[i].Cells[1].Value.ToString();
                CardList.DeleteCard(word, photo, albumName);
                dataGridView1.Rows.RemoveAt(i);
            }
                
        }
    }
}
