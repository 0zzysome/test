// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Wisp w1 = new Wisp();
Wisp w2 = new Wisp();
WanderingVagrant v1 = new WanderingVagrant();

v1.Name = "mending";
v1.Health = 1000;



while(v1.Health <= 0){
    string input = Console.ReadLine();

    int dmg;
    bool success = int.TryParse(input, out dmg);

    if (success)
    {
    v1.Health -= dmg;
    Console.WriteLine(v1.Health);
    
    }


}



