namespace InterfaceDemo1;

public interface IDestroyable
{
    // property to store the audio file of the destruction soud
    string DestructionSound { get; set; }
    
    // method to destroy an object
    void Destroy();
}