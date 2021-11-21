using System.Collections.Generic;
using System.Threading.Tasks;
using Ardalis.Result;
using Minimal.Hr.Core.ProjectAggregate;

namespace Minimal.Hr.Core.Interfaces;

public interface IToDoItemSearchService
{
  Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
  Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
}
