using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRepairOrderData : IRepairOrderData
    {
        List<RepairOrder> repairOrders;

        public InMemoryRepairOrderData()
        {
            repairOrders = new List<RepairOrder>()
            {
                new RepairOrder { Id =  1, Name = "Henk Jansen", StatusRepair = Status.Under_repair },
                new RepairOrder { Id =  2, Name = "Jaap Tokki", StatusRepair = Status.Done },
                new RepairOrder { Id =  3, Name = "Jan de Jong", StatusRepair = Status.Waiting_for_parts },
            };
        }

        public void Add(RepairOrder repairOrder)
        {
            repairOrders.Add(repairOrder);
            repairOrder.Id = repairOrders.Max(r => r.Id) + 1;
        }

        public void Update(RepairOrder repairOrder)
        {
            var existing = Get(repairOrder.Id);
            if (existing != null)
            {
                existing.Name = repairOrder.Name;
                existing.StatusRepair = repairOrder.StatusRepair;
            }
        }

        public RepairOrder Get(int id)
        {
            return repairOrders.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<RepairOrder> GetAll()
        {
            return repairOrders.OrderBy(r => r.Name);
        }

        public void Delete(int id)
        {
            var repairorder = Get(id);
            if (repairorder != null)
            {
                repairOrders.Remove(repairorder);
            }
        }
    }
}
