public class CaptureCalculator
{
  public static int CalculateCaptureProbability(CapturablePokemon pokemon, Pokeball pokeball)
  {
    int probability = pokemon.CatchRate * pokeball.CaptureMultiplier;
    if (probability > 255)
    {
      probability = 255;
    }
    return probability;
  }
}