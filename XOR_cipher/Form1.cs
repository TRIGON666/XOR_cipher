using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOR_cipher
{
    public partial class Form1 : Form
    {
        private const string RussianLetters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя0123456789";
        private const string EnglishLetters = "abcdefghijklmnopqrstuvwxyz0123456789";
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

            txtInput.ScrollBars = ScrollBars.Vertical;
            txtBinaryDec.ScrollBars = ScrollBars.Vertical;
            txtBinaryInput.ScrollBars = ScrollBars.Vertical;
            txtCrypto.ScrollBars = ScrollBars.Vertical;
            txtKey.ScrollBars = ScrollBars.Vertical;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtBinaryKey.ScrollBars = ScrollBars.Vertical;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBinaryInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCrypto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBinaryKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBinaryDec_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string text = txtInput.Text.ToLower();
                string key = txtKey.Text.ToLower();
                string alphabet = comboBox1.SelectedItem.ToString() == "Русский" ? RussianLetters : EnglishLetters;

                if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(key))
                    throw new ArgumentException("Текст и ключ не могут быть пустыми!");

                byte[] textBytes = new byte[text.Length];
                byte[] keyBytes = new byte[key.Length];

                for (int i = 0; i < text.Length; i++)
                {
                    int index = alphabet.IndexOf(text[i]);
                    if (index == -1) throw new ArgumentException("Недопустимый символ в тексте");
                    textBytes[i] = (byte)index;
                }

                for (int i = 0; i < key.Length; i++)
                {
                    int index = alphabet.IndexOf(key[i]);
                    if (index == -1) throw new ArgumentException("Недопустимый символ в ключе");
                    keyBytes[i] = (byte)index;
                }

                byte[] cryptoBytes = new byte[textBytes.Length];
                for (int i = 0; i < textBytes.Length; i++)
                {
                    cryptoBytes[i] = (byte)(textBytes[i] ^ keyBytes[i % keyBytes.Length]);
                }

                txtBinaryInput.Text = string.Concat(textBytes.Select(b => Convert.ToString(b, 2).PadLeft(6, '0')));
                txtBinaryKey.Text = string.Concat(keyBytes.Select(b => Convert.ToString(b, 2).PadLeft(6, '0')));
                txtCrypto.Text = string.Concat(cryptoBytes.Select(b => Convert.ToString(b, 2).PadLeft(6, '0')));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string cryptoBits = txtCrypto.Text;
                string key = txtKey.Text.ToLower();
                string alphabet = comboBox1.SelectedItem.ToString() == "Русский" ? RussianLetters : EnglishLetters;

                if (string.IsNullOrEmpty(cryptoBits) || string.IsNullOrEmpty(key))
                    throw new ArgumentException("Криптограмма и ключ не могут быть пустыми!");

                if (cryptoBits.Length % 6 != 0)
                    throw new ArgumentException("Длина криптограммы должна быть кратна 6");

                int blockCount = cryptoBits.Length / 6;
                byte[] cryptoBytes = new byte[blockCount];
                for (int i = 0; i < blockCount; i++)
                {
                    string chunk = cryptoBits.Substring(i * 6, 6);
                    cryptoBytes[i] = Convert.ToByte(chunk, 2);
                }

                byte[] keyBytes = new byte[key.Length];
                for (int i = 0; i < key.Length; i++)
                {
                    int index = alphabet.IndexOf(key[i]);
                    if (index == -1) throw new ArgumentException("Недопустимый символ в ключе");
                    keyBytes[i] = (byte)index;
                }

                byte[] decryptedBytes = new byte[cryptoBytes.Length];
                for (int i = 0; i < cryptoBytes.Length; i++)
                {
                    decryptedBytes[i] = (byte)(cryptoBytes[i] ^ keyBytes[i % keyBytes.Length]);
                }

                StringBuilder output = new StringBuilder();
                for (int i = 0; i < decryptedBytes.Length; i++)
                {
                    if (decryptedBytes[i] >= alphabet.Length)
                        throw new ArgumentException("Ошибка расшифровки");
                    output.Append(alphabet[decryptedBytes[i]]);
                }

                txtBinaryKey.Text = string.Concat(keyBytes.Select(b => Convert.ToString(b, 2).PadLeft(6, '0')));
                txtBinaryDec.Text = string.Concat(decryptedBytes.Select(b => Convert.ToString(b, 2).PadLeft(6, '0')));
                txtOutput.Text = output.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            try
            {
                string text = txtInput.Text.ToLower();
                if (string.IsNullOrEmpty(text))
                    throw new ArgumentException("Сначала введите исходный текст!");

                string alphabet = comboBox1.SelectedItem.ToString() == "Русский" ? RussianLetters : EnglishLetters;
                int bitLength = text.Length * 6;
                int zeroCount = bitLength / 2;
                int oneCount = bitLength / 2;

                char[] bits = new char[bitLength];
                for (int i = 0; i < zeroCount; i++)
                    bits[i] = '0';
                for (int i = zeroCount; i < bitLength; i++)
                    bits[i] = '1';

                Random rand = new Random();
                for (int i = bitLength - 1; i > 0; i--)
                {
                    int j = rand.Next(0, i + 1);
                    char temp = bits[i];
                    bits[i] = bits[j];
                    bits[j] = temp;
                }

                StringBuilder key = new StringBuilder();
                for (int i = 0; i < bitLength; i += 6)
                {
                    string chunk = new string(bits, i, 6);
                    int index = Convert.ToInt32(chunk, 2);
                    if (index >= alphabet.Length) index = rand.Next(0, alphabet.Length);
                    key.Append(alphabet[index]);
                }

                txtKey.Text = key.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
