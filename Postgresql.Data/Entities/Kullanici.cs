using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Postgresql.Data.Entities
{
    [Table("Kullanici")]
    class Kullanici
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sifre { get; set; }
    }
}
