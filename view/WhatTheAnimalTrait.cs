using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class WhatTheAnimalTrait : Form
    {
        public string AnimalTrait { get; private set; }

        public WhatTheAnimalTrait(String animalA, String animalB)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.tbAnimalTrait.Select();
            string defaultText = this.lQuestion.Text;
            this.lQuestion.Text = String.Format(defaultText, animalA, animalB);
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            this.AnimalTrait = this.tbAnimalTrait.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void tbAnimalTrait_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.bOK_Click(sender, e);
            }
        }
    }
}
