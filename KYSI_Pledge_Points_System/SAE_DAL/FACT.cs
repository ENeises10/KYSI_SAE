//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAE_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class FACT
    {
        public int PLEDGE_CLASS_ID { get; set; }
        public int PLEDGE_ID { get; set; }
        public int POINT_VAL_ID { get; set; }
        public int POINT_ID { get; set; }
    
        public virtual PLEDGE PLEDGE { get; set; }
        public virtual PLEDGE_CLASS PLEDGE_CLASS { get; set; }
        public virtual POINT_VALUES POINT_VALUES { get; set; }
        public virtual POINT POINT { get; set; }
    }
}
