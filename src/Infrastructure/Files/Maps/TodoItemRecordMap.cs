using System.Globalization;
using CleanArchitectureCQRS.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace CleanArchitectureCQRS.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).Convert(c => c.Value.Done ? "Yes" : "No");
    }
}
