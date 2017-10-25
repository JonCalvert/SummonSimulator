using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing.Imaging;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        int ThCount = 0;
        int FoCount = 0;
        int FiCount = 0;
        int timer = 0;
        System.Timers.Timer t = new System.Timers.Timer();
        Random rand = new Random();



        private void btnSingleSummon_Click(object sender, EventArgs e)
        {
            panelSummonType.Visible = false;
            panelSingleSummon.Visible = true;
            lblSingleSummonRes.Text = "";
            lblnumSums.Text = "0";
            cntFives.Text = "0";
            cntFours.Text = "0";
            cntThrees.Text = "0";

            /*
            String path = "C:\\Users\\Jonca\\Documents\\Visual Studio 2015\\Projects\\WindowsFormsApplication1\\WindowsFormsApplication1\\image\\Sparks.gif";
            var gif = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(213, 240),
                Location = new Point(0, 0),
                Image = Image.FromFile(path),

            };
            gif.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSumm.Controls.Add(gif);
            */
        }
        private void btnMassSummon_Click(object sender, EventArgs e)
        {
            panelSummonType.Visible = false;
            panelMassSummon.Visible = true;
            Stats.Text = "";
            FiveStars.Text = "";
            NumberSummons.Text = "";
            WantedMon.Text = "";
            panelPrevSums.Controls.Clear();

        }

        private void Summon_Click(object sender, EventArgs e)
        {
            panelPrevSums.Controls.Clear();
            Result.Text = "";
            int numSums = Int32.Parse(NumberSummons.Text);
            initMassSummon(numSums);

        }
        private void btnSingle_Click(object sender, EventArgs e)
        {
            count += 1;            
            lblnumSums.Text = count.ToString();
            lblSingleSummonRes.Text = "";
            
            picSummonedMon.Visible = false;
            InitSingleSummon();

        }

        

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            panelSummonType.Visible = true;
            panelMassSummon.Visible = false;
            panelSingleSummon.Visible = false;
        }
        private void btnExit2_Click(object sender, EventArgs e)
        {
            panelSummonType.Visible = true;
            panelMassSummon.Visible = false;
            panelSingleSummon.Visible = false;
            count = 0;
            ThCount = 0;
            FoCount = 0;
            FiCount = 0;
            lblnumSums.Text = "";
            cntFives.Text = "";
            cntFours.Text = "";
            cntThrees.Text = "";
        }


        private void InitSingleSummon()
        {
            
            List<Tier> monsterList = InitSummons(1);
            List<string> summonedThrees = new List<string>();
            List<string> summonedFours = new List<string>();
            List<string> summonedFives = new List<string>();
            String[] res = DoSummon(rand, monsterList);

            string summoned = res[1];
            timer = 0;
            
            t.Interval = 2000; //In milliseconds here
            t.AutoReset = false; //Stops it from repeating
            t.Elapsed += new ElapsedEventHandler(TimerElapsed);
            t.Start();
            while (timer == 0) { }


            pbSumm.Visible = true;


            if ( res[0] == "Nat 4" )
            {
                FoCount += 1;
                cntFours.Text = FoCount.ToString();
                lblSingleSummonRes.Font = new Font("Times New Roman", 10.0f, FontStyle.Bold);
            }
            else if(res[0] == "Nat 5")
            {
                FiCount += 1;
                cntFives.Text = FiCount.ToString();
                lblSingleSummonRes.Font = new Font("Times New Roman", 16.0f, FontStyle.Bold);
            }
            else
            {
                ThCount += 1;
                cntThrees.Text = ThCount.ToString();
                lblSingleSummonRes.Font = new Font("Times New Roman", 10.0f, FontStyle.Regular);
            }

            /*
                 String dir = "C:\\Users\\Jonca\\Documents\\Visual Studio 2015\\Projects\\WindowsFormsApplication1\\WindowsFormsApplication1\\image\\";
                String image = res[1] + ".png";
                String imagePath = dir + image;


                var picture = new PictureBox
                {
                    Name = "pictureBox",
                    Size = new Size(40, 40),
                    Location = new Point( 10 + (50 * j) , 10 ),
                    Image = Image.FromFile(imagePath),

                };
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                panelPrevSums.Controls.Add(picture);
             
             
             */





           
            String dir = "C:\\Users\\Jonca\\Documents\\Visual Studio 2015\\Projects\\SummonSimulator\\SummonSimulator\\image\\";
            String image = summoned + ".png";
            String imagePath = dir + image;
            pbSumm.Visible = false;
            if ( File.Exists(imagePath)  )
            {
                Image imageFromFile = Image.FromFile(imagePath);
           
                Image thumbnail = imageFromFile.GetThumbnailImage(213, 240, null, IntPtr.Zero);
                picSummonedMon.Image = thumbnail;
                picSummonedMon.Visible = true;
            }
            else
            {

                Image imageFromFile = Image.FromFile(dir+"Notfound.png");

                Image thumbnail = imageFromFile.GetThumbnailImage(213, 240, null, IntPtr.Zero);
                picSummonedMon.Image = thumbnail;
                picSummonedMon.Visible = true;
            }
            

            lblSingleSummonRes.Text = summoned;

        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            timer = 1;
        }

        private void initMassSummon(int numSums)
        {
            Random rand = new Random();
            List<Tier> monsterList = InitSummons(numSums);
            List<string> summonedThrees = new List<string>();
            List<string> summonedFours = new List<string>();
            List<string> summonedFives = new List<string>();
            for (int j = 0; j <= numSums - 1; j++)
            {

                String[] res = DoSummon(rand, monsterList);

                switch (res[0])
                {
                    case "Nat 3":
                        summonedThrees.Add(res[1]);
                        break;
                    case "Nat 4":
                        summonedFours.Add(res[1]);
                        break;
                    case "Nat 5":
                        summonedFives.Add(res[1]);
                        break;
                    default:
                        break;
                }
                //stop the loop if the desired monster is summoned
                if (res[1].ToLower() == WantedMon.Text.ToLower())
                {
                    break;
                }


            }
            String stats = "Number of Natural 3 star monsters: " + summonedThrees.Count
                + "\nNumber of Natural 4 star monsters: " + summonedFours.Count
                + "\nNumber of Natural 5 star monsters: " + summonedFives.Count;
            Stats.Text = stats;
            string fiveStars = "";




            String dir = "C:\\Users\\Jonca\\Documents\\Visual Studio 2015\\Projects\\SummonSimulator\\SummonSimulator\\image\\";
            
            

            for (int i = 0; i <= summonedFives.Count - 1; i++)
            {
                fiveStars += summonedFives.ElementAt(i) + ", ";
                String image = summonedFives.ElementAt(i) + ".png";
                String imagePath = dir + image;

                var picture = new PictureBox
                {
                    Name = "pictureBox",
                    Size = new Size(50, 50),
                    Location = new Point(10 + (60 * i), 10),
                    Image = Image.FromFile(imagePath),

                };
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                panelPrevSums.Controls.Add(picture);

            }
            if (fiveStars.EndsWith(", "))
            {
                fiveStars = fiveStars.Substring(0, fiveStars.Length - 2);
            }
            FiveStars.Text = fiveStars;
        }


        private List<Tier> InitSummons(int numSums)
        {
            
            //add all available monsters from mystical scroll to array
            String[] natThrees = { "Ceres", "Ellin", "Hina", "Granite", "Talc", "Olivine", "Kungen", "Gruda", "Dagorr", "Nangrim", "Gangchun", "Suri", "Randy", "Wayne", "Roger", "Ignicus", "Aqcus", "Zephicus", "Xiao Chun", "Mao", "Huan", "Adrian", "Eluin", "Erwin", "Rina", "Michelle", "Iselia", "Elucia", "Bulldozer", "Tractor", "Crane", "Kugo", "Kuhn", "Ragion", "Spectra", "Kahn", "Bernard", "Sath", "Hemos", "Hiva", "Racuni", "Remy", "Lucasha", "Ramira", "Prilea", "Kahli", "Ellena", "Moria", "Fairo", "Yaku", "Pigma", "Tagaros", "Purian", "Anduril", "Raoq", "Icaru", "Ramahan", "Iron", "Nickel", "Copper", "Igmanodon", "Kernodon", "Velfinodon", "Cassandra", "Sharron", "Ardella", "Sin", "Luan", "Lo", "Mei", "Mina", "Naomi", "Burentau", "Urtau", "Eintau", "Sonora", "Nubia", "Namib", "Rebecca", "Megan", "Silia", "Naki", "Toma", "Mav", "Krakdon", "Fao", "Shailoq", "Ermeda", "Gunpyeong", "Kai'en", "Geoffrey", "Dagora", "Garoche", "Vigor", "Shakan" };
            String[] natFours = { "Khmun", "Avaris", "Iunu", "Lexy", "Stella", "Tanya", "Surtr", "Aegir", "Hraesvelg", "Draco", "Orion", "Aquila", "Arnold", "Fedora", "Briand", "Ludo", "Reno", "Morris", "Chloe", "Raviti", "Harmonia", "Sonnet", "Triana", "Duamutef", "Qebehsenuef", "Imesety", "Smokey", "Chilling", "Windy", "Jojo", "Sian", "Lushen", "Zibrolta", "Malaka", "Taurus", "Hong Hua", "Xiao Lin", "Ling Ling", "Antares", "Rigel", "Fuco", "Astar", "Lapis", "Lupinus", "Platy", "Tetra", "Cichlid", "Lisa", "Emma", "Olivia", "Trevor", "Ryan", "Logan", "Shihwa", "Soha", "Arang", "Garo", "Susano", "Orochi", "Jean", "Luer", "Julien", "Clara", "Julie", "Sophia", "Carrack", "Galleon", "Barque", "Hwa", "Su", "Yen", "Jun", "Kaz", "Kaito", "Hwahee", "Mihyang", "Chasun", "Akia", "Izaria", "Selena", "Baretta", "Tyron", "Shimitae", "Fria", "Lumirecia", "Acasis", "Gildong", "Woochi", "Atenai", "Mikene", "Delphoi", "Verdehile", "Liesel", "Argen" };
            String[] natFives = { "Ariel", "Eladriel", "Velajuel", "Kumar", "Chandra", "Ritesh", "Rakan", "Taor", "Lagmaron", "Sekhmet", "Bastet", "Hathor", "Zaiross", "Verad", "Jamire", "Laika", "Chow", "Leo", "Daphnis", "Psamathe", "Ganymede", "Raki", "Beth", "Ethna", "Mei Hou Wang", "Shi Hou", "Xing Zhe", "Rica", "Anavel", "Charlotte", "Juno", "Praha", "Seara", "Ophilia", "Josephine", "Louise", "Mo Long", "Feng Yan", "Perna", "Teshar", "Chiwu", "Woosa", "Pungbaek", "Brandia", "Alicia", "Tiana", "Okeanos", "Poseidon", "Triton", "Helena", "Amelia", "Diana", "Vanessa", "Camilla" };

            Tier n5 = new Tier("Nat 5", 0.005, natFives);
            Tier n4 = new Tier("Nat 4", 0.080, natFours);
            Tier n3 = new Tier("Nat 3", 0.915, natThrees);

            List<Tier> tierList = new List<Tier>();
            tierList.Add(n5);
            tierList.Add(n4);
            tierList.Add(n3);

            return tierList;            
        }

        private String[] DoSummon(Random rand, List<Tier> monsterList)
        {
            String summonTier = "";
            String summonRes = "";
            Double summonResNum = rand.NextDouble();
            Double cumulative = 0.000;
            foreach (Tier tierList in monsterList)
            {
                cumulative += tierList.rate;
                if (summonResNum < cumulative)
                {
                    summonTier = tierList.name;
                    int length = tierList.monsterList.Count();
                    int indexOfMon = rand.Next(0, length);
                    string monster = tierList.monsterList[indexOfMon];
                    summonRes = monster;
                    break;
                }
            }
            //Result.Text += summonRes + ", ";

           
            String[] returnVal = { summonTier, summonRes };
            return returnVal;

        }

        
    }   
}
