using UnityEngine;

public class ColorMatch : MonoBehaviour
{
    private bool eslesme = false;
    private Renderer rend;

    [Header("Tag Ayarý")]
    [SerializeField] private string dogruTag;

    [Header("GameManager Baðlantýsý")]
    [SerializeField] private GameManager gameManager;

    [Header("Materyaller")]
    [SerializeField] private Material GrayMat;
    [SerializeField] private Material PurpleMat;

    private void Awake()
    {
        rend = GetComponent<Renderer>();
        rend.material = GrayMat;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(dogruTag) && !eslesme)
        {
            eslesme = true;
            
            if (PurpleMat != null)
            {
                //TODO:Küpün yerleþtirildiði alan doðruysa Alanýn Material rengini deðiþtirecek kodu yazýnýz.     

                rend.material = PurpleMat;
            }

            //TODO:Küp doðru alana yerleþtirildiyse uygun mesajý konsola yazdýrýnýz.
            //TODO:"Kýrmýzý küp doðru yere getirildi." veya  "Yeþil küp doðru yere getirildi."                                           
            Debug.Log(dogruTag+ " küp doðru yere getirildi.");


            gameManager.puan++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(dogruTag) && eslesme)
        {
            eslesme = false;
            if (GrayMat != null)
            {
                // TODO: Küp alanýn dýþýna çýktýðýnda Alanýn Material rengini deðiþtirecek kodu yazýnýz
                rend.material = GrayMat;
            }

            gameManager.puan--;
        }
    }
}
