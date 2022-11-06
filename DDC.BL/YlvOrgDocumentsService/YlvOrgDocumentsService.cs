using DDC.DAL;
using DDC.Domain.DTOs;
using Microsoft.Xrm.Sdk.Query;
using ProxyTypes;

namespace DDC.BL
{
    public class YlvOrgDocumentsService : IYlvOrgDocumentsService
    {
        private readonly IYlvOrgDocumentsRepository ylvOrgDocumentsRepository;
        public YlvOrgDocumentsService(IYlvOrgDocumentsRepository ylvOrgDocumentsRepository)
        {
            this.ylvOrgDocumentsRepository = ylvOrgDocumentsRepository;
        }
        private DateTime ConvertDt(DateTime dt) => new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0, DateTimeKind.Utc);
        private string ConvertDtToString(DateTime dt) => $"{dt.Year}-{dt.Month}-{dt.Day}";
        public async Task<IEnumerable<YlvOrgDocumentsDTO>> GetDocuments(DateTime? startDateTime)
        {
            startDateTime = startDateTime == null ? ConvertDt(DateTime.Now.AddDays(-1)) : ConvertDt(startDateTime.Value);
            return await ylvOrgDocumentsRepository.RetrieveMultiple(new QueryExpression
            {
                ColumnSet = new ColumnSet(
                    YlvOrgDocuments.ylv_accountName,
                    YlvOrgDocuments.ylv_objectidName,
                    YlvOrgDocuments.ylv_opportunityidName,
                    YlvOrgDocuments.ylv_doctypeName,
                    YlvOrgDocuments.ylv_docobjecttypeName,
                    YlvOrgDocuments.ylv_nameName,
                    YlvOrgDocuments.ylv_status_update_dateName,
                    YlvOrgDocuments.ylv_document_statusName
                ),
                Criteria = new FilterExpression()
                {
                    Conditions =
                    {
                        new ConditionExpression(YlvOrgDocuments.ylv_accountName,ConditionOperator.NotNull),
                        new ConditionExpression(YlvOrgDocuments.ylv_objectidName,ConditionOperator.NotNull),
                        new ConditionExpression(YlvOrgDocuments.ylv_doctypeName,ConditionOperator.NotNull),
                        new ConditionExpression(YlvOrgDocuments.ylv_doctypeName,ConditionOperator.NotEqual,(int)ylv_packettype.Аккредитация_организации),
                        new ConditionExpression(YlvOrgDocuments.ylv_nameName,ConditionOperator.NotNull),
                        new ConditionExpression(YlvOrgDocuments.ylv_document_statusName,ConditionOperator.NotNull),
                        new ConditionExpression(YlvOrgDocuments.ylv_status_update_dateName,ConditionOperator.GreaterEqual,ConvertDtToString(startDateTime.Value)),
                    },
                    Filters =
                    {
                        new FilterExpression()
                        {
                            FilterOperator=LogicalOperator.Or,
                            Filters =
                            {
                                new FilterExpression()
                                {
                                    Conditions =
                                    {
                                        new ConditionExpression(YlvOrgDocuments.ylv_doctypeName, ConditionOperator.Equal, (int)ylv_packettype.Аккредитация_объектов),
                                        new ConditionExpression(YlvOrgDocuments.ylv_doctypeName, ConditionOperator.NotNull),
                                    }
                                },
                                new FilterExpression()
                                {
                                    Conditions =
                                    {
                                        new ConditionExpression(YlvOrgDocuments.ylv_doctypeName, ConditionOperator.NotEqual, (int)ylv_packettype.Аккредитация_объектов),
                                    }
                                },
                            }
                        },

                    }
                }
            });
        }
    }
}