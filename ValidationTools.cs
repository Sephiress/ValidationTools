using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Textvalidation
{
    internal class ValidationTools
    {
        #region data
            //Ik, better use data base but I didnt have opportunity
        public static string special_1 = " że ";
        public static string special_2 = " ze ";
        public static string special_3 = " aby ";
        public static string special_4 = " aczkolwiek ";
        public static string special_5 = " bo ";
        public static string special_6 = " bowiem ";
        public static string special_7 = " dlatego ";
        public static string special_8 = " ponieważ ";
        public static string special_9 = " poniewaz ";
        public static string special_10 = " ile ";
        public static string special_11 = " jak ";
        public static string special_12 = " jezeli ";
        public static string special_13 = " jeżeli ";
        public static string special_14 = " kiedy ";
        public static string special_15 = " mimo ";
        public static string special_16 = " po czym ";
        public static string special_17 = " gdy ";
        public static string special_18 = " skoro ";
        public static string special_19 = " zeby ";
        public static string special_20 = " żeby ";
        public static string special_21 = " iz ";
        public static string special_22 = " iż ";
        public static string special_23 = " wiec ";
        public static string special_24 = " więc ";
        public static string special_25 = " który ";
        public static string special_26 = " ktora ";
        public static string special_27 = " ktorego ";
        public static string special_28 = " którego ";
        public static string special_29 = " ktory ";
        public static string special_30 = " którą ";
        public static string special_31 = " która ";
        #endregion  
        public int i = 0;

        public string Validation(string text)
        {
            int i = 0;
            int j = 0;
            int count = text.Length;
            char[] validationtext = new char[count];
            foreach (char item in text)
            {
                if (item == '.')
                {
                    validationtext[j] = item;
                    i = 1;
                    j++;
                }
                else if (i == 1)
                {
                    if (item == ' ')
                    {
                        validationtext[j] = item;
                        j++;
                        i = 2;
                    }
                    else
                    {
                        validationtext[j] = Char.ToUpper(text[j]);
                        j++;
                        i = 0;
                    }

                }
                else if (i == 2)
                {
                    validationtext[j] = Char.ToUpper(item);
                    j++;
                    i = 0;
                }
                else
                {
                    if (j == 0)
                    {
                        validationtext[0] = Char.ToUpper(text[0]);
                        j++;
                    }
                    else
                    {
                        validationtext[j] = item;
                        if (j < text.Length)
                            j++;
                    }
                }
            }

            StringBuilder build = new StringBuilder();
            i = 0;
            while (i < validationtext.Length)
            {
                build.Append($"{validationtext[i]}");
                if (validationtext[i] == '.')
                {
                    //wyjatek kropka na koncu!!!
                    try {
                        if (validationtext[i + 1] != ' ')
                        {
                            build.Append(" ");
                        }
                    }
                    catch(Exception)
                    {

                    }
                    finally
                    {
                        build.Append("");
                    }
                    
                }
                i++;
            }
            text = build.ToString(); 
            return text;
        }
        public string Comma(string commatext)
        {

            commatext = commatext.Replace(special_1, (',' + special_1));
            commatext = commatext.Replace(special_2, (',' + special_2));
            commatext = commatext.Replace(special_3, (',' + special_3));
            commatext = commatext.Replace(special_4, (',' + special_4));
            commatext = commatext.Replace(special_5, (',' + special_5));
            commatext = commatext.Replace(special_6, (',' + special_6));
            commatext = commatext.Replace(special_7, (',' + special_7));
            commatext = commatext.Replace(special_8, (',' + special_8));
            commatext = commatext.Replace(special_9, (',' + special_9));
            commatext = commatext.Replace(special_10, (',' + special_10));
            commatext = commatext.Replace(special_11, (',' + special_11));
            commatext = commatext.Replace(special_12, (',' + special_12));
            commatext = commatext.Replace(special_13, (',' + special_13));
            commatext = commatext.Replace(special_14, (',' + special_14));
            commatext = commatext.Replace(special_15, (',' + special_15));
            commatext = commatext.Replace(special_16, (',' + special_16));
            commatext = commatext.Replace(special_17, (',' + special_17));
            commatext = commatext.Replace(special_18, (',' + special_18));
            commatext = commatext.Replace(special_19, (',' + special_19));
            commatext = commatext.Replace(special_20, (',' + special_20));
            commatext = commatext.Replace(special_21, (',' + special_21));
            commatext = commatext.Replace(special_22, (',' + special_22));
            commatext = commatext.Replace(special_23, (',' + special_23));
            commatext = commatext.Replace(special_24, (',' + special_24));
            commatext = commatext.Replace(special_25, (',' + special_25));
            commatext = commatext.Replace(special_26, (',' + special_26));
            commatext = commatext.Replace(special_27, (',' + special_27));
            commatext = commatext.Replace(special_28, (',' + special_28));
            commatext = commatext.Replace(special_29, (',' + special_29));
            commatext = commatext.Replace(special_30, (',' + special_30));
            commatext = commatext.Replace(special_31, (',' + special_31));
            return commatext;
        }
        
    }
}
