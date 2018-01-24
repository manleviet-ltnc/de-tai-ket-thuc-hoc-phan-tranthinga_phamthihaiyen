using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiny_card.entity
{
    class CardList
    {
        public static List<Card> ReadFromFile(String albumName)
        {
            List<Card>  list = new List<Card>();

            string filePath = string.Format("{0}/{1}.txt", AppDomain.CurrentDomain.BaseDirectory, albumName);

            if (!File.Exists(filePath)) return new List<Card>();

            System.IO.StreamReader file = new System.IO.StreamReader(filePath);

            string newline;
            while ((newline = file.ReadLine()) != null)
            {
                if (string.IsNullOrEmpty(newline)) continue;
                if(File.Exists(relativePath(albumName, newline)))
                    list.Add(new Card(newline, relativePath(albumName, newline)));
            }
            file.Close();

            return list;
        }

        public static String relativePath(String albumName, String fileName)
        {
            string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            string[] parts = folderPath.Split('\\');
            string filePath= "";
            foreach(string part in parts)
                if(!part.Equals("Debug") 
                    && !part.Equals("bin") 
                    && !part.Equals(""))
                    filePath = filePath + part + '\\';
            return filePath + @"Resources\"+ albumName +@"\"+ fileName + ".jpg";
        }

        public static String relativePath(String albumName)
        {
            string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            string[] parts = folderPath.Split('\\');
            string filePath = "";
            foreach (string part in parts)
                if (!part.Equals("Debug")
                    && !part.Equals("bin")
                    && !part.Equals(""))
                    filePath = filePath + part + '\\';
            return filePath + @"Resources\" + albumName;
        }

        public static String ResourcePath()
        {
            string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            string[] parts = folderPath.Split('\\');
            string filePath = "";
            foreach (string part in parts)
                if (!part.Equals("Debug")
                    && !part.Equals("bin")
                    && !part.Equals(""))
                    filePath = filePath + part + '\\';
            return filePath + @"Resources\";
        }

        public static void WriteToFile(String word, String photoFilePath, String album)
        {
            var fileName = Path.GetFileName(photoFilePath);
            var extension = Path.GetExtension(photoFilePath);
            string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            string toFilePath = string.Format("{0}/{1}.txt", folderPath, album);

            var destination = relativePath(album);

            CreateAlbumIfNotExist(album);

            System.IO.File.Copy(photoFilePath, destination + @"\" + word + extension, true);
            if (File.Exists(folderPath))
                word = "\n" + word;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(toFilePath, true))
            {
                file.WriteLine(word);
            }
        }

        public static void DeleteCard(String word, String photoFilePath, String album)
        {
            string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            string toFilePath = string.Format("{0}/{1}.txt", folderPath, album);
            var destination = relativePath(album);

            string line = null;
            List<string> list = new List<string>();

            using (StreamReader reader = new StreamReader(toFilePath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }

            using (StreamWriter writer = new StreamWriter(toFilePath))
            {
                foreach(string str in list)
                {
                    if (String.Compare(str, word) != 0)
                    {
                        if(list.Last().Equals(str))
                            writer.WriteLine(str);
                        else
                            writer.WriteLine(str + "\n");
                    }
                }
            }

            System.IO.File.Delete(photoFilePath);
        }

        public static void CreateAlbumIfNotExist(String album)
        {
            var destination = relativePath(album);
            if (!Directory.Exists(destination))
                Directory.CreateDirectory(destination);
        }

        public static List<string> GetAllAlbumFolder()
        {
            List<string> list = new List<string>();
            string[] dirs = Directory.GetDirectories(ResourcePath(), "*", SearchOption.AllDirectories);
            foreach(String dir in dirs)
            {
                string[] parts = dir.Split('\\');
                string filePath = parts[parts.Length - 1];
                
                list.Add(filePath);
            }
            return list;
        }
    }
}
