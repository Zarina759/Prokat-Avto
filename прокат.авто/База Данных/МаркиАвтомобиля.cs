//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace прокат.авто.База_Данных
{
    using System;
    using System.Collections.Generic;
    
    public partial class МаркиАвтомобиля
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public МаркиАвтомобиля()
        {
            this.Автомобили = new HashSet<Автомобили>();
        }
    
        public int КодМарки { get; set; }
        public string НаименованиеМаркиАвто { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Автомобили> Автомобили { get; set; }
    }
}
