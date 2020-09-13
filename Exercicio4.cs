using System;

class Caracteristicas{
  //atributos
  private string nome;
  private int idade;
  private double peso;
  private double altura;

  //metodos de variaveis privadas
  public string getName(){
    return nome;
  }

  public void setName(string newName){
    nome = newName;
  }

  public int getIdade(){
    return idade;
  }

  public void setIdade(int newIdade){
    idade = newIdade;
  }

  public double getPeso(){
    return peso;
  }

  public void setPeso(double newPeso){
    peso = newPeso;
  }

   public double getAltura(){
    return altura;
  }

  public void setAltura(double newAltura){
    altura = newAltura;
  }

  //metodos de modificação 

  public void Envelhecer (){ 
    if ( idade < 21){
      altura += 0.5;
    }

    idade += 1;

  }

  public void Engordar (){

    peso += 0.300;

  }

  public void Emagrecer (){

    peso -= 0.300;

  }

  public void Crescer (){

    altura += 0.5;
  
  }


}
