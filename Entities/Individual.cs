
namespace Exercícios_Abstratas.Entities
{
    class Individual : TaxPayer
    {
        public double Expenditures { get; set; }

        public Individual(string name, double income, double expenditures) : base(name, income)
        {
            Expenditures = expenditures;
        }
        public override double Tax() 
        {
           if(Expenditures <= 20.000)
            {
                return (Income * 0.15) - (Expenditures * 0.5); 
            }
           else
            {
                return (Income * 0.25) - (Expenditures * 0.5);
            }
        }


    }
}
