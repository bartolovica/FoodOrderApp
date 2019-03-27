using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marende.DTO;

namespace Marende.Domain
{
    public class OrderManager
    {
        public static void CreateOrder(DTO.OrderDto orderDto)
        {
            if (orderDto.Ime.Trim().Length == 0)
                throw new Exception("Ime je obavezno");
            if (orderDto.Prezime.Trim().Length == 0)
                throw new Exception("Prezime je obavezno");

            orderDto.TotalCijena = RizzoCijenaManager.CalculateRizzoCijena(orderDto);

            Persistence.OrderRepository.CreateOrder(orderDto);
        }

        public static List<DTO.OrderDto> GetOrders()
        {
            return Persistence.OrderRepository.GetOrders();
        }
    }
}
