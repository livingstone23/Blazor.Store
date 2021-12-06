﻿using Blazor.Store.Client.Services.Interface;
using Blazor.Store.Shared.Model;
using System.Collections.Generic;
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

        public async Task<int> GetNextNumber()
        {
            return await _httpClient.GetFromJsonAsync<int>($"api/order/getnextnumber/");
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Order>>($"api/order/");
        }

        public async Task<Order> GetDetails(int id)
        {
            return await _httpClient.GetFromJsonAsync<Order>($"api/order/{id}");
        }
    }
}
