using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;

namespace DDC.DAL
{
    /// <summary>
    /// Базовый интерфейс для репозиториев.
    /// </summary>
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> RetrieveMultiple(QueryExpression query);
        Task<T> Retrieve(Guid Id, ColumnSet columnSet);
    }
}
