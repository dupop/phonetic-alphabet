﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpelovanjeSlova
{
    public partial class SpelovanjeForma : Form
    {
        string[] AlphabetDictionary;
        public SpelovanjeForma()
        {
            InitializeComponent();
            AlphabetDictionary = File.ReadAllLines("azbuka.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = PoljeZaUnosTeksta.Text;
            StringBuilder spelledOutput = new StringBuilder();

            foreach (char letter in userInput)
            {
                //TODO: naci nazive interpunkcija automatski?
                //TODO: da ima opciju da izgovori sadrzaj klipborda na npr Shift F1 (global hot key)
                //TODO: 

                string appropriateWord = AlphabetDictionary.Where(s => string.Equals(s[0].ToString(), letter.ToString(), StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                if(appropriateWord == null)
                {
                    spelledOutput.Append("nepoznat karakter" + " ");
                }
                else
                {
                    spelledOutput.Append(appropriateWord.Substring(2) + " ");
                }
                
               
                
                
            }

            PoljeZaUnosTeksta.Text = spelledOutput.ToString();
        }


    }
}
