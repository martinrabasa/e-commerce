using System;
using System.Collections.Generic;
using System.Linq;
using EPE.Database;
using EPE.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace EPE.Application.Cart
{
    public class GetCart
    {
        private ApplicationDbContext _ctx;
        private ISession _session;
        public GetCart(ISession session, ApplicationDbContext ctx)
        {
            _session = session;
            _ctx = ctx;
        }

        public class Response
        {
            public string Name { get; set; }
            public string Value { get; set; }
            public int StockId { get; set; }
            public int Qty { get; set; }
        }

        public IEnumerable<Response> Do()
        {
            var stringObject = _session.GetString("cart");

            if (String.IsNullOrEmpty(stringObject))
            {
                return new List<Response>();
            }

            var cartList = JsonConvert.DeserializeObject<List<CartProduct>>(stringObject);

            var response = _ctx.Stock
                .Include(x => x.Product).AsEnumerable()
                .Where(x => cartList.Any(y => y.StockId == x.Id))
                .Select(x => new Response
                {
                    Name = x.Product.Name,
                    Value = $"$ {x.Product.Value.ToString("N2")}",
                    StockId = x.Id,
                    Qty = cartList.FirstOrDefault(y => y.StockId == x.Id).Qty
                })
                .ToList();

            return response;
        }
    }
}