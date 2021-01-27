using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRepairOrderData : IRepairOrderData
    {
        List<RepairOrder> repairOrders;
        List<Status> statusOrders;

        public InMemoryRepairOrderData()
        {
            repairOrders = new List<RepairOrder>()
            {
                new RepairOrder { Id =  1, Name = "Henk Jansen", StatusRepair = Status.Under_repair, BeginDate = DateTime.Today, EndDate = DateTime.Today.AddDays(7) },
                new RepairOrder { Id =  2, Name = "Jaap Tokki", StatusRepair = Status.Done, BeginDate = DateTime.Today, EndDate = DateTime.Today.AddDays(7) },
                new RepairOrder { Id =  3, Name = "Jan de Jong", StatusRepair = Status.Waiting_for_parts, BeginDate = DateTime.Today, EndDate = DateTime.Today.AddDays(7) },
            };

            statusOrders = new List<Status>();
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
                existing.BeginDate = repairOrder.BeginDate;
                existing.EndDate = repairOrder.EndDate;
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
        /*
        public Status Get(string status)
        {
            return statusOrders.ForEach
        }
        */
    }
}
