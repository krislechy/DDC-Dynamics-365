namespace ProxyTypes {
    
    
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("ylv_org_documents")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.54")]
    public partial class YlvOrgDocuments : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged {
        
        public const string EntityLogicalName = "ylv_org_documents";
        
        public const int EntityTypeCode = 10554;
        
        public static string createdbyName = "createdby";
        
        public static string createdonName = "createdon";
        
        public static string createdonbehalfbyName = "createdonbehalfby";
        
        public static string emailaddressName = "emailaddress";
        
        public static string importsequencenumberName = "importsequencenumber";
        
        public static string modifiedbyName = "modifiedby";
        
        public static string modifiedonName = "modifiedon";
        
        public static string modifiedonbehalfbyName = "modifiedonbehalfby";
        
        public static string overriddencreatedonName = "overriddencreatedon";
        
        public static string owneridName = "ownerid";
        
        public static string owningbusinessunitName = "owningbusinessunit";
        
        public static string owningteamName = "owningteam";
        
        public static string owninguserName = "owninguser";
        
        public static string statecodeName = "statecode";
        
        public static string statuscodeName = "statuscode";
        
        public static string timezoneruleversionnumberName = "timezoneruleversionnumber";
        
        public static string utcconversiontimezonecodeName = "utcconversiontimezonecode";
        
        public static string versionnumberName = "versionnumber";
        
        public static string ylv_accountName = "ylv_account";
        
        public static string ylv_annotations_namesName = "ylv_annotations_names";
        
        public static string ylv_checkenddateName = "ylv_checkenddate";
        
        public static string ylv_commentsName = "ylv_comments";
        
        public static string ylv_descriptionName = "ylv_description";
        
        public static string ylv_docobjecttypeName = "ylv_docobjecttype";
        
        public static string ylv_doctypeName = "ylv_doctype";
        
        public static string ylv_document_statusName = "ylv_document_status";
        
        public static string ylv_historyName = "ylv_history";
        
        public static string ylv_nameName = "ylv_name";
        
        public static string ylv_notrelatedtoName = "ylv_notrelatedto";
        
        public static string ylv_objectidName = "ylv_objectid";
        
        public static string ylv_opportunityidName = "ylv_opportunityid";
        
        public static string ylv_opportunitypackettypeName = "ylv_opportunitypackettype";
        
        public static string ylv_org_documentsidName = "ylv_org_documentsid";
        
        public static string ylv_portaluserName = "ylv_portaluser";
        
        public static string ylv_rbcommentName = "ylv_rbcomment";
        
        public static string ylv_rblinecommentName = "ylv_rblinecomment";
        
        public static string ylv_readytosendName = "ylv_readytosend";
        
        public static string ylv_required_attachName = "ylv_required_attach";
        
        public static string ylv_status_update_dateName = "ylv_status_update_date";
        
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public YlvOrgDocuments() : 
                base(EntityLogicalName) {
        }
        
        /// <summary>
        /// Уникальный идентификатор пользователя, создавшего запись.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy {
            get {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
            }
        }
        
        /// <summary>
        /// Дата и время создания записи.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn {
            get {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
            }
        }
        
        /// <summary>
        /// Уникальный идентификатор пользователя-делегата, создавшего запись.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy {
            get {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
            }
        }
        
        /// <summary>
        /// Основной адрес электронной почты сущности.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress")]
        public string EmailAddress {
            get {
                return this.GetAttributeValue<string>("emailaddress");
            }
            set {
                this.OnPropertyChanging("EmailAddress");
                this.SetAttributeValue("emailaddress", value);
                this.OnPropertyChanged("EmailAddress");
            }
        }
        
        /// <summary>
        /// Порядковый номер импорта, в результате которого была создана эта запись.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
        public System.Nullable<int> ImportSequenceNumber {
            get {
                return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
            }
            set {
                this.OnPropertyChanging("ImportSequenceNumber");
                this.SetAttributeValue("importsequencenumber", value);
                this.OnPropertyChanged("ImportSequenceNumber");
            }
        }
        
        /// <summary>
        /// Уникальный идентификатор пользователя, изменившего запись.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy {
            get {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
            }
        }
        
        /// <summary>
        /// Дата и время изменения записи.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn {
            get {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
            }
        }
        
        /// <summary>
        /// Уникальный идентификатор пользователя-делегата, изменившего запись.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy {
            get {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
            }
        }
        
        /// <summary>
        /// Дата и время переноса записи.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
        public System.Nullable<System.DateTime> OverriddenCreatedOn {
            get {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
            }
            set {
                this.OnPropertyChanging("OverriddenCreatedOn");
                this.SetAttributeValue("overriddencreatedon", value);
                this.OnPropertyChanged("OverriddenCreatedOn");
            }
        }
        
        /// <summary>
        /// Идентификатор ответственного
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId {
            get {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
            }
            set {
                this.OnPropertyChanging("OwnerId");
                this.SetAttributeValue("ownerid", value);
                this.OnPropertyChanged("OwnerId");
            }
        }
        
        /// <summary>
        /// Уникальный идентификатор бизнес-единицы, владеющей этой записью
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit {
            get {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
            }
        }
        
        /// <summary>
        /// Уникальный идентификатор группы, владеющей записью
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam {
            get {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
            }
        }
        
        /// <summary>
        /// Уникальный идентификатор пользователя, владеющего этой записью.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser {
            get {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
            }
        }
        
        /// <summary>
        /// Статус Документы для аккредитации
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public ylv_org_documents_statecode? statecode {
            get {
                var ret = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				return (ret!=null ? (ylv_org_documents_statecode?)ret.Value : (ylv_org_documents_statecode?)null);;
            }
            set {
                this.OnPropertyChanging("statecode");
                if ((value == null)) {
                    this.SetAttributeValue("statecode", null);
                }
                else {
				this.SetAttributeValue("statecode", (value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value.Value) : null));
                }
                this.OnPropertyChanged("statecode");
            }
        }
        
        /// <summary>
        /// Причина состояния Документы для аккредитации
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public ylv_org_documents_statuscode? statuscode {
            get {
                var ret = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
				return (ret!=null ? (ylv_org_documents_statuscode?)ret.Value : (ylv_org_documents_statuscode?)null);;
            }
            set {
                this.OnPropertyChanging("statuscode");
                if ((value == null)) {
                    this.SetAttributeValue("statuscode", null);
                }
                else {
				this.SetAttributeValue("statuscode", (value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value.Value) : null));
                }
                this.OnPropertyChanged("statuscode");
            }
        }
        
        /// <summary>
        /// Только для внутреннего использования.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
        public System.Nullable<int> TimeZoneRuleVersionNumber {
            get {
                return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
            }
            set {
                this.OnPropertyChanging("TimeZoneRuleVersionNumber");
                this.SetAttributeValue("timezoneruleversionnumber", value);
                this.OnPropertyChanged("TimeZoneRuleVersionNumber");
            }
        }
        
        /// <summary>
        /// Код часового пояса, использовавшийся при создании записи.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
        public System.Nullable<int> UTCConversionTimeZoneCode {
            get {
                return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
            }
            set {
                this.OnPropertyChanging("UTCConversionTimeZoneCode");
                this.SetAttributeValue("utcconversiontimezonecode", value);
                this.OnPropertyChanged("UTCConversionTimeZoneCode");
            }
        }
        
        /// <summary>
        /// Номер версии
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber {
            get {
                return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_account")]
        public Microsoft.Xrm.Sdk.EntityReference ylv_account {
            get {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ylv_account");
            }
            set {
                this.OnPropertyChanging("ylv_account");
                this.SetAttributeValue("ylv_account", value);
                this.OnPropertyChanged("ylv_account");
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_annotations_names")]
        public string ylv_annotations_names {
            get {
                return this.GetAttributeValue<string>("ylv_annotations_names");
            }
            set {
                this.OnPropertyChanging("ylv_annotations_names");
                this.SetAttributeValue("ylv_annotations_names", value);
                this.OnPropertyChanged("ylv_annotations_names");
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_checkenddate")]
        public System.Nullable<System.DateTime> ylv_checkenddate {
            get {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("ylv_checkenddate");
            }
            set {
                this.OnPropertyChanging("ylv_checkenddate");
                this.SetAttributeValue("ylv_checkenddate", value);
                this.OnPropertyChanged("ylv_checkenddate");
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_comments")]
        public string ylv_comments {
            get {
                return this.GetAttributeValue<string>("ylv_comments");
            }
            set {
                this.OnPropertyChanging("ylv_comments");
                this.SetAttributeValue("ylv_comments", value);
                this.OnPropertyChanged("ylv_comments");
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_description")]
        public string ylv_description {
            get {
                return this.GetAttributeValue<string>("ylv_description");
            }
            set {
                this.OnPropertyChanging("ylv_description");
                this.SetAttributeValue("ylv_description", value);
                this.OnPropertyChanged("ylv_description");
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_docobjecttype")]
        public ylv_objectpackettype? ylv_docobjecttype {
            get {
                var ret = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("ylv_docobjecttype");
				return (ret!=null ? (ylv_objectpackettype?)ret.Value : (ylv_objectpackettype?)null);;
            }
            set {
                this.OnPropertyChanging("ylv_docobjecttype");
                if ((value == null)) {
                    this.SetAttributeValue("ylv_docobjecttype", null);
                }
                else {
				this.SetAttributeValue("ylv_docobjecttype", (value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value.Value) : null));
                }
                this.OnPropertyChanged("ylv_docobjecttype");
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_doctype")]
        public ylv_packettype? ylv_doctype {
            get {
                var ret = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("ylv_doctype");
				return (ret!=null ? (ylv_packettype?)ret.Value : (ylv_packettype?)null);;
            }
            set {
                this.OnPropertyChanging("ylv_doctype");
                if ((value == null)) {
                    this.SetAttributeValue("ylv_doctype", null);
                }
                else {
				this.SetAttributeValue("ylv_doctype", (value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value.Value) : null));
                }
                this.OnPropertyChanged("ylv_doctype");
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_document_status")]
        public ylv_org_documents_ylv_document_status? ylv_document_status {
            get {
                var ret = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("ylv_document_status");
				return (ret!=null ? (ylv_org_documents_ylv_document_status?)ret.Value : (ylv_org_documents_ylv_document_status?)null);;
            }
            set {
                this.OnPropertyChanging("ylv_document_status");
                if ((value == null)) {
                    this.SetAttributeValue("ylv_document_status", null);
                }
                else {
				this.SetAttributeValue("ylv_document_status", (value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value.Value) : null));
                }
                this.OnPropertyChanged("ylv_document_status");
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_history")]
        public string ylv_history {
            get {
                return this.GetAttributeValue<string>("ylv_history");
            }
            set {
                this.OnPropertyChanging("ylv_history");
                this.SetAttributeValue("ylv_history", value);
                this.OnPropertyChanged("ylv_history");
            }
        }
        
        /// <summary>
        /// Имя настраиваемой сущности.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_name")]
        public string ylv_name {
            get {
                return this.GetAttributeValue<string>("ylv_name");
            }
            set {
                this.OnPropertyChanging("ylv_name");
                this.SetAttributeValue("ylv_name", value);
                this.OnPropertyChanged("ylv_name");
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_notrelatedto")]
        public System.Nullable<bool> ylv_notrelatedto {
            get {
                return this.GetAttributeValue<System.Nullable<bool>>("ylv_notrelatedto");
            }
            set {
                this.OnPropertyChanging("ylv_notrelatedto");
                this.SetAttributeValue("ylv_notrelatedto", value);
                this.OnPropertyChanged("ylv_notrelatedto");
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_objectid")]
        public Microsoft.Xrm.Sdk.EntityReference ylv_objectid {
            get {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ylv_objectid");
            }
            set {
                this.OnPropertyChanging("ylv_objectid");
                this.SetAttributeValue("ylv_objectid", value);
                this.OnPropertyChanged("ylv_objectid");
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_opportunityid")]
        public Microsoft.Xrm.Sdk.EntityReference ylv_opportunityid {
            get {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ylv_opportunityid");
            }
            set {
                this.OnPropertyChanging("ylv_opportunityid");
                this.SetAttributeValue("ylv_opportunityid", value);
                this.OnPropertyChanged("ylv_opportunityid");
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_opportunitypackettype")]
        public ylv_opportunitytpackettype? ylv_opportunitypackettype {
            get {
                var ret = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("ylv_opportunitypackettype");
				return (ret!=null ? (ylv_opportunitytpackettype?)ret.Value : (ylv_opportunitytpackettype?)null);;
            }
            set {
                this.OnPropertyChanging("ylv_opportunitypackettype");
                if ((value == null)) {
                    this.SetAttributeValue("ylv_opportunitypackettype", null);
                }
                else {
				this.SetAttributeValue("ylv_opportunitypackettype", (value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value.Value) : null));
                }
                this.OnPropertyChanged("ylv_opportunitypackettype");
            }
        }
        
        /// <summary>
        /// Уникальный идентификатор экземпляров сущности
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_org_documentsid")]
        public System.Nullable<System.Guid> ylv_org_documentsId {
            get {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("ylv_org_documentsid");
            }
            set {
                this.OnPropertyChanging("ylv_org_documentsId");
                this.SetAttributeValue("ylv_org_documentsid", value);
                if (value.HasValue) {
                    base.Id = value.Value;
                }
                else {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ylv_org_documentsId");
            }
        }
        
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_org_documentsid")]
        public override System.Guid Id {
            get {
                return base.Id;
            }
            set {
                this.ylv_org_documentsId = value;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_portaluser")]
        public string ylv_portaluser {
            get {
                return this.GetAttributeValue<string>("ylv_portaluser");
            }
            set {
                this.OnPropertyChanging("ylv_portaluser");
                this.SetAttributeValue("ylv_portaluser", value);
                this.OnPropertyChanged("ylv_portaluser");
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_rbcomment")]
        public string ylv_rbcomment {
            get {
                return this.GetAttributeValue<string>("ylv_rbcomment");
            }
            set {
                this.OnPropertyChanging("ylv_rbcomment");
                this.SetAttributeValue("ylv_rbcomment", value);
                this.OnPropertyChanged("ylv_rbcomment");
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_rblinecomment")]
        public string ylv_rblinecomment {
            get {
                return this.GetAttributeValue<string>("ylv_rblinecomment");
            }
            set {
                this.OnPropertyChanging("ylv_rblinecomment");
                this.SetAttributeValue("ylv_rblinecomment", value);
                this.OnPropertyChanged("ylv_rblinecomment");
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_readytosend")]
        public ylv_readytosend? ylv_readyToSend {
            get {
                var ret = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("ylv_readytosend");
				return (ret!=null ? (ylv_readytosend?)ret.Value : (ylv_readytosend?)null);;
            }
            set {
                this.OnPropertyChanging("ylv_readyToSend");
                if ((value == null)) {
                    this.SetAttributeValue("ylv_readytosend", null);
                }
                else {
				this.SetAttributeValue("ylv_readytosend", (value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value.Value) : null));
                }
                this.OnPropertyChanged("ylv_readyToSend");
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_required_attach")]
        public System.Nullable<bool> ylv_required_attach {
            get {
                return this.GetAttributeValue<System.Nullable<bool>>("ylv_required_attach");
            }
            set {
                this.OnPropertyChanging("ylv_required_attach");
                this.SetAttributeValue("ylv_required_attach", value);
                this.OnPropertyChanged("ylv_required_attach");
            }
        }
        
        /// <summary>
        /// Дата статуса
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ylv_status_update_date")]
        public System.Nullable<System.DateTime> ylv_status_update_date {
            get {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("ylv_status_update_date");
            }
            set {
                this.OnPropertyChanging("ylv_status_update_date");
                this.SetAttributeValue("ylv_status_update_date", value);
                this.OnPropertyChanged("ylv_status_update_date");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
        
        private void OnPropertyChanged(string propertyName) {
            if ((this.PropertyChanged != null)) {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        private void OnPropertyChanging(string propertyName) {
            if ((this.PropertyChanging != null)) {
                this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
            }
        }
    }
}
