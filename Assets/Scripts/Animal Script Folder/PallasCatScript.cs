using UnityEngine;

public class PallasCat : Animals, IInteractible, IPettable
{
    public float pallascatMeow;

    public PallasCat(string animalName, int animalAge, float pallascatMeow)
    {
        this.animalName = animalName;
        this.animalAge = animalAge;
        this.pallascatMeow = pallascatMeow;
    }

    // Implements the abstract method which makes a sound.
    public override void animalSound()
    {
        Debug.Log(animalName + " meows at a volume of " + pallascatMeow + " decibels. ");
    }

    // Unique behaviour.
    public void CatStalk()
    {
        Debug.Log(animalName + " is stalking its prey. ");
    }

    // Interactible interface method.
    public void Interact()
    {
        Debug.Log(" You interacted with " + animalName + " , the Pallas cat. It turns its back to you, looking for food. ");
    }

    public void Pet()
    {
        Debug.Log(" You pet " + animalName + " , the Pallas cat. It looks at you appreciatively. ");
    }
}
