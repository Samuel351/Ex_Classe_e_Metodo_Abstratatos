

namespace Exercícios_Abstratas.Entities
{
    class Company : TaxPayer
    {
     public int Employees { get; set; }

        public Company(string name, double income, int employees) : base(name, income)
        {
            Employees = employees;
        }

        public override double Tax()
        {
            if(Employees > 10)
            {
                return Income * 0.14;
            }
            else
            {
                return Income * 0.16;
            }
        }

    }
}
