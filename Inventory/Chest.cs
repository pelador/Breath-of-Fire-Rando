using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BreathofFireRandomiser.Inventory
{
    public class Chest
    {
        public static List<Chest> list;
        public string contents;
        public string address;

        public bool swappable()
        {
            foreach (Armour a in Armour.list)
            {
                if (a.Matches_Chest_Contents(this.contents))
                {
                    if (a.Swappable()==true)
                    {
                        Console.WriteLine("swapping Armour " + a.name);
                        return true; }
                 }
            }
            foreach (Items a in Items.list)
            {
                if (a.Matches_Chest_Contents(this.contents))
                {
                    if (a.Swappable() == true)
                    {
                        Console.WriteLine("swapping Item " + a.name);
                        return true; }
                }
            }
            foreach (Weapons a in Weapons.list)
            {
                if (a.Matches_Chest_Contents(this.contents))
                {
                    if (a.Swappable() == true)
                    {
                        Console.WriteLine("swapping Weapon " + a.name);
                        return true; }
                }
            }
            return false;
        }
        public void InsertRandomObject(Random r, Byte[] arr)


        {

            int choice = r.Next(1, 3);

            GameObject a=Items.GetRandomValid(r);

            if(choice==1)
            {
                a=Items.GetRandomValid(r); 
            }
            if(choice==2)
            {
                a = Weapons.GetRandomValid(r);
            }
            if (choice==3)
            {
                a = Armour.GetRandomValid(r); 
            }


            int adr = Int32.Parse(this.address, System.Globalization.NumberStyles.HexNumber);
            int aa = Int32.Parse(a.id, System.Globalization.NumberStyles.HexNumber);
           
            byte first = Convert.ToByte(aa);
            //Console.WriteLine(a + " " + i2.id);
            int bb = Int32.Parse(a.Object_type, System.Globalization.NumberStyles.HexNumber);
            byte second = Convert.ToByte(bb);
            arr[adr + 4] = first;
            arr[adr + 5] = second;
            Console.WriteLine("for " + a.name);


        }
        /*
        public void Insert_Random_Armour(Random r, byte[] rom)
        {
            bool Found_Valid_Armour = false;
            while (Found_Valid_Armour == false)
            {
                Armour i = RandomArmour(r);
                if (i.Swappable() == true)
                {
                    this.contents = i.id + i.Object_type;
                    Found_Valid_Armour = true;
                    int adr = Int32.Parse(this.address, System.Globalization.NumberStyles.HexNumber);
                    rom[adr] = Byte.Parse(i.id);
                    rom[adr + 1] = Byte.Parse(i.Object_type);
                }
            }
        }

        public void Insert_Random_Weapons(Random r, byte[] rom)
        {
            bool Found_Valid_Weapon = false;
            while (Found_Valid_Weapon == false)
            {
                Weapons i = RandomWeapon(r);
                if (i.Swappable() == true)
                {
                    this.contents = i.id + i.Object_type;
                    Found_Valid_Weapon = true;
                    int adr = Int32.Parse(this.address, System.Globalization.NumberStyles.HexNumber);
                    rom[adr] = Byte.Parse(i.id);
                    rom[adr + 1] = Byte.Parse(i.Object_type);

                }
            }
        }
        */
        public static string[] addresses =  {
            "523E1 ","523E7 ","523EE ","523F4 ","523FB ","52401 ","52407 ","5240D ","52413 ","5241A ","52420 ",
            "52426 ","5242C ","52432 ","52438 ","5243E ","52445 ","5244B ","52451 ","52457 ","5245D ",
            "52463 ","52469 ","5246F ","52477 ","5247D ","52484 ","5248A ","52490 ","52497 ","5249D ",
            "524A3 ","524A9 ","524AF ","524B5 ","524BB ","524C1 ","524C8 ","524CE ","524D4 ","524DA ",
            "524E0 ","524E6 ","524EC ","524F2 ","524F9 ","524FF ","52505 ","5250C ","52512 ","52518 ",
            "5251F ","52525 ","5252B ","52531 ","52537 ","5253D ","52543 ","52549 ","52550 ","52556 ",
            "5255C ","52563 ","52569 ","5256F ","52575 ","5257C ","52582 ","52588 ","5258E ","52594 ",
            "5259B ","525A1 ","525A7 ","525AD ","525B3 ","525B9 ","525BF ","525C6 ","525CC ","525D2 ",
            "525D8 ","525DE ","525E5 ","525EB ","525F1 ","525F7 ","525FE ","52604 ","5260A ","52610 ",
            "52616 ","5261C ","52622 ","52628 ","5262F ","52635 ","5263B ","52641 ","52647 ","5264D ",
            "52654 ","5265A ","52660 ","52666 ","5266D ","52673 ","52679 ","5267F ","52686 ","5268C ",
            "52692 ","52698 ","5269E ","526A4 ","526AA ","526B1 ","526B7 ","526BD ","526C3 ","526C9 ",
            "526CF ","526D5 ","526DC ","526E3 ","526E9 ","526EF ","526F5 ","526FB ","52701 ","52708 ",
            "5270E ","52714 ","5271A ","52720 ","52726 ","5272D ","52733 ","52739 ","5273F ","52745 ",
            "5274B ","52751 ","52757 ","5275E ","52764 ","5276A ","52770 ","52776 ","5277C ","52782 ",
            "52789 ","5278F ","52795 ","5279B ","527A1 ","527A7 ","527AD ","527B4 ","527BA ","527C0 ",
            "527C6 ","527CC ","527D2 ","527D8 ","527DF ","527E5 ","527EB ","527F2 ","527F8 ","527FE ",
            "52804 ","5280A ","52811 ","52817 ","5281D ","52823 ","52829 ","5282F ","52836 ","5283C ",
            "52842 ","52848 ","5284E ","52854 ","5285B ","52862 ","52868 ","5286E ","52875 ","5287B ",
            "52881 ","52887 ","5288D ","52893 ","52899 ","5289F ","528A6 ","528AC ","528B2 ","528B8 ",
            "528BE ","528C5 ","528CB ","528D1 ","528D7 ","528DD ","528E3 ","528EA ","528F0 ","528F6 ",
            "528FC ","52902 ","52908 ","5290E ","52914 ","5291B ","52921 ","52927 ","5292E ","52934 ",
            "5293A ","52940 ","52946 ","5294C ","52952 ","52959 ","5295F ","52965 ","5296C ","52972 ",
            "52978 ","5297E ","52984 ","5298A ","52991 ","52997 ","5299D ","529A3 ","529A9 ","529AF ",
            "529B5 ","529BB ","529C2 ","529C8 ","529CE ","529D4 ","529DA ","529E0 ","529E6 ","529EC ",
            "529F3 ","529F9 ","529FF ","52A05 ","52A0B ","52A11 ","52A17 ","52A1D ","52A24 ","52A2A ",
            "52A30 ","52A36 ","52A3C ","52A43 ","52A49 ","52A4F ","52A55 ","52A5B ","52A61 ","52A67 ",
            "52A6E ","52A74 ","52A7A ","52A80 ","52A86 ","52A8C ","52A93 ","52A99 ","52A9F ","52AA5 ",
            "52AAB ","52AB1 ","52AB7 ","52ABE ","52AC4 ","52ACA ","52AD0 ","52AD6 ","52ADC ","52AE2 ",
            "52AE8 ","52AEF ","52AF5 ","52AFB ","52B01 ","52B07 ","52B0E ","52B14 ","52B1A ","52B20 ",
            "52B27 ","52B2D ","52B33 ","52B39 ","52B3F ","52B45 ","52B4B ","52B51 ","52B58 ","52B5E ",
            "52B64 ","52B6A ","52B70 ","52B76 ","52B7C ","52B82 ","52B89 ","52B8F ","52B95 ","52B9B ",
            "52BA1 ","52BA7 ","52BAD ","52BB3 ","52BBA ","52BC0 ","52BC6 ","52BCC ","52BD2 ","52BD8 ",
            "52BDE ","52BE5 ","52BEB ","52BF1 ","52BF8 ","52BFE ","52C04 ","52C0A "
            };
        public static string[] contentsarray = {"3901 ","0801 ","5501 ","0801 ","3B01 ","0801 ","0901 ","0A01 ","0401 ","1D01 ",
"3C01 ","0F01 ","0601 ","0801 ","0B01 ","8721 ","0901 ","0801 ","2001 ","0001 ",
"1721 ","0101 ","0801 ","5401 ","4501 ","5F01 ","5901 ","5B01 ","6721 ","0C01 ",
"7301 ","0801 ","7301 ","6E01 ","7201 ","0801 ","6A01 ","2901 ","2701 ","3401 ",
"5B11 ","0801 ","5921 ","0121 ","0801 ","0801 ","0101 ","0111 ","0801 ","3121 ",
"0801 ","0101 ","0801 ","4D21 ","0801 ","3201 ","2801 ","2901 ","0801 ","7301 ",
"1101 ","7301 ","5511 ","0901 ","3301 ","3611 ","0D01 ","3E21 ","0D01 ","1D01 ",
"0801 ","0901 ","7801 ","1801 ","3201 ","0E21 ","2521 ","2501 ","8C21 ","0B01 ",
"0A01 ","1D01 ","4321 ","3301 ","0901 ","1201 ","2701 ","0901 ","1611 ","1D01 ",
"0911 ","0F01 ","7621 ","0801 ","0A01 ","0801 ","0A01 ","3221 ","5821 ","0801 ",
"0801 ","0821 ","0001 ","2101 ","0901 ","0901 ","0A01 ","0901 ","0D01 ","0801 ",
"0801 ","0F01 ","0E01 ","0C01 ","0901 ","5E11 ","0C01 ","0301 ","2001 ","0A01 ",
"0801 ","0E01 ","0901 ","0E11 ","0801 ","0801 ","0801 ","0D01 ","0F01 ","0B01 ",
"2801 ","5621 ","0801 ","0801 ","6621 ","2101 ","0B01 ","1901 ","0F01 ","4F21 ",
"0F01 ","1D01 ","0701 ","0801 ","7E21 ","1521 ","3521 ","0B01 ","0801 ","5A21 ",
"3421 ","7C21 ","1901 ","0801 ","0D01 ","0F01 ","1001 ","0B01 ","0801 ","7301 ",
"0801 ","7C21 ","0801 ","0801 ","6501 ","3301 ","3201 ","5D01 ","7121 ","0901 ",
"8021 ","7121 ","0A01 ","7F21 ","0801 ","0D01 ","0801 ","0801 ","0801 ","0D01 ",
"1D01 ","0411 ","1D01 ","0101 ","0101 ","0201 ","2201 ","2101 ","6601 ","1D01 ",
"3401 ","1001 ","0601 ","0801 ","0801 ","0601 ","7621 ","0801 ","0801 ","0601 ",
"1D01 ","2001 ","1D01 ","7801 ","0801 ","0901 ","7421 ","0F01 ","0801 ","0801 ",
"2001 ","0801 ","0801 ","4311 ","3721 ","0801 ","4311 ","6C21 ","0901 ","3521 ",
"4211 ","0801 ","0801 ","8D21 ","1D01 ","6A21 ","2D21 ","0801 ","1D01 ","0B01 ",
"0B01 ","0801 ","0801 ","4C21 ","0901 ","0701 ","5311 ","2111 ","5E21 ","3721 ",
"1D01 ","0801 ","0801 ","3411 ","0801 ","4021 ","1D01 ","0F01 ","0801 ","3101 ",
"0801 ","1D01 ","4F21 ","1921 ","0801 ","4021 ","2411 ","0801 ","0801 ","0801 ",
"0801 ","0C01 ","0601 ","4511 ","0901 ","0901 ","5D21 ","0601 ","4B21 ","6A21 ",
"1D01 ","3401 ","0901 ","5201 ","3301 ","0801 ","2501 ","4221 ","2901 ","0801 ",
"1121 ","1D01 ","2B11 ","0901 ","5D21 ","0F01 ","3321 ","0801 ","0801 ","2301 ",
"6B21 ","6421 ","4521 ","6221 ","4611 ","4A21 ","2211 ","2801 ","0E01 ","2901 ",
"1D01 ","8421 ","7821 ","6521 ","3F11 ","0F01 ","2901 ","3201 ","3301 ","3101 ",
"3301 ","3401 ","3201 ","7221 ","4821 ","2D11 ","1001 ","1A01 ","2401 ","0921 ",
"6521 ","4121 ","7321 ","1E21 ","2B21 ","3301 ","1001 ","2601 ","3401 ","3401 ",
"3301 ","3201 ","2801 ","3201 ","2A01 ","0A01 ","0A01 ","0001 ","0001 "};
    }
    
}
