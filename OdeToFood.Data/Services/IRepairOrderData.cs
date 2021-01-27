using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public interface IRepairOrderData
    {
        IEnumerable<RepairOrder> GetAll();
        RepairOrder Get(int id);
        void Add(RepairOrder repairOrder);
        void Update(RepairOrder repairOrder);
        void Delete(int id);
        //Status Get(string status);
        
    }
}
