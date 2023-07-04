using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BreathofFireRandomiser.Common.Common;

namespace BreathofFireRandomiser.Inventory
{
    public class Weapons :GameObject
    {
    public static List<Weapons> list;
    
        public  static GameObject GetRandom(Random r)
        {
            int inty = r.Next(0, Weapons.list.Count - 1);
            return (GameObject) Weapons.list[inty];
        }

        public static GameObject GetRandomValid(Random r)
        {
            while (true)
            {
                Weapons a = (Weapons) Weapons.GetRandom(r);
                if (a.Swappable() == true)
                { return a; }
            }


        }
        public bool Swappable()
        {if (this.name.Length>2)
            { return true; }
        else
            { return false; }
                    }

        public static string[] names = {"Dirk ","BronzSD ","Sabre ","Scythe ","LongSD ","DragonSD ","PowerSD ","WingSD ",
        "EmporSD ","BrokenSD "," ","FlameSD ","Sickle ","BroadSD ","MystSD ","Dummy ","ShortRP ","Rapier ",
        "IronRP ","PoisonRP ","LightRP "," ","FlameRP ","WingRP ","BronzRP ","EvilRP ","ThundrRP "," ",
        "LoyalRP ","PowerRP ","IronHR ","SpineHR ","Club ","GiantHR ","FlameHR "," ","RageHR "," ",
        "Mallet ","StarHR ","Stick ","Cane ","BoneCN ","EvilCN "," ","IcyCN "," ","GlowCN ",
        " ","Pole ","Pike ","Javelin ","OldSP ","HeroSP ","Trident "," ","Sleeper "," ",
        "DigCW ","RustCW ","IronCW ","IcyCW "," ","MystCW "," ","ThrowDR ","Dagger ","Dart ",
        "Tri-DR ","PowerDR ","FlameDR ","SilverDR "," "," ","IcyDR "," ","DarkDR "," ",
        "BronzBW ","ShortBW ","LongBW ","SteelBW ","PoisonBW ","SharpBW ","MoonBW ","JadeBW ","Tri-BW "," ",
        " "," ","DwarfBW ","HeroBW "," ","B.Rang ","Rang ","Tri-Rang "
        };
        public static string[] addresses = {"13E200 ","13E210 ","13E220 ","13E230 ","13E240 ","13E250 ","13E260 ",
        "13E270 ","13E280 ","13E290 ","13E2A0 ","13E2B0 ","13E2C0 ","13E2D0 ","13E2E0 ","13E2F0 ","13E300 ",
        "13E310 ","13E320 ","13E330 ","13E340 ","13E350 ","13E360 ","13E370 ","13E380 ","13E390 ","13E3A0 ",
        "13E3B0 ","13E3C0 ","13E3D0 ","13E3E0 ","13E3F0 ","13E400 ","13E410 ","13E420 ","13E430 ","13E440 ",
        "13E450 ","13E460 ","13E470 ","13E480 ","13E490 ","13E4A0 ","13E4B0 ","13E4C0 ","13E4D0 ","13E4E0 ",
        "13E4F0 ","13E500 ","13E510 ","13E520 ","13E530 ","13E540 ","13E550 ","13E560 ","13E570 ","13E580 ",
        "13E590 ","13E5A0 ","13E5B0 ","13E5C0 ","13E5D0 ","13E5E0 ","13E5F0 ","13E600 ","13E610 ","13E620 ",
        "13E630 ","13E640 ","13E650 ","13E660 ","13E670 ","13E680 ","13E690 ","13E6A0 ","13E6B0 ","13E6C0 ",
        "13E6D0 ","13E6E0 ","13E6F0 ","13E700 ","13E710 ","13E720 ","13E730 ","13E740 ","13E750 ","13E760 ",
        "13E770 ","13E780 ","13E790 ","13E7A0 ","13E7B0 ","13E7C0 ","13E7D0 ","13E7E0 ","13E7F0 "};
        public static string[] ids = {"0 ","1 ","2 ","3 ","4 ","5 ","6 ","7 ","8 ",
        "9 ","A ","B ","C ","D ","E ","F ","10 ","11 ","12 ",
        "13 ","14 ","15 ","16 ","17 ","18 ","19 ","1A ","1B ","1C ",
        "1D ","1E ","1F ","20 ","21 ","22 ","23 ","24 ","25 ","26 ",
        "27 ","28 ","29 ","2A ","2B ","2C ","2D ","2E ","2F ","30 ",
        "31 ","32 ","33 ","34 ","35 ","36 ","37 ","38 ","39 ","3A ",    
        "3B ","3C ","3D ","3E ","3F ","40 ","41 ","42 ","43 ","44 ",
        "45 ","46 ","47 ","48 ","49 ","4A ","4B ","4C ","4D ","4E ",
        "4F ","50 ","51 ","52 ","53 ","54 ","55 ","56 ","57 ","58 ",
        "59 ","5A ","5B ","5C ","5D ","5E ","5F " };

    }
}