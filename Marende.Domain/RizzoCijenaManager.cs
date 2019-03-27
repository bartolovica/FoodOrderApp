using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marende.DTO;
using Marende.DTO.Enums;

namespace Marende.Domain
{
    public class RizzoCijenaManager
    {
        public static decimal CalculateRizzoCijena(DTO.OrderDto order)
        {
            decimal cijena = 0.0M;
            var cijene = getRizzoCijena();

            cijena += calculateOsnovnoCijena(order, cijene);
            cijena += calculateDodaciCijena(order, cijene);

            return cijena;
        }

        private static decimal calculateOsnovnoCijena(DTO.OrderDto order, DTO.RizzoCijeneDto cijene)
        {
            decimal cijena = 0.0M;

            if (order.VelicinaSendvic == VelicinaType.Mali)
            {
                switch (order.SastavSendvicOsnovno)
                {
                    case SendvicOsnovnoType.Nista:
                        cijena = cijene.Mali;
                        break;
                    case SendvicOsnovnoType.SirSunka:
                        cijena = cijene.MaliSirSunka;
                        break;
                    case SendvicOsnovnoType.Sunka:
                        cijena = cijene.MaliSirSunka;
                        break;
                    case SendvicOsnovnoType.Budola:
                        cijena = cijene.MaliBudolaZimskaPrsutKulen;
                        break;
                    case SendvicOsnovnoType.Zimska:
                        cijena = cijene.MaliBudolaZimskaPrsutKulen;
                        break;
                    case SendvicOsnovnoType.Kulen:
                        cijena = cijene.MaliBudolaZimskaPrsutKulen;
                        break;
                    case SendvicOsnovnoType.Prsut:
                        cijena = cijene.MaliBudolaZimskaPrsutKulen;
                        break;
                    case SendvicOsnovnoType.Pureca:
                        cijena = cijene.MaliPurecaDimljena;
                        break;
                    case SendvicOsnovnoType.Dimljena:
                        cijena = cijene.MaliPurecaDimljena;
                        break;
                    case SendvicOsnovnoType.Tuna:
                        cijena = cijene.MaliTuna;
                        break;
                    case SendvicOsnovnoType.SamoNamaz:
                        if (order.SastavSendvicOsnovno == SendvicOsnovnoType.SamoNamaz && order.TunaKomdai)
                            cijena = cijene.MaliTuna;
                        else
                            cijena = cijene.Mali;
                        break;
                    default:
                        break;
                }
            }
            else if (order.VelicinaSendvic == VelicinaType.Veliki)
            {
                switch (order.SastavSendvicOsnovno)
                {
                    case SendvicOsnovnoType.Nista:
                        cijena = cijene.Veliki;
                        break;
                    case SendvicOsnovnoType.SirSunka:
                        cijena = cijene.VelikiSirSunka;
                        break;
                    case SendvicOsnovnoType.Sunka:
                        cijena = cijene.VelikiSirSunka;
                        break;
                    case SendvicOsnovnoType.Budola:
                        cijena = cijene.VelikiBudolaZimskaPrsutKulen;
                        break;
                    case SendvicOsnovnoType.Zimska:
                        cijena = cijene.VelikiBudolaZimskaPrsutKulen;
                        break;
                    case SendvicOsnovnoType.Kulen:
                        cijena = cijene.VelikiBudolaZimskaPrsutKulen;
                        break;
                    case SendvicOsnovnoType.Prsut:
                        cijena = cijene.VelikiBudolaZimskaPrsutKulen;
                        break;
                    case SendvicOsnovnoType.Pureca:
                        cijena = cijene.VelikiPurecaMladiDimljena;
                        break;
                    case SendvicOsnovnoType.Dimljena:
                        cijena = cijene.VelikiPurecaMladiDimljena;
                        break;
                    case SendvicOsnovnoType.Tuna:
                        cijena = cijene.VelikiTuna;
                        break;
                    case SendvicOsnovnoType.SamoNamaz:
                        if (order.SastavSendvicOsnovno == SendvicOsnovnoType.SamoNamaz && order.TunaKomdai)
                            cijena = cijene.VelikiTuna;
                        else
                            cijena = cijene.Veliki;
                        break;
                    default:
                        break;
                }
            }
            else if (order.VelicinaSendvic == VelicinaType.Srednji)
            {
                switch (order.SastavSendvicOsnovno)
                {
                    case SendvicOsnovnoType.SezonskaSalata:
                        cijena = cijene.SezonskaSalata;
                        break;
                    case SendvicOsnovnoType.GrckaSalata:
                        cijena = cijene.GrckaSalata;
                        break;
                    case SendvicOsnovnoType.TunjSalata:
                        cijena = cijene.TunjSalata;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                cijena = 0.0M;
            }

            return cijena;
        }

        private static decimal calculateDodaciCijena(DTO.OrderDto order, DTO.RizzoCijeneDto cijene)
        {
            decimal cijena = 0.0M;

            if (order.Sir)
                cijena = 2.0M;
            else if (order.SastavSendvicOsnovno == SendvicOsnovnoType.Tuna && order.MladiSir)
                cijena = 4.0M;
            else if (order.SastavSendvicOsnovno == SendvicOsnovnoType.Tuna && order.TunaKomdai)
                cijena = 4.0M;
            else if (order.MladiSir)
                cijena = 4.0M;
            else
                cijena = 0.0M;

            return cijena;
        }

        private static DTO.RizzoCijeneDto getRizzoCijena()
        {
            return Persistence.RizzoPriceRepository.GetRizzoPrices();
        }
    }
}
