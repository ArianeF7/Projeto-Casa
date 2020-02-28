using Microsoft.AspNetCore.Identity;

namespace CasaDeShow1.Models
{
    public class Comprar
    {
        public int Id {get; set;}
        public int Quantidade {get; set;}
        public float TotalCompra {get; set;}
        public Evento Evento {get; set;}
        public IdentityUser IdentityUser {get; set;}
    }
}