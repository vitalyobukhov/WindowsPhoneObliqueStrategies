using System;

namespace WindowsPhoneObliqueStrategies
{
    public class Strategy
    {
        private static readonly string[] strategies;
        private static readonly Random rnd;


        public int Number { get; private set; }
        public string Text { get; private set; }


        static Strategy()
        {
            const char separator = '\n';
            strategies = Strategies.Texts.Split(separator);

            rnd = new Random();
        }

        private Strategy() 
        { }


        public static Strategy Random()
        {
            var number = rnd.Next(0, strategies.Length);
            return new Strategy
            {
                Number = number,
                Text = strategies[number]
            };
        }
    }
}
