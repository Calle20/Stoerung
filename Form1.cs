using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Störung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog.Filter = "txt-Files|*.txt";
        }
        public List<string> book { get; set; }
        private void btnOpenBook_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                book=Regex.Replace(File.ReadAllText(openFileDialog.FileName), @"[^0-9a-zA-Z ä ü ö ß ']", " ").Split(' ').ToList();
                book.RemoveAll(str => string.IsNullOrEmpty(str));
                txtBoxBook.Text = Path.GetFileName(openFileDialog.FileName).Replace(".txt","");
            }
        }
        private void btnOpenSentence_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> foundedSentences=new List<string>();
                List<string> sentence = File.ReadAllText(openFileDialog.FileName).Split(' ').ToList();
                for(int i = 0; i < book.Count; i++)
                {
                    int sentenceCount = 0;
                    string [] tempSentence = new string[sentence.Count];
                    sentence.CopyTo(tempSentence);
                    while (sentence[sentenceCount].ToLower() == book[i].ToLower() || sentence[sentenceCount]=="_")
                    {
                        if (sentence[sentenceCount] == "_")
                        {
                            tempSentence[sentenceCount] = book[i].ToLower();
                        }
                        i++;
                        sentenceCount++;
                        if (sentenceCount == sentence.Count)
                        {
                            foundedSentences.Add(string.Join(" ",tempSentence));
                            break;
                        }
                    }
                }
                if (foundedSentences.Count == 0)
                {
                    foundedSentences.Add("Keinen Satz gefunden!");
                }
                listBox.DataSource = foundedSentences;
            }
        }
    }
}
