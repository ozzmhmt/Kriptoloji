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
using Microsoft.Office.Interop.Excel;

namespace Kriptoloji
{
    public partial class DesifreFrm : Form
    {
        string key = "CHİPPER";
        string trAlphabet = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
        string engAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string alfabe;
        string chipperText;
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        string portaTableName;
        public DesifreFrm()
        {
            InitializeComponent();
        }
      
        private void desifreMetinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (desifreMetinTextBox.Text.Length > 50 || char.IsNumber(e.KeyChar) || char.IsUpper(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void desifreClearBtn_Click(object sender, EventArgs e)
        {
            desifreMetinTextBox.Clear();
            desifreMesajLabel.Text = "Deşifre Edilen Mesaj";
        }

        private void desfireMainBtn_Click(object sender, EventArgs e)
        {
            Form1 mainfrm = new Form1();
            mainfrm.Show();
            this.Hide();
        }

        private static string VigenereDecrypt(string s, string key, string alphabet)
        {
            s = s.ToUpper();
            key = key.ToUpper();
            int j = 0;
            StringBuilder ret = new StringBuilder(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                if (alphabet.Contains(s[i]))
                    ret.Append(alphabet[(alphabet.IndexOf(s[i]) - alphabet.IndexOf(key[j]) + alphabet.Length) % alphabet.Length]);
                else
                    ret.Append(s[i]);
                j = (j + 1) % key.Length;
            }
            return ret.ToString();
        }

        private void desifreComboBox_Click(object sender, EventArgs e)
        {
            desifreComboBox.DroppedDown = true;
        }

        private void desifreComboBox_DropDown(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(Math.Sqrt(desifreMetinTextBox.Text.Length));
            string son;
            for (int i = 1; i <= deger; i++)
            {
                son = i.ToString();
                desifreComboBox.Items.Remove(son);
            }
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {

        }

        private void portaDesifreMetinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void portaDesifreTemizleBtn_Click(object sender, EventArgs e)
        {
            portaDesifreMetinTextBox.Clear();
            portaDesifreLabel.Text = "DeşifreEdilen Mesaj...";
        }

        private void portaDesifreMainBtn_Click(object sender, EventArgs e)
        {
            Form1 mainfrm = new Form1();
            mainfrm.Show();
            this.Hide();

        }

        private void portaDesifreBtn_Click(object sender, EventArgs e)
        {
            String deger="";
            if (portaDesifreMetinTextBox.Text.Length % 4 == 0)
            {
                char[] metin = portaDesifreMetinTextBox.Text.ToCharArray();
                if (portaDesifreTrRadioBtn.Checked == true)
                {
                    alfabe = trAlphabet;
                    portaTableName = "trPorta";
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ozzmhmt\\source\\repos\\Kriptoloji\\trPorta.accdb");
                   // con.Open();
                   
                }
                else if (portaDesifreEngRadioBtn.Checked == true)
                {
                    alfabe = engAlphabet;
                    portaTableName = "engPorta";
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ozzmhmt\\source\\repos\\Kriptoloji\\engPorta.accdb");
                    //con.Open();
                    
                }
                else
                    MessageBox.Show("Dil Seçimi Hatalı");
                char[] alfabeChar = alfabe.ToCharArray();
                for(int k = 0; k < metin.Length; k=k+4)
                {
                    string sayi = metin[k].ToString() + metin[k + 1].ToString() + metin[k + 2].ToString() + metin[k + 3].ToString();
                for(int i = 0; i < alfabeChar.Length; i++)
                {
                        con.Open();
                    for(int j = 0; j < alfabeChar.Length; j++)
                    {
                            cmd = new OleDbCommand("SELECT "+alfabeChar[i]+" FROM "+portaTableName+" WHERE KEY='"+alfabeChar[j]+"'", con);
                           
                            int count = Convert.ToInt32(cmd.ExecuteScalar());
                            if (count != 0)
                            {
                                OleDbDataReader dataRead = cmd.ExecuteReader();
                                while (dataRead.Read())
                                {
                                    string mes = dataRead[0].ToString();
                                    if(sayi==mes.PadLeft(4,'0'))
                                        deger = deger + alfabeChar[i].ToString()+alfabeChar[j].ToString();
                                  
                                }
                            }
                        }con.Close();
                }
                }
                    portaDesifreLabel.Text = deger;
            }
            else
                MessageBox.Show("Eksik Karakter Bulunmakta Lütfen Kontrol Ediniz..");

        }
    }
}
