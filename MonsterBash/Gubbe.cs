namespace BashMonster;

public class Gubbe
{
    public float maxHp = 100;
    public string name;
    public float hp;
    public float mass = 80;

    public Gubbe()
    {
        ResetHp();
    }
    
    public void ResetHp()
    {
        hp = maxHp;
    }

}