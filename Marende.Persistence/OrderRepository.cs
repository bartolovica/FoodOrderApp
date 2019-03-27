using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marende.Persistence
{
    public class OrderRepository
    {
        public static void CreateOrder(DTO.OrderDto orderDto)
        {
            var db = new MarendeEntities();

            var order = convertToEntity(orderDto);
            db.Orders.Add(order);
            db.SaveChanges();
        }

        private static Order convertToEntity(DTO.OrderDto orderDto)
        {
            var order = new Order();

            order.Ime = orderDto.Ime;
            order.Prezime = orderDto.Prezime;
            order.TipKruh = orderDto.TipKruh;
            order.VelicinaSendvic = orderDto.VelicinaSendvic;
            order.SastavSendvicOsnovno = orderDto.SastavSendvicOsnovno;
            order.Kecap = orderDto.Kecap;
            order.Majoneza = orderDto.Majoneza;
            order.Tartar = orderDto.Tartar;
            order.TunaPasteta = orderDto.TunaPasteta;
            order.TunaKomdai = orderDto.TunaKomdai;
            order.Sir = orderDto.MladiSir;
            order.MladiSir = orderDto.MladiSir;
            order.Jaja = orderDto.Jaja;
            order.Kupus = orderDto.Kupus;
            order.Salata = orderDto.Salata;
            order.Pome = orderDto.Pome;
            order.Rukola = orderDto.Rukola;
            order.Krastavci = orderDto.Krastavci;
            order.SvjeziKrastavci = orderDto.SvjeziKrastavci;
            order.Kapula = orderDto.Kapula;
            order.Kukuruz = orderDto.Kukuruz;
            order.Paprika = orderDto.Paprika;
            order.Napomena = orderDto.Napomena;
            order.TotalCijena = orderDto.TotalCijena;
            order.DatumUnosa = orderDto.DatumUnosa;

            return order;
        }

        public static List<DTO.OrderDto> GetOrders()
        {
            var dateNow = DateTime.Now.Date;

            var db = new MarendeEntities();
            var orders = db.Orders.Where(p => p.DatumUnosa >= dateNow).ToList();
            var ordersDto = convertToDtos(orders);
            return ordersDto;
        }

        private static List<DTO.OrderDto> convertToDtos(List<Order> orders)
        {
            var ordersDto = new List<DTO.OrderDto>();

            foreach (var order in orders)
            {
                var orderDto = new DTO.OrderDto();

                orderDto.OrderId = order.OrderId;
                orderDto.Ime = order.Ime;
                orderDto.Prezime = order.Prezime;
                orderDto.TipKruh = order.TipKruh;
                orderDto.VelicinaSendvic = order.VelicinaSendvic;
                orderDto.SastavSendvicOsnovno = order.SastavSendvicOsnovno;
                orderDto.Kecap = order.Kecap;
                orderDto.Majoneza = order.Majoneza;
                orderDto.Tartar = order.Tartar;
                orderDto.TunaPasteta = order.TunaPasteta;
                orderDto.TunaKomdai = order.TunaKomdai;
                orderDto.Sir = order.MladiSir;
                orderDto.MladiSir = order.MladiSir;
                orderDto.Jaja = order.Jaja;
                orderDto.Kupus = order.Kupus;
                orderDto.Salata = order.Salata;
                orderDto.Pome = order.Pome;
                orderDto.Rukola = order.Rukola;
                orderDto.Krastavci = order.Krastavci;
                orderDto.SvjeziKrastavci = order.SvjeziKrastavci;
                orderDto.Kapula = order.Kapula;
                orderDto.Kukuruz = order.Kukuruz;
                orderDto.Paprika = order.Paprika;
                orderDto.Napomena = order.Napomena;
                orderDto.TotalCijena = order.TotalCijena;
                orderDto.DatumUnosa = order.DatumUnosa;

                ordersDto.Add(orderDto);
            }

            return ordersDto;
        }
    }
}