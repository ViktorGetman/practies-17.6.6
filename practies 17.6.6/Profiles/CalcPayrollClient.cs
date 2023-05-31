using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practies_17._6._6.Profiles
{
    internal class CalcPayrollClient : ILandingProfile
    {
        // Метод для расчета процентной ставки
        public void CalculateInterest(Account account)
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;
        }
    }
}