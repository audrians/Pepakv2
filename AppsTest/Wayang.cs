//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppsTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class Wayang
    {
        public int WayangId { get; set; }
        public string JenengWayang { get; set; }
        public string GambarURL { get; set; }
        public Nullable<int> KategoriId { get; set; }
    
        public virtual Kategori Kategori { get; set; }
    }
}