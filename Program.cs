using System; // Utilisation de l'espace de noms System qui contient la classe Console.

class Program // Déclaration de la classe Program.
{
    static void Main() // Point d'entrée principal du programme.
    {
        Console.Write("Enter first number: "); // Demande à l'utilisateur d'entrer le premier nombre.
        float num1 = float.Parse(Console.ReadLine()); // Convertit l'entrée utilisateur en float et la stocke dans num1.

        Console.Write("Enter second number: "); // Demande à l'utilisateur d'entrer le deuxième nombre.
        float num2 = float.Parse(Console.ReadLine()); // Convertit l'entrée utilisateur en float et la stocke dans num2.

        // Calcule la moyenne de num1 et num2 en appelant la méthode Moyenne, puis affiche le résultat.
        Console.WriteLine($"Moyenne: {Moyenne(num1, num2)}");

        float[] arr = { 10.5f, 20.5f, 30.5f }; // Déclare et initialise un tableau de float.
        // Calcule la moyenne des nombres dans le tableau en appelant la méthode Moyenne, puis affiche le résultat.
        Console.WriteLine($"Moyenne of array: {Moyenne(arr)}");
    }

    // Méthode pour calculer la moyenne de deux nombres.
    static float Moyenne(float a, float b)
    {
        return (a + b) / 2; // Somme a et b, puis divise par 2 pour obtenir la moyenne.
    }

    // Méthode pour calculer la moyenne d'un tableau de nombres.
    static float Moyenne(float[] arr)
    {
        float sum = 0; // Initialise la somme à 0.
        foreach (float num in arr) // Parcourt chaque nombre dans le tableau.
            sum += num; // Ajoute chaque nombre à la somme.
        return sum / arr.Length; // Divise la somme totale par le nombre d'éléments pour obtenir la moyenne.
    }
}
