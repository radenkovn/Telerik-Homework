namespace Facade.Classes.Library
{
    using System;
    using System.Linq;

    public interface IPlayer
    {
        void Play();

        void Stop();
        MediaType CurrentMediaType();

        void Load(Media media);
    }
}
