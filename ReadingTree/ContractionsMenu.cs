﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingTree
{
    public partial class ContractionsMenu : Form
    {
        public ContractionsMenu()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            Close();
        }

        private void btnTch_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }

        private void btnContractionsNonPhonetic_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }

        private void buttonContractionsPhonetic_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form previous = History.GetPrev();
            previous.Show();
            Close();
        }
    }
}
