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
    
    public partial class Преподаватели
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Преподаватели()
        {
            this.Текущая_практика = new HashSet<Текущая_практика>();
        }
    
        public int IDПреподавателя { get; set; }
        public string ФИОПреподавателя { get; set; }
        public string Должность { get; set; }
        public string Кафедра { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Текущая_практика> Текущая_практика { get; set; }
    }
}
