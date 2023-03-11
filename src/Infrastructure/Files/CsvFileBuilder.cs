using System.Globalization;
using CleanArchitectureCQRS.Application.Common.Interfaces;
using CleanArchitectureCQRS.Application.TodoLists.Queries.ExportTodos;
using CleanArchitectureCQRS.Infrastructure.Files.Maps;
using CsvHelper;

namespace CleanArchitectureCQRS.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Context.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
