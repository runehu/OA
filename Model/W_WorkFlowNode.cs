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
    
    public partial class W_WorkFlowNode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public W_WorkFlowNode()
        {
            this.W_WorkFlowBranch = new HashSet<W_WorkFlowBranch>();
            this.W_WorkFlowBranch1 = new HashSet<W_WorkFlowBranch>();
            this.W_WorkFlowNode1 = new HashSet<W_WorkFlowNode>();
            this.W_WorkFlowNode11 = new HashSet<W_WorkFlowNode>();
            this.W_WorkFlowNode12 = new HashSet<W_WorkFlowNode>();
            this.W_WrokFlowRole = new HashSet<W_WrokFlowRole>();
            this.WR_WrokFlowApplyDetails = new HashSet<WR_WrokFlowApplyDetails>();
        }
    
        public int wn_Id { get; set; }
        public int wn_WorkFlowID { get; set; }
        public string wn_Name { get; set; }
        public int wn_NextNode { get; set; }
        public int wn_PrevNode { get; set; }
        public int wn_NodeType { get; set; }
        public int wn_NodeFuncType { get; set; }
        public string wn_NodeFuncClassName { get; set; }
        public bool wn_IsDel { get; set; }
        public System.DateTime wn_Addtime { get; set; }
    
        public virtual W_WorkFlow W_WorkFlow { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<W_WorkFlowBranch> W_WorkFlowBranch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<W_WorkFlowBranch> W_WorkFlowBranch1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<W_WorkFlowNode> W_WorkFlowNode1 { get; set; }
        public virtual W_WorkFlowNode W_WorkFlowNode2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<W_WorkFlowNode> W_WorkFlowNode11 { get; set; }
        public virtual W_WorkFlowNode W_WorkFlowNode3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<W_WorkFlowNode> W_WorkFlowNode12 { get; set; }
        public virtual W_WorkFlowNode W_WorkFlowNode4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<W_WrokFlowRole> W_WrokFlowRole { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WR_WrokFlowApplyDetails> WR_WrokFlowApplyDetails { get; set; }
    }
}
