

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static BreathofFireRandomiser.Common.Common;

namespace BreathofFireRandomiser.Inventory
{
    public class Items :GameObject
    {
        public static List<Items> list;
        public bool Swappable()
        { 
        if (status.Contains("Unused") || status.Contains("Story Key Item") || status.Contains("Examine For Text") || status.Contains("Purchase Only"))
            { return false; }
        else
            { return true; }
                    
        }

        public static GameObject GetRandom(Random r)
        {
            int inty = r.Next(0, Items.list.Count - 1);
            return Items.list[inty];
        }

        public static GameObject GetRandomValid(Random r)
        {
            while (true)
            {
                Items a = (Items)Items.GetRandom(r);
                if (a.Swappable() == true)
                { return a; }
            }

        }

        public static string[] names={
        "70GP ","150GP ","300GP ","650GP ","900GP ","1200GP ","2000GP ","3000GP ","Herb ","Cure ",
        "Antdt ","Acorn ","M.Drop ","T.Drop ","Charm ","Life2 ","Mrbl1 ","Mrbl2 ","Mrbl3 ","Whskrs ",
        "Worm ",
        "Worm2 ","Shrimp ","Urchin ","Shell ","Apple ","ProtnA ","Antlr ","WMeat ","Life ","Nails ",
        "Meat ","B.Stn ","F.Stn ","C.Stn ","Smoke ","DkKiss ","Cure2 ","ProtnB ","Sash ","W.Ptn ",
        "S.Ptn ","HrGlas ","ExpBug ","Slab ","Lifter ","E.Key ","ClnWtr ","Coach ","Clog ","A.Ptn ",
        "L.Ptn ","V.Ptn ","DrSoul ","DrWarp ","PlceBo ","Remedy ","WtrJr ","Saw ","Tablet ","Ring ",
        "WtrJr' ","KngKey ","Paper ","Oath ","Pouch ","GnPwdr ","LtKey ","DkKey ","Mirror ","Book ",
        "Srdine ","Mackrl ","Sole ","Trout ","C.Fsh ","Snapr ","Tuna ","Puffer ","Rod1 ","Rod2 ",
        "Rod3 ","Rod4 ","Rod5 ","I.Ore ","Key ","Vitamn ","Statue ","OldEgg ","Goods ","Egg ",
        "Sphere ","Gills ","G.Bar ","Icicle ","Fife ","Pass ","B.Part ","Parts ","D.Hrt ","Map ",
        "List ","Wtzit ","Note1 ","Note2 ","I.Claw ","TmKey ","B.Rang ","SkyKey ","Cowl ","Bolster ",
        "Maestro ","G.Fly ","Oil ","M.Cura ","Melon ","Fruit ","P.Fish ","Root ","C.Nut ","W.Ant ",
        "Tonic ","Herb x9 ","Antd x9 ","Drop x9 ","Chrm x9 ","Cure x9 ","Acrn x9 "};


        public static string[] statuses = {
        "When Obtained  GP+70 ",
        "When Obtained GP+150",
        "When Obtained  GP+300",
        "When Obtained  GP+650",
        "When Obtained  GP+0 (Incorrect Value Data) ",
        "When Obtained  GP+1200 ",
        "When Obtained  GP+2000 ",
        "When Obtained  GP+3000 ",
        "Heal: 50 HP ",
        "Heal: 100% HP ",
        "Recover: Poison ",
        "Heal: 20 AP ",
        "Heal All: 100% Recover All: All ",
        "Recover: Zombie ",
        "Recover: Curse",
        "Heal: 100% HP Heal: 100% AP Recover: All" ,
        "Attack: Slam ",
        "Magic/Dragon?: Slam ",
        "No Encounters ",
        "Unused ",
        "Fishing Bait ",
        "Fishing Bait ",
        "Fishing Bait ",
        "Fishing Bait ",
        "Fishing Bait ",
        "Heal: 60 HP ",
        "Battle ATK +20 ",
        "Recover: Poison ",
        "Heal All: 150 HP ",
        "Recover: KO 1 HP ",
        "Unused ",
        "Heal All: 70 HP ",
        "Cast: Fry ",
        "Cast: Flame ",
        "Cast: Frost ",
        "Escape From Battle ",
        "Cast: Rub ",
        "Heal All: 250 HP ",
        "Battle ATK +50 ",
        "ATK +10 ",
        "WIS +1 ",
        "STR +1 ",
        "Story Key Item Cycles Day And Night ",
        "Unused ",
        "Examine For Text ",
        "Doubles Drop Rate ",
        "Story Key ItemCast: 3.5 ",
        "Unused ",
        "Unused Replaces Followers With Coach Doubles Field Movement Speed Only Ox Takes Field Hazard Damage",
        "ACT +10",
        "AGI +1 ",
        "LCK +1 ",
        "VIG +1 ",
        "Unused ",
        "Unused ",
        "Unused ",
        "Story Key Item ",
        "Story Key Item Can Be Filled",
        "Story Key Item Enter Myst Forest",
        "Story Key Item Enter Aqua",
        "ATK +10 ",
        "Heal All: 100% HP Heal All: 100% MP Recover All: All",
        "Story Key Item Enter Stone Robot",
        "Unused ",
        "Unused ",
        "Story Key Item Prevents Inn Theft ",
        "Story Key Item Enter Dark Dragon Port",
        "Story Key Item Turn Time To Day ",
        "Story Key Item Turn Time To Night ",
        "Story Key Item Enter Vault",
        "Story Key Item Recruit Karn",
        "Heal: 50 HP ",
        "Recover: Poison ",
        "Heal: 100 HP ",
        "Heal: 150 HP Recover: Poison",
        "Heal: 200 HP Recover: All",
        "Heal: 400 HP Recover: All",
        "Heal: 100% HP Recover: All",
        "Inflicts: Poison ",
        "For Fishing ",
        "For Fishing ",
        "Unused For Fishing",
        "For Fishing",
        "For Fishing Can Catch Dragon",
        "Story Key Item",
        "Story Key Item ",
        "Sidequest Item Recover: Poison",
        "Story Key Item Enter Drifting Town",
        "Story Key Item ",
        "Story Key Item ",
        "Story Key Item ",
        "Story Key Item ",
        "Story Key Item Enter Ocean",
        "Story Key Item Sells For Full Value",
        "Story Key Item Enter Desert",
        "Story Key Item Enter Crypt",
        "Story Key Item Enter Scande",
        "Story Key Item",
        "Story Key Item ",
        "Battle All Dragons Set To 1 HP",
        "Story Key Item Open Map With Start ",
        "Story Key Item ",
        "Story Key Item ",
        "Story Key Item ",
        "Story Key Item ",
        "Story Key Item Enter Obelisk",
        "Story Key Item",
        "Story Key Item ",
        "Story Key Item ",
        "Story Key Item ",
        "Story Key Item Enter Mogu's Dream",
        "Story Key Item",
        "Story Key Item ",
        "Story Key Item ",
        "Story Key Item ",
        "Heal: 100% HP ",
        "Story Key Item ",
        "Story Key Item ",
        "Story Key Item ",
        "Story Key Item Heal: 20 HP",
        "Story Key Item Heal: 100 AP",
        "Story Key Item ",
        "Purchase Only Converts to 9 Herb",
        "Purchase Only Converts to 9 Antdt ",
        "Purchase Only Converts to 9 T.Drop",
        "Purchase Only Converts to 9 Charm",
        "Misstranslated Purchase Only Converts to 9 Life\" ",
        "Purchase Only Converts to 9 Acorn"
        };
        /*public static string[] addresses = {"13F200 ","13F20E ","13F21C ","13F22A ","13F238 ","13F246 ","13F254 ","13F262 ","13F270 ","13F27E ",
        "13F28C ","13F29A ","13F2A8 ","13F2B6 ","13F2C4 ","13F2D2 ","13F2E0 ","13F2EE ","13F2FC ","13F30A ",
        "13F318 ","13F326 ","13F334 ","13F342 ","13F350 ","13F35E ","13F36C ","13F37A ","13F388 ","13F396 ",
        "13F3A4 ","13F3B2 ","13F3C0 ","13F3CE ","13F3DC ","13F3EA ","13F3F8 ","13F406 ","13F414 ","13F422 ",
        "13F430 ","13F43E ","13F44C ","13F45A ","13F468 ","13F476 ","13F484 ","13F492 ","13F4A0 ","13F4AE ",
        "13F4BC ","13F4CA ","13F4D8 ","13F4E6 ","13F4F4 ","13F502 ","13F510 ","13F51E ","13F52C ","13F53A ",
        "13F548 ","13F556 ","13F564 ","13F572 ","13F580 ","13F58E ","13F59C ","13F5AA ","13F5B8 ","13F5C6 ",
        "13F5D4 ","13F5E2 ","13F5F0 ","13F5FE ","13F60C ","13F61A ","13F628 ","13F636 ","13F644 ","13F652 ",
        "13F660 ","13F66E ","13F67C ","13F68A ","13F698 ","13F6A6 ","13F6B4 ","13F6C2 ","13F6D0 ","13F6DE ",
        "13F6EC ","13F6FA ","13F708 ","13F716 ","13F724 ","13F732 ","13F740 ","13F74E ","13F75C ","13F76A ",
        "13F778 ","13F786 ","13F794 ","13F7A2 ","13F7B0 ","13F7BE ","13F7CC ","13F7DA ","13F7E8 ","13F7F6 ",
        "13F804 ","13F812 ","13F820 ","13F82E ","13F83C ","13F84A ","13F858 ","13F866 ","13F874 ","13F882 ",
        "13F890 ","13F89E ","13F8AC ","13F8BA ","13F8C8 ","13F8D6 ","13F8E4 ","13F8F2 "};
        */
        static public String[] ids = {"00",
        "01","02","03","04","05","06","07","08","09","0A",
        "0B","0C","0D","0E","0F","10","11","12","13","14",
        "15","16","17","18","19","1A","1B","1C","1D","1E",
        "1F","20","21","22","23","24","25","26","27","28",
        "29","2A","2B","2C","2D","2E","2F","30","31","32",
        "33","34","35","36","37","38","39","3A","3B","3C",
        "3D","3E","3F","40","41","42","43","44","45","46",
        "47","48","49","4A","4B","4C","4D","4E","4F","50",
        "51","52","53","54","55","56","57","58","59","5A",
        "5B","5C" ,"5D","5E","5F","60","61","62","63","64",
        "65","66" ,"67","68","69","6A","6B","6C","6D","6E",
        "6F","70" ,"71","72","73","74","75","76","77","78",
        "79","7A","7B","7C","7D","7E","7F"};
    }
}