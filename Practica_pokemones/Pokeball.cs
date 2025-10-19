public class Pokeball
{
  private int _captureMultiplier;
  public int CaptureMultiplier
  {
    get { return _captureMultiplier; }
    private set
    {
      if (value <= 0)
      {
        value = 1;
      }
      _captureMultiplier = value;
    }
  }
  private CaptureCalculator _calculator;
  private CaptureCalculator Calculator
  {
    get { return _calculator; }
    set { _calculator = value; }
  }
  public Pokeball(CaptureCalculator calculator)
  {
    Calculator = calculator;
    CaptureMultiplier = 1;
  }

  public virtual bool CapturablePokemon(Pokemon pokemon)
  {
    if (pokemon is not CapturablePokemon capturablePokemon)
    {
      Console.WriteLine($"El Pokémon {pokemon.Name} no puede ser capturado (No es de tipo CapturablePokemon).");
      return false;
    }

    Random random = new Random();
    int valorDeCaptura = random.Next(1, 256);
    int probabilidadDeCaptura = CaptureCalculator.CalculateCaptureProbability(capturablePokemon, this);

    Console.WriteLine($"Probabilidad de Captura: {probabilidadDeCaptura}");
    Console.WriteLine($"Valor Aleatorio Generado: {valorDeCaptura}");

    if (valorDeCaptura <= probabilidadDeCaptura)
    {
      Console.WriteLine($"¡Felicidades! ¡El Pokémon {capturablePokemon.Name} ha sido capturado!");
      return true;
    }
    else
    {
      Console.WriteLine($"¡Oh no! El Pokémon {capturablePokemon.Name} ha escapado.");
      return false;
    }
  }
}