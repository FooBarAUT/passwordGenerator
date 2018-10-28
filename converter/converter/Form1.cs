using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converter
{
    public partial class Form1 : Form
    {
        public string createPassword(int length, string[] characters)
        {
            StringBuilder result = new StringBuilder();
            Random rand = new Random();
            while (0 < length--)
            {
                result.Append(characters[rand.Next(characters.Length)]);
            }
            return result.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Text = trackBar1.Value.ToString();
            textBox2.Text = "";
            lowercase.Checked = true;
            uppercase.Checked = false;
            numbers.Checked = true;
            symbols.Checked = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            List<string> characters = new List<string>();

            if (!lowercase.Checked && !uppercase.Checked && !numbers.Checked && !symbols.Checked) {
                textBox2.AppendText("Please choose at least one of the above!\n");
            }
            else {
                for(int i =0; i < numericUpDown1.Value; i++) {
                    if (lowercase.Checked)
                    {
                        string[] lower = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
                        foreach (string letter in lower)
                        {
                            characters.Add(letter);
                        }
                    }
                    if (uppercase.Checked)
                    {
                        string[] upper = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
                        foreach (string letter in upper)
                        {
                            characters.Add(letter);
                        }
                    }
                    if (numbers.Checked)
                    {
                        string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
                        foreach (string number in numbers)
                        {
                            characters.Add(number);
                        }
                    }
                    if (symbols.Checked)
                    {
                        string[] symbols = { "!", "?", "#", "$", "%", "(", ")", "/", "&", "=", "_", "-", ".", "+", "*" };
                        foreach (string symbol in symbols)
                        {
                            characters.Add(symbol);
                        }
                    }
                    string[] finalArray = characters.ToArray();

                    string password = createPassword(trackBar1.Value, finalArray);
                    int index = i + 1;

                    textBox2.AppendText(">_  " + password + '\n');
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            lowercase.Checked = true;
            uppercase.Checked = false;
            numbers.Checked = true;
            symbols.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lowercase_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void export_Click(object sender, EventArgs e)
        {
            string timestamp = DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss");
            string filename = "C:\\Users\\wagne\\Desktop\\" + timestamp + ".txt";

            System.IO.StreamWriter streamWriter;
            streamWriter = new System.IO.StreamWriter(filename);

            List<string> characters = new List<string>();

            if (!lowercase.Checked && !uppercase.Checked && !numbers.Checked && !symbols.Checked)
            {
                textBox2.AppendText("Please choose at least one of the above!\n");
            }
            else
            {
                textBox2.Text = "";
                textBox2.AppendText("Exporting ..." + "\n");
                Thread.Sleep(2000);

                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    if (lowercase.Checked)
                    {
                        string[] lower = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
                        foreach (string letter in lower)
                        {
                            characters.Add(letter);
                        }
                    }
                    if (uppercase.Checked)
                    {
                        string[] upper = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
                        foreach (string letter in upper)
                        {
                            characters.Add(letter);
                        }
                    }
                    if (numbers.Checked)
                    {
                        string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
                        foreach (string number in numbers)
                        {
                            characters.Add(number);
                        }
                    }
                    if (symbols.Checked)
                    {
                        string[] symbols = { "!", "?", "#", "$", "%", "(", ")", "/", "&", "=", "_", "-", ".", "+", "*" };
                        foreach (string symbol in symbols)
                        {
                            characters.Add(symbol);
                        }
                    }
                    string[] finalArray = characters.ToArray();

                    string password = createPassword(trackBar1.Value, finalArray);
                    int index = i + 1;

                    streamWriter.WriteLine(">_  " + password);
                }
                streamWriter.Close();
                textBox2.AppendText("Exported sucessfully!");
            }
        }
    }
}
