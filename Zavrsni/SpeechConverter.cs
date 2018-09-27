using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.IO;
namespace Zavrsni
{
    public partial class SpeechConverter : Form
    {
        
        public SpeechConverter()
        {
            InitializeComponent();
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public string predmet;
        SpeechRecognitionEngine writer = new SpeechRecognitionEngine();
        SpeechSynthesizer reader = new SpeechSynthesizer();
        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != null)
            {
                
                reader.Dispose();
                
                reader = new SpeechSynthesizer();
                
                reader.Rate = trackBar2.Value;
                reader.Volume = trackBar1.Value;
                if (comboBox1.Text == "Male")
                {
                    reader.SelectVoiceByHints(VoiceGender.Male);
                }
                if (comboBox1.Text == "Female")
                {
                    reader.SelectVoiceByHints(VoiceGender.Female);
                }
                reader.SpeakAsync(richTextBox1.Text);
            }
            else
            {
                MessageBox.Show("Choose a lesson!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Speaking)
                {
                    reader.Pause();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Paused)
                {
                    reader.Resume();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {

                reader.Dispose();
                
            }
        }

        private void SpeechConverter_Load(object sender, EventArgs e)
        {
            BackColor = Color.Lavender;
            
            if (predmet == null)
            {
                this.Close();
                MessageBox.Show("Please choose a subject!");

            }
            if (predmet == "Mathematics")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Mathematics as science");
                comboBox2.Items.Add("Applied mathematics");
                comboBox2.Items.Add("Computational mathematics");
                comboBox2.Items.Add("Mathematical awards");
                BackColor = Color.PowderBlue;

            }
            if (predmet == "Physics")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("What is physics");
                comboBox2.Items.Add("Motion");
                comboBox2.Items.Add("Energy");
                comboBox2.Items.Add("Astronomy");
                BackColor = Color.RosyBrown;

            }
            if (predmet == "History")
            {
                BackColor = Color.PeachPuff;

                comboBox2.Items.Clear();
                comboBox2.Items.Add("Ancient Mesopotamia");
                comboBox2.Items.Add("Middle Ages");
                comboBox2.Items.Add("World War I");
                comboBox2.Items.Add("World War II");

            }
            if (predmet == "Chemistry")
            {
                BackColor = Color.Turquoise;

                comboBox2.Items.Clear();
                comboBox2.Items.Add("What is chemistry");
                comboBox2.Items.Add("Why is chemistry important?");
                comboBox2.Items.Add("Components of Matter");
            }
            if (predmet == "Biology")
            {
                BackColor = Color.LightCyan;

                comboBox2.Items.Clear();
                comboBox2.Items.Add("What is Biology");
                comboBox2.Items.Add("The Cell");
                comboBox2.Items.Add("Human Body");
                comboBox2.Items.Add("Photosynthesis");

            }



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (predmet == "Mathematics")
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    richTextBox1.Clear();
                    StreamReader sr = new StreamReader(@"C:\Users\Anavi\Desktop\lekcije\mm\Mathematics as science.txt");
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.Text = line.ToString();
                    }
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    richTextBox1.Clear();
                    StreamReader sr = new StreamReader(@"C:\Users\Anavi\Desktop\lekcije\mm\Applied mathematics.txt");
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.Text = line.ToString();
                    }
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    richTextBox1.Clear();
                    StreamReader sr = new StreamReader(@"C:\Users\Anavi\Desktop\lekcije\mm\Computational mathematics.txt");
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.Text = line.ToString();
                    }
                }
                if (comboBox2.SelectedIndex == 3)
                {
                    richTextBox1.Clear();
                    StreamReader sr = new StreamReader(@"C:\Users\Anavi\Desktop\lekcije\mm\Mathematical awards.txt");
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.Text = line.ToString();
                    }
                }

            }
            if (predmet == "Physics")
            {

                if (comboBox2.SelectedIndex == 0)
                {
                    richTextBox1.Clear();
                    StreamReader sr = new StreamReader(@"C:\Users\Anavi\Desktop\lekcije\fiz\What is physics.txt");
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.Text = line.ToString();
                    }
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    richTextBox1.Clear();
                    StreamReader sr = new StreamReader(@"C:\Users\Anavi\Desktop\lekcije\fiz\Motion.txt");
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.Text = line.ToString();
                    }
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    richTextBox1.Clear();
                    StreamReader sr = new StreamReader(@"C:\Users\Anavi\Desktop\lekcije\fiz\Energy.txt");
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.Text = line.ToString();
                    }
                }
                if (comboBox2.SelectedIndex == 3)
                {
                    richTextBox1.Clear();
                    StreamReader sr = new StreamReader(@"C:\Users\Anavi\Desktop\lekcije\fiz\Astronomy.txt");
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.Text = line.ToString();
                    }
                }

            }
            if (predmet == "History")
            {

                if (comboBox2.SelectedIndex == 0)
                {
                    richTextBox1.Clear();
                    StreamReader sr = new StreamReader(@"C:\Users\Anavi\Desktop\lekcije\pov\Ancient Mesopotamia.txt");
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.Text = line.ToString();
                    }
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    richTextBox1.Clear();
                    StreamReader sr = new StreamReader(@"C:\Users\Anavi\Desktop\lekcije\pov\Middle Ages.txt");
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.Text = line.ToString();
                    }
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    richTextBox1.Clear();
                    StreamReader sr = new StreamReader(@"C:\Users\Anavi\Desktop\lekcije\pov\World War I.txt");
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.Text = line.ToString();
                    }
                }
                if (comboBox2.SelectedIndex == 3)
                {
                    richTextBox1.Clear();
                    StreamReader sr = new StreamReader(@"C:\Users\Anavi\Desktop\lekcije\pov\World War II");
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.Text = line.ToString();
                    }
                }

            }
            if (predmet == "Chemistry")
            {


                if (comboBox2.SelectedIndex == 0)
                {
                    richTextBox1.Clear();
                    StreamReader sr = new StreamReader(@"C:\Users\Anavi\Desktop\lekcije\kem\What is chemistry.txt");
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.Text = line.ToString();
                    }
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    richTextBox1.Clear();
                    StreamReader sr = new StreamReader(@"C:\Users\Anavi\Desktop\lekcije\kem\Why is chemistry important.txt");
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.Text = line.ToString();
                    }
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    richTextBox1.Clear();
                    StreamReader sr = new StreamReader(@"C:\Users\Anavi\Desktop\lekcije\kem\Components of Matter.txt");
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.Text = line.ToString();
                    }
                }


            }
            if (predmet == "Biology")
            {

                if (comboBox2.SelectedIndex == 0)
                {
                    richTextBox1.Clear();
                    StreamReader sr = new StreamReader(@"C:\Users\Anavi\Desktop\lekcije\bio\What is Biology.txt");
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.Text = line.ToString();
                    }
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    richTextBox1.Clear();
                    StreamReader sr = new StreamReader(@"C:\Users\Anavi\Desktop\lekcije\bio\The Cell.txt");
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.Text = line.ToString();
                    }
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    richTextBox1.Clear();
                    StreamReader sr = new StreamReader(@"C:\Users\Anavi\Desktop\lekcije\bio\Human Body.txt");
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.Text = line.ToString();
                    }
                }
                if (comboBox2.SelectedIndex == 3)
                {
                    richTextBox1.Clear();
                    StreamReader sr = new StreamReader(@"C:\Users\Anavi\Desktop\lekcije\bio\Photosynthesis.txt");
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.Text = line.ToString();
                    }
                }

            }
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (predmet == "Mathematics")
            {
                if (comboBox2.SelectedText == "Mathematics as science")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "Mathematics  is the study of topics such as quantity, structure, space, and change.There is a range of views among mathematicians and philosophers as to the exact scope and definition of mathematics. Mathematicians seek out patterns and use them to formulate new conjectures. Mathematicians resolve the truth or falsity of conjectures by mathematical proof. When mathematical structures are good models of real phenomena, then mathematical reasoning can provide insight or predictions about nature. Through the use of abstraction and logic, mathematics developed from counting, calculation, measurement, and the systematic study of the shapes and motions of physical objects. Practical mathematics has been a human activity from as far back as written records exist. The research required to solve mathematical problems can take years or even centuries of sustained inquiry.";
                }
                if (comboBox2.SelectedText == "Applied mathematics")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "Applied mathematics is a branch of mathematics that deals with mathematical methods that find use in science, engineering, business, computer science, and industry. Thus, applied mathematics is a combination of mathematical science and specialized knowledge. The term applied mathematics also describes the professional specialty in which mathematicians work on practical problems by formulating and studying mathematical models. In the past, practical applications have motivated the development of mathematical theories, which then became the subject of study in pure mathematics where abstract concepts are studied for their own sake. The activity of applied mathematics is thus intimately connected with research in pure mathematics. In the past, practical applications have motivated the development of mathematical theories, which then became the subject of study in pure mathematics, where mathematics is developed primarily for its own sake. Thus, the activity of applied mathematics is vitally connected with research in pure mathematics.";
                }
                if (comboBox2.SelectedText == "Computational mathematics")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "Computational mathematics proposes and studies methods for solving mathematical problems that are typically too large for human numerical capacity. Numerical analysis studies methods for problems in analysis using functional analysis and approximation theory; numerical analysis includes the study of approximation and discretization broadly with special concern for rounding errors. Numerical analysis and, more broadly, scientific computing also study non-analytic topics of mathematical science, especially algorithmic matrix and graph theory. Other areas of computational mathematics include computer algebra and symbolic computation.";
                }
                if (comboBox2.SelectedText == "Mathematical awards")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "Arguably the most prestigious award in mathematics is the Fields Medal, established in 1936 and awarded every four years (except around World War II) to as many as four individuals. The Fields Medal is often considered a mathematical equivalent to the Nobel Prize. The Wolf Prize in Mathematics, instituted in 1978, recognizes lifetime achievement, and another major international award, the Abel Prize, was instituted in 2003. The Chern Medal was introduced in 2010 to recognize lifetime achievement. These accolades are awarded in recognition of a particular body of work, which may be innovational, or provide a solution to an outstanding problem in an established field. A famous list of 23 open problems, called Hilberts problems, was compiled in 1900 by German mathematician David Hilbert. This list achieved great celebrity among mathematicians, and at least nine of the problems have now been solved. A new list of seven important problems, titled the Millennium Prize Problems, was published in 2000. A solution to each of these problems carries a $1 million reward, and only one (the Riemann hypothesis) is duplicated in Hilberts problems.";
                }

            }
            if (predmet == "Physics")
            {
    
                if (comboBox2.SelectedText == "What is physics")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "Physics is a branch of science that studies matter and its motion as well as how it interacts with energy and forces. Physics is a huge subject. There are many branches of physics including electricity, astronomy, motion, waves, sound, and light. Physics studies the smallest elementary particles and atoms as well as the largest stars and the universe. Scientists who are experts in physics are called physicists. Physicists use the scientific method to test hypotheses and develop scientific laws. Some of the most famous scientists in history are considered physicists such as Isaac Newton and Albert Einstein. ";
                }
                if (comboBox2.SelectedText == "Motion")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "There are a lot of different mathematical quantities used in physics. Examples of these include acceleration, velocity, speed, force, work, and power. These different quantities are often described as being either scalar or vector quantities. Below we will discuss what these words mean as well as introduce some basic vector math. A scalar is a quantity that is fully described by a magnitude only. It is described by just a single number. Some examples of scalar quantities include speed, volume, mass, temperature, power, energy, and time. A vector is a quantity that has both a magnitude and a direction. Vector quantities are important in the study of motion. Some examples of vector quantities include force, velocity, acceleration, displacement, and momentum. ";
                }
                if (comboBox2.SelectedText == "Energy")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "The simplest definition of energy is the ability to do work. Energy is how things change and move. It's everywhere around us and takes all sorts of forms. It takes energy to cook food, to drive to school, and to jump in the air. In physics, the standard unit of measure for energy is the joule which is abbreviated as J. There are other units of measure for energy that are used throughout the world including kilowatt-hours, calories, newton-meters, therms, and foot-pounds. ";
                }
                if (comboBox2.SelectedText == "Astronomy")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "Astronomy is the branch of science that studies outer space focusing on celestial bodies such as stars, comets, planets, and galaxies. Perhaps one of the oldest sciences, we have record of people studying astronomy as far back as Ancient Mesopotamia. Later civilizations such as the Greeks, Romans, and Mayans also studied astronomy. However, all of these early scientists had to observe space with just their eyes. There was only so much they could see. With the invention of the telescope in the early 1600s, scientists were able to see much further objects as well as get a better view of closer objects like the moon and the planets.";
                }

            }
            if (predmet == "History")
            {

                if (comboBox2.SelectedText == "Ancient Mesopotamia")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "Ancient Mesopotamia refers to the place where humans first formed civilizations. It was here that people first gathered in large cities, learned to write, and created governments. For this reason Mesopotamia is often called the Cradle of Civilization. Early settlers in Mesopotamia started to gather in small villages and towns. As they learned how to irrigate land and grow crops on large farms, the towns grew bigger. Eventually these towns became large cities. New inventions such as government and writing were formed to help keep order in the cities. The first human civilization was formed. Sumer - The Sumerians were the first humans to form a civilization. They invented writing and government. They were organized in city-states where each city had its own independent government ruled by a king that controlled the city and the surrounding farmland. Each city also had its own primary god. Sumerian writing, government, and culture would pave the way for future civilizations. Akkadians - The Akkadians came next. They formed the first united empire where the city-states of the Sumer were united under one ruler. The Akkadian language replaced the Sumerian language during this time. It would be the main language throughout much of the history of Mesopotamia. Babylonians - The city of Babylon became the most powerful city in Mesopotamia. Throughout the history of the region, the Babylonians would rise and fall. At times the Babylonians would create vast empires that ruled much of the Middle East. The Babylonians were the first to write down and record their system of law. Assyrians - The Assyrians came out of the northern part of Mesopotamia. They were a warrior society. They also ruled much of the Middle East at different times over the history of Mesopotamia. Much of what we know about the history of Mesopotamia comes from clay tablets found in Assyrian cities. Persians - The Persians put an end to the rule of the Assyrians and the Babylonians. They conquered much of the Middle East including Mesopotamia.";
                }
                if (comboBox2.SelectedText == "Middle Ages")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "The Middle Ages, or Medieval Times, in Europe was a long period of history from 500 AD to 1500 AD. That's 1000 years! It covers the time from the fall of the Roman Empire to the rise of the Ottoman Empire. This was a time of castles and peasants, guilds and monasteries, cathedrals and crusades. Great leaders such as Joan of Arc and Charlemagne were part of the Middle Ages as well as major events such as the Black Plague and the rise of Islam. When people use the terms Medieval Times, Middle Ages, and Dark Ages they are generally referring to the same period of time. The Dark Ages is usually referring to the first half of the Middle Ages from 500 to 1000 AD. After the fall of the Roman Empire, a lot of the Roman culture and knowledge was lost. This included art, technology, engineering, and history. Historians know a lot about Europe during the Roman Empire because the Romans kept excellent records of all that happened. However, the time after the Romans is dark to historians because there was no central government recording events. This is why historians call this time the Dark Ages. Although the term Middle Ages covers the years between 500 and 1500 throughout the world, this timeline is based on events specifically in Europe during that time. Go here to learn about the Islamic Empire during the Middle Ages.";
                }
                if (comboBox2.SelectedText == "World War I")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "World War I was a major conflict fought between 1914 and 1918. Other names for World War I include the First World War, WWI, the War to End All Wars, and the Great War. World War I was fought between the Allied Powers and the Central Powers. The main members of the Allied Powers were France, Russia, and Britain. The United States also fought on the side of the Allies after 1917. The main members of the Central Powers were Germany, Austria-Hungary, the Ottoman Empire, and Bulgaria. The majority of the fighting took place in Europe along two fronts: the western front and the eastern front. The western front was a long line of trenches that ran from the coast of Belgium to Switzerland. A lot of the fighting along this front took place in France and Belgium. The eastern front was between Germany, Austria-Hungary, and Bulgaria on one side and Russia and Romania on the other. Although there were a number of causes for the war, the assassination of Austrian Archduke Franz Ferdinand was the main catalyst for starting the war. After the assassination, Austria declared war on Serbia. Then Russia prepared to defend its ally Serbia. Next, Germany declared war on Russia to protect Austria. This caused France to declare war on Germany to protect its ally Russia. Germany invaded Belgium to get to France which caused Britain to declare war on Germany. This all happened in just a few days. A lot of the war was fought using trench warfare along the western front. The armies hardly moved at all. They just bombed and shot at each other from across the trenches. Some of the major battles during the war included the First Battle of the Marne, Battle of the Somme, Battle of Tannenberg, Battle of Gallipoli, and the Battle of Verdun. The fighting ended on November 11, 1918 when a general armistice was agreed to by both sides. The war officially ended between Germany and the Allies with the signing of the Treaty of Versailles. ";
                }
                if (comboBox2.SelectedText == "World War II")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "World War II was fought between the Axis Powers (Germany, Italy, Japan) and the Allied Powers (Britain, United States, Soviet Union, France). Most of the countries in the world were involved in some way. It was the deadliest war in all of human history with around 70 million people killed. World War II started in 1939 when Germany invaded Poland. Great Britain and France responded by declaring war on Germany. The war in Europe ended with Germany's surrender on May 7, 1945. The war in the Pacific ended when Japan surrendered on September 2, 1945. World War II started in Europe, but spread throughout the world. Much of the fighting took place in Europe and in Southeast Asia (Pacific). ";
                }

            }
            if (predmet == "Chemistry")
            {


                if (comboBox2.SelectedText == "What is chemistry")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "Chemistry is the branch of science that studies the properties of matter and how matter interacts with energy. Chemistry is considered a physical science and is closely related to physics. Sometimes chemistry is called the central science because it is an important part of other major sciences such as biology, Earth science, and physics. Scientists who specialize in chemistry are called chemists. ";
                }
                if (comboBox2.SelectedText == "Why is chemistry important?")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "Chemistry is used all around us. Doctors use chemistry to make medicine that helps us when we are sick. Engineers use chemistry to make electronics like your TV and your cell phone. Farmers use chemistry to help their crops to grow so we can have food. Even chefs use chemistry to cook delicious meals. By understanding chemistry you can better understand the world around you and how it works. ";
                }
                if (comboBox2.SelectedText == "Components of Matter")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "Matter is composed of different building blocks. Atom - Matter is made up of tiny building blocks called atoms. It takes millions and millions of atoms to make even the smallest object. Element - Substances made up of a single type of atom are called elements. Compound - Compounds are made up of different types of elements. Mixture - A material made up of different types of compounds that do not chemically combine.";
                }
               

            }
            if (predmet == "Biology")
            {

                if (comboBox2.SelectedText == "What is Biology")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "Biology is the branch of science that studies life and living organisms. This includes such subjects as the cell, genes, inheritance, microorganisms, plants, animals, and the human body. There are many branches of science that are part of biology including ecology (how organisms interact with their environment), agriculture (the study of producing crops from the land), biochemistry (the chemical reactions needed to support life), botany (the study of plants), physiology (how living organisms function), and zoology (the study of animals).";
                }
                if (comboBox2.SelectedText == "The Cell")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "The cell is the basic unit of life. Some organisms are made up of a single cell, like bacteria, while others are made up of trillions of cells. Human beings are made up of cells, too. There are lots of different types of cells. Each type of cell is different and performs a different function. In the human body, we have nerve cells which can be as long as from our feet to our spinal cord. Nerve cells help to transport messages around the body. We also have billions of tiny little brain cells which help us think and muscle cells which help us move around. There are many more cells in our body that help us to function and stay alive. Although there are lots of different kinds of cells, they are often divided into two main categories: prokaryotic and eukaryotic. Prokaryotic Cells - The prokaryotic cell is a simple, small cell with no nucleus. Organisms made from prokaryotic cells are very small, such as bacteria. There are three main regions of the prokaryotic cell: 1) The outside protection or envelope of the cell. This is made up of the cell wall, membrane, and capsule. 2) The flagella, which are a whip-like appendages that can help the cell to move. Note: not all prokaryotic cells have flagella. 3) The inside of the cell called the cytoplasmic region. This region includes the nucleoid, cytoplasm, and ribosomes. Eukaryotic Cells - These cells are typically a lot bigger and more complex than prokaryotic cells. They have a defined cell nucleus which houses the cell's DNA. These are the types of cells we find in plants and animals.";
                }
                if (comboBox2.SelectedText == "Human Body")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "The human body is a complex biological system involving cells, tissues, organs, and systems all working together to make up a human being. From the outside, the human body can be divided into several main structures. The head houses the brain which controls the body. The neck and trunk house many of the important systems that keep the body alive and healthy. The limbs (arms and legs) help the body to move about and function in the world. The human body has five main senses that it uses to convey information about the outside world to the brain. These senses include sight (eyes), hearing (ears)Hearing and the Ear, smell (nose), taste (tongue), and touch (skin). ";
                }
                if (comboBox2.SelectedText == "Photosynthesis")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "Have you ever noticed that plants need sunlight to live? It seems sort of strange doesn't it? How can sunlight be a type of food? Well, sunlight is energy and photosynthesis is the process plants use to take the energy from sunlight and use it to convert carbon dioxide and water into food. Plants need three basic things to live: water, sunlight, and carbon dioxide. Plants breathe carbon dioxide just like we breathe oxygen. When plants breathe carbon dioxide in, they breathe out oxygen. Plants are the major source of oxygen on planet Earth and help keep us alive. We know now that plants use sunlight as energy, they get water from rain, and they get carbon dioxide from breathing. The process of taking these three key ingredients and making them into food is called photosynthesis. ";
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
