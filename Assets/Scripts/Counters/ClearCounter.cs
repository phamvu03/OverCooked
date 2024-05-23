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
                if (player.GetKitchenObject().TryGetPlate(out PlateKitchenObject plateKitchenObject))
                {
                    //Player dang cam dia
                    if (plateKitchenObject.TryAddIngredient(GetKitchenObject().GetKitchenObjectSO()))
                    {
                        GetKitchenObject().DestroySelf();   
                    }
                    
                }
                else
                {
                    //Player khong cam dia nhung cam cai khac
                    if (GetKitchenObject().TryGetPlate(out plateKitchenObject))
                    {
                        //Counter đdang co dia  
                        if (plateKitchenObject.TryAddIngredient(player.GetKitchenObject().GetKitchenObjectSO()))
                        {
                            player.GetKitchenObject().DestroySelf();
                        }
                    }
                }
            }
            else
            {
                //Player khong cam gi
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
}
