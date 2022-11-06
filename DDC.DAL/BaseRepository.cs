using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DDC.DAL
{
    /// <summary>
    /// Представляет базовый функционал для всех репозиториев.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly IOrganizationServiceAsync service;
        public BaseRepository(IOrganizationServiceAsync service)
        {
            this.service = service;
        }

        protected abstract string LogicalName
        {
            get;
        }

        public async Task<IEnumerable<T>> RetrieveMultiple(QueryExpression query)
        {
            var pageNumber = 1;
            var pagingCookie = string.Empty;
            var result = new List<T>();
            query.EntityName ??= LogicalName;
            EntityCollection resp;
            do
            {
                if (pageNumber != 1)
                {
                    query.PageInfo.PageNumber = pageNumber;
                    query.PageInfo.PagingCookie = pagingCookie;
                }
                resp = await service.RetrieveMultipleAsync(query);
                if (resp.MoreRecords)
                {
                    pageNumber++;
                    pagingCookie = resp.PagingCookie;
                }
                result.AddRange(from r in resp.Entities.AsEnumerable() select Convert(r));
            }
            while (resp.MoreRecords);

            return result;

        }
        public async Task<T> Retrieve(Guid Id,ColumnSet columnSet)
        {
            var result=await service.RetrieveAsync(LogicalName, Id, columnSet);
            return Convert(result);
        }
        abstract protected Entity Convert(T entity);
        abstract protected T Convert(Entity entity);
    }
}
