using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nowornever : MonoBehaviour
{ string heroname = "joha";
    string vn = "jaguar";
    int hp = 99;
    int vp = 200;
    float playerspeed = 0.1f;

    // set speed function
    void setpeed(float newspeed)
    {
        print("the old speed is" + playerspeed);
        playerspeed = newspeed;
        print("the new speed is " + newspeed);
    }

    // Start is called before the first frame update
    void Start()
    {
        print("there once was a hero with the name of " + heroname + " and a villan who is called " + vn);
        print("the heros power was " + hp + " and the villans was " + vp);
        if( vp > hp)
        {
            print("the villan is stronger by the difference of" + (vp - hp));
        }
        else if(vp == hp)
         {
            print("they are equal");
         }
        else
        {
            
            print("the hero is stronger by the difference of " + (hp - vp));
        }
        
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
