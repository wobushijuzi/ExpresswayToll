using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golbal
{
    public class Charge
    {
        DistanceBLL distancebll = new DistanceBLL();
        ChargeStandardBLL ChargeStandardbll = new ChargeStandardBLL();
        /// <summary>
        /// 费用计算
        /// </summary>
        /// <param name="cartype">车辆类型</param>
        /// <param name="weight">重量</param>
        /// <param name="start">驶入站</param>
        /// <param name="end">驶出站</param>
        /// <returns></returns>
        public double GetPay(string cartype,double weight,string start,string end)
        {
            double pay = 0;
            var distance = distancebll.List().Where(c => (c.Start == start && c.End == end) || (c.End == start && c.Start == end)).FirstOrDefault();
            var chargestandard = ChargeStandardbll.List().Where(c => c.CarType == cartype && c.WeightMin <= weight && c.WeightMax >= weight).FirstOrDefault();
            pay = distance.Distance * chargestandard.Ratio;
            return pay;
        }
    }
}
