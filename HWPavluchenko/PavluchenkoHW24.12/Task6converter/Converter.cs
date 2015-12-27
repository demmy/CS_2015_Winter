using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6converter
{
    class Converter
    {
        double usdCoeff;

        public double UsdCoeff
        {
            get { return usdCoeff; }
            set { usdCoeff = value; }
        }
        double eurCoeff;

        public double EurCoeff
        {
            get { return eurCoeff; }
            set { eurCoeff = value; }
        }
        double rubCoeff;

        public double RubCoeff
        {
            get { return rubCoeff; }
            set { rubCoeff = value; }
        }
        public Converter(double usd, double eur, double rub)
        {
            usdCoeff = usd;
            eurCoeff = eur;
            rubCoeff = rub;

        }
        public void UahTo(double uah)
        {
            Console.WriteLine("{0} in usd: {1}\n{0} in eur: {2}\n{0} in rub: {3}\n",
                                uah, uah / usdCoeff, uah / eurCoeff, uah / rubCoeff);
            Console.ReadLine();
        }
        public void ToUah(double money)
        {
            Console.WriteLine("{0} usd = {1} uah \n{0} eur = {2} uah\n{0} rub = {3} uah ",
                               money, usdCoeff * money, eurCoeff * money, rubCoeff * money);
            Console.ReadLine();
        }
    }
}
