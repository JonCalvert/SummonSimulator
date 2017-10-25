using System;

namespace WindowsFormsApplication1
{

    public class Tier
    {
        public string name { get; set; }
        public double rate { get; set; }
        public String[] monsterList { get; set; }

        public Tier()
        {
            name = "";
            rate = 0.000;
            monsterList = new String[0];
        }
        public Tier(String name, double rate, String[] monsterlist)
        {
            this.name = name;
            this.rate = rate;
            this.monsterList = monsterlist;
        }

    }
}
