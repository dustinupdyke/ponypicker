using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using Newtonsoft.Json;

namespace ThePonyPicker
{
    public class Ponies : List<Pony> { }

    public class Pony
    {
        public string Name { get; set; }
        public string Saying { get; set; }
        public string Picture { get; set; }
        public Color BackgroundColor { get; set; }  
    }

    public static class PonyManager
    {
        public static Ponies GetAll()
        {
            var raw = File.ReadAllText(@"..\..\assets\ponies.json");
            return JsonConvert.DeserializeObject<Ponies>(raw);
        }

        public static void Save(Ponies ponies)
        {
            var json = JsonConvert.SerializeObject(ponies, Formatting.Indented);
            File.WriteAllText(@"..\..\assets\ponies.json", json);
        }

        public static Pony GetByName(string name)
        {
            return GetAll().FirstOrDefault(p => p.Name == name);
        }

        private static void PonyMaker()
        {
            var ponies = new Ponies();
            var pony = new Pony();
            pony.Name = "Twilight Sparkle";
            pony.Saying = "B O O K S";
            pony.Picture = @"..\..\assets\twilight.png";
            pony.BackgroundColor = Color.Purple;
            ponies.Add(pony);
            pony = new Pony();
            pony.Name = "Diamond Tiara";
            pony.Saying = "You don't have a cutie mark";
            pony.Picture = @"..\..\assets\diamond.jpg";
            pony.BackgroundColor = Color.Purple;
            ponies.Add(pony);
            pony = new Pony();
            pony.Name = "Scootaloo";
            pony.Saying = "AWSOMENESS";
            pony.Picture = @"..\..\assets\scootaloo.png";
            pony.BackgroundColor = Color.DarkOrange;
            ponies.Add(pony);
            pony = new Pony();
            pony.Name = "Sweety Bell";
            pony.Saying = "PRETTY";
            pony.Picture = @"..\..\assets\sweety.png";
            pony.BackgroundColor = Color.LightPink;
            ponies.Add(pony);
            pony = new Pony();
            pony.Name = "Apple Bloom";
            pony.Saying = "YEEHAW";
            pony.Picture = @"..\..\assets\apple.gif";
            pony.BackgroundColor = Color.Goldenrod;
            ponies.Add(pony);
            pony = new Pony();
            pony.Name = "Baba Seed";
            pony.Saying = "That's not how you talk to my friends.";
            pony.Picture = @"..\..\assets\baba.jpg";
            pony.BackgroundColor = Color.Black;
            ponies.Add(pony);
            pony = new Pony();
            pony.Name = "Rarity";
            pony.Saying = "STYLE";
            pony.Picture = @"..\..\assets\rarity.png";
            pony.BackgroundColor = Color.Gray;
            ponies.Add(pony);
            pony = new Pony();
            pony.Name = "Pinkie Pie";
            pony.Saying = "Party Time!";
            pony.Picture = @"..\..\assets\pinkie.png";
            pony.BackgroundColor = Color.HotPink;
            ponies.Add(pony);
            pony = new Pony();
            pony.Name = "Rainbow Dash";
            pony.Saying = "Radicalness!";
            pony.Picture = @"..\..\assets\dash.png";
            pony.BackgroundColor = Color.MintCream;
            ponies.Add(pony);
            PonyManager.Save(ponies);
        }
    }
}
