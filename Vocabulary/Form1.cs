using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocabulary
{
    public partial class Form1 : Form
    {
        private List<string> englishWords = new List<string>();
        private List<string> turkishWords = new List<string>();
        private List<string> dates = new List<string>();
        private List<string> fulldates = new List<string>();
        private Random random = new Random();
        private Button[] answerButtons;
        private string currentEnglishWord;
        private string correctTurkishTranslation;
        private List<string> filteredEnglishWords = new List<string>();
        private List<string> filteredTurkishWords = new List<string>();
        int doğru = 0;
        int yanlış = 0;
        int ToplamSayı = -1;
        public Form1()
        {
            InitializeComponent();
            InitializeWordLists();
            answerButtons = new Button[] { button1, button2, button3, button4 };
            ctarih.DataSource = dates;
            ShowRandomWord();
        }
        private void InitializeWordLists()
        {
            //Burada englishWords ve turkishWords listelerini doldurun.
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kande\OneDrive\Masaüstü\Vocabulary.xlsx; Extended Properties='Excel 12.0 xml;HDR=YES;'");
            OleDbCommand cmd = new OleDbCommand("Select * from [Sayfa1$]", con);
            con.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string englishWord = reader["İNGİLİZCE"].ToString();
                string turkishWord = reader["TÜRKÇE"].ToString();
                string tarih = reader["TARİH"].ToString();
                string[] x = tarih.Split(' ');
                string düzgüntarih = x[0]; // İlk kelimeyi al

                if (!string.IsNullOrEmpty(englishWord) && !string.IsNullOrEmpty(turkishWord))
                {
                    englishWords.Add(englishWord);
                    turkishWords.Add(turkishWord);
                    fulldates.Add(düzgüntarih);
                    if (!dates.Contains("All"))
                    {
                        dates.Add("All");
                    }
                    if (!dates.Contains(düzgüntarih))
                    {
                        dates.Add(düzgüntarih);
                    }
                }
            }

        }
        private void ShowRandomWord()
        {
                int randomIndex = random.Next(filteredEnglishWords.Count);
                currentEnglishWord = filteredEnglishWords[randomIndex];
                correctTurkishTranslation = filteredTurkishWords[randomIndex];

                Soru.Text = currentEnglishWord;

                // Sadece doğru çevabı bir butona yerleştirin
                int correctButtonIndex = random.Next(answerButtons.Length);
                answerButtons[correctButtonIndex].Text = correctTurkishTranslation;

                // Diğer butonlara farklı cevapları yerleştirin
                for (int i = 0; i < answerButtons.Length; i++)
                {
                    if (i != correctButtonIndex)
                    {
                        string incorrectTranslation = GetRandomIncorrectTranslation();
                        answerButtons[i].Text = incorrectTranslation;
                    }
                }
                ToplamSayı++;
                ToplamSoru.Text = ToplamSayı.ToString();
            
        }
        private string GetRandomIncorrectTranslation()
        {
            string randomIncorrectTranslation;
            do
            {
                int randomIndex = random.Next(filteredTurkishWords.Count);
                randomIncorrectTranslation = filteredTurkishWords[randomIndex];
            } while (randomIncorrectTranslation == correctTurkishTranslation);

            return randomIncorrectTranslation;
        }

        private async void CheckAnswer(object sender, EventArgs e)
        {

            Button clickedButton = sender as Button;
            int correctButtonIndex = Array.IndexOf(answerButtons, Array.Find(answerButtons, btn => btn.Text == correctTurkishTranslation));

            if (clickedButton.Text == correctTurkishTranslation)
            {
                clickedButton.BackColor = Color.Green;
                clickedButton.FlatAppearance.BorderColor = Color.Green;
                await Task.Delay(150);
                doğru++;
                Doğru.Text = doğru.ToString();
                clickedButton.BackColor = Color.White;
                clickedButton.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                clickedButton.BackColor = Color.Red;
                clickedButton.FlatAppearance.BorderColor = Color.Red;
                answerButtons[correctButtonIndex].BackColor = Color.Green;
                answerButtons[correctButtonIndex].FlatAppearance.BorderColor = Color.Green;
                await Task.Delay(500);
                yanlış++;
                Yanlış.Text = yanlış.ToString();
                clickedButton.BackColor = Color.White;
                clickedButton.FlatAppearance.BorderColor = Color.White;
                answerButtons[correctButtonIndex].BackColor = Color.White;
                answerButtons[correctButtonIndex].FlatAppearance.BorderColor = Color.White;
            }

            ShowRandomWord();
        }
        private void ctarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            answerButtons = new Button[] { button1, button2, button3, button4 };
            string selectedDate = ctarih.SelectedItem.ToString();
            filteredEnglishWords.Clear();
            filteredTurkishWords.Clear();

            if (selectedDate == "All")
            {
                filteredEnglishWords = englishWords.ToList(); // englishWords'in kopyasını al
                filteredTurkishWords = turkishWords.ToList(); // turkishWords'ün kopyasını al
            }
            else
            {
                for (int i = 0; i < fulldates.Count; i++)
                {
                    if (fulldates[i] == selectedDate)
                    {
                        filteredEnglishWords.Add(englishWords[i]);
                        filteredTurkishWords.Add(turkishWords[i]);
                    }
                }
            }
            ToplamSayı--;
            ShowRandomWord();
        }
    }
}