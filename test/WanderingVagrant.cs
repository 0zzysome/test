

public class WanderingVagrant
{
    public int elite; 
    public string Name;
    /*position*/
    public double x;
    public double y;
    public double z;
    /*rotation*/
    public double rx;
    public double ry;
    public double rz;
    public double Damage;
    public double AttackSpeed;
    public double MoveSpeed;
    public double Health = 2000;
    public int Armor;
    public int[] Items = new int[148];
    /*67 effects */
    public int[] Effects = new int[67];
    public string Target;
    public int NextAttack;  
    public bool UnderQuarterHp = false;  
}
