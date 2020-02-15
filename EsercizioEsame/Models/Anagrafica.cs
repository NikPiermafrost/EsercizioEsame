namespace EsercizioEsame.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Anagrafica")]
    public partial class Anagrafica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Anagrafica()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int AnagraficaId { get; set; }

        [StringLength(50)]
        public string Nome { get; set; }

        [StringLength(50)]
        public string Cognome { get; set; }

        public string Indirizzo { get; set; }

        [StringLength(50)]
        public string Telefono { get; set; }

        public bool? IsCliente { get; set; }

        public bool? IsFornitore { get; set; }

        public bool? IsInterno { get; set; }

        [StringLength(50)]
        public string CodiceAnagrafica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
