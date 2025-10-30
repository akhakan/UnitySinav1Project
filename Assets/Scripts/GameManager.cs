using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int puan = 0;
    void Update()
    {
        if (puan >= 2)
        {
            // TODO:Küpler doðru alandaysa "Tüm küpler doðru yerde! Kazandýn!" mesajýný konsola yazdýrýnýz.
            Debug.Log("Tüm küpler doðru yerde! Kazandýn!");
        }
    }
}
