/*Crie uma classe que modele uma pessoa:

Atributos: nome, idade, peso e altura
Métodos: Envelhercer, engordar, emagrecer, crescer. 
Obs: Por padrão, a cada ano que nossa pessoa envelhece, sendo a idade dela menor que 21 anos, ela deve crescer 0,5 cm.

Lorhana sua linda
Romeu seu fofo

*/


using System;

class MainClass {
  public static void Main (string[] args) {
    Caracteristicas l = new Caracteristicas();

    Console.Write("Qual seu nome? ");
    string nome = Console.ReadLine();

    Console.Write("Qual sua idade? ");
    int idade = int.Parse( Console.ReadLine() );

    Console.Write("Qual seu peso? ");
    double peso = double.Parse( Console.ReadLine() );

    Console.Write("Qual sua altura? ");
    double altura = double.Parse( Console.ReadLine() );


    l.setName( nome );
    l.setIdade( idade );
    l.setPeso( peso );
    l.setAltura( altura );
    
    l.Envelhecer ( );
    l.Engordar   ( );
    l.Emagrecer  ( );
    l.Crescer    ( );
   
    Console.WriteLine("Seu nome: "   + l.getName()   );
    Console.WriteLine("Sua idade: "  + l.getIdade()  );
    Console.WriteLine("Seu peso: "   + l.getPeso()   );
    Console.WriteLine("Seu altura: " + l.getAltura() );
    
    
  }
}
