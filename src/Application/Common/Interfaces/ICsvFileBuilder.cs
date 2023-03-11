using CleanArchitectureCQRS.Application.TodoLists.Queries.ExportTodos;

namespace CleanArchitectureCQRS.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
