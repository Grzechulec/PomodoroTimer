using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }
        DbSet<Sound> Sounds { get; set; }
        DbSet<Mode> Modes { get; set; }

    }
}
