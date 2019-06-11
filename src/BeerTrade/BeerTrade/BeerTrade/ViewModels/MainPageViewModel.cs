using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BeerTrade.ViewModels
{
    public sealed class MainPageViewModel
    {
        public Task<int> AddTwoUsingEveryLastBitOfComputerPower(int x) {
            //if (x >= 10)
            //    throw new Exception("Erro na operação.");

            var result = x + 2;
            return Task.FromResult(result);
        }
    }
}
