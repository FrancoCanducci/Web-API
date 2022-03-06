namespace API_Atividade
{
    public class Produto
    {
        public int id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public float Peso { get; set; } = float.MinValue;
    }
}
