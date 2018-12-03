using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentGunSprite : MonoBehaviour {

    public List<Sprite> GunSprites;
    private void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = GunSprites[0];
    }
    public void ChangeGun(GameObject GunNumber)
    {

    }
}
