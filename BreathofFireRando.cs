
using BreathofFireRandomiser.Common;
using BreathofFireRandomiser.Inventory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _BreathofFireRandomiser
{
    public partial class BreathofFireRando : Form
    {

        bool loading = true;
        byte[] romData;
        byte[] romData2;
        public BreathofFireRando()
        {
            InitializeComponent();

        }
        private void Button5_Click(object sender, EventArgs e)
        {

        }
        private void RunChecksum()
        {
            try
            {
                using (var md5 = SHA1.Create())
                {
                    using (var stream = File.OpenRead(txtFileName.Text))
                    {
                        lblSHAChecksum.Text = BitConverter.ToString(md5.ComputeHash(stream)).ToLower().Replace("-", "");
                    }
                }
            }
            catch
            {
                lblSHAChecksum.Text = "????????????????????????????????????????";
            }
        }

        private void BreathofFireRando_Load(object sender, EventArgs e)
        {
            txtSeed.Text = (DateTime.Now.Ticks % 2147483647).ToString();

            try
            {
                using (TextReader reader = File.OpenText("lastBoF.txt"))
                {
                    txtFlags.Text = reader.ReadLine();
                    txtFileName.Text = reader.ReadLine();

                    DetermineChecks(null, null);

                    RunChecksum();
                    loading = false;
                }
            }
            catch
            {
                // ignore error
                loading = false;
            }
        }

        private void BtnNewSeed_Click(object sender, EventArgs e)
        {
            txtSeed.Text = (DateTime.Now.Ticks % 2147483647).ToString();
        }

        private bool LoadRom(bool extra = false)
        {
            try
            {
                romData = File.ReadAllBytes(txtFileName.Text);

                if (extra)
                    romData2 = File.ReadAllBytes(txtCompare.Text);

            }
            catch
            {
                MessageBox.Show("Empty file name(s) or unable to open files.  Please verify the files exist.");
                return false;
            }
            return true;
        }

        private void SaveRom()
        {
            string options = "";
            string finalFile = Path.Combine(Path.GetDirectoryName(txtFileName.Text), "BoFR_" + txtSeed.Text + "_" + txtFlags.Text + ".smc");
            File.WriteAllBytes(finalFile, romData);
            lblStatus.Text = "ROM hacking complete!  (" + finalFile + ")";
            txtCompare.Text = finalFile;
        }

        private void Swap(int firstAddress, int secondAddress)
        {
            byte holdAddress = romData[secondAddress];
            romData[secondAddress] = romData[firstAddress];
            romData[firstAddress] = holdAddress;
        }

        private int[] SwapArray(int[] array, int first, int second)
        {
            int holdAddress = array[second];
            array[second] = array[first];
            array[first] = holdAddress;
            return array;
        }

        private int ScaleValue(int value, double scale, double adjustment, Random r1)
        {
            var exponent = (double)r1.Next() / int.MaxValue * 2.0 - 1.0;
            var adjustedScale = 1.0 + adjustment * (scale - 1.0);

            return (int)Math.Round(Math.Pow(adjustedScale, exponent) * value, MidpointRounding.AwayFromZero);
        }

        private int[] Inverted_power_curve(int min, int max, int arraySize, double powToUse, Random r1)
        {
            int range = max - min;
            double p_range = Math.Pow(range, 1 / powToUse);
            int[] points = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                double section = (double)r1.Next() / int.MaxValue;
                points[i] = (int)Math.Round(max - Math.Pow(section * p_range, powToUse));
            }
            Array.Sort(points);
            return points;
        }

        private void DetermineFlags(object sender, EventArgs e)
        {
            if (loading)
                return;

            string flags = "";
            int number = (chkTreasures.Checked ? 1 : 0);
            flags += ConvertIntToChar(number);

            txtFlags.Text = flags;

        }

        private void DetermineChecks(object sender, EventArgs e)
        {
            string flags = txtFlags.Text;
            int number = ConvertChartoInt(Convert.ToChar(flags.Substring(0, 1)));
            chkTreasures.Checked = (number % 2 >= 1);

        }

        private string ConvertIntToChar(int number)
        {
            if (number >= 0 && number <= 9)
                return number.ToString();
            if (number >= 10 && number <= 35)
                return Convert.ToChar(55 + number).ToString();
            if (number >= 36 && number <= 61)
                return Convert.ToChar(61 + number).ToString();
            if (number == 62) return "!";
            if (number == 63) return "@";
            return "";
        }

        private int ConvertChartoInt(char character)
        {
            if (character >= Convert.ToChar("0") && character <= Convert.ToChar("9"))
                return character - 48;
            if (character >= Convert.ToChar("A") && character <= Convert.ToChar("Z"))
                return character - 55;
            if (character >= Convert.ToChar("a") && character <= Convert.ToChar("z"))
                return character - 61;
            if (character == Convert.ToChar("!")) return 62;
            if (character == Convert.ToChar("@")) return 63;
            return 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter writer = File.CreateText("LastBoF.txt"))
            {
                writer.WriteLine(txtFlags.Text);
                writer.WriteLine(txtFileName.Text);
            }
        }
        List<String> item_attributes;
        //Items, weapons and armour. Key items and unused are left out.

        public string itemID = "01";
        public string armourID = "21";
        public string weaponID = "11";

        public void ShuffleItems(Random r1, byte[] romData)
        {

            Armour.list = new List<Armour>();

            for (int iter2=0;iter2< Armour.addresses.Length;iter2++)
                {
                Armour a=new Armour();
                a.name = Armour.names[iter2];
                a.address = Armour.addresses[iter2];
                a.Object_type = "21";
               // Console.WriteLine("armour id " + Armour.ids[iter2]);
                a.id = Armour.ids[iter2];
                Armour.list.Add(a);
                }

            Weapons.list = new List<Weapons>();
            for (int iter2 = 0; iter2 < Weapons.addresses.Length; iter2++)
            {
                Weapons a = new Weapons();
                a.name = Weapons.names[iter2];
                a.address = Weapons.addresses[iter2];
                a.Object_type = "11";
                a.id = Weapons.ids[iter2];
                Weapons.list.Add(a);
            }

            Items.list = new List<Items>();
            for (int iter2 = 0; iter2 < Items.statuses.Length; iter2++)
            {
                Items a = new Items();
                a.name = Items.names[iter2];
                //a.address = Items.addresses[iter2];
                //Console.WriteLine(iter2);
                //Console.WriteLine(a.address);

                a.status = Items.statuses[iter2];
              //  Console.WriteLine(a.status);

                a.Object_type = "01";
                a.id = Items.ids[iter2];
                Items.list.Add(a);
            }
            Chest.list = new List<Chest>();

            Console.WriteLine(Chest.addresses.Length);
            Console.WriteLine(Chest.contentsarray.Length);


            for (int iter2 = 0; iter2 < Chest.addresses.Length; iter2++)
            {
                Chest a = new Chest();
                a.address = Chest.addresses[iter2];
                a.contents = Chest.contentsarray[iter2];
                Chest.list.Add(a);
            }



            foreach (Chest n in Chest.list)
            {
                /*
                int contentsint = Int32.Parse(contentsID, System.Globalization.NumberStyles.HexNumber);

                int itemint = Int32.Parse(itemID, System.Globalization.NumberStyles.HexNumber);
                int armourint = Int32.Parse(armourID, System.Globalization.NumberStyles.HexNumber);
                int weaponint = Int32.Parse(weaponID, System.Globalization.NumberStyles.HexNumber);
                */
                if (n.swappable())
                { 
                n.InsertRandomObject(r1,romData);
                }
            }
                //Console.WriteLine("contentsId" + contentsID);
                //Console.WriteLine(" armourID" + armourID);
                //Console.WriteLine("contentsint" + contentsint + " armourint" + armourint);
                /*
                if (contentsint == weaponint)
                {
                    bool swapped_this_chest = false;
                    foreach (Weapons w in Weapons.list)
                    {
                        if (swapped_this_chest == false)
                        {
                            //   Console.WriteLine("found"+i.name);

                            //   if(i.Matches_Chest_Contents(n.contents))
                            // { Console.WriteLine(i.name+"matches chest contents"); }

                            if (w.Swappable() == true && w.Matches_Chest_Contents(n.contents))
                            {
                                bool Found_Valid_Weapon= false;
                                while (Found_Valid_Weapon == false)
                                {
                                    Weapons w2 = n.RandomWeapon(r1);
                                    if (w2.Swappable() == true)
                                    {
                                        n.contents = w2.id + w2.Object_type;
                                        Found_Valid_Weapon = true;
                                        swapped_this_chest = true;
                                        int adr = Int32.Parse(n.address, System.Globalization.NumberStyles.HexNumber);
                                        int localweaponint = Int32.Parse(w2.id, System.Globalization.NumberStyles.HexNumber);
                                        // Console.WriteLine(aa);
                                        //Console.WriteLine(i2.id);
                                        byte weaponbyte = Convert.ToByte(localweaponint);
                                        //Console.WriteLine(a + " " + i2.id);
                                        int bb = Int32.Parse(w2.Object_type, System.Globalization.NumberStyles.HexNumber);
                                        byte b = Convert.ToByte(bb);
                                        romData[adr + 4] = weaponbyte;
                                        romData[adr + 5] = b;
                                        //Console.WriteLine("replaced a WEAPON");
                                        Console.WriteLine("replaced WEAPON " + w.name + " with " + w2.name);
                                       // Console.WriteLine("replaced" + w.status + " with " + w2.status);

                                        // Console.WriteLine("at address " + adr);
                                    }
                                }
                            }

                        }
                    }
                }

                if (contentsint == armourint)
                {
                    bool swapped_this_chest = false;
                    foreach (Armour a in Armour.list)
                    {
                        if (swapped_this_chest == false)
                        {
                            //Console.WriteLine("found armour "+a.name);

                            //if(a.Matches_Chest_Contents(n.contents))
                            //{  Console.WriteLine(a.name+"matches chest contents"); }


                            if (a.Swappable() == true && a.Matches_Chest_Contents(n.contents))
                            {
                                bool Found_Valid_Armour = false;
                                while (Found_Valid_Armour == false)
                                {
                                    Armour a2 = n.RandomArmour(r1);
                                    if (a2.Swappable() == true)
                                    {
                                        n.contents = a2.id + a2.Object_type;
                                        Found_Valid_Armour = true;
                                        swapped_this_chest = true;
                                        int adr = Int32.Parse(n.address, System.Globalization.NumberStyles.HexNumber);
                                        int localarmourint = Int32.Parse(a2.id, System.Globalization.NumberStyles.HexNumber);
                                        // Console.WriteLine(aa);
                                        //Console.WriteLine(i2.id);
                                        byte armourbyte = Convert.ToByte(localarmourint);
                                        //Console.WriteLine(a + " " + i2.id);
                                        int bb = Int32.Parse(a2.Object_type, System.Globalization.NumberStyles.HexNumber);
                                        byte b = Convert.ToByte(bb);
                                        romData[adr + 4] = armourbyte;
                                        romData[adr + 5] = b;
                                        Console.WriteLine("replaced ARMOR " + a.name + " with " + a2.name);
                                        //Console.WriteLine("replaced" + a.status + " with " + a2.status);

                                        // Console.WriteLine("at address " + adr);
                                    }
                                }
                            }

                        }
                    }
                }
                if (itemint==contentsint)
                {
                   //Console.WriteLine(contentsID + " equals " + itemID);
                    bool swapped_this_chest = false;
                    foreach (Items i in Items.list)
                    {
                        if(swapped_this_chest==false)
                        { 
                     //   Console.WriteLine("found"+i.name);
                     
                     //   if(i.Matches_Chest_Contents(n.contents))
                       // { Console.WriteLine(i.name+"matches chest contents"); }

                        if (i.Swappable() == true && i.Matches_Chest_Contents(n.contents))
                        {
                                bool Found_Valid_Item = false;
                                while (Found_Valid_Item == false)
                                {
                                    Items i2 = n.RandomItem(r1);
                                    if (i2.Swappable() == true)
                                    {
                                        n.contents = i2.id + i2.Object_type;
                                        Found_Valid_Item = true;
                                        swapped_this_chest = true;
                                        int adr = Int32.Parse(n.address, System.Globalization.NumberStyles.HexNumber);
                                        int aa = Int32.Parse(i2.id, System.Globalization.NumberStyles.HexNumber);
                                       // Console.WriteLine(aa);
                                        //Console.WriteLine(i2.id);
                                        byte a= Convert.ToByte(aa);
                                        //Console.WriteLine(a + " " + i2.id);
                                        int bb= Int32.Parse(i2.Object_type, System.Globalization.NumberStyles.HexNumber);
                                        byte b= Convert.ToByte(bb);
                                        romData[adr+4] = a;
                                        romData[adr + 5] = b;
                                        Console.WriteLine("replaced item: " + i.name + " with " + i2.name);
                                        //Console.WriteLine("replaced" + i.status + " with " + i2.status);

                                        // Console.WriteLine("at address " + adr);
                                    }
                                }
                        }
                        
                    }
                    }
                }
                if (contentsID == armourID)
                {
                    foreach (Armour i in Armour.list)
                    {
                        if (i.Swappable() == true && i.Matches_Chest_Contents(n.contents))
                        { n.Insert_Random_Armour(r1,romData); }
                    }
                }
                if (contentsID == weaponID)
                {
                    foreach (Weapons i in Weapons.list)
                    {
                        if (i.Swappable() == true && i.Matches_Chest_Contents(n.contents))
                        { n.Insert_Random_Weapons(r1,romData); }
                    }
                }
                */
               
                
               //}

            }
        
            

       /*
        public string item_name_for_chest(int number,string[] chests, List<int> item_list)
        {
            int adr = Int32.Parse(chests[number], System.Globalization.NumberStyles.HexNumber);
            
            return(item_name_for_chest_adr(adr + 4, item_list));

        }
        public string name_for_item_id(int id,List<int> item_list)
        {
            
            return name_for_item_desc_address(item_list[id])+item_attributes[id];
           
        }
        
        public string item_name_for_chest_adr(int adr,List<int> item_addresses)
        {
          
            int item_id = romData[adr];
            
            int hi = item_addresses[item_id];
            return name_for_item_desc_address(hi)+" "+item_attributes[item_id];
        }
        */
        public string name_for_item_desc_address(int adr)
        {
            string mystr = "";
            for (int x = 0; x < 14; x = x + 1)
            {
                byte romdata;
                romdata = romData[adr + x];
                if (romdata > 47 && romdata < 59)
                { mystr = mystr + (Char.ToString((char)romdata)); }
                else
                {
                    if (romdata > 192 && romdata < 219)
                    { mystr = mystr + (Char.ToString((char)(romdata - 128))); }
                    else
                    {

                        mystr = mystr + (Char.ToString((char)(romdata - 32)));

                    }
                }
            }
            return(mystr);
        }
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "SNES ROM (*.sfc)|*.sfc|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName;
                RunChecksum();
            }
        }

        private void RomPlugin(int locationStart, byte[] rom)
        {
            for (int lnI = 0; lnI < rom.Length; lnI++)
                romData[locationStart + lnI] = rom[lnI];
        }

        private void CmdRandomise_Click(object sender, EventArgs e)
        {
            try
            {
                LoadRom();
                Random r1 = new Random(Convert.ToInt32(txtSeed.Text));
                if (chkTreasures.Checked) ShuffleItems(r1,romData);
                SaveRom();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:  " + ex.StackTrace);
            }
          }

        }
    }

    



