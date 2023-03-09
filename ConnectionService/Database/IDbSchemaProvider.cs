using ConnectionService.Models;

namespace ConnectionService.Database;

public interface IDbSchemaProvider
{
    public Task<IEnumerable<TableInfo>> GetTablesAndColumns();
}