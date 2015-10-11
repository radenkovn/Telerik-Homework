namespace Facade.Classes.Library
{
    using System;
    using System.Linq;
    public class CDPlayer : IPlayer
    {
        private Media media;
        private int mediaIndex;

        public CDPlayer()
        {
            this.media = null;
            this.mediaIndex = 0;
        }
        public void Play()
        {
            if (this.media == null)
            {
                Console.WriteLine("No media loaded!");
                return;
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("You are playing {0}", this.media.Name);
            Console.WriteLine("------------------------------------");
        }

        public void Stop()
        {
            if (this.media == null)
            {
                return;
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("{0} ejected!", this.media.Name);
            Console.WriteLine("------------------------------------");
            this.media = null;
        }

        public void Load(Media media)
        {

            this.media = media.Clone();
        }


        public MediaType CurrentMediaType()
        {
            if (this.media == null)
            {
                Console.WriteLine("No media loaded!");
                return MediaType.None;
            }
            return this.media.Type;

        }
    }
}
