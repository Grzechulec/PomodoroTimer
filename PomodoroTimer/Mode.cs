using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    class Mode
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public Sound workSound { get; set; }
        public Sound changeSound { get; set; }
        public Sound pauseSound { get; set; }
        public int workDuration { get; set; }
        public int pauseDuration { get; set; }
        public int seriesAmount { get; set; }
    }
}
