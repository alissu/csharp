namespace CalculosImpostos
{
  //TODO: criar pasta e fazer devidas configurações
  public class Impostos
  {
    public decimal Icms(decimal valorProduto, bool isPorDentro, decimal aliquota){
      var icmsARecolher = 0M;
      if(isPorDentro)
      {
        icmsARecolher = valorProduto / (1 - aliquota) - valorProduto;
        return icmsARecolher;
      }
      else
      {
        icmsARecolher = valorProduto * aliquota - valorProduto;
        return icmsARecolher;
      }
    }
  }
}
