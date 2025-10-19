public class Pokemon
{
  public enum PokeType
  {
    Water,
    Fire,
    Fly
  }
  private string _name;
  public string Name
  {
    get { return _name; }
    private set { _name = value; }
  }
  private PokeType _poktype;
  public PokeType PokType
  {
    get { return _poktype; }
    private set { _poktype = value; }
  }
  private int _maxLife;
  public int MaxLife
  {
    get { return _maxLife; }
    private set
    {
      if (value < 0)
      {
        value = 0;
      }
      _maxLife = value;
    }
  }
  private int _actualLife;
  public int ActualLife
  {
    get { return _actualLife; }
    private set
    {
      if (value < 0)
      {
        value = 0;
      }
      if (value > MaxLife)
      {
        value = MaxLife;
      }
      _actualLife = MaxLife;
    }
  }
  public Pokemon(string name, PokeType type, int maxLife)
  {
    Name = name;
    PokType = type;
    MaxLife = maxLife;
    ActualLife = MaxLife;
  }
  public void ReceiveDamage(int damage)
  {
    ActualLife = -damage;
    if (ActualLife == 0)
    {
      Console.WriteLine("El pokemon ha sido debilitado");
    }
  }
  public void Heal(int healing)
  {
    ActualLife = +healing;
  }
}