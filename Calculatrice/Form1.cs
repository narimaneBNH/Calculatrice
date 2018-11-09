using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chiffre0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void chiffre4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void chiffre5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void chiffre7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void chiffre8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void chiffre9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
          
        }

        private void somme_Click(object sender, EventArgs e)
        {
            textBox1.Text += " + ";
        }

        private void soustraction_Click(object sender, EventArgs e)
        {
            textBox1.Text += " - ";
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            textBox1.Text += " * ";
        }

        private void division_Click(object sender, EventArgs e)
        {
            textBox1.Text += " / ";
        }

        private void egale_Click(object sender, EventArgs e)
        {
            int resultat = 0;

            //recuperer la valeur de la textbox
            string data = textBox1.Text;
            string[] cal = data.Split(' '); //mettre des espaces sur les opérateurs pour quye ça marche!
            string[] operateur = { "+", "-", "*", "/" };

            //parser les valeurs
           // bool test = operateur.Contains("+");

            if (string.IsNullOrEmpty(cal[0]) || string.IsNullOrEmpty(cal[2]))
            { 
                    MessageBoxButtons buttons1 = MessageBoxButtons.OK;
               
                    string message1 = "La calculatrice ne fonctionne pas comme ça!!!!!";
                  //  MessageBox.Show(message1, "Erreur!!", buttons1);
                    DialogResult d = MessageBox.Show(message1, "Erreur!!", MessageBoxButtons.OK);
                if (d == DialogResult.OK)
                {
                    textBox1.Clear();
                         
                }

            }
            
                int a;
                int b = 0; ;
                int.TryParse(cal[0], out a);
                int.TryParse(cal[2], out b);
                
                //verifie le symbole dans la chaine
                //bool test = cal.Contains("+");
                switch (cal[1])
                {
                    case "+":
                        resultat = a + b;
                        break;
                    case "-":
                        resultat = a - b;
                        break;
                    case "*":
                        resultat = a * b;
                        break;
                    case "/":
                        {
                            if (b != 0)
                            {
                                resultat = a / b;
                                break;
                            }
                            else
                            {
                            
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                string message = "division /0 est inaccessible!!";
                                MessageBox.Show(message, "Erreur!!", buttons);

                                break;
                            }
                        }
                
            }
           
            
            string calResult = Convert.ToString(resultat);       
            textBox1.Text = calResult;
            Console.WriteLine(textBox1.Text);
            //split la chaine pour recup les deux cote de la chaine
            // y.Split();
            //Convertir les deux chaines de caractere en int/decim
            //tu les passe en argument a une potentiellle methode addition
            // gerer le return dans la textbox
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
