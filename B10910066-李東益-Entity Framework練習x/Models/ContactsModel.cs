using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace B10910066_李東益_Entity_Framework練習x.Models
{
    public partial class ContactsModel : DbContext
    {
        public ContactsModel()
            : base("name=ContactsModel")
        {
        }

        public virtual DbSet<ContactsTable> ContactsTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactsTable>()
                .Property(e => e.Id)
                .IsUnicode(false);
        }
    }
}
