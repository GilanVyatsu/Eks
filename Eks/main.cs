//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eks
{
    using System;
    using System.Collections.Generic;
    
    public partial class main
    {
        public int id { get; set; }
        public string Auto { get; set; }
        public string Managers { get; set; }
        public string Buyer { get; set; }
    
        public virtual Auto Auto1 { get; set; }
        public virtual Buyer Buyer1 { get; set; }
        public virtual Managers Managers1 { get; set; }
    }
}