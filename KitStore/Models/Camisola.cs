using KitStore.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace KitStore.Models
{
    public class Camisola
    {
        [Key]
        public int Id { get; set; }
        public string ImagemURL { get; set; }

        public string NomeEquipa { get; set; }

        public string NomeMarca { get; set; }

        public string Equipamento { get; set; }

        public float Preco { get; set; }

        public Liga Liga { get; set; }
    }
}
