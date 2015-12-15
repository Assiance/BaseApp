using System.Data;
using System.Data.Entity;
using System.Web;
using BaseApp.Core.Tasks;
using BaseApp.Data.Contexts;
using BaseApp.Web.Infrastructure.Tasks;

namespace BaseApp.Web.Infrastructure
{
    public class TransactionPerRequest : IRunOnEachRequest, IRunOnError, IRunAfterEachRequest
    {
        public static string TransactionKey { get { return "_Transaction"; } }
        public static string ErrorKey { get { return "_Error"; } }

        private readonly ApplicationDbContext _context;
        private readonly HttpContextBase _httpContext;

        public TransactionPerRequest(ApplicationDbContext context,
            HttpContextBase httpContext)
        {
            //Todo: Add all Contexts to this file
            this._context = context;
            this._httpContext = httpContext;
        }

        void IRunOnEachRequest.Execute()
        {
            _httpContext.Items[TransactionKey] = _context.Database.BeginTransaction(IsolationLevel.ReadCommitted);
        }

        void IRunOnError.Execute()
        {
            _httpContext.Items[ErrorKey] = true;
        }

        void IRunAfterEachRequest.Execute()
        {
            var transaction = (DbContextTransaction)_httpContext.Items[TransactionKey];

            if (_httpContext.Items[ErrorKey] != null)
            {
                transaction.Rollback();
            }
            else
            {
                transaction.Commit();
            }
        }
    }
}