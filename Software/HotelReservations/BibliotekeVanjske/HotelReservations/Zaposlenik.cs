//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt_faza_1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zaposlenik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zaposlenik()
        {
            this.Izvjescas = new HashSet<Izvjesca>();
            this.Popravio_kvar = new HashSet<Popravio_kvar>();
        }
    
        public int OIB_zaposlenika { get; set; }
        public string OIB_hotela { get; set; }
        public string id_tip { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string IBAN { get; set; }
        public System.DateTime datum_rodjenja { get; set; }
        public string email { get; set; }
        public string adresa { get; set; }
        public string korisnicko_ime { get; set; }
        public byte[] slika_profila { get; set; }
        public string telefon { get; set; }
        public int korisnik_id { get; set; }
    
        public virtual Hotel Hotel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Izvjesca> Izvjescas { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Popravio_kvar> Popravio_kvar { get; set; }
        public virtual Tip_zaposlenika Tip_zaposlenika { get; set; }
    }
}
