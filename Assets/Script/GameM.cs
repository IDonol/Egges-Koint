using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameM : MonoBehaviour
{
    public float cena = 5;
    public float mani = 0;
    public float i = 0;
    public float timer = 0;
    public static int j = 0;
    public float cenik = 25;
    public float cenik2 = 40;
    public static bool flag;
    public GameObject spavn;
    public GameObject ciksa;
    public GameObject ciksa2;
    public GameObject pe;
    public GameObject cyr;
    public GameObject ufo;
    public static GameObject[] ciksas = new GameObject[10];

    public Text[] eggsText;
    public Text[] maniText;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ufo)
        {
            timer = timer + 1 * Time.deltaTime;
        }
        
        eggsText[0].text = "ßéöà: " + ray.eggs;
        eggsText[1].text = "ßéöà: " + ray.eggs;
        maniText[0].text = "Äåíüãè: " + mani;
        maniText[1].text = "Äåíüãè: " + mani;
        if (timer >= 6)
        {
            ufo.SetActive(true);
            flag = true;
            timer = 0;
        }
    }
    public void egg()
    {
        i = cena * ray.eggs;
        ray.eggs = 0;
        mani = mani + i;
    }
    public void shop()
    {
        if(mani >= cenik)
        {
            cyr = Instantiate(ciksa, spavn.transform.position, Quaternion.identity);
            Instantiate(pe, spavn.transform.position, Quaternion.identity);
            ciksas[j] = cyr;
            j++;
            if (j > 10)
            {
                j = 0;
            }
            mani =   mani - cenik;
            
        }
        
    }

    public void shop2()
    {
        if (mani >= cenik)
        {
            cyr = Instantiate(ciksa2, spavn.transform.position, Quaternion.identity);
            Instantiate(pe, spavn.transform.position, Quaternion.identity);
            ciksas[j] = cyr;
            j++;
            if (j > 10)
            {
                j = 0;
            }
            mani = mani - cenik;

        }

    }

}
