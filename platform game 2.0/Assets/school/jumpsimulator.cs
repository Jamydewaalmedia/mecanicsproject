using UnityEngine;

public class JumpSimulator : MonoBehaviour
{
    // Definieer de variabelen
    public double g = 9.81;  // Zwaartekracht (m/s^2)
    public double v0 = 10;   // Initiële snelheid (m/s)
    public double deltaH;    // Hoogteverandering (m)
    public double customT = 2.0; // Aanpasbare waarde van t

    // Start is called before the first frame update
    void Start()
    {
        // Bereken de totale tijd van de sprong
        double totalTime = CalculateTotalTime();

        // Bereken de hoogte van de sprong op basis van de gegeven formule met de totale tijd
        double height = CalculateJumpHeight(totalTime);

        // Toon de berekende hoogte 
        this.WriteToConsole($"De hoogte van de sprong is: {height} meter.", Color.green);

      
        JumpObject((float)height);
    }

    // Functie om de totale tijd van de sprong te berekenen
    double CalculateTotalTime()
    {
        // De totale tijd van de sprong kan worden berekend als de tijd die het kost om van de initiële snelheid naar nul te gaan onder invloed van de zwaartekracht
        double totalTime = v0 / g;
        return totalTime;
    }

    
    double CalculateJumpHeight(double totalTime)
    {
        // Hoogteformule: f(t) = v0*t - 0.5*g*t^2 + Δh
        double height = v0 * totalTime - 0.5 * g * totalTime * totalTime + deltaH;
        return height;
    }

   
    

    // Functie om het object te laten springen
    void JumpObject(float height)
    {
        // Voeg de berekende hoogte toe aan de huidige positie van het object
        Vector3 newPosition = transform.position + new Vector3(0, height, 0);

        // Verplaats het object naar de nieuwe positie
        transform.position = newPosition;
    }
}
