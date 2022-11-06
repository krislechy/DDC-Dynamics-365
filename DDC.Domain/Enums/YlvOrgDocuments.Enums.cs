namespace ProxyTypes {
    using System.ComponentModel;
    
    
    [System.Runtime.Serialization.DataContractAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.54")]
    public enum ylv_org_documents_statecode {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactive = 1,
    }
    
    [System.Runtime.Serialization.DataContractAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.54")]
    public enum ylv_org_documents_statuscode {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactive = 2,
    }
    
    [System.Runtime.Serialization.DataContractAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.54")]
    public enum ylv_org_documents_ylv_document_status {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Черновик = 852250000,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Проверка = 852250001,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Отказ = 852250002,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Согласовано_с_замечаниями = 852250004,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Одобрен = 852250003,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum ylv_objectpackettype
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Пакет_документов_по_земле = 852250000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Пакет_документов_на_строительство = 852250001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Пакет_документов_по_энергетике = 852250002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Переоформление_пакет_документов_по_земле = 852250003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Переоформление_пакет_документов_по_энергетике = 852250004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Пакет_документов_PНР = 852250005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Пакет_документов_ДА = 852250006,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Пакет_документов_ВЛЭС = 852250007,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Пакет_документов_CМР = 852250008,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Пакет_документов_СМР_документация = 852250009,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Договор_с_оператором = 852250010,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Коммерческая_переуступка = 852250011,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum ylv_packettype
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Аккредитация_организации = 852250000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Аккредитация_объектов = 852250001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Аккредитация_заказов = 852250002,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum ylv_opportunitytpackettype
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnknownLabel852250000 = 852250000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnknownLabel852250001 = 852250001,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum ylv_readytosend
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnknownLabel852250000 = 852250000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnknownLabel852250001 = 852250001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnknownLabel852250002 = 852250002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnknownLabel852250003 = 852250003,
    }
}
