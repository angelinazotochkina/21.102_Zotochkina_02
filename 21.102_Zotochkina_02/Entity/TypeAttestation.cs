//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _21._102_Zotochkina_02.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypeAttestation
    {
        public TypeAttestation()
        {
            this.Attestation = new HashSet<Attestation>();
        }
    
        public int IdTypeAttestation { get; set; }
        public string Title { get; set; }
    
        public virtual ICollection<Attestation> Attestation { get; set; }
    }
}
