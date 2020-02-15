namespace EsercizioEsame.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ticket")]
    public partial class Ticket
    {
        public int TicketId { get; set; }

        public int UserId { get; set; }

        [StringLength(50)]
        public string Agent { get; set; }

        [Column(TypeName = "datetime2")]
        [DataType(DataType.Date)]
        public DateTime RequestDate { get; set; }

        [Column(TypeName = "datetime2")]
        [DataType(DataType.Date)]
        public DateTime? CloseDate { get; set; }

        public int StatusRequest { get; set; }

        [Required]
        [StringLength(50)]
        public string Request { get; set; }

        [Required]
        public string Description { get; set; }

        public string Answer { get; set; }

        public virtual Anagrafica Anagrafica { get; set; }
    }
}
