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
    
    public partial class Group
    {
        public Group()
        {
            this.Attestation = new HashSet<Attestation>();
            this.Student = new HashSet<Student>();
        }
    
        public int IdGroup { get; set; }
        public string Title { get; set; }
        public string CourseNumber { get; set; }
        public int IdSpeciality { get; set; }
    
        public virtual ICollection<Attestation> Attestation { get; set; }
        public virtual Speciality Speciality { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
