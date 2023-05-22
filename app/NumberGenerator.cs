namespace app;

public class NumberGenerator
{
    private static NumberGenerator? _instance;
    private Random _random;
    private int _instanceCount;

    private NumberGenerator()
    {
        _instanceCount++;
        _random = new Random();
    }

    public static NumberGenerator Instance()
    {
        if (_instance is null)
        {
            _instance = new NumberGenerator();
        }

        return _instance;
    }

    public int GetNewRandomInt()
    {
        return _random.Next();
    }

    public int GetInstanceCount() => _instanceCount;
}
