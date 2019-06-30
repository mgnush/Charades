using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Windows.Forms;

namespace Charades_v1._0
{
    public partial class CHARADES : Form
    {

        private XmlDocument itemsDoc;
        private XmlNodeList entries;
        private Random rnd;
        private bool drinkGame;

        public CHARADES()
        {
            InitializeComponent();
            itemsDoc = new XmlDocument();
            itemsDoc.Load("C://Users/Mgnus/source/repos/Charades_v1.0/Charades_v1.0/charades.xml");
            rnd = new Random();
            entries = itemsDoc.SelectNodes("data-set/record");
            drinkGame = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void generate(object sender, EventArgs e)
        {
            int rid = rnd.Next(0, entries.Count);
            XmlNode aNode = entries[rid];
            XmlNode item = aNode.SelectSingleNode(".//Item");
            XmlNode cat = aNode.SelectSingleNode(".//Category");
            textBox1.Text = item.InnerText;
            cattext.Text = "(" + cat.InnerText + ")";
            if (drinkGame)
            {
                XmlNode drinks = aNode.SelectSingleNode(".//Drinks");
                drinkCount.Text = "Sips: " + drinks.InnerText;
            } else
            {
                drinkCount.Text = "";
            }
        }

        private void drinkingMode(object sender, EventArgs e)
        {
            drinkbut.BackColor = System.Drawing.Color.PaleGreen;
            drinkGame = !drinkGame;
            if (drinkGame)
            {
                this.BackColor = System.Drawing.Color.Purple;
            } else
            {
                drinkbut.BackColor = System.Drawing.Color.Red;
                this.BackColor = System.Drawing.Color.White;
            }

        }

    }
}
