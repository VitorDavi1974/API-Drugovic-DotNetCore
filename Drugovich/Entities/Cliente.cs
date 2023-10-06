namespace Drugovich.Entities
{
    public class Cliente
    {
        public int id { get; set; }

        public string? cnpj { get; set; }

        public string? nome { get; set; }

        public DateTime fundacao { get; set; }

        public int? Grupoid { get; set; }

        public virtual Grupo? Grupo { get; set; }
    }
}
