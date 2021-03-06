﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using tiny_card.entity;

namespace tiny_card
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        List<Card> cardList;
        DataGridView dataGridView1;
        int stage = 0;
        int remainCard = 0;
        int maxStage = 0;
        int minStage = 0;

        public frm1(String albumName, DataGridView dataGridView1)
        {
            InitializeComponent();
            this.dataGridView1 = dataGridView1;
            cardList = CardList.ReadFromFile(albumName);
        }

        private void frm1_Load(object sender, EventArgs e)
        {
            initiateStage();

            maxStage = cardList.Count - 1;
            remainCard = cardList.Count;
        }

        private void initiateStage()
        {
            int currentIndex = this.dataGridView1.CurrentRow.Index;

            lblCard1.Text = cardList[currentIndex].Word;
           
            picBox1.Image = Image.FromFile(cardList[currentIndex].Path);
           
        }

        private void nextStage(int i)
        {
            ChangeCard(lblCard1, picBox1, i + 0);
            
        }

        private void backStage(int i)
        {
            ChangeCard(lblCard1, picBox1, i - 0);
            
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

        bool kt = true;
        private object dataGriView1;

        private void picBox1_Click(object sender, EventArgs e)
        { 
            if (kt)
            {
                lblCard1.Show();
                picBox1.Hide();
            }
            else
            {
                lblCard1.Hide();
                picBox1.Show();
            }
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

        private void lblCard1_Click(object sender, EventArgs e)
        {
            if (kt)
            {
                lblCard1.Hide();
                picBox1.Show();
            }
            else
            {
                lblCard1.Show();
                picBox1.Hide();
                
            }
        }
    }
}
