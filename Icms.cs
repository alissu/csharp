namespace CalculosImpostos
{
  //TODO: criar pasta e fazer devidas configurações
  public class Impostos
  {
    public decimal Icms(decimal valorProduto, decimal aliquota) => valorProduto / (1 - aliquota);
  }
}
