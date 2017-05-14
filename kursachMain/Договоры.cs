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
    
    public partial class Договоры
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Договоры()
        {
            this.Предприятия = new HashSet<Предприятия>();
            this.Текущая_практика = new HashSet<Текущая_практика>();
        }
    
        public int IDДоговора { get; set; }
        public string НомерДоговора { get; set; }
        public string ДатаЗаключения { get; set; }
        public string ФИОИсполнителя { get; set; }
        public string ДолжностьИсполнителя { get; set; }
        public string НазваниеПредприятия { get; set; }
        public string УченаяСтепень { get; set; }
        public string Звание { get; set; }
        public string СерияПаспорта { get; set; }
        public string НомерПаспорта { get; set; }
        public string ДатаВыдачи { get; set; }
        public string ОрганВыдачи { get; set; }
        public string ИдентификационныйНомер { get; set; }
        public string НомерСтраховогоСвидетельства { get; set; }
        public string ДомашнийАдрес { get; set; }
        public string ТелРабочий { get; set; }
        public string ТелДомашний { get; set; }
        public string МестоОсновнойРаботы { get; set; }
        public int IDСтудента { get; set; }
        public string ДатаПроведения { get; set; }
        public string КоличествоЧасов { get; set; }
        public string СтоимостьОдногоЧаса { get; set; }
        public string ОбщаяСумма { get; set; }//-
        public string НомерПриказа { get; set; }
        public string ДатаПриказа { get; set; }
        public string ФИООтделаКадров { get; set; }
        public string ФИОЗавКафедрой { get; set; }
        public string НазваниеКафедры { get; set; }
        public string РуководительПрактики { get; set; }
    
        public virtual Студенты Студенты { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Предприятия> Предприятия { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Текущая_практика> Текущая_практика { get; set; }
    }
}
