namespace ProxyTypes {
    
    
    /// <summary>
    /// Примечание, которое прикреплено к одному или нескольким объектам, в том числе другим примечаниям.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("annotation")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.54")]
    public partial class Annotation : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged {
        
        public const string EntityLogicalName = "annotation";
        
        public const int EntityTypeCode = 5;
        
        public static string annotationidName = "annotationid";
        
        public static string createdbyName = "createdby";
        
        public static string createdonName = "createdon";
        
        public static string createdonbehalfbyName = "createdonbehalfby";
        
        public static string documentbodyName = "documentbody";
        
        public static string dummyfilenameName = "dummyfilename";
        
        public static string dummyregardingName = "dummyregarding";
        
        public static string filenameName = "filename";
        
        public static string filesizeName = "filesize";
        
        public static string importsequencenumberName = "importsequencenumber";
        
        public static string isdocumentName = "isdocument";
        
        public static string langidName = "langid";
        
        public static string mimetypeName = "mimetype";
        
        public static string modifiedbyName = "modifiedby";
        
        public static string modifiedonName = "modifiedon";
        
        public static string modifiedonbehalfbyName = "modifiedonbehalfby";
        
        public static string notetextName = "notetext";
        
        public static string objectidName = "objectid";
        
        public static string objecttypecodeName = "objecttypecode";
        
        public static string overriddencreatedonName = "overriddencreatedon";
        
        public static string owneridName = "ownerid";
        
        public static string owningbusinessunitName = "owningbusinessunit";
        
        public static string owningteamName = "owningteam";
        
        public static string owninguserName = "owninguser";
        
        public static string prefixName = "prefix";
        
        public static string stepidName = "stepid";
        
        public static string subjectName = "subject";
        
        public static string versionnumberName = "versionnumber";
        
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Annotation() : 
                base(EntityLogicalName) {
        }
        
        /// <summary>
        /// Уникальный идентификатор примечания.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annotationid")]
        public System.Nullable<System.Guid> AnnotationId {
            get {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("annotationid");
            }
            set {
                this.OnPropertyChanging("AnnotationId");
                this.SetAttributeValue("annotationid", value);
                if (value.HasValue) {
                    base.Id = value.Value;
                }
                else {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("AnnotationId");
            }
        }
        
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annotationid")]
        public override System.Guid Id {
            get {
                return base.Id;
            }
            set {
                this.AnnotationId = value;
            }
        }
        
        /// <summary>
        /// Уникальный идентификатор пользователя, создавшего примечание.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy {
            get {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
            }
        }
        
        /// <summary>
        /// Дата и время создания примечания.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn {
            get {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
            }
        }
        
        /// <summary>
        /// Уникальный идентификатор делегата, создавшего заметку.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy {
            get {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
            }
        }
        
        /// <summary>
        /// Содержимое вложения примечания.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("documentbody")]
        public string DocumentBody {
            get {
                return this.GetAttributeValue<string>("documentbody");
            }
            set {
                this.OnPropertyChanging("DocumentBody");
                this.SetAttributeValue("documentbody", value);
                this.OnPropertyChanged("DocumentBody");
            }
        }
        
        /// <summary>
        /// Фиктивный атрибут, связанный с вложением примечания
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dummyfilename")]
        public string DummyFileName {
            get {
                return this.GetAttributeValue<string>("dummyfilename");
            }
        }
        
        /// <summary>
        /// Фиктивный атрибут, связанный с записью "в отношении" примечания
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dummyregarding")]
        public string DummyRegarding {
            get {
                return this.GetAttributeValue<string>("dummyregarding");
            }
        }
        
        /// <summary>
        /// Имя файла примечания.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filename")]
        public string FileName {
            get {
                return this.GetAttributeValue<string>("filename");
            }
            set {
                this.OnPropertyChanging("FileName");
                this.SetAttributeValue("filename", value);
                this.OnPropertyChanged("FileName");
            }
        }
        
        /// <summary>
        /// Размер файла примечания.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filesize")]
        public System.Nullable<int> FileSize {
            get {
                return this.GetAttributeValue<System.Nullable<int>>("filesize");
            }
        }
        
        /// <summary>
        /// Уникальный идентификатор импорта или переноса данных, создавшего эту запись.
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
        /// Определяет, является ли примечание вложением.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdocument")]
        public System.Nullable<bool> IsDocument {
            get {
                return this.GetAttributeValue<System.Nullable<bool>>("isdocument");
            }
            set {
                this.OnPropertyChanging("IsDocument");
                this.SetAttributeValue("isdocument", value);
                this.OnPropertyChanged("IsDocument");
            }
        }
        
        /// <summary>
        /// Идентификатор языка примечания.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("langid")]
        public string LangId {
            get {
                return this.GetAttributeValue<string>("langid");
            }
            set {
                this.OnPropertyChanging("LangId");
                this.SetAttributeValue("langid", value);
                this.OnPropertyChanged("LangId");
            }
        }
        
        /// <summary>
        /// Тип MIME вложения примечания.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mimetype")]
        public string MimeType {
            get {
                return this.GetAttributeValue<string>("mimetype");
            }
            set {
                this.OnPropertyChanging("MimeType");
                this.SetAttributeValue("mimetype", value);
                this.OnPropertyChanged("MimeType");
            }
        }
        
        /// <summary>
        /// Уникальный идентификатор пользователя, который последним изменил примечание.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy {
            get {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
            }
        }
        
        /// <summary>
        /// Дата и время последнего изменения примечания.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn {
            get {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
            }
        }
        
        /// <summary>
        /// Уникальный идентификатор делегата, который последним изменил заметку.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy {
            get {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
            }
        }
        
        /// <summary>
        /// Текст примечания.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("notetext")]
        public string NoteText {
            get {
                return this.GetAttributeValue<string>("notetext");
            }
            set {
                this.OnPropertyChanging("NoteText");
                this.SetAttributeValue("notetext", value);
                this.OnPropertyChanged("NoteText");
            }
        }
        
        /// <summary>
        /// Уникальный идентификатор объекта, с которым связана заметка.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        public Microsoft.Xrm.Sdk.EntityReference ObjectId {
            get {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("objectid");
            }
            set {
                this.OnPropertyChanging("ObjectId");
                this.SetAttributeValue("objectid", value);
                this.OnPropertyChanged("ObjectId");
            }
        }
        
        /// <summary>
        /// Тип сущности, с которой связано примечание.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
        public string ObjectTypeCode {
            get {
                return this.GetAttributeValue<string>("objecttypecode");
            }
            set {
                this.OnPropertyChanging("ObjectTypeCode");
                this.SetAttributeValue("objecttypecode", value);
                this.OnPropertyChanged("ObjectTypeCode");
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
        /// Уникальный идентификатор пользователя или рабочей группы, ответственных за примечание.
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
        /// Уникальный идентификатор бизнес-единицы, ответственной за примечание.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit {
            get {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
            }
        }
        
        /// <summary>
        /// Уникальный идентификатор рабочей группы, ответственной за примечание.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam {
            get {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
            }
        }
        
        /// <summary>
        /// Уникальный идентификатор пользователя, ответственного за примечание.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser {
            get {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
            }
        }
        
        /// <summary>
        /// Префикс указателя файла в хранилище BLOB-объектов.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("prefix")]
        public string Prefix {
            get {
                return this.GetAttributeValue<string>("prefix");
            }
        }
        
        /// <summary>
        /// Идентификатор шага бизнес-процесса, связанного с примечанием.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stepid")]
        public string StepId {
            get {
                return this.GetAttributeValue<string>("stepid");
            }
            set {
                this.OnPropertyChanging("StepId");
                this.SetAttributeValue("stepid", value);
                this.OnPropertyChanged("StepId");
            }
        }
        
        /// <summary>
        /// Тема, связанная с примечанием.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subject")]
        public string Subject {
            get {
                return this.GetAttributeValue<string>("subject");
            }
            set {
                this.OnPropertyChanging("Subject");
                this.SetAttributeValue("subject", value);
                this.OnPropertyChanged("Subject");
            }
        }
        
        /// <summary>
        /// Номер версии примечания.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber {
            get {
                return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
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
