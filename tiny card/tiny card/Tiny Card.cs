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
        int stage = 0;
        int remainCard = 0;
        int maxStage;
        int minStage = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            cardList = CardList.ReadFromFile();

            initiateStage();
            
            maxStage = cardList.Count / 4;
            remainCard = cardList.Count % 4;
        }

        private void initiateStage()
        {
            lblCard1.Text = cardList[0].Word;
            lblCard2.Text = cardList[1].Word;
            lblCard3.Text = cardList[2].Word;
            lblCard4.Text = cardList[3].Word;
            picBox1.Image = Image.FromFile(cardList[0].Path);
            picBox2.Image = Image.FromFile(cardList[1].Path);
            picBox3.Image = Image.FromFile(cardList[2].Path);
            picBox4.Image = Image.FromFile(cardList[3].Path);
        }

        private void nextStage(int i)
        {
            ChangeCard(lblCard1, picBox1, i*4 + 0);
            ChangeCard(lblCard2, picBox2, i*4 + 1);
            ChangeCard(lblCard3, picBox3, i*4 + 2);
            ChangeCard(lblCard4, picBox4, i*4 + 3);
        }

        private void backStage(int i)
        {
            ChangeCard(lblCard1, picBox1, i*4 - 0);
            ChangeCard(lblCard2, picBox2, i*4 - 1);
            ChangeCard(lblCard3, picBox3, i*4 - 2);
            ChangeCard(lblCard4, picBox4, i*4 - 3);
        }

        private void ChangeCard(Label label, PictureBox picBox, int i)
        {
            if (i >= 0 &&  i < cardList.Count)
            {
                picBox.Image = Image.FromFile(cardList[i].Path);
                label.Text = cardList[i].Word;
            }
            else
            {
                label.Text = "?";
                picBox.Image = picBox.InitialImage;
            }
            picBox.Show();
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
            if (stage < maxStage)
            {
                stage = stage + 1;
                nextStage(stage);
                txtStage.Text = stage.ToString();
            } 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(stage > minStage)
            {
                stage = stage - 1;
                backStage(stage);
                txtStage.Text = stage.ToString();
            }
            if (stage == minStage)
            {
                initiateStage();
                txtStage.Text = stage.ToString();
            }
        }
    }
}
