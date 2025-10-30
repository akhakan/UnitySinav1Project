using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float hiz = 5f;

    void Update()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 hareket = new Vector3(yatay, 0, dikey);
        // TODO:Player'i yön tuþlarý ya da W,A,S,D tuþlarýyla hareket ettirecek kodu yazýnýz.
        transform.Translate(hareket * hiz * Time.deltaTime);

    }
}
