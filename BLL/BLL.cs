 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBLL;
namespace BLL
{
  
     public partial class Bill_LeaveBLL : BaseBLL<Model.Bill_Leave>,IBill_LeaveBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IBill_LeaveDAL;
		}
    }

  
     public partial class oldWF_AutoTransactNodeBLL : BaseBLL<Model.oldWF_AutoTransactNode>,IoldWF_AutoTransactNodeBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IoldWF_AutoTransactNodeDAL;
		}
    }

  
     public partial class oldWF_BillFlowNodeBLL : BaseBLL<Model.oldWF_BillFlowNode>,IoldWF_BillFlowNodeBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IoldWF_BillFlowNodeDAL;
		}
    }

  
     public partial class oldWF_BillFlowNodeRemarkBLL : BaseBLL<Model.oldWF_BillFlowNodeRemark>,IoldWF_BillFlowNodeRemarkBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IoldWF_BillFlowNodeRemarkDAL;
		}
    }

  
     public partial class oldWF_BillStateBLL : BaseBLL<Model.oldWF_BillState>,IoldWF_BillStateBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IoldWF_BillStateDAL;
		}
    }

  
     public partial class oldWF_NodeBLL : BaseBLL<Model.oldWF_Node>,IoldWF_NodeBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IoldWF_NodeDAL;
		}
    }

  
     public partial class oldWF_NodeStateBLL : BaseBLL<Model.oldWF_NodeState>,IoldWF_NodeStateBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IoldWF_NodeStateDAL;
		}
    }

  
     public partial class oldWF_WorkFlowBLL : BaseBLL<Model.oldWF_WorkFlow>,IoldWF_WorkFlowBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IoldWF_WorkFlowDAL;
		}
    }

  
     public partial class oldWF_WorkFlowNodeBLL : BaseBLL<Model.oldWF_WorkFlowNode>,IoldWF_WorkFlowNodeBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IoldWF_WorkFlowNodeDAL;
		}
    }

  
     public partial class Ou_DepartmentBLL : BaseBLL<Model.Ou_Department>,IOu_DepartmentBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IOu_DepartmentDAL;
		}
    }

  
     public partial class Ou_PermissionBLL : BaseBLL<Model.Ou_Permission>,IOu_PermissionBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IOu_PermissionDAL;
		}
    }

  
     public partial class Ou_RoleBLL : BaseBLL<Model.Ou_Role>,IOu_RoleBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IOu_RoleDAL;
		}
    }

  
     public partial class Ou_RolePermissionBLL : BaseBLL<Model.Ou_RolePermission>,IOu_RolePermissionBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IOu_RolePermissionDAL;
		}
    }

  
     public partial class Ou_UserInfoBLL : BaseBLL<Model.Ou_UserInfo>,IOu_UserInfoBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IOu_UserInfoDAL;
		}
    }

  
     public partial class Ou_UserRoleBLL : BaseBLL<Model.Ou_UserRole>,IOu_UserRoleBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IOu_UserRoleDAL;
		}
    }

  
     public partial class Ou_UserVipPermissionBLL : BaseBLL<Model.Ou_UserVipPermission>,IOu_UserVipPermissionBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IOu_UserVipPermissionDAL;
		}
    }

  
     public partial class W_WorkFlowBLL : BaseBLL<Model.W_WorkFlow>,IW_WorkFlowBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IW_WorkFlowDAL;
		}
    }

  
     public partial class W_WorkFlowBranchBLL : BaseBLL<Model.W_WorkFlowBranch>,IW_WorkFlowBranchBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IW_WorkFlowBranchDAL;
		}
    }

  
     public partial class W_WorkFlowNodeBLL : BaseBLL<Model.W_WorkFlowNode>,IW_WorkFlowNodeBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IW_WorkFlowNodeDAL;
		}
    }

  
     public partial class W_WrokFlowRoleBLL : BaseBLL<Model.W_WrokFlowRole>,IW_WrokFlowRoleBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IW_WrokFlowRoleDAL;
		}
    }

  
     public partial class WR_WorkFlowApplyBLL : BaseBLL<Model.WR_WorkFlowApply>,IWR_WorkFlowApplyBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IWR_WorkFlowApplyDAL;
		}
    }

  
     public partial class WR_WrokFlowApplyDetailsBLL : BaseBLL<Model.WR_WrokFlowApplyDetails>,IWR_WrokFlowApplyDetailsBLL
    {
		public override void SetDAL()
		{
			 idal = DBSession.IWR_WrokFlowApplyDetailsDAL;
		}
    }


}