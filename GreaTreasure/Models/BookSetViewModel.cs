using System.Collections.Generic;

namespace GreaTreasure.Models
{
    public class BookSetViewModel
    {
        public int ShelfID { get; set; }
        public int NumberOfBooks { get; set; }
        public List<string> BookTitles { get; set; } = new List<string>();
        public List<string> Descriptions { get; set; } = new List<string>();
        public List<int> Heights { get; set; } = new List<int>();
        public List<int> Widths { get; set; } = new List<int>();
    }
}
