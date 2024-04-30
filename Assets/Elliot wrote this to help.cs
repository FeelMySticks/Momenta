using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    // Below I am declaring the variables that i will be using in this script. and giving them a name for this code to understand.
    [SerializeField] private GameObject tile;
    //I am getting a GameObject (a literal thing in the scene, set in editor) and calling it tile

    // the number I will use to have my smoothness for me Lerp (Linear Interpolate)
    [SerializeField] private float timeToPosition = 1f;


    // Get the GameObject's transform component and then increase the z value (x,y,z) over the float time.
    //This can be triggered on collision of the player going through a collider
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
