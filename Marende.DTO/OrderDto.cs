using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marende.DTO
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Nullable<Marende.DTO.Enums.TipKruhType> TipKruh { get; set; }
        public Marende.DTO.Enums.VelicinaType VelicinaSendvic { get; set; }
        public Marende.DTO.Enums.SendvicOsnovnoType SastavSendvicOsnovno { get; set; }
        public bool Kecap { get; set; }
        public bool Majoneza { get; set; }
        public bool Tartar { get; set; }
        public bool TunaPasteta { get; set; }
        public bool TunaKomdai { get; set; }
        public bool Sir { get; set; }
        public bool MladiSir { get; set; }
        public bool Jaja { get; set; }
        public bool Kupus { get; set; }
        public bool Salata { get; set; }
        public bool Pome { get; set; }
        public bool Rukola { get; set; }
        public bool Krastavci { get; set; }
        public bool SvjeziKrastavci { get; set; }
        public bool Kapula { get; set; }
        public bool Kukuruz { get; set; }
        public bool Paprika { get; set; }
        public string Napomena { get; set; }
        public decimal TotalCijena { get; set; }
        public Nullable<System.DateTime> DatumUnosa { get; set; }
    }
}
