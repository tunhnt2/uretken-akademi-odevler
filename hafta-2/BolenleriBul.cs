using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolenleriBul : MonoBehaviour
{

    void bolenleriBul(int ilkSayi, int ikinciSayi)
    {
        if(ilkSayi > ikinciSayi)
        {
            print("ilk sayý ikinci sayýdan büyük olamaz!");
            return;
        }

        ArrayList sayiListesi = new ArrayList();

        // sayý listesi içerisine tüm elemanlarý ekledim 
        for(int i = ilkSayi; i <= ikinciSayi; i++) {
            sayiListesi.Add(i);
        }

        // tum sayýlar için 
        string tumSayilar = "";
        foreach (int item in sayiListesi)
        {
            tumSayilar += " " + item;
        }

        // ikiye bölünenler için
        string ikiyeBolunenler = "";
        foreach (int item in sayiListesi)
        {
            if(item % 2 == 0)
            {
                ikiyeBolunenler += " " + item;
            }
        }

        // üçe bölünenler için
        string uceBolunenler = "";
        foreach (int item in sayiListesi)
        {
            if (item % 3 == 0)
            {
                uceBolunenler += " " + item;
            }
        }

        // dörde bölünenler için
        string dordeBolunenler = "";
        foreach (int item in sayiListesi)
        {
            if (item % 4 == 0)
            {
                dordeBolunenler += " " + item;
            }
        }

        // beþe bölünenler için
        string beseBolunenler = "";
        foreach (int item in sayiListesi)
        {
            if (item % 5 == 0)
            {
                beseBolunenler += " " + item;
            }
        }

        // yazdýr
        print("Tüm sayýlar: " + tumSayilar);
        print("ikiye bölünenler: " + ikiyeBolunenler);
        print("Üçe bölünenler: " + uceBolunenler);
        print("Dörde bölünenler: " + dordeBolunenler);
        print("Beþe bölünenler: " + beseBolunenler);



    }


    // Start is called before the first frame update
    void Start()
    {
        bolenleriBul(20, 30);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
