using Cliente.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cliente.Domain.Entity
{
    [Table("Cliente", Schema = "Pessoa")]
    public class Clientes
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public SexoEnum Sexo { get; set; }
    }
}
