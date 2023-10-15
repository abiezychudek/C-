public enum EHeroClass
{
    dogMaster = 1,
    paladin,
    amazon
}

public class Hero
{
    public string Name {
        get; set;
    }
    public EHeroClass Type {
        get; set;
    }

    public Hero(string name, EHeroClass type)
    {
        this.Name = name;
        this.Type = type;
    }
}
