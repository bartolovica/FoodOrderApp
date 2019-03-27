using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marende.DTO.Enums;

namespace Marende.Domain
{
    public class OstaliCijenaManager
    {
        public static decimal CalculateRizzoCijena(DTO.OrderDto order)
        {
            decimal cijena = 0.0M;
            var cijene = getOstaliCijena();

            cijena += calculateOsnovnoCijena(order, cijene);

            return cijena;
        }

        private static decimal calculateOsnovnoCijena(DTO.OrderDto order, DTO.OstaliCijeneDto cijene)
        {
            decimal cijena = 0.0M;

            switch (order.SastavSendvicOsnovno)
            {
                case SendvicOsnovnoType.SirSunka:
                    if (order.VelicinaSendvic == VelicinaType.Mali)
                        cijena = cijene.Mali;
                    if (order.VelicinaSendvic == VelicinaType.Srednji)
                        cijena = cijene.Srednji;
                    if (order.VelicinaSendvic == VelicinaType.Veliki)
                        cijena = cijene.Veliki;
                    break;
                case SendvicOsnovnoType.Piletina:
                    cijena = cijene.Piletina;
                    break;
                case SendvicOsnovnoType.PiletinaSir:
                    cijena = cijene.PiletinaSir;
                    break;
                case SendvicOsnovnoType.Hamburger:
                    cijena = cijene.Hamburger;
                    break;
                case SendvicOsnovnoType.Cheesburger:
                    cijena = cijene.Cheesburger;
                    break;
                case SendvicOsnovnoType.Cevapi:
                    cijena = cijene.Cevapi;
                    break;
                case SendvicOsnovnoType.Pizza:
                    cijena = cijene.Pizza;
                    break;
            }

            return cijena;
        }


        private static DTO.OstaliCijeneDto getOstaliCijena()
        {
            return Persistence.OstaliPriceRepository.GetOstaliPrices();
        }
    }
}

