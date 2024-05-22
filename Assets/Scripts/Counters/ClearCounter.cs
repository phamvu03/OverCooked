using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        { 
            // Khong co KitchenObject
            if (player.HasKitchenObject())
            {
                //Player dang cam object
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {
                //Player khong cam gi
            }

        } 
        else
        {
            //Co KitchenObject 
            if (player.HasKitchenObject())
            {
                //Player dang cam Object

            }
            else
            {
                //Player khong cam gi
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
}
