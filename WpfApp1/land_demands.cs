//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class land_demands
    {
        public int Id { get; set; }
        public string Address_City { get; set; }
        public string Address_Street { get; set; }
        public string Address_House { get; set; }
        public string Address_Number { get; set; }
        public Nullable<int> MinPrice { get; set; }
        public Nullable<int> MaxPrice { get; set; }
        public int AgentId { get; set; }
        public int ClientId { get; set; }
        public string MinArea { get; set; }
        public string MaxArea { get; set; }
    }
}
