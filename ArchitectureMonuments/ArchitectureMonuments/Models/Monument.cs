//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArchitectureMonuments.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Monument
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string adress { get; set; }
        public string description { get; set; }
        public string main_photo_path { get; set; }
        public string sub_photo_path { get; set; }
        public Nullable<int> likes { get; set; }
    }
}
