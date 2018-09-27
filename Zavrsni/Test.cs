using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavrsni
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
       
        public string ime;
        public int tocno;
        public int netocno;
        public int brojac;
        public int ocjena;
        private void Test_Load(object sender, EventArgs e)
        {
            BackColor = Color.Lavender;
            if (ime == null)
            {
                MessageBox.Show("Please choose a subject!");
                this.Close();
            }
            label6.Text = "Welcome to test from " + ime;
            brojac = 0;
            
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            brojac = brojac + 1;
            button1.Text = "Next";
           
         
            if (brojac > 10)
            {
                if (tocno <5)
                {
                    ocjena = 1;
                }
                if (tocno>4 && tocno <7)
                {
                    ocjena = 2;
                }
                if (tocno > 6 && tocno < 9)
                {
                    ocjena = 3;
                }
                if (tocno > 8 && tocno < 10)
                {
                    ocjena = 4;
                }
                if (tocno >9)
                {
                    ocjena = 5;
                }
                MessageBox.Show("You have " + tocno + " correct answers and  " + netocno + " uncorrect! Your grade is: " + ocjena);
               
                this.Close();
            }
            if (ime == "Mathematics")
            {
                BackColor = Color.PowderBlue;
                List<string> odg = new List<string>();
                odg.Add("10");
                odg.Add("16");
                odg.Add("18");
                odg.Add("36");
                Pitanja P = new Pitanja("The value of x + x(xx) when x = 2 is:", "10", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("broke even");
                odg.Add("lost 4 cents");
                odg.Add("gained 4 cents");
                odg.Add("lost 10 cents");
                P = new Pitanja("Mr. Jones sold two pipes at $1.20 each. Based on the cost, his profit one was 20% and his loss on the other was 20%. On the sale of the pipes, he:", "broke even", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("587 × 108 miles");
                odg.Add("587 × 1010 miles");
                odg.Add("587 × 10-10 miles");
                odg.Add("587 × 1012 miles");
                P = new Pitanja("The distance light travels in one year is approximately 5,870,000,000,000 miles. The distance light travels in 100 years is:", "587 × 1012 miles", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("three times as much");
                odg.Add("twice as much");
                odg.Add("the same");
                odg.Add("half as much");
                P = new Pitanja("Jones covered a distance of 50 miles on his first trip. On a later trip he traveled 300 miles while going three times as fast. His new time compared with the old time was:", "twice as much", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("20");
                odg.Add("4");
                odg.Add("0.4");
                odg.Add("0.04");
                P = new Pitanja("20 % of 2 is equal to:", "0.4", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("-10.0");
                odg.Add("-0.5");
                odg.Add("-0.4");
                odg.Add("-0.2");
                P = new Pitanja("If (0.2)x = 2 and log 2 = 0.3010, then the value of x to the nearest tenth is:", "-0.4", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("-1/5");
                odg.Add("1/50");
                odg.Add("1/25");
                odg.Add("1/5");
                P = new Pitanja("If 102y = 25, then 10-y equals:", "1/5", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("15");
                odg.Add("20");
                odg.Add("30");
                odg.Add("32");
                P = new Pitanja("The sum of three numbers is 98. The ratio of the first to the second is 2/3, and the ratio of the second to the third is 5/8. The second number is:", "30", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("100");
                odg.Add("101");
                odg.Add("111");
                odg.Add("999");
                P = new Pitanja("What is the smallest three digit number?", "100", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("6.4 %");
                odg.Add("6.3 ");
                odg.Add("6.1 ");
                odg.Add("6.2 ");
                P = new Pitanja("A man has $ 10,000 to invest. He invests $ 4000 at 5 % and $ 3500 at 4 %. In order to have a yearly income of $ 500, he must invest the remainder at:", "6.4 %", odg);
                lista.Add(P);

                label7.Visible = true;
                label5.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                button2.Visible = true;
                label7.Text = brojac.ToString() + ". question:";
                label5.Text = lista[brojac - 1].Pitanje;
                radioButton1.Text = lista[brojac - 1].Odgovori[0];
                radioButton2.Text = lista[brojac - 1].Odgovori[1];
                radioButton3.Text = lista[brojac - 1].Odgovori[2];
                radioButton4.Text = lista[brojac- 1].Odgovori[3];


               

            }
            if (ime == "Physics")
            {
                BackColor = Color.RosyBrown;
                List<string> odg = new List<string>();
                odg.Add("collision between fast neutrons and nitrogen nuclei present in the atmosphere");
                odg.Add("action of ultraviolet light from the sun on atmospheric oxygen");
                odg.Add("action of solar radiations particularly cosmic rays on carbon dioxide present in the atmosphere");
                odg.Add("lightning discharge in atmosphere");
                Pitanja P = new Pitanja("Radiocarbon is produced in the atmosphere as a result of", "collision between fast neutrons and nitrogen nuclei present in the atmosphere", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("work done in rolling is more than in lifting");
                odg.Add("work done in lifting the stone is equal to rolling it");
                odg.Add("work done in both is same but the rate of doing work is less in rolling");
                odg.Add("work done in rolling a stone is less than in lifting it");
                P = new Pitanja("It is easier to roll a stone up a sloping road than to lift it vertical upwards because", "work done in rolling a stone is less than in lifting it", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("viscosity of ink");
                odg.Add("capillary action phenomenon");
                odg.Add("diffusion of ink through the blotting");
                odg.Add("siphon action");
                P = new Pitanja("The absorption of ink by blotting paper involves", "capillary action phenomenon", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("Siphon will fail to work if");
                odg.Add("the level of the liquid in the two vessels are at the same height");
                odg.Add("both its limbs are of unequal length");
                odg.Add("the temperature of the liquids in the two vessels are the same");
                P = new Pitanja("Siphon will fail to work if", "the level of the liquid in the two vessels are at the same height", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("the heating effect of current alone");
                odg.Add("hysteresis loss alone");
                odg.Add("both the heating effect of current and hysteresis loss");
                odg.Add("intense sunlight at noon");
                P = new Pitanja("Large transformers, when used for some time, become very hot and are cooled by circulating oil.The heating of the transformer is due to", "both the heating effect of current and hysteresis loss", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("Fermi");
                odg.Add("angstrom");
                odg.Add("newton");
                odg.Add("tesla");
                P = new Pitanja("Nuclear sizes are expressed in a unit named", "Fermi", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("time");
                odg.Add("distance");
                odg.Add("light");
                odg.Add("intensity of light");
                P = new Pitanja("Light year is a unit of", "distance", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("2 minutes");
                odg.Add("4 minutes");
                odg.Add("8 minutes");
                odg.Add("16 minutes");
                P = new Pitanja("Light from the Sun reaches us in nearly", "8 minutes", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("all stars move from east to west");
                odg.Add("the earth rotates from west to east");
                odg.Add("the earth rotates from east to west");
                odg.Add("the background of the stars moves from west to east");
                P = new Pitanja("Stars appears to move from east to west because", "the earth rotates from west to east", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("thrust");
                odg.Add("pressure");
                odg.Add("frequency");
                odg.Add("conductivity");
                P = new Pitanja("Pa(Pascal) is the unit for", "pressure", odg);
                lista.Add(P);
                label7.Visible = true;
                label5.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                button2.Visible = true;
                label7.Text = brojac.ToString() + ". question:";
                label5.Text = lista[brojac - 1].Pitanje;
                radioButton1.Text = lista[brojac - 1].Odgovori[0];
                radioButton2.Text = lista[brojac - 1].Odgovori[1];
                radioButton3.Text = lista[brojac - 1].Odgovori[2];
                radioButton4.Text = lista[brojac - 1].Odgovori[3];
            }

            if (ime == "Biology")
            {
                BackColor = Color.LightCyan;
                List<string> odg = new List<string>();
                odg.Add("Potassium chloride");
                odg.Add("Potassium carbonate");
                odg.Add("Potassium hydroxide");
                odg.Add("Sodium bicarbonate");
                Pitanja P = new Pitanja("Ordinary table salt is sodium chloride. What is baking soda?", "Sodium bicarbonate", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("hole in ozone layer");
                odg.Add("decrease in the ozone layer in troposphere");
                odg.Add("decrease in thickness of ozone layer in stratosphere");
                odg.Add("increase in the thickness of ozone layer in troposphere");
                P = new Pitanja("Ozone hole refers to", "decrease in thickness of ozone layer in stratosphere", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("angiosperms");
                odg.Add("gymnosperms");
                odg.Add("monocotyledons");
                odg.Add("dicotyledons");
                P = new Pitanja("Pine, fir, spruce, cedar, larch and cypress are the famous timber-yielding plants of which several also occur widely in the hilly regions of India. All these belong to", "gymnosperms", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("transfer of pollen from anther to stigma");
                odg.Add("germination of pollen grains");
                odg.Add("growth of pollen tube in ovule");
                odg.Add("visiting flowers by insects");
                P = new Pitanja("Pollination is best defined as", "transfer of pollen from anther to stigma", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("soil");
                odg.Add("chlorophyll");
                odg.Add("atmosphere");
                odg.Add("light");
                P = new Pitanja("Plants receive their nutrients mainly from", "soil", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("osmosis");
                odg.Add("active transport");
                odg.Add("diffusion");
                odg.Add("passive transport");
                P = new Pitanja("Movement of cell against concentration gradient is called", "active transport", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("Leaf and other chloroplast bearing parts");
                odg.Add("stem and leaf");
                odg.Add("Roots and chloroplast bearing parts");
                odg.Add("Bark and leaf");
                P = new Pitanja("Photosynthesis generally takes place in which parts of the plant ? ", "Leaf and other chloroplast bearing parts", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("starch");
                odg.Add("sugar");
                odg.Add("amino acids");
                odg.Add("fatty acids");
                P = new Pitanja("Plants synthesis protein from", "amino acids", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("free nitrogen");
                odg.Add("urea");
                odg.Add("ammonia");
                odg.Add("proteins");
                P = new Pitanja("Plants absorb dissolved nitrates from soil and convert them into", "free nitrogen", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("Place for muscle attachment");
                odg.Add("Protection of vital organs");
                odg.Add("Secretion of hormones for calcium regulation in blood and bones");
                odg.Add("Production of blood corpuscles");
                P = new Pitanja("One of the following is not a function of bones.", "Secretion of hormones for calcium regulation in blood and bones", odg);
                lista.Add(P);

                label5.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                label7.Visible = true;
                button2.Visible = true;
                label7.Text = brojac.ToString() + ". question:";
                label5.Text = lista[brojac - 1].Pitanje;
                radioButton1.Text = lista[brojac - 1].Odgovori[0];
                radioButton2.Text = lista[brojac - 1].Odgovori[1];
                radioButton3.Text = lista[brojac - 1].Odgovori[2];
                radioButton4.Text = lista[brojac - 1].Odgovori[3];
            }
            if (ime == "History")
            {
                BackColor = Color.PeachPuff;
                List<string> odg = new List<string>();
                odg.Add("1757");
                odg.Add("1782");
                odg.Add("1748");
                odg.Add("1764");
                Pitanja P = new Pitanja("The Battle of Plassey was fought in", "1757", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("Sutlej and Beas");
                odg.Add("Jhelum and Chenab");
                odg.Add("Ravi and Chenab");
                odg.Add("Ganga and Yamuna");
                P = new Pitanja("The territory of Porus who offered strong resistance to Alexander was situated between the rivers of", "Jhelum and Chenab", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("military affairs");
                odg.Add("the state treasury");
                odg.Add("the royal household");
                odg.Add("the land revenue system");
                P = new Pitanja("Under Akbar, the Mir Bakshi was required to look after", "military affairs", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("Buddhists");
                odg.Add("Hindus");
                odg.Add("Jains");
                odg.Add("None of the above");
                P = new Pitanja("Tripitakas are sacred books of", "Buddhists", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("Nirvana");
                odg.Add("Sangha");
                odg.Add("Buddha");
                odg.Add("Dhamma");
                P = new Pitanja("The trident-shaped symbol of Buddhism does not represent", "Nirvana", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("Jawaharlal Nehru");
                odg.Add("Dadabhai Naoroji");
                odg.Add("R.C. Dutt");
                odg.Add("M.K. Gandhi");
                P = new Pitanja("The theory of economic drain of India during British imperialism was propounded by", "Dadabhai Naoroji", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("Robert Clive");
                odg.Add("Cornwallis");
                odg.Add("Dalhousie");
                odg.Add("Warren Hastings");
                P = new Pitanja("The treaty of Srirangapatna was signed between Tipu Sultan and", "Cornwallis", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("1833");
                odg.Add("1853");
                odg.Add("1858");
                odg.Add("1882");
                P = new Pitanja("The system of competitive examination for civil service was accepted in principle in the year", "1853", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("Dannayaka");
                odg.Add("Sumanta");
                odg.Add("Nayaka");
                odg.Add("Mahanayakacharya");
                P = new Pitanja("Through which one of the following, the king exercised his control over villages in the Vijayanagar Empire?", "Mahanayakacharya", odg);
                lista.Add(P);

                label7.Visible = true;
                label5.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                button2.Visible = true;
                label7.Text = brojac.ToString() + ". question:";
                label5.Text = lista[brojac - 1].Pitanje;
                radioButton1.Text = lista[brojac - 1].Odgovori[0];
                radioButton2.Text = lista[brojac - 1].Odgovori[1];
                radioButton3.Text = lista[brojac - 1].Odgovori[2];
                radioButton4.Text = lista[brojac - 1].Odgovori[3];
            }
            if (ime == "Chemistry")
            {
                BackColor = Color.Turquoise;
                List<string> odg = new List<string>();
                odg.Add("electrons and neutrons");
                odg.Add("electrons and protons");
                odg.Add("protons and neutrons");
                odg.Add("All of the above");
                Pitanja P = new Pitanja("The nucleus of an atom consists of:", "protons and neutrons", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("molality");
                odg.Add("molarity");
                odg.Add("normality");
                odg.Add("formality");
                P = new Pitanja("The number of moles of solute present in 1 kg of a solvent is called its", "molality", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("sodium");
                odg.Add("bromine");
                odg.Add("fluorine");
                odg.Add("oxygen");
                P = new Pitanja("The most electronegative element among the following is", "fluorine", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("Na");
                odg.Add("Ag");
                odg.Add("Hg");
                odg.Add("Fe");
                P = new Pitanja("The metal used to recover copper from a solution of copper sulphate is", "Fe", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("smelting");
                odg.Add("roasting");
                odg.Add("calcinations");
                odg.Add("froth floatation");
                P = new Pitanja("The metallurgical process in which a metal is obtained in a fused state is called", "smelting", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("Dalton's law");
                odg.Add("Gay Lussac's law");
                odg.Add("Henry's law");
                odg.Add("Raoult's law");
                P = new Pitanja("The law which states that the amount of gas dissolved in a liquid is proportional to its partial pressure is", "Henry's law", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("helium");
                odg.Add("ozone");
                odg.Add("oxygen");
                odg.Add("methane");
                P = new Pitanja("The gas present in the stratosphere which filters out some of the sun's ultraviolet light and provides an effective shield against radiation damage to living things is", "ozone", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("specific heat");
                odg.Add("thermal capacity");
                odg.Add("water equivalent");
                odg.Add("None of the above");
                P = new Pitanja("The heat required to raise the temperature of body by 1 K is called", "thermal capacity", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("alcohol");
                odg.Add("carbon dioxide");
                odg.Add("chlorine");
                odg.Add("sodium chlorine");
                P = new Pitanja("The most commonly used bleaching agent is", "chlorine", odg);
                lista.Add(P);

                odg = new List<string>();
                odg.Add("electrons");
                odg.Add("positrons");
                odg.Add("neutrons");
                odg.Add("mesons");
                P = new Pitanja("The nuclear particles which are assumed to hold the nucleons together are", "mesons", odg);
                lista.Add(P);
                label7.Visible = true;
                label5.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                button2.Visible = true;
                label7.Text = brojac.ToString() + ". question:";
                label5.Text = lista[brojac - 1].Pitanje;
                radioButton1.Text = lista[brojac - 1].Odgovori[0];
                radioButton2.Text = lista[brojac - 1].Odgovori[1];
                radioButton3.Text = lista[brojac - 1].Odgovori[2];
                radioButton4.Text = lista[brojac - 1].Odgovori[3];
            }
         


        


        }
        public  List<Pitanja> lista = new List<Pitanja>();
       
        private void button2_Click(object sender, EventArgs e)
        {

            string o ="";
           if(radioButton1.Checked)
            {
                o = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                o = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                o = radioButton3.Text;
            }
            if (radioButton4.Checked)
            {
                o = radioButton4.Text;
            }
            if(lista[brojac - 1].TocanOdgovor == o)
            {
                MessageBox.Show("The answer is correct!");
                tocno = tocno + 1;
            }
            else
            {
                MessageBox.Show("The answer is not correct!");
                netocno = netocno + 1;
            }
            
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
