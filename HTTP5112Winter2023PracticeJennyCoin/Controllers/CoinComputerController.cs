using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112Winter2023PracticeJennyCoin.Controllers
{
    public class CoinComputerController : ApiController
    {
        /// <summary>
        /// Input numbers representing Jenny's collection of nickles, dimes, quarters, loonies & twoonies, determine if Jenny can purchase a new toy worth $10.50 CAD.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="d"></param>
        /// <param name="q"></param>
        /// <param name="l"></param>
        /// <param name="t"></param>
        /// <returns>
        /// TRUE if she has enough money to purchase new toy
        /// FALSE if she does not have enough money to purchase new toy
        /// </returns>
        /// <example>GET api/example/coincomputer/0/0/0/15/0 --> TRUE</example>
        /// <example>GET api/example/coincomputer/20/0/0/1/1 --> FALSE</example>
        /// <example>GET api/example/coincomputer/100/20/2/4/0 --> TRUE</example>
        [HttpGet]
        [Route("api/example/coincomputer/{n}/{d}/{q}/{l}/{t}")]
        public string coincomputer(int n, int d, int q, int l, int t)
        {
            double newToyValue = 10.5;
            double coinCollectionValue = 0;
            string canAfford;

            double nickle = .05;
            double dime = .1;
            double quarter = .25;
            double loonie = 1;
            double twoonie = 2;

            coinCollectionValue =  (n * nickle) + (d * dime) + (q * quarter) + (l * loonie) + (t * twoonie);

            if (coinCollectionValue > newToyValue)
            {
                 canAfford = "TRUE";
            } else
            {
                canAfford = "FALSE";
            }
            return canAfford;
        }
    }
}
