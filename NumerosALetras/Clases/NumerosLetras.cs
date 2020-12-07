using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTILS.Clases
{
    class NumerosLetras
    {
        static String[] Unidades = {"cero", "uno", "dos", "tres", "cuatro", "cinco",
                             "seis", "siete","ocho","nueve","diez","once","doce",
                             "trece","catorce","quince","dieciseis","diecisiete",
                             "deiciocho","diecinueve"};

        static String[] Decenas = {"cero","diez", "veinte", "treinta", "cuarenta", "cincuenta",
                             "sesenta","setenta","ochenta","noventa"};

        static String[] Centenas = {"cero","cien","doscientos","trescientos","cuatrocientos","quinientos",
                             "seiscientos","setecientos","ochocientos","novecientos"};

        public static void TestUnidades()
        {
            //Recorrer todo el array de String
            foreach(String cad in Unidades)
            {
                Console.WriteLine(cad);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Devuelve el equivalente en letras para las unidades
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static String getUnidades(int num)
        {
            String aux = "";
            if(num>=0 && num < 20)
            {
                aux = Unidades[num];
            }
            return aux;
        }

        public static String getDecenas(int num)
        {
            String aux = "";
            if(num>=0 && num < 20)
            {
                aux = getUnidades(num);
            }else 
                if(num>=20 && num < 100)
                {
                int residuo = num % 10;
                aux = Decenas[num / 10];
                if (residuo > 0)
                {
                    aux += " y " + getUnidades(residuo);
                }
                }
            return aux;
        }

        public static String getCentenas(int num)
        {
            String aux = "";
            if(num>=0 && num < 100)
            {
                aux = getDecenas(num);
            }else if (num == 100)
            {
                aux += Centenas[num /100];
            }
            else if (num>100 && num<200)
            {
                int residuo = num % 100;
                if(residuo > 0)
                {
                    aux += "ciento " + getDecenas(residuo);
                }
                
            }else if(num>=200 && num < 1000)
            {
                int residuo = num % 100;
                aux = Centenas[num / 100];
                if (residuo > 0 )
                {
                    aux +=  " " + getDecenas(residuo);
                }
            }
            return aux;
        }

        public static String getUnidadesMil(int num)
        {
            String aux = "";
            if(num>=0 && num < 1000)
            {
                aux = getCentenas(num);
            }else if (num == 1000)
            {
                aux = "mil";
            }
            else if(num>1000 && num <= 999999)
            {
                int residuo = num % 1000;
                if(num>1000 && num < 2000)
                {
                    aux = "mil " + getCentenas(residuo);
                }   
                else if(num >= 2000 && num <=999999)
                {
                    aux = getCentenas(num / 1000) + " mil";
                    if(residuo > 0)
                    {
                        aux += " " + getCentenas(residuo);
                    }
                }
            }
            return aux;
        }

        public static String getMillones(int num)
        {
            String aux = "";
            if(num>=0 && num <= 999999)
            {
                aux = getUnidadesMil(num);
            }else if (num>=1000000 && num<= 999999999)
            {
                int residuo = num % 1000000;
                if (num >= 1000000 && num <2000000)
                {
                    aux = "un millon";
                    if (residuo > 0)
                    {
                        aux += " " + getUnidadesMil(residuo);
                    }
                }
                else if(num>1000000 && num<= 999999999)
                {
                    aux = getUnidadesMil(num / 1000000) + " millones";
                    if (residuo > 0)
                    {
                        aux += " " + getUnidadesMil(residuo);
                    }
                }
            }
            return aux;
        }
    }
}
    