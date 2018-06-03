using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kriptoloji
{
    public partial class b : Form
    {
        string key = "CHİPPER";
        string trAlphabet = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
        string engAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string chipperText;
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        string portaTableName;

        public b()
        {
            InitializeComponent();
        }
          

        private void metinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (metinTextBox.Text.Length > 50 || char.IsNumber(e.KeyChar) || char.IsUpper(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != string.Empty)
            {

                if (trRadioBtn.Checked == true)
                {
                    chipperText = VigenereEncrypt(metinTextBox.Text, key, trAlphabet);

                }
                else if (engRadioBtn.Checked == true)
                {
                    chipperText = VigenereEncrypt(metinTextBox.Text, key, engAlphabet);

                }
                else
                    MessageBox.Show("Dil Hatası");
                int kolon = Convert.ToInt32(comboBox1.Text);
                mesajLabel.Text = String.Empty;
                sifreliMesajLabel.Text = String.Empty;
                char[] chipperChar = chipperText.ToCharArray();
                char[] charChipper = new char[kolon * kolon];
                chipperChar.CopyTo(charChipper, 0);
                char[] metinChar = metinTextBox.Text.ToCharArray();
                char[] charMetin = new char[kolon * kolon];
                metinChar.CopyTo(charMetin, 0);
                if (chipperChar.Length < kolon * kolon)
                {
                    for (int l = chipperChar.Length; l < kolon * kolon; l++)
                        charChipper[l] = 'X';
                }
                if (metinChar.Length < kolon * kolon)
                {
                    for (int k = metinChar.Length; k < kolon * kolon; k++)
                    {
                        charMetin[k] = 'X';
                    }
                }

                for (int i = 0; i < kolon; i++)
                {

                    for (int j = 0; j < kolon; j++)
                    {

                        int degis = (kolon * kolon) - (kolon * (j + 1)) + i;
                        mesajLabel.Text += charMetin[degis].ToString().ToUpper();


                    }
                    mesajLabel.Text += " \n";
                }
                MessageBox.Show(chipperText);
                char[,] cokBoyDizi = new char[kolon, kolon];
                for (int j = 0; j < charChipper.Length; j++) {

                    for (int i = 0; i < kolon; i++)
                    {
                        cokBoyDizi[i, kolon - i] = charChipper[j];
                    }
                }
                // diziye ulaşmak için
                for (int row = 0; row < cokBoyDizi.GetLength(0); row++)
                {
                    for (int col = 0; col < cokBoyDizi.GetLength(1); col++)
                    {

                        MessageBox.Show(cokBoyDizi[row, col].ToString());
                    }
                }
            }
            else
                MessageBox.Show("Sütun sayısını seçiniz.");
        }


        private static string VigenereEncrypt(string s, string key, string alphabet)
        {
            s = s.ToUpper();
            key = key.ToUpper();
            int j = 0;
            StringBuilder ret = new StringBuilder(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                if (alphabet.Contains(s[i]))
                    ret.Append(alphabet[(alphabet.IndexOf(s[i]) + alphabet.IndexOf(key[j])) % alphabet.Length]);
                else
                    ret.Append(s[i]);
                j = (j + 1) % key.Length;
            }
            return ret.ToString();
        }


        private void clearBtn_Click(object sender, EventArgs e)
        {
            metinTextBox.Clear();
            mesajLabel.Text = "B2 Mesaj İçeriği";
            sifreliMesajLabel.Text ="E3 Şifreli Mesaj";
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            Form1 mainfrm = new Form1();
            mainfrm.Show();
            this.Hide();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
             int deger =Convert.ToInt32(Math.Sqrt(metinTextBox.Text.Length));
            string son;
             for (int i=1; i<= deger; i++)
             {
                son = i.ToString();
                 comboBox1.Items.Remove(son);
            }

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }

        private void portaMetinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (metinTextBox.Text.Length > 50 || char.IsNumber(e.KeyChar) || char.IsUpper(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;

        }

        private void portaMainBtn_Click(object sender, EventArgs e)
        {
            Form1 mainfrm = new Form1();
            mainfrm.Show();
            this.Hide();

        }

        private void portaTemizleBtn_Click(object sender, EventArgs e)
        {
            portaMetinTextBox.Clear();
            portaChipperLabel.Text = string.Empty;
            portaChipperLabel.Text = "POrta Şifrelemesi Sonucu";
        }

        private void portaSifreleBtn_Click(object sender, EventArgs e)
        {
            String deger="";
            if (portaMetinTextBox.Text.Length % 2 == 0)
            {
                char[] metin = portaMetinTextBox.Text.ToCharArray();
                if (trRadioBtn.Checked == true)
                {
                    portaTableName = "trPorta";
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ozzmhmt\\source\\repos\\Kriptoloji\\trPorta.accdb");
                    con.Open();

                }
                else if (engRadioBtn.Checked == true)
                {
                    portaTableName = "engPorta";
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ozzmhmt\\source\\repos\\Kriptoloji\\engPorta.accdb");
                    con.Open();
                }
                else
                    MessageBox.Show("Dil Hatası");
                for (int i = 0; i < metin.Length; i = i + 2)
                {

                    cmd = new OleDbCommand("SELECT " + metin[i] + " FROM " + portaTableName + " WHERE KEY='" + metin[i + 1] + "'", con);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count != 0)
                    {
                        OleDbDataReader dataRead = cmd.ExecuteReader();
                        while (dataRead.Read())
                        {
                            string mes =dataRead[0].ToString();

                            deger = deger + mes.PadLeft(4,'0');
                           // MessageBox.Show(mes.ToString());
                        }
                    }
                    
                }con.Close();
                    portaChipperLabel.Text = deger;
            }
            else
                MessageBox.Show("Lütfen çift sayısa harf giriniz.");
            
        }
    }
}
