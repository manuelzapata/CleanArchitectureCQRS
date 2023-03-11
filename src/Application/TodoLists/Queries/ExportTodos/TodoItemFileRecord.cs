using CleanArchitectureCQRS.Application.Common.Mappings;
using CleanArchitectureCQRS.Domain.Entities;

namespace CleanArchitectureCQRS.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
