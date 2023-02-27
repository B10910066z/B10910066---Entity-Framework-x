namespace B10910066_李東益_Entity_Framework練習x.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactsTable")]
    public partial class ContactsTable
    {
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int quantity { get; set; }

        public int price { get; set; }

        [Required]
        [StringLength(50)]
        public string category { get; set; }
    }
}
