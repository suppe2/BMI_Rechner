using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Rechner
{
    public class BMI
    {
        //double m_groesse, m_gewicht;
        //public BMI(double groesse, double gewicht)
        //{
        //    m_groesse = groesse;
        //    m_gewicht = gewicht;
        //}
        public static double CalculateBMI(double groesse, double gewicht)
        {
            double bmi;
            bmi = gewicht / (Math.Pow(groesse, 2));
            return bmi;
        }
    }
}
