using System.ComponentModel.DataAnnotations;

namespace LazyPinger.Base.Models
{
    public class UserSelection
    {
        [Key]
        public int ID { get; set; }

        public bool AutoRun { get; set; }

        public bool FastPing { get; set; }

        public bool FastnessLevel { get; set; }

    }
}
