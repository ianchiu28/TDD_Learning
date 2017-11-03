using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Learning
{
    class Day7
    {
    }

    public interface ICheckInFee
    {
        decimal GetFee(Customer customer);
    }

    public class Customer
    {
        public bool IsMale { get; set; }

        public int Seq { get; set; }
    }

    public class Pub
    {
        private ICheckInFee _checkInFee;
        private decimal _inCome = 0;

        public Pub(ICheckInFee checkInFee)
        {
            this._checkInFee = checkInFee;
        }

        public int CheckIn(List<Customer> customers)
        {
            var result = 0;

            foreach(var customer in customers)
            {
                var isFemale = !customer.IsMale;

                // only men need to pay
                if (isFemale)
                {
                    continue;
                }
                else
                {
                    // for stub, validate status: income value
                    // for mock, validate only male
                    this._inCome += this._checkInFee.GetFee(customer);

                    result++;
                }
            }

            // for stub, validate return value
            return result;
        }

        public decimal GetInCome()
        {
            return this._inCome;
        }
    }
}
