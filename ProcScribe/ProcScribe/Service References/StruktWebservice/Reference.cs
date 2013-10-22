﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProcScribe.StruktWebservice {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StruktWebservice.StruktUserSoap")]
    public interface StruktUserSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/checkLogin", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable checkLogin(string strName, string strPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/checkLogin", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> checkLoginAsync(string strName, string strPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getProcessByUserID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable getProcessByUserID(string strID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getProcessByUserID", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> getProcessByUserIDAsync(string strID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getProcessAll", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable getProcessAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getProcessAll", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> getProcessAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getUserAll", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable getUserAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getUserAll", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> getUserAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getUserByStruktID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable getUserByStruktID(string strID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getUserByStruktID", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> getUserByStruktIDAsync(string strID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getDescriptionDetail", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable getDescriptionDetail(string strID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getDescriptionDetail", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> getDescriptionDetailAsync(string strID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getTaskExtendByList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable getTaskExtendByList(string[] listStrTaskID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getTaskExtendByList", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> getTaskExtendByListAsync(string[] listStrTaskID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/setUptadeTaskDescription", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void setUptadeTaskDescription(string strID, string Desc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/setUptadeTaskDescription", ReplyAction="*")]
        System.Threading.Tasks.Task setUptadeTaskDescriptionAsync(string strID, string Desc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/setUpdateTaskExtend", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void setUpdateTaskExtend(string strID, string strDesc, string strLinkType, string strAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/setUpdateTaskExtend", ReplyAction="*")]
        System.Threading.Tasks.Task setUpdateTaskExtendAsync(string strID, string strDesc, string strLinkType, string strAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getAppListAll", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable getAppListAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getAppListAll", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> getAppListAllAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface StruktUserSoapChannel : ProcScribe.StruktWebservice.StruktUserSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StruktUserSoapClient : System.ServiceModel.ClientBase<ProcScribe.StruktWebservice.StruktUserSoap>, ProcScribe.StruktWebservice.StruktUserSoap {
        
        public StruktUserSoapClient() {
        }
        
        public StruktUserSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StruktUserSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StruktUserSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StruktUserSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public System.Data.DataTable checkLogin(string strName, string strPassword) {
            return base.Channel.checkLogin(strName, strPassword);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> checkLoginAsync(string strName, string strPassword) {
            return base.Channel.checkLoginAsync(strName, strPassword);
        }
        
        public System.Data.DataTable getProcessByUserID(string strID) {
            return base.Channel.getProcessByUserID(strID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> getProcessByUserIDAsync(string strID) {
            return base.Channel.getProcessByUserIDAsync(strID);
        }
        
        public System.Data.DataTable getProcessAll() {
            return base.Channel.getProcessAll();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> getProcessAllAsync() {
            return base.Channel.getProcessAllAsync();
        }
        
        public System.Data.DataTable getUserAll() {
            return base.Channel.getUserAll();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> getUserAllAsync() {
            return base.Channel.getUserAllAsync();
        }
        
        public System.Data.DataTable getUserByStruktID(string strID) {
            return base.Channel.getUserByStruktID(strID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> getUserByStruktIDAsync(string strID) {
            return base.Channel.getUserByStruktIDAsync(strID);
        }
        
        public System.Data.DataTable getDescriptionDetail(string strID) {
            return base.Channel.getDescriptionDetail(strID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> getDescriptionDetailAsync(string strID) {
            return base.Channel.getDescriptionDetailAsync(strID);
        }
        
        public System.Data.DataTable getTaskExtendByList(string[] listStrTaskID) {
            return base.Channel.getTaskExtendByList(listStrTaskID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> getTaskExtendByListAsync(string[] listStrTaskID) {
            return base.Channel.getTaskExtendByListAsync(listStrTaskID);
        }
        
        public void setUptadeTaskDescription(string strID, string Desc) {
            base.Channel.setUptadeTaskDescription(strID, Desc);
        }
        
        public System.Threading.Tasks.Task setUptadeTaskDescriptionAsync(string strID, string Desc) {
            return base.Channel.setUptadeTaskDescriptionAsync(strID, Desc);
        }
        
        public void setUpdateTaskExtend(string strID, string strDesc, string strLinkType, string strAddress) {
            base.Channel.setUpdateTaskExtend(strID, strDesc, strLinkType, strAddress);
        }
        
        public System.Threading.Tasks.Task setUpdateTaskExtendAsync(string strID, string strDesc, string strLinkType, string strAddress) {
            return base.Channel.setUpdateTaskExtendAsync(strID, strDesc, strLinkType, strAddress);
        }
        
        public System.Data.DataTable getAppListAll() {
            return base.Channel.getAppListAll();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> getAppListAllAsync() {
            return base.Channel.getAppListAllAsync();
        }
    }
}