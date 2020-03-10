using System;

namespace BogLib
{
    public class Bog
    {
        private string _titel;
        private string _forfatter;
        private int _sidetal;
        private string _isbn13;

        public Bog() { }

        public Bog(string titel, string forfatter, int sidetal, string isbn13)
        {
            _titel = titel;
            _forfatter = forfatter;
            _sidetal = sidetal;
            _isbn13 = isbn13;
        }

        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }
        public string Forfatter
        {
            get { return _forfatter; }
            set
            {
                string spacesremoved = value.Replace(" ", "");
                if (spacesremoved.Length >= 2)
                {
                    _forfatter = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

        }
        public int Sidetal {
            get { return _sidetal; }
            set
            {
                if (value >= 4 && value <= 1000)
                {
                    _sidetal = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
             }

        public string Isbn13
        {
            get { return _isbn13; }
            set
            {
                if (value.Length == 13)
                {
                    _isbn13 = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public override string ToString()
        {
            return $"Titel:{Titel} Forfatter:{Forfatter} Sidetal:{Sidetal} Isbn13:{Isbn13}";
        }
    }
}