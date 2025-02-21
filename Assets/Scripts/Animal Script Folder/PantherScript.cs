using UnityEngine;

public class Panther : Animals, IInteractible, IPettable
{
    public float pantherRoar;

    public Panther(string animalName, int animalAge, float pantherRoar)
    {
        this.animalName = animalName;
        this.animalAge = animalAge;
        this.pantherRoar = pantherRoar;
    }

    // Implements the abstract method which makes a sound.
    public override void animalSound()
    {
        Debug.Log(animalName + " unleashes a mighty roar of " + pantherRoar + " decibels. ");
    }

    // Unique behaviour.
    public void Sharpen()
    {
        Debug.Log(animalName + " is sharpening its claws. ");
    }

    // Interactible interface method.
    public void Interact()
    {
        Debug.Log(" You interacted with " + animalName + " , the panther. It looks at you like you're food. ");
    }

    public void Pet()
    {
        Debug.Log(" You try to pet " + animalName + " , the panther, but it bites your hand clean off. You now have " + (remainingHands - 1) + " hands left. ");
    }
}