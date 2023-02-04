using UnityEngine;

public class DestroyTile : MonoBehaviour
{

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Debug.Log(transform.position);
    }

    private void checkFog(){
      //  for var (Xfogpositione = (trnasform.positione-1); Xfogpositione = (transform.positione+1); Xfogpositione++;)
            //for (var Yfogpositione = (transform.positione-1); Yfogpositione = (transform.positione+1); Yfogpositione++)
               // Destroy(GameObject.Find("Fog/Column/Fog.transform.positione"))
                
    }

}
