using UnityEngine;

public class Turkey : Animals, IInteractible, IPettable
{
    public float gobbleVolume;

    public Turkey(string animalName, int animalAge, float gobbleVolume)
    {
        this.animalName = animalName;
        this.animalAge = animalAge;
        this.gobbleVolume = gobbleVolume;
    }

    // Implements the abstract method which makes a sound.
    public override void animalSound()
    {
        Debug.Log(animalName + " gobbles at a volume of " + gobbleVolume + " decibels. ");
    }

    // Unique behavior for the Turkey class.
    public void Peck()
    {
        Debug.Log(animalName + " is pecking. ");
    }

    // Interactible interface method.
    public void Interact()
    {
        Debug.Log(" You interacted with " + animalName + " , the turkey. It gobbles at you. ");
    }

    public void Pet()
    {
        Debug.Log(" You pet " + animalName + " , the turkey. It nips at your fingers. ");
    }
}
