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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Card> cardList;
        private void Form1_Load(object sender, EventArgs e)
        {
            cardList = CardList.ReadFromFile();

            lblCard1.Text = cardList[0].Word;
            picBox1.Image = Image.FromFile(cardList[0].Path);

        }

        private void picBox1_Click(object sender, EventArgs e)
        {
            picBox1.Hide();
        }

        private void picBox2_Click(object sender, EventArgs e)
        {
            picBox2.Hide();
        }

        private void picBox3_Click(object sender, EventArgs e)
        {
            picBox3.Hide();
        }

        private void picBox4_Click(object sender, EventArgs e)
        {
            picBox4.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
