using System;

namespace Loans
{
    public class LoanTerm : IDisposable
    {
        private bool disposedValue;

        public double Years { get; set; }
        public LoanTerm(double years)
        {
            if (years <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Years),"Years value must be greater than zero");
            }
            Years = years;
        }



        public double ReturnTermInMonth()
        {
            return Years * 12;
        }

        public double ReturnOneThird()
        {
            return (Years / 3);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~LoanTerm()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        //public override bool Equals(object obj)
        //{
        //   if(obj== null || obj.GetType() != GetType())
        //    {
        //        return false;
        //    }
        //   else
        //    {
        //        LoanTerm receiver = (LoanTerm)obj;
        //        if (receiver.Years == Years)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}

    }
}
