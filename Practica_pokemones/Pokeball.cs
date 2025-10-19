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
    if (pokemon is not CapturablePokemon)
    {
      Console.WriteLine("El pokemon no puede ser capturado");
      
    }
  }
}