using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface IPayModeRepository
    {
        void Add(PayModeModel payModemodel);

        void edit(PayModeModel payModemodel);

        void delete(int id);

        IEnumerable<PayModeModel> GetAll();

        IEnumerable<PayModeModel> GetByValue(string value);
    }
}
