using System.Threading.Tasks;
using EPE.Database;
using EPE.Domain.Models;

namespace EPE.Application.StockAdmin
{
    public class CreateStock
    {
        private ApplicationDbContext _ctx;
        public CreateStock(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {
            var stock = new Stock
            {
                ProductId = request.ProductId,
                Qty = request.Qty,
                Description = request.Description
            };

            _ctx.Stock.Add(stock);

            await _ctx.SaveChangesAsync();
            
            return new Response
            {
                Id = stock.Id,
                Description = stock.Description,
                Qty = stock.Qty
            };
        }

        public class Request
        {
            public int ProductId { get; set; }
            public string Description { get; set; }
            public int Qty { get; set; }
        }

        public class Response
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public int Qty { get; set; }
        }
    }
}