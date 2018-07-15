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
    public partial class WhatTheAnimal : Form
    {
        public string AnimalName { get; private set; }

        public WhatTheAnimal()
        {
            InitializeComponent();
            this.tbAnimalName.Select();
            this.CenterToScreen();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            this.AnimalName = this.tbAnimalName.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void tbAnimalName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.bOK_Click(sender, e);
            }
        }
    }
}
