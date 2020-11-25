namespace CalculosImpostos
{
  //TODO: criar pasta e fazer devidas configurações
  /*
  IPI
  Para ilustrar, pode ser citado o exemplo do IPI, incidente sobre operações com produtos industrializados, cuja base de cálculo consiste na soma do preço do produto, do frete e das demais despesas acessórias cobradas do comprador ou destinatário do bem. Valendo-se de valores nominais hipotéticos, o cálculo é feito da seguinte forma:

IPI = Valor da operação x alíquota
IPI = (preço do produto + frete + despesas acessórias) x alíquota
IPI = (R$ 5.000,00 + R$ 300,00 + R$ 0,00) x 10%
IPI = R$ 5.300,00 x 10%
IPI = 530,00

Na nota fiscal dessa operação constariam as seguintes informações:

Valor Total dos Produtos: R$ 5.000,00
Valor do Frete: R$ 300,00
Valor do IPI: R$ 530,00
Valor Total da Nota: R$ 5.830,00 (produto + frete + IPI)
Note que o valor do IPI é acrescido ao valor do produto após o seu cálculo, compondo o valor total e final da operação.


  */
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
