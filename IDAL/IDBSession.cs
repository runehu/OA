 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDAL
{
public partial interface IDBSession
{
   IBill_LeaveDAL IBill_LeaveDAL{get;set;}
   IoldWF_AutoTransactNodeDAL IoldWF_AutoTransactNodeDAL{get;set;}
   IoldWF_BillFlowNodeDAL IoldWF_BillFlowNodeDAL{get;set;}
   IoldWF_BillFlowNodeRemarkDAL IoldWF_BillFlowNodeRemarkDAL{get;set;}
   IoldWF_BillStateDAL IoldWF_BillStateDAL{get;set;}
   IoldWF_NodeDAL IoldWF_NodeDAL{get;set;}
   IoldWF_NodeStateDAL IoldWF_NodeStateDAL{get;set;}
   IoldWF_WorkFlowDAL IoldWF_WorkFlowDAL{get;set;}
   IoldWF_WorkFlowNodeDAL IoldWF_WorkFlowNodeDAL{get;set;}
   IOu_DepartmentDAL IOu_DepartmentDAL{get;set;}
   IOu_PermissionDAL IOu_PermissionDAL{get;set;}
   IOu_RoleDAL IOu_RoleDAL{get;set;}
   IOu_RolePermissionDAL IOu_RolePermissionDAL{get;set;}
   IOu_UserInfoDAL IOu_UserInfoDAL{get;set;}
   IOu_UserRoleDAL IOu_UserRoleDAL{get;set;}
   IOu_UserVipPermissionDAL IOu_UserVipPermissionDAL{get;set;}
   IW_WorkFlowDAL IW_WorkFlowDAL{get;set;}
   IW_WorkFlowBranchDAL IW_WorkFlowBranchDAL{get;set;}
   IW_WorkFlowNodeDAL IW_WorkFlowNodeDAL{get;set;}
   IW_WrokFlowRoleDAL IW_WrokFlowRoleDAL{get;set;}
   IWR_WorkFlowApplyDAL IWR_WorkFlowApplyDAL{get;set;}
   IWR_WrokFlowApplyDetailsDAL IWR_WrokFlowApplyDetailsDAL{get;set;}
}
}