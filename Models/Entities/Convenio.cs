namespace SysDente.Entities
{
    public class Convenio : IEntity
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public int DentistaId { get; set; }
        public Dentista Dentista { get; set; }
    }
}