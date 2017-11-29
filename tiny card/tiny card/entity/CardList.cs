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
            string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            string[] parts = folderPath.Split('\\');
            string filePath= "";
            foreach(string part in parts)
            {
                if(!part.Equals("Debug") && !part.Equals("bin") && !part.Equals(""))
                {
                    filePath = filePath + part + '\\';
                }
            }
            return filePath + @"Resources\"+ path + ".jpg";
        }
    }
}
