using UnityEngine;

public interface IInteractible
{
    void Interact();
}

public interface IPettable
{
    void Pet();
}

public abstract class Animals : MonoBehaviour
{
    public string animalName;
    public int animalAge;
    public int remainingHands = 2;

    public abstract void animalSound();

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}