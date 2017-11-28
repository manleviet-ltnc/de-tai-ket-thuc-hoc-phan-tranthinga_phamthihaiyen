using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiny_card.entity
{
    class CardList
    {
        public static List<Card> ReadFromFile()
        {
            List<Card>  list = new List<Card>();

            string filePath = string.Format("{0}/{1}", AppDomain.CurrentDomain.BaseDirectory, "card.txt");
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);

            string newline;
            while ((newline = file.ReadLine()) != null)
            {
                list.Add(new Card(newline, relativePath(newline)));
            }
            file.Close();

            return list;
        }

        public static String relativePath(String path)
        {
            string resFolder = AppDomain.CurrentDomain.RelativeSearchPath;
            return resFolder + path + ".jpg";
        }
    }
}
