using System;
using System.Collections.Generic;
using System.Text;

namespace Loans
{
    public class LoanProduct
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public LoanProduct(long id, string name)
        {
            Id = id;
            Name = name;
        }

        public override bool Equals(object obj)
        {
           if(obj == null || obj.GetType() != GetType())
            {
                return false;
            }
           else
            {
                LoanProduct receiver = (LoanProduct)obj;
                if(receiver.Id == Id && receiver.Name == Name)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
