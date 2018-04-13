using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб4
{
    class Inventar
    {

        public string NameInv { get; set; }
        public int IDinv { get; set; }
        public double CostInv { get; set; }
        public DateTime DateInv { get; set; }
        public Tipinv Tip { get; set; }

        public Inventar(string NameInv, int IDinv, double CostInv, DateTime DateInv, Tipinv Tip)
        {
            this.NameInv = NameInv;
            this.IDinv = IDinv;
            this.CostInv = CostInv;
            this.DateInv = DateInv;
            this.Tip = Tip;
        }

       public void GetInfo ()
        {
            Console.Write("Код инвентаря: {0}\n    Название: {1}\n    Стоимость: {2}\n    Дата поступления: {3}\n    Тип инвентаря: ", IDinv, NameInv, CostInv, DateInv);
            Tip.GetInfo();

        }
    }
}
