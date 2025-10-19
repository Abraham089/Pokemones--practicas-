public class CapturablePokemon : Pokemon
{
  private int _baseCatchRate;
  protected int BaseCatchRate
  {
    get { return _baseCatchRate; }
    set
    {
      if (value <= 0)
      {
        value = 1;
      }
      if (value > 255)
      {
        value = 255;
      }
      _baseCatchRate = value;
    }
  }
  public virtual int CatchRate
  {
    get
    {
      var random = new Random();
      return random.Next(1, 256);
    }
  }
  public CapturablePokemon(string name, PokeType type, int maxLife, int baseCatchRate) : base(name, type, maxLife)
  {
    BaseCatchRate = baseCatchRate;
  }
}