int health = 100;

void TakeDamage(int damage)
{
    int health = 50;
    health -= damage;
}

TakeDamage(5);
Console.WriteLine($"Health after taking damage: {health}");