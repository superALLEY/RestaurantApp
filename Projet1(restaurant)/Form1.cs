namespace Projet1_restaurant_
{
    public partial class Form1 : Form
    {
        private Dictionary<string, double> soupPrices = new Dictionary<string, double>()
        {
            { "Soupe aux légumes", 4.75 },
            { "Soupe aux pois", 4.75 },
            { "Soupe aux gourgane", 4.75 },
            { "Soupe aux boulettes de boeuf", 6.75 },
            { "Potage aux champignons", 4.75 }
        };

        private Dictionary<string, double> entreePrices = new Dictionary<string, double>()
        {
            { "Chaudrée de seiches", 8.75 },
            { "Pétoncles aux basilic", 10.75 },
            { "Tartare aux tomates", 9.75 },
            { "Chaudrée du pêcheur", 9.75 },
            { "Mozzarella aux bacon", 8.75 }
        };

        private Dictionary<string, double> mainPrices = new Dictionary<string, double>()
        {
            { "Spaghettis à la crème de poivrons", 14.75 },
            { "Riz cantonais aux crevettes", 22.75 },
            { "Cari de boeuf massalé", 19.75 },
            { "Tajine de poulet marocain aux légumes", 18.75 },
            { "Cari de dorade au combava", 19.75 }
        };

        private Dictionary<string, double> dessertPrices = new Dictionary<string, double>()
        {
            { "Crème glacée", 5.75 },
            { "Tarte aux pommes", 4.75 },
            { "Choux à la crème", 4.75 },
            { "Dessert au sirop d'érable", 6.75 }
        };

        public Form1()
        {
            InitializeComponent();
            richTextBox3.Text = "Voici les prix réguliers:\r\n\nSoupes:\t$4,50\r\nEntrées :\t$6,75\r\nPlats principaux: $15,75\r\nDesserts:\t$5,00\r\n\n\nEnfants -10% avant taxe\r\nAinées -12% avant taxe\r\nMembre -2%\r\n\n\nTaxe: 5% du total et 9,975% du total";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }

        private void CalculateTotal()
        {
            double total = 0.0;

            if (comboBox1.SelectedItem != null && soupPrices.ContainsKey(comboBox1.SelectedItem.ToString()))
            {
                total += soupPrices[comboBox1.SelectedItem.ToString()];
                richTextBox1.Text += comboBox1.SelectedItem.ToString() + "\n";
            }
            comboBox1.SelectedItem = null;
            if (comboBox2.SelectedItem != null && entreePrices.ContainsKey(comboBox2.SelectedItem.ToString()))
            {
                total += entreePrices[comboBox2.SelectedItem.ToString()];
                richTextBox1.Text += comboBox2.SelectedItem.ToString() + "\n";
            }
            comboBox2.SelectedItem = null;
            if (comboBox3.SelectedItem != null && mainPrices.ContainsKey(comboBox3.SelectedItem.ToString()))
            {
                total += mainPrices[comboBox3.SelectedItem.ToString()];
                richTextBox1.Text += comboBox3.SelectedItem.ToString() + "\n";
            }
            comboBox3.SelectedItem = null;

            if (checkBox1.Checked && dessertPrices.ContainsKey("Crème glacée"))
            {
                total += dessertPrices["Crème glacée"];
                richTextBox1.Text += "Dessert: Crème glacée\n";
            }
            if (checkBox2.Checked && dessertPrices.ContainsKey("Tarte aux pommes"))
            {
                total += dessertPrices["Tarte aux pommes"];
                richTextBox1.Text += "Dessert: Tarte aux pommes\n";
            }
            if (checkBox3.Checked && dessertPrices.ContainsKey("Choux à la crème"))
            {
                total += dessertPrices["Choux à la crème"];
                richTextBox1.Text += "Dessert: Choux à la crème\n";
            }
            if (checkBox4.Checked && dessertPrices.ContainsKey("Dessert au sirop d'érable"))
            {
                total += dessertPrices["Dessert au sirop d'érable"];
                richTextBox1.Text += "Dessert: Dessert au sirop d'érable\n";
            }

            if (radioButton2.Checked)
            {
                total *= 0.90;
                richTextBox1.Text += "Enfant\n";
            }
            else if (radioButton1.Checked)
            {
                richTextBox1.Text += "Adulte\n";
                total *= 0.88;
            }

            if (radioButton4.Checked)
            {
                total *= 0.98;
                richTextBox1.Text += "Membre\n";
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            double tax = total * 0.05 + total * 0.09975;

            richTextBox2.Text = $"Total: {total:C2}\n";
            richTextBox2.Text += $"Tax: {tax:C2}\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
