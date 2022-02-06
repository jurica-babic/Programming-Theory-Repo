using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// when collided, the animal will be fed one unit of food, reduce the hungriness and "act" (saying something in a console)
public class Animal : MonoBehaviour
{

    


    private int hungriness;

    // ENCAPSULATION
    public int Hungriness{
        get {
            return hungriness;
        }
        private set{
            if(value>100){
                hungriness = 100;
            }    
            else if(value<0){
                hungriness = 0;
            } 
            else{
                hungriness = value;
            }
        }
    }

    

    // Start is called before the first frame update
    void Start()
    {

    }

    void AdjustSize(float increment)
        {
            gameObject.transform.localScale+=Vector3.up * increment;
        }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("Player")){
            Feed();
        }
    }


    // ABSTRACTION
    public virtual void Feed(int food){
        Hungriness-=food;
        AdjustSize(food/3f);
        Act();
    }

    // POLYMORPHISM
    public virtual void Feed(){
        Feed(1);
    }

    public virtual void Act(){
        Debug.Log("*animal sound*");
    }
}
