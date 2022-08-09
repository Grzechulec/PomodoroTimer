using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public class Sound
    {
        private SoundPlayer player;
        public Sound(int Id, string Name, string Source)
        {
            this.Id = Id;
            this.Name = Name;
            this.Source = Source;
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; }
        public string Source { get; set; } = null!;

        public void play()
        {
            player = new SoundPlayer(Source);
            player.Load();
            player.Play();
        }
    }
}
