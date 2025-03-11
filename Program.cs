using System;

class Temperature{
    public string City;
    public double[] temp_odczyt = new double[7];

    public int TempType=1;
    
    public Temperature(){
        City = "Białystok";
        for(int i = 0; i < temp_odczyt.Length; i++){
            temp_odczyt[i] = 0;
        }
    }

    public Temperature(string City){
        this.City = City;
        for(int i = 0; i < temp_odczyt.Length; i++){
            temp_odczyt[i] = 0;
        }
    }

    public Temperature(string City, double [] temps){
        this.City = City;
        for(int i = 0; i < temp_odczyt.Length; i++){
            temp_odczyt[i] = temps[i];
        }
    }

    public double SetKelvin(int day, double kelvin){
        if (TempType == 2){kelvin = kelvin - 273.15;}
        else if (TempType == 3){kelvin = (5/9)*(kelvin - 32) + 273.15;}
        
        TempType = 1;
        return kelvin;
    }

    public double SetCelcius(int day, double celcius){
        if (TempType == 1){celcius = celcius - 273.15;}
        else if (TempType == 3){celcius = (5/9)*(celcius - 32);}
        TempType = 2;
        return celcius;
    }

    public double SetFarhrenheit(int day, double farh){
        if (TempType == 2){farh = (9.0/5.0)*farh+32;}
        else if(TempType == 1){farh = (9.0/5.0)*(farh - 273.15)+15;}
        TempType = 3;
        return farh;
}

    public void GetKelvin(int day, double kelvin){
        if (TempType == 1){
        Console.WriteLine("Temperatura w kelvinach: ", kelvin);
    }
    else{
        SetKelvin(day, kelvin);
        Console.WriteLine("Temperatura w kelvinach: ", kelvin);
    }
    }

    public void GetCelcius(int day, double celcius){
        if (TempType == 2){
        Console.WriteLine("Temperatura w Celcjuszach: ", celcius);
    }
    else{
        SetCelcius(day, celcius);
        Console.WriteLine("Temperatura w Celcjuszach: ", celcius);
    }
    }

    public void GetFahr(int day, double fahr){
        if (TempType == 3){
        Console.WriteLine("Temperatura w Fahrenheitach: ", fahr);
    }
    else{
        SetFarhrenheit(day, fahr);
        Console.WriteLine("Temperatura w Fahrenheitach: ", fahr);
    }
    }

}

class Program {
    static void Main(string[] args)
    {
    Console.WriteLine("Hello, World!");
    }
}

