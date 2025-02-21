using UnityEngine;

public class Fox : Animals, IInteractible, IPettable
{
    public float foxChirp;

    public Fox(string animalName, int animalAge, float foxChirp)
    {
        this.animalName = animalName;
        this.animalAge = animalAge;
        this.foxChirp = foxChirp;
    }

    // Implements the abstract method which makes a sound.
    public override void animalSound()
    {
        Debug.Log(animalName + " chirps at a volume of " + foxChirp + " decibels. ");
    }

    // Unique behaviour.
    public void foxChill()
    {
        Debug.Log(animalName + " is chilling. ");
    }

    // Interactible interface method.
    public void Interact()
    {
        Debug.Log(" You interacted with " + animalName + " , the fox. It chirps, running around in circles. ");
    }

    public void Pet()
    {
        Debug.Log(" You pet " + animalName + " , the fox. It rolls over so you can scratch its belly. ");
    }
}
