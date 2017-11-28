using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiny_card.entity
{
    public class Card
    {
        private String word;
        private String path;

        public Card(String word, String path)
        {
            this.Word = word;
            this.Path = path;
        }

        public string Word { get => word; set => word = value; }
        public string Path { get => path; set => path = value; }
    }
}
