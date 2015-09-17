namespace Facade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Facade.Classes.Library;
    class Playstation
    {
        private CDPlayer player;
        private IList<Media> database;
        private readonly DisplayController displayController;
        private int currentIndex;

        private Playstation()
        {
            this.database = new List<Media>();
            this.displayController = new DisplayController();
            this.currentIndex = 0;
        }

        public static Playstation CreateInstance()
        {
            return new Playstation();
        }
        public void Start()
        {
            this.displayController.LoadIntro();
            this.player.Load(database[0]);
            this.currentIndex = 1;
        }
        public void PlayNext()
        {
            if (this.currentIndex <= this.database.Count)
            {
                this.player.Stop();
                this.player.Load(database[this.currentIndex]);
            }
        }
        public void Close()
        {
            this.player.Stop();
            this.displayController.LoadOutro();
        }
        public void LoadDatabase()
        {
            this.database.Add(new Media("The Last of Us", MediaType.Game));
            this.database.Add(new Media("Inception", MediaType.Video));
            this.database.Add(new Media("Metallica", MediaType.Music));
            this.database.Add(new Media("Gears of War", MediaType.Game));
            this.database.Add(new Media("Star Wars", MediaType.Video));
            this.database.Add(new Media("Justin Bieber", MediaType.Music));
        }
    }
}
