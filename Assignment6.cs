using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {

            //--------------------question 1------------------------------------------
            string s1 = "AslıçokZEVklibirkız".ToLower(); 
            string s2 = "programlamaçokzevklibirders".ToLower();
            string common = "";
            string common2 = "";
            int counter = 0;
            //s1deki bütün harfleri s2deki bütün harflerle tek tek karşılaştırmak için iç içe for..
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s2[j])//eğer aynı harf gelirse
                    {
                        counter = 0;
                        while (true)
                        {
                            counter++;//sırayla bir yanındaki harfi kontrol etmek için bir sayaç
                                //sayacımız s1 string dizisinde index hata vermesin diye counter+i ve counter +j nin string dizilerinden küçük bir değerde kalmaları gerekiyor.
                            if (counter+i < s1.Length && counter + j < s2.Length && s1[i + counter] == s2[j + counter])
                            {
                                common = s1.Substring(i,counter + 1);//aynı harfler geldikçe başlangıç indeximiz i'den itibaren counter+1e yani benzerliğin en son olduğu harfe kadar common'a atıyoruz
                                if (common.Length > common2.Length) //birden çok benzerlik olabileceği için en fazla benzeliği common2 ye atıyoruz
                                {
                                    common2 = common;
                                }
                            }
                            else//farklılık olduğu takdirde while'dan çık
                            {
                                break;
                            }
                            
                        }
                    }
                }
            }
            Console.WriteLine(common2);//ekrana yaz



            //--------------------question 1 END------------------------------------------

            Console.WriteLine("Press enter for next question");
            Console.ReadLine();

            //--------------------question 2------------------------------------------

            string[] dictionary ={ "algorithms", "and", "computer", "course", "department", "engineering", "programming", "student", "teacher", "university", "I", "am", "a", "at", "of", "the" };
            string s = "I am a sutdend at the debartment of zomputer ergineening".ToLower();
            string[] split = s.Split();//cümledeki bütün kelimeleri split dizisine atıyoruz
            bool flag = true;



            for (int i = 0; i < split.Length; i++)//kelimelerin hepsini dolaşacak
            {
                flag = true;
                for (int j = 0; j < dictionary.Length; j++)//kelimeleri sözlükledki bütün kelimelerle karşılaştıracak
                {
                    if (split[i] == dictionary[j])//kelimemiz sözlükte geçiyorsa
                    {
                        flag = false;//flağı false yapıyoruz ve diğer denetime tabi tutmuyoruz.
                        break;//diğer kelimeye geç
                    }
                }
                if (flag)//kelime sözlükte yoksa
                {
                    for (int j = 0; j < dictionary.Length; j++)//sözlüğü dolaşıyoruz
                    {
                        if (split[i].Length == dictionary[j].Length)//kelimemizle aynı uzunluklu olan kelimeleri seçiyoruz
                        {
                            int counter2 = 0;
                            int a = -1;
                            int b = -1;
                            for (int k = 0; k < split[i].Length; k++)//kelimemizin harfleri kadar döngü kuruyoruz
                            {
                                if (split[i].Substring(k, 1) != dictionary[j].Substring(k, 1))//eşit olmayan harflerin sayısını buluyoruz
                                {
                                    counter2++;//kaç tane farklı harf olmadığını tutuyor
                                    if (a == -1)
                                    {
                                        a = k;//ilk benzemeyen harfin indexini a ya atıyoruz
                                    }
                                    else if (b == -1)
                                    {
                                        b = k;//ikinci benzemeyen harfin indexini b ye atıyoruz.
                                    }
                                }
                            }
                            if (counter2 == 1)//bir tane benzemeyen harf varsa 
                            {
                                s = s.Replace(split[i], dictionary[j]);//sözlükteki kelimeyle değiştiriyoruz
                            }
                            //iki tane benzemeyen harf varsa ve bu harflerin yerini değiştirdiğimizde sözlükteki doğru kelimeyi elde ediyorsak
                            else if (counter2 == 2 && dictionary[j].Substring(a, 1) == split[i].Substring(b, 1) && dictionary[j].Substring(b, 1) == split[i].Substring(a, 1))//
                            {
                                s = s.Replace(split[i], dictionary[j]);//kelimeleri yer değiştiriyoruz.
                            }

                        }
                    }
                }
            }


            Console.WriteLine(s);
            Console.WriteLine("Press enter for exit");
            Console.ReadLine();
            //--------------------question 2 END---------------------------------------



        }
    }
}
