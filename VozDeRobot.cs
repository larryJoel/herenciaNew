class  VozDeRobot{
    protected string frase;
    public VozDeRobot (string f){
        frase = f;
    }

    public void Hablar(){
        Console.WriteLine("Esta es mi voz en 8bit: "+ frase);
    }
    
}