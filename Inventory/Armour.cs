using System;
using System.Collections.Generic;
using static BreathofFireRandomiser.Common.Common;

namespace BreathofFireRandomiser.Inventory
{
	public class Armour : GameObject
	{
        public static List<Armour> list;
        
        public static  GameObject GetRandom(Random r)
        {
            int inty = r.Next(0, Armour.list.Count - 1);
            return Armour.list[inty];

        }
        public static GameObject GetRandomValid(Random r)
        {
            while (true)
            {
                Armour a =(Armour) Armour.GetRandom(r);
                if (a.Swappable()==true)
                { return a; }
            }


        }

        public bool Swappable()


        {
            if (this.name.Length>2)
            { return true; }
            else
            { return false; }
        }
        public static string[] names = {"Robe ","SuedeCP ","Dress ","MetalAR ","SilkGN ","Cloth ","LightCL ","Gown ","ArmPad ","WolfSkin ","RangerVT ",
        "BronzAR ","PlateAR "," ","FlameAR ","PrisnCL "," ","IcyAR ","WorldML "," ","SpineCL ",
        "ThiefCL ","EvilRB ","SuedeGN ","SuedeAR ","ChainML ","IronML ","WoolRB ","SuedeRB ","LifeAR ","PowerAR ",
        "QuartAR ","AngleAR "," ","GuruCT "," "," ","WorldAR ","SageML "," ","MystRB ",
        "EarthRB "," ","AgileAR "," ","HuntCL ","ClearCL "," ","WoodSH ","Gauntlet ","SuedeSH ",
        "GuardSH ","Bracelet ","IronSH ","BronzSH ","MetalSH ","FlameSH "," "," ","IronSL ","MetalSL ",
        " ","Wrist ","IcySH ","ProSH ","LoveBR ","WindBR ","RubyBR "," ","DarkBR "," ",
        "MystSH ","Glove "," ","TrapGrd ","LightSH ","MagicRG ","Bandage "," ","SilverBR "," ",
        "ColdSH ","HuntGL ","MaskSH ","DragonSH "," ","FlameSH "," ","SuedeHT ","Visor ","Hairband ",
        "Tiara ","ChainHT ","G.Tiara ","EchoHT ","IronMask "," "," ","StoneHT ","GoldHT ","FaceMask ",
        "AgileHT ","NiceHT ","MystSF ","DivingHT ","GaiaMask ","Headgear ","CursedHT ","ShellHT ","StrawHT ","IronHT ",
        " ","TideHT ","SkullHT ","PowerHT ","Domin ","HornHT ","Bandana ","Turban "," ","LoveHT ",
        " "," "," ","BronzHT "," ","SunHT ","WolfHT ","IcyHT "," "," ",
        " ","StarSH ","HeroRG ","SkullRG ","SkySH "," "," ","DragonHT ","DragonAR ","SmartRG ",
        "DreamRG "
        };

        public static string[] addresses = {"13E800 ","13E810 ","13E820 ","13E830 ","13E840 ","13E850 ","13E860 ","13E870 ","13E880 ","13E890 ",
        "13E8A0 ","13E8B0 ","13E8C0 ","13E8D0 ","13E8E0 ","13E8F0 ","13E900 ","13E910 ","13E920 ","13E930 ",
        "13E940 ","13E950 ","13E960 ","13E970 ","13E980 ","13E990 ","13E9A0 ","13E9B0 ","13E9C0 ","13E9D0 ",
        "13E9E0 ","13E9F0 ","13EA00 ","13EA10 ","13EA20 ","13EA30 ","13EA40 ","13EA50 ","13EA60 ","13EA70 ",
        "13EA80 ","13EA90 ","13EAA0 ","13EAB0 ","13EAC0 ","13EAD0 ","13EAE0 ","13EAF0 ","13EB00 ","13EB10 ",
        "13EB20 ","13EB30 ","13EB40 ","13EB50 ","13EB60 ","13EB70 ","13EB80 ","13EB90 ","13EBA0 ","13EBB0 ",
        "13EBC0 ","13EBD0 ","13EBE0 ","13EBF0 ","13EC00 ","13EC10 ","13EC20 ","13EC30 ","13EC40 ","13EC50 ",
        "13EC60 ","13EC70 ","13EC80 ","13EC90 ","13ECA0 ","13ECB0 ","13ECC0 ","13ECD0 ","13ECE0 ","13ECF0 ",
        "13ED00 ","13ED10 ","13ED20 ","13ED30 ","13ED40 ","13ED50 ","13ED60 ","13ED70 ","13ED80 ","13ED90 ",
        "13EDA0 ","13EDB0 ","13EDC0 ","13EDD0 ","13EDE0 ","13EDF0 ","13EE00 ","13EE10 ","13EE20 ","13EE30 ",
        "13EE40 ","13EE50 ","13EE60 ","13EE70 ","13EE80 ","13EE90 ","13EEA0 ","13EEB0 ","13EEC0 ","13EED0 ",
        "13EEE0 ","13EEF0 ","13EF00 ","13EF10 ","13EF20 ","13EF30 ","13EF40 ","13EF50 ","13EF60 ","13EF70 ",
        "13EF80 ","13EF90 ","13EFA0 ","13EFB0 ","13EFC0 ","13EFD0 ","13EFE0 ","13EFF0 ","13F000 ","13F010 ",
        "13F020 ","13F030 ","13F040 ","13F050 ","13F060 ","13F070 ","13F080 ","13F090 ","13F0A0 ","13F0B0 ",
        "13F0C0 ","13F0D0 "};
        public static string[] ids = {"00",
    "01","02","03","04","05","06","07","08","09","0A",
    "0B","0C","0D","0E","0F","10 ","11 ","12 ","13 ","14 ",
    "15 ","16 ","17 ","18 ","19 ","1A ","1B ","1C ","1D ","1E ",
    "1F ","20 ","21 ","22 ","23 ","24 ","25 ","26 ","27 ","28 ",
    "29 ","2A ","2B ","2C ","2D ","2E ","2F ","30 ","31 ","32 ",
    "33 ","34 ","35 ","36 ","37 ","38 ","39 ","3A ","3B ","3C ",
    "3D ","3E ","3F ","40 ","41 ","42 ","43 ","44 ","45 ","46 ",
    "47 ","48 ","49 ","4A ","4B ","4C ","4D ","4E ","4F ","50 ",
    "51 ","52 ","53 ","54 ","55 ","56 ","57 ","58 ","59 ","5A ",
    "5B ","5C ","5D ","5E ","5F ","60 ","61 ","62 ","63 ","64 ",
    "65 ","66 ","67 ","68 ","69 ","6A ","6B ","6C ","6D ","6E ",
    "6F ","70 ","71 ","72 ","73 ","74 ","75 ","76 ","77 ","78 ",
    "79 ","7A ","7B ","7C ","7D ","7E ","7F ","80 ","81 ","82 ",
    "83 ","84 ","85 ","86 ","87 ","88 ","89 ","8A ","8B ","8C ","8D"};
    }
}