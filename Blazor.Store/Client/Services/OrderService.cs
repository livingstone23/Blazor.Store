﻿using Blazor.Store.Client.Services.Interface;
using Blazor.Store.Shared.Model;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Blazor.Store.Client.Services
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _httpClient;
        public OrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task SaveOrder(Order order)
        {
            if (order.Id == 0)
                await _httpClient.PostAsJsonAsync<Order>($"api/order/", order);
            //else
                //Invoke Update

        }
    }
}
