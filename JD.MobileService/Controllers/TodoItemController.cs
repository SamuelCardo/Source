using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using JD.MobileService.DataObjects;
using JD.MobileService.Models;
using Microsoft.WindowsAzure.Mobile.Service.Security;

namespace JD.MobileService.Controllers
{
    public class TodoItemController : TableController<TodoItem>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<TodoItem>(context, Request, Services);
        }

        // GET tables/TodoItem
        //TODO TEMP security for xplatform testing
        [AuthorizeLevel(AuthorizationLevel.Anonymous)]
        public IQueryable<TodoItem> GetAllTodoItems()
        {
            return Query();
        }

        // GET tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        //TODO TEMP security for xplatform testing
        [AuthorizeLevel(AuthorizationLevel.Anonymous)]
        public SingleResult<TodoItem> GetTodoItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        //TODO TEMP security for xplatform testing
        [AuthorizeLevel(AuthorizationLevel.Anonymous)]
        public Task<TodoItem> PatchTodoItem(string id, Delta<TodoItem> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/TodoItem
        //TODO TEMP security for xplatform testing
        [AuthorizeLevel(AuthorizationLevel.Anonymous)]
        public async Task<IHttpActionResult> PostTodoItem(TodoItem item)
        {
            TodoItem current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        //TODO TEMP security for xplatform testing
        [AuthorizeLevel(AuthorizationLevel.Anonymous)]
        public Task DeleteTodoItem(string id)
        {
            return DeleteAsync(id);
        }
    }
}