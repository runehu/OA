//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill_Leave
    {
        public int Leave { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> BeginDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> BillStateID { get; set; }
        public Nullable<int> WorkFlowID { get; set; }
    
        public virtual oldWF_BillState oldWF_BillState { get; set; }
        public virtual oldWF_WorkFlow oldWF_WorkFlow { get; set; }
    }
}
