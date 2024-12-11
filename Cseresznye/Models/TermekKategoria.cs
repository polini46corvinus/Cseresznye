using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Cseresznye.Models;

[Table("TERMEK_KATEGORIA")]
public partial class TermekKategoria
{
    [Key]
    [Column("KategoriaID")]
    public int KategoriaId { get; set; }

    [StringLength(50)]
    public string Nev { get; set; } = null!;

    [StringLength(255)]
    public string? Leiras { get; set; }

    [InverseProperty("Kategoria")]
    public virtual ICollection<Termek> Termek { get; } = new List<Termek>();
}
