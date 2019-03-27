using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marende.Persistence
{
    public class RizzoPriceRepository
    {
        public static DTO.RizzoCijeneDto GetRizzoPrices()
        {
            var db = new MarendeEntities();
            var prices = db.RizzoCijenes.First();
            var dto = convertToDto(prices);
            return dto;
        }

        private static DTO.RizzoCijeneDto convertToDto(RizzoCijene rizzoCijene)
        {
            var rizzoCijeneDto = new DTO.RizzoCijeneDto();

            rizzoCijeneDto.Mali = rizzoCijene.Mali;
            rizzoCijeneDto.MaliSirSunka = rizzoCijene.MaliSirSunka;
            rizzoCijeneDto.MaliPurecaDimljena = rizzoCijene.MaliPurecaDimljena;
            rizzoCijeneDto.MaliBudolaZimskaPrsutKulen = rizzoCijene.MaliBudolaZimskaPrsutKulen;
            rizzoCijeneDto.MaliTuna = rizzoCijene.MaliTuna;
            rizzoCijeneDto.Veliki = rizzoCijene.Veliki;
            rizzoCijeneDto.VelikiSirSunka = rizzoCijene.VelikiSirSunka;
            rizzoCijeneDto.VelikiPurecaMladiDimljena = rizzoCijene.VelikiPurecaMladiDimljena;
            rizzoCijeneDto.VelikiBudolaZimskaPrsutKulen = rizzoCijene.VelikiBudolaZimskaPrsutKulen;
            rizzoCijeneDto.VelikiTuna = rizzoCijene.VelikiTuna;
            rizzoCijeneDto.DodatakSir = rizzoCijene.DodatakSir;
            rizzoCijeneDto.DodatakNapomena = rizzoCijene.DodatakNapomena;
            rizzoCijeneDto.SezonskaSalata = rizzoCijene.SezonskaSalata;
            rizzoCijeneDto.GrckaSalata = rizzoCijene.GrckaSalata;
            rizzoCijeneDto.TunjSalata = rizzoCijene.TunjSalata;

            return rizzoCijeneDto;
        }
    }
}


