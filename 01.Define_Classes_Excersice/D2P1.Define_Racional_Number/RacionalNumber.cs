﻿namespace D2P1.Define_Racional_Number
{
    public class RacionalNumber
    {
        private int numerator;
        private int denumerator;

        public RacionalNumber(int numerator, int denumerator)
        {
            Numerator = numerator;
            Denumerator = denumerator;
        }

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public int Denumerator
        {
            get { return denumerator; }
            set { denumerator = value; }
        }

        //public override string ToString()
        //{
        //    return $"{Numerator}/{Denumerator}";
        //}
    }
}
