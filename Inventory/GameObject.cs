using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreathofFireRandomiser.Inventory
{
    public abstract class GameObject
    {
        public string Object_type;
        public string name;
        public string status;
        public string address;
        public string id;
        //static public abstract GameObject GetRandom(Random r);
        //static public abstract GameObject GetRandomValid(Random r);
        public string itemID = "01";
        public string armourID = "21";
        public string weaponID = "11";

        public bool Matches_Chest_Contents(string contents)
        {

            //Console.WriteLine(this.id + "|" + this.Object_type);
            string tester = string.Join("", (this.id+this.Object_type).Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
            int intid = Int32.Parse(tester, System.Globalization.NumberStyles.HexNumber);
           // Console.WriteLine("intid" + intid);
            int contentsid = Int32.Parse(contents, System.Globalization.NumberStyles.HexNumber);
            //Console.WriteLine(contentsid);
            /*
            if (this.Object_type == "21")
            {
            Console.WriteLine("intid "+intid+" contentsid "+contentsid);
                Console.WriteLine("this armour id is " + this.id);
            }*/

            if (intid == contentsid)
            { return true; }
            else
            { return false; }

        }
    }
}
