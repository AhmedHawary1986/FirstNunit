using System;
using System.Collections.Generic;
using System.Text;

namespace Loans
{
    public class LoanPaymentCalculator
    {
        private LoanTerm _loanTerm;

        private double _OriginalCost;

        private double _rate;

        public LoanPaymentCalculator(double OriginalCost,double Rate,LoanTerm LoanTerm)
        {
            _OriginalCost = OriginalCost;
            _rate = Rate;
            _loanTerm = LoanTerm;
        }

        public double CalculateLoan()
        {
            return (_OriginalCost + (_loanTerm.ReturnTermInMonth() * _rate* _OriginalCost));
        }
    }
}
