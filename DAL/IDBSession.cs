 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;

namespace DAL
{
public partial class DBSession:IDBSession
{
    #region 1 数据接口 IBill_LeaveDAL
   IBill_LeaveDAL iBill_LeaveDAL;
  public IBill_LeaveDAL IBill_LeaveDAL{
   get
   {
   if(iBill_LeaveDAL==null)
      iBill_LeaveDAL=new Bill_LeaveDAL();
      return  iBill_LeaveDAL;
   }
   set
   {
    iBill_LeaveDAL=value;
   }
   }
   #endregion

    #region 2 数据接口 IoldWF_AutoTransactNodeDAL
   IoldWF_AutoTransactNodeDAL ioldWF_AutoTransactNodeDAL;
  public IoldWF_AutoTransactNodeDAL IoldWF_AutoTransactNodeDAL{
   get
   {
   if(ioldWF_AutoTransactNodeDAL==null)
      ioldWF_AutoTransactNodeDAL=new oldWF_AutoTransactNodeDAL();
      return  ioldWF_AutoTransactNodeDAL;
   }
   set
   {
    ioldWF_AutoTransactNodeDAL=value;
   }
   }
   #endregion

    #region 3 数据接口 IoldWF_BillFlowNodeDAL
   IoldWF_BillFlowNodeDAL ioldWF_BillFlowNodeDAL;
  public IoldWF_BillFlowNodeDAL IoldWF_BillFlowNodeDAL{
   get
   {
   if(ioldWF_BillFlowNodeDAL==null)
      ioldWF_BillFlowNodeDAL=new oldWF_BillFlowNodeDAL();
      return  ioldWF_BillFlowNodeDAL;
   }
   set
   {
    ioldWF_BillFlowNodeDAL=value;
   }
   }
   #endregion

    #region 4 数据接口 IoldWF_BillFlowNodeRemarkDAL
   IoldWF_BillFlowNodeRemarkDAL ioldWF_BillFlowNodeRemarkDAL;
  public IoldWF_BillFlowNodeRemarkDAL IoldWF_BillFlowNodeRemarkDAL{
   get
   {
   if(ioldWF_BillFlowNodeRemarkDAL==null)
      ioldWF_BillFlowNodeRemarkDAL=new oldWF_BillFlowNodeRemarkDAL();
      return  ioldWF_BillFlowNodeRemarkDAL;
   }
   set
   {
    ioldWF_BillFlowNodeRemarkDAL=value;
   }
   }
   #endregion

    #region 5 数据接口 IoldWF_BillStateDAL
   IoldWF_BillStateDAL ioldWF_BillStateDAL;
  public IoldWF_BillStateDAL IoldWF_BillStateDAL{
   get
   {
   if(ioldWF_BillStateDAL==null)
      ioldWF_BillStateDAL=new oldWF_BillStateDAL();
      return  ioldWF_BillStateDAL;
   }
   set
   {
    ioldWF_BillStateDAL=value;
   }
   }
   #endregion

    #region 6 数据接口 IoldWF_NodeDAL
   IoldWF_NodeDAL ioldWF_NodeDAL;
  public IoldWF_NodeDAL IoldWF_NodeDAL{
   get
   {
   if(ioldWF_NodeDAL==null)
      ioldWF_NodeDAL=new oldWF_NodeDAL();
      return  ioldWF_NodeDAL;
   }
   set
   {
    ioldWF_NodeDAL=value;
   }
   }
   #endregion

    #region 7 数据接口 IoldWF_NodeStateDAL
   IoldWF_NodeStateDAL ioldWF_NodeStateDAL;
  public IoldWF_NodeStateDAL IoldWF_NodeStateDAL{
   get
   {
   if(ioldWF_NodeStateDAL==null)
      ioldWF_NodeStateDAL=new oldWF_NodeStateDAL();
      return  ioldWF_NodeStateDAL;
   }
   set
   {
    ioldWF_NodeStateDAL=value;
   }
   }
   #endregion

    #region 8 数据接口 IoldWF_WorkFlowDAL
   IoldWF_WorkFlowDAL ioldWF_WorkFlowDAL;
  public IoldWF_WorkFlowDAL IoldWF_WorkFlowDAL{
   get
   {
   if(ioldWF_WorkFlowDAL==null)
      ioldWF_WorkFlowDAL=new oldWF_WorkFlowDAL();
      return  ioldWF_WorkFlowDAL;
   }
   set
   {
    ioldWF_WorkFlowDAL=value;
   }
   }
   #endregion

    #region 9 数据接口 IoldWF_WorkFlowNodeDAL
   IoldWF_WorkFlowNodeDAL ioldWF_WorkFlowNodeDAL;
  public IoldWF_WorkFlowNodeDAL IoldWF_WorkFlowNodeDAL{
   get
   {
   if(ioldWF_WorkFlowNodeDAL==null)
      ioldWF_WorkFlowNodeDAL=new oldWF_WorkFlowNodeDAL();
      return  ioldWF_WorkFlowNodeDAL;
   }
   set
   {
    ioldWF_WorkFlowNodeDAL=value;
   }
   }
   #endregion

    #region 10 数据接口 IOu_DepartmentDAL
   IOu_DepartmentDAL iOu_DepartmentDAL;
  public IOu_DepartmentDAL IOu_DepartmentDAL{
   get
   {
   if(iOu_DepartmentDAL==null)
      iOu_DepartmentDAL=new Ou_DepartmentDAL();
      return  iOu_DepartmentDAL;
   }
   set
   {
    iOu_DepartmentDAL=value;
   }
   }
   #endregion

    #region 11 数据接口 IOu_PermissionDAL
   IOu_PermissionDAL iOu_PermissionDAL;
  public IOu_PermissionDAL IOu_PermissionDAL{
   get
   {
   if(iOu_PermissionDAL==null)
      iOu_PermissionDAL=new Ou_PermissionDAL();
      return  iOu_PermissionDAL;
   }
   set
   {
    iOu_PermissionDAL=value;
   }
   }
   #endregion

    #region 12 数据接口 IOu_RoleDAL
   IOu_RoleDAL iOu_RoleDAL;
  public IOu_RoleDAL IOu_RoleDAL{
   get
   {
   if(iOu_RoleDAL==null)
      iOu_RoleDAL=new Ou_RoleDAL();
      return  iOu_RoleDAL;
   }
   set
   {
    iOu_RoleDAL=value;
   }
   }
   #endregion

    #region 13 数据接口 IOu_RolePermissionDAL
   IOu_RolePermissionDAL iOu_RolePermissionDAL;
  public IOu_RolePermissionDAL IOu_RolePermissionDAL{
   get
   {
   if(iOu_RolePermissionDAL==null)
      iOu_RolePermissionDAL=new Ou_RolePermissionDAL();
      return  iOu_RolePermissionDAL;
   }
   set
   {
    iOu_RolePermissionDAL=value;
   }
   }
   #endregion

    #region 14 数据接口 IOu_UserInfoDAL
   IOu_UserInfoDAL iOu_UserInfoDAL;
  public IOu_UserInfoDAL IOu_UserInfoDAL{
   get
   {
   if(iOu_UserInfoDAL==null)
      iOu_UserInfoDAL=new Ou_UserInfoDAL();
      return  iOu_UserInfoDAL;
   }
   set
   {
    iOu_UserInfoDAL=value;
   }
   }
   #endregion

    #region 15 数据接口 IOu_UserRoleDAL
   IOu_UserRoleDAL iOu_UserRoleDAL;
  public IOu_UserRoleDAL IOu_UserRoleDAL{
   get
   {
   if(iOu_UserRoleDAL==null)
      iOu_UserRoleDAL=new Ou_UserRoleDAL();
      return  iOu_UserRoleDAL;
   }
   set
   {
    iOu_UserRoleDAL=value;
   }
   }
   #endregion

    #region 16 数据接口 IOu_UserVipPermissionDAL
   IOu_UserVipPermissionDAL iOu_UserVipPermissionDAL;
  public IOu_UserVipPermissionDAL IOu_UserVipPermissionDAL{
   get
   {
   if(iOu_UserVipPermissionDAL==null)
      iOu_UserVipPermissionDAL=new Ou_UserVipPermissionDAL();
      return  iOu_UserVipPermissionDAL;
   }
   set
   {
    iOu_UserVipPermissionDAL=value;
   }
   }
   #endregion

    #region 17 数据接口 IW_WorkFlowDAL
   IW_WorkFlowDAL iW_WorkFlowDAL;
  public IW_WorkFlowDAL IW_WorkFlowDAL{
   get
   {
   if(iW_WorkFlowDAL==null)
      iW_WorkFlowDAL=new W_WorkFlowDAL();
      return  iW_WorkFlowDAL;
   }
   set
   {
    iW_WorkFlowDAL=value;
   }
   }
   #endregion

    #region 18 数据接口 IW_WorkFlowBranchDAL
   IW_WorkFlowBranchDAL iW_WorkFlowBranchDAL;
  public IW_WorkFlowBranchDAL IW_WorkFlowBranchDAL{
   get
   {
   if(iW_WorkFlowBranchDAL==null)
      iW_WorkFlowBranchDAL=new W_WorkFlowBranchDAL();
      return  iW_WorkFlowBranchDAL;
   }
   set
   {
    iW_WorkFlowBranchDAL=value;
   }
   }
   #endregion

    #region 19 数据接口 IW_WorkFlowNodeDAL
   IW_WorkFlowNodeDAL iW_WorkFlowNodeDAL;
  public IW_WorkFlowNodeDAL IW_WorkFlowNodeDAL{
   get
   {
   if(iW_WorkFlowNodeDAL==null)
      iW_WorkFlowNodeDAL=new W_WorkFlowNodeDAL();
      return  iW_WorkFlowNodeDAL;
   }
   set
   {
    iW_WorkFlowNodeDAL=value;
   }
   }
   #endregion

    #region 20 数据接口 IW_WrokFlowRoleDAL
   IW_WrokFlowRoleDAL iW_WrokFlowRoleDAL;
  public IW_WrokFlowRoleDAL IW_WrokFlowRoleDAL{
   get
   {
   if(iW_WrokFlowRoleDAL==null)
      iW_WrokFlowRoleDAL=new W_WrokFlowRoleDAL();
      return  iW_WrokFlowRoleDAL;
   }
   set
   {
    iW_WrokFlowRoleDAL=value;
   }
   }
   #endregion

    #region 21 数据接口 IWR_WorkFlowApplyDAL
   IWR_WorkFlowApplyDAL iWR_WorkFlowApplyDAL;
  public IWR_WorkFlowApplyDAL IWR_WorkFlowApplyDAL{
   get
   {
   if(iWR_WorkFlowApplyDAL==null)
      iWR_WorkFlowApplyDAL=new WR_WorkFlowApplyDAL();
      return  iWR_WorkFlowApplyDAL;
   }
   set
   {
    iWR_WorkFlowApplyDAL=value;
   }
   }
   #endregion

    #region 22 数据接口 IWR_WrokFlowApplyDetailsDAL
   IWR_WrokFlowApplyDetailsDAL iWR_WrokFlowApplyDetailsDAL;
  public IWR_WrokFlowApplyDetailsDAL IWR_WrokFlowApplyDetailsDAL{
   get
   {
   if(iWR_WrokFlowApplyDetailsDAL==null)
      iWR_WrokFlowApplyDetailsDAL=new WR_WrokFlowApplyDetailsDAL();
      return  iWR_WrokFlowApplyDetailsDAL;
   }
   set
   {
    iWR_WrokFlowApplyDetailsDAL=value;
   }
   }
   #endregion

}
}