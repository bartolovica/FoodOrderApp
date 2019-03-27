using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marende.Persistence
{
    public class OstaliPriceRepository
    {
        public static DTO.OstaliCijeneDto GetOstaliPrices()
        {
            var db = new MarendeEntities();
            var prices = db.OstaliCijenes.First();
            var dto = convertToDto(prices);
            return dto;
        }

        private static DTO.OstaliCijeneDto convertToDto(OstaliCijene ostaliCijene)
        {
            var ostaliCijeneDto = new DTO.OstaliCijeneDto();

            ostaliCijeneDto.Mali = ostaliCijene.Mali;
            ostaliCijeneDto.Srednji = ostaliCijene.Srednji;
            ostaliCijeneDto.Veliki = ostaliCijene.Veliki;
            ostaliCijeneDto.Piletina = ostaliCijene.Piletina;
            ostaliCijeneDto.PiletinaSir = ostaliCijene.PiletinaSir;
            ostaliCijeneDto.Hamburger = ostaliCijene.Cheesburger;
            ostaliCijeneDto.Cevapi = ostaliCijene.Cevapi;
            ostaliCijeneDto.Pizza = ostaliCijene.Pizza;

            return ostaliCijeneDto;
        }
    }
}
