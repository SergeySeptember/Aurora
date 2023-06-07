using System.ComponentModel.DataAnnotations.Schema;

namespace Aurora.Entity
{
    public class Ads
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime Date_create { get; set; }
    }
}