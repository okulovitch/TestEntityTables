//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kursachMain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Студенты
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Студенты()
        {
            this.Договоры = new HashSet<Договоры>();
        }
    
        public int IDСтудента { get; set; }
        public string ФИОСтудента { get; set; }
        public int IDГруппы { get; set; }
        public string НомерТелефона { get; set; }
        public string НомерЗачетки { get; set; }
    
        public virtual Группы Группы { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Договоры> Договоры { get; set; }
    }
}
