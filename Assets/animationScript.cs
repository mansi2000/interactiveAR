using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animationScript : MonoBehaviour
{
    public Animator anim;
    public string theAnimation;
    public string theObject;
    public GameObject inputField;
    public GameObject objectInputField;
    public GameObject human;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        human.SetActive(false);
    }
    public void tiggerClicked(){
        theAnimation = inputField.GetComponent<Text>().text;
        theObject = objectInputField.GetComponent<Text>().text;
        if(theObject == "human"){
            human.SetActive(true);
        }

        if(theAnimation == "run"){
             anim.Play("HumanoidRun");
        }
        if(theAnimation == "walk"){
             anim.Play("HumanoidWalk");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown("1")){
            anim.Play("HumanoidRun");
        }
        if(Input.GetKeyDown("2")){
            anim.Play("HumanoidWalk");
        }
    }
}
