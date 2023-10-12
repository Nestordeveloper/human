class Human
{
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;

    /* Agregar un método constructor que tome el string Name e inicializar 
    // Strength, Intelligence, y Dexterity a un valor por default de 3 y Health a un valor
    // por default de 100.*/
    public Human(string name = "Default")
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }

    /* Crear un constructor adicional que acepte 5 parámetros, para que podamos establecer
    valores personalizados para cada campo */
    public Human(string name, int strength, int intelligence, int dexterity, int health)
    {
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
        Health = health;
    }
    /* Agregar un nuevo método llamado Attack que cuando se invoque, deberá reducir la salud de
    otro objeto Human que se pase como parámetro. El daño realizado debe ser 3*Strength
    (3 puntos de daño al objetivo por cada 1 punto de fuerza del atacante).
    Este método debería devolver el estado restante del objeto de destino.*/
    public int Attack(Human target)
    {
        int damage = 3 * Strength;
        target.Health -= damage;

        if (target.Health < 0)
        {
            target.Health = 0;
        }

        return target.Health;
    }
}
