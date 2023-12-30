using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolenleriBul : MonoBehaviour
{

    void bolenleriBul(int ilkSayi, int ikinciSayi)
    {
        if(ilkSayi > ikinciSayi)
        {
            print("ilk say� ikinci say�dan b�y�k olamaz!");
            return;
        }

        ArrayList sayiListesi = new ArrayList();

        // say� listesi i�erisine t�m elemanlar� ekledim 
        for(int i = ilkSayi; i <= ikinciSayi; i++) {
            sayiListesi.Add(i);
        }

        // tum say�lar i�in 
        string tumSayilar = "";
        foreach (int item in sayiListesi)
        {
            tumSayilar += " " + item;
        }

        // ikiye b�l�nenler i�in
        string ikiyeBolunenler = "";
        foreach (int item in sayiListesi)
        {
            if(item % 2 == 0)
            {
                ikiyeBolunenler += " " + item;
            }
        }

        // ��e b�l�nenler i�in
        string uceBolunenler = "";
        foreach (int item in sayiListesi)
        {
            if (item % 3 == 0)
            {
                uceBolunenler += " " + item;
            }
        }

        // d�rde b�l�nenler i�in
        string dordeBolunenler = "";
        foreach (int item in sayiListesi)
        {
            if (item % 4 == 0)
            {
                dordeBolunenler += " " + item;
            }
        }

        // be�e b�l�nenler i�in
        string beseBolunenler = "";
        foreach (int item in sayiListesi)
        {
            if (item % 5 == 0)
            {
                beseBolunenler += " " + item;
            }
        }

        // yazd�r
        print("T�m say�lar: " + tumSayilar);
        print("ikiye b�l�nenler: " + ikiyeBolunenler);
        print("��e b�l�nenler: " + uceBolunenler);
        print("D�rde b�l�nenler: " + dordeBolunenler);
        print("Be�e b�l�nenler: " + beseBolunenler);



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
